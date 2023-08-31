using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class Car:BaseEntity
    {
        public string Vin { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int FabricationYear { get; set; }
        public double Odometer { get; set; }
        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }  
        public int NoGears { get; set; }
        public string Transmission { get ; set; }   
        public int FuelCity { get; set; }
        public int FuelWay { get; set; } 
        public double Motor { get ; set; }  
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string AppUserId { get; set; }
        public string? WinnerId { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public DateTime WinDate { get; set; }
        public int BanId { get; set; }
        public Ban Ban { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime ActionDate { get; set; }
        public double AuctionWinPrice { get; set; }
        public List<CarImage> CarImages { get; set; }
        public List<Auction> Auctions { get; set; }
	}
}
