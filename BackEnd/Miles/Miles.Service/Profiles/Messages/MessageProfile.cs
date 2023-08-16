using AutoMapper;
using Miles.Core.Entities;
using Miles.Service.Dtos.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Profiles.Messages
{
    public class MessageProfile:Profile
    {
        public MessageProfile()
        {
			CreateMap<MessagePostDto, Message>();
        }
    }
}
