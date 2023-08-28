using Microsoft.AspNetCore.Http;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Cars
{
    public class CarPostDto
    {
        public string Vin { get; set; }
        public int ModelId { get; set; }
        public int FabricationYear { get; set; }
        public double Odometer { get; set; }
        public int FuelId { get; set; }
        public int NoGears { get; set; }
        public string Transmission { get; set; }
        public int FuelCity { get; set; }
        public int FuelWay { get; set; }
        public double Motor { get; set; }
        public int ColorId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string? AppUserId { get; set; }
        public int BanId { get; set; }
        public DateTime ActionDate { get; set; }
		public List<IFormFile>? FormFiles { get; set; }
    }
}
