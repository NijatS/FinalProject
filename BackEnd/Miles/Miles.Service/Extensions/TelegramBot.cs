using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using Microsoft.AspNetCore.Http;
using Telegram.Bot.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.SqlClient;
using System.Data;
using Message = Telegram.Bot.Types.Message;
using System.Runtime.ConstrainedExecution;
using System.Collections;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading.Channels;
using Telegram.Bot;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Miles.Service.Extensions
{
    public static class TelegramBot
    {
        public static async Task SendMessage(this IServiceCollection services)
        {
            var botClient = new TelegramBotClient("6410356240:AAFScjubC7OYJC78m9s_Te_mcvRJyaXd-p4");
            using CancellationTokenSource cts = new();
            // StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
            ReceiverOptions receiverOptions = new()
            {
                AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
            };
            botClient.StartReceiving(
                updateHandler: HandleUpdateAsync,
                pollingErrorHandler: HandlePollingErrorAsync,
                receiverOptions: receiverOptions,
                cancellationToken: cts.Token
            );

            var me = await botClient.GetMeAsync();
            Console.WriteLine($"Start listening for @{me.Username}");
            Console.ReadLine();
            cts.Cancel();
        }
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is not { } message)
                return;
            if (message.Text is not { } messageText)
                return;
            var chatId = message.Chat.Id;
            Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");
            if (message.Text.ToLower().Trim() is "hello")
            {
                message = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Hello,I am MilesBot!\nKey words:\n\n\n/address - you can info about address\n/auction - you can info about cars which wait auction" +
                "\n/blog - you can info about blog",
                cancellationToken: cancellationToken);
            }
            else if (message.Text.ToLower().Trim() is "salam")
            {
                message = await botClient.SendTextMessageAsync(
               chatId: chatId,
               text: "Salam,mən MilesBot-am!\nAçar sözlər:\n\n\n/address - address haqqında məlumat\n/auction - aksiyonda olan maşınlar haqqında məlumat" +
               "\n/blog - bloqlar haqqında məlumat",
               cancellationToken: cancellationToken);
            }
            else if (message.Text.ToLower().Trim() is "/auction")
            {
                string text = null;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a9ede5_nijats;User Id=db_a9ede5_nijats_admin;MultipleActiveResultSets=true;Password=Nicat1966.";
                   // conn.ConnectionString = "Server=DESKTOP-NIJAT;Database=MilesApp;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true";
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT c.Id,m.Name,FabricationYear,Price,ActionDate,b.Name,ci.Image FROM Cars c INNER JOIN Models m on c.ModelId =m.Id Inner JOIN Brands b on m.BrandId = b.Id Inner Join CarImages ci on ci.CarId=c.Id Where (StatusId = 2 ANd ci.isMain = 1) OR (StatusId =1 And ci.isMain = 1)";
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            int id = (int)sdr["Id"];
                            int date = sdr.GetInt32(2); 
                            string price = sdr.GetValue(3).ToString();
                            string auctionDate = sdr.GetValue(4).ToString();
                            string brand = sdr.GetValue(5).ToString();
                            string image = sdr.GetValue(6).ToString();
                            text = "Id: " + id.ToString() + "   \nModel: " +brand+" "+ sdr.GetString(1) +" " + date.ToString() +
                                "\nAuction Start Price: $" + price.ToString() + "   \nAuction Date: " + auctionDate+ "\n";
                            try
                            {
                                Message messageP = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                  photo: InputFile.FromUri("http://nijats-001-site1.btempurl.com/Images/Cars/" + image),
                                   parseMode: ParseMode.Html,
                               cancellationToken: cancellationToken);
                            }
                            catch (Exception ex)
                            {
                                Console.Write(ex.ToString());
                            }
                           
                            message = await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: text,
                            cancellationToken: cancellationToken);
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Can not open connection !");

                    }

                }
            }
            else if (message.Text.ToLower().Trim() is "/blog")
            {
                string text = null;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a9ede5_nijats;User Id=db_a9ede5_nijats_admin;MultipleActiveResultSets=true;Password=Nicat1966.";
                    //conn.ConnectionString = "Server=DESKTOP-NIJAT;Database=MilesApp;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true";
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Id,Title,Author,Image,Description FROM Blogs Where IsDeleted=0";
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            int id = (int)sdr["Id"];
                            string title = sdr.GetValue(1).ToString();
                            string author = sdr.GetValue(2).ToString();
                            string image = sdr.GetValue(3).ToString();
                            string desc = sdr.GetValue(4).ToString().Substring(0,100);
                            text = "Id: " + id.ToString() + "   \nTitle: " + title+
                                "\nAuthor: " + author + "\nText: " + desc+"...";
                            try
                            {
                                await botClient.SendPhotoAsync(
                                chatId: chatId,
                                  photo: InputFile.FromUri("http://nijats-001-site1.btempurl.com/Images/Blogs/" + image),
                                   parseMode: ParseMode.Html);
                            }
                            catch (Exception ex)
                            {
                                Console.Write(ex.ToString());
                            }


                            message = await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: text,
                            cancellationToken: cancellationToken);
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Can not open connection !");

                    }
                }
            }
            else if (message.Text.ToLower().Trim() is "/address")
            {
                message = await botClient.SendVenueAsync(
                chatId: chatId,
                latitude: 40.4812238f,
                longitude: 49.9525772f,
                title: "Man Hanging out",
                   address: "Azerbaijan,Baku,Zabrat",
               cancellationToken: cancellationToken);
            }
            else
            {
                Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "You said:\n" + messageText,
                cancellationToken: cancellationToken);
            }
        }
        public static Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }
    }
}
