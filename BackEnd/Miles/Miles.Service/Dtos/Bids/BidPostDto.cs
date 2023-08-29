using Microsoft.AspNetCore.Http;
using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Bids
{
    public class BidPostDto
    {
        public int CarId { get; set; }
        public double Count { get; set; }
        public string AppUserId { get; set; }
    }
}
