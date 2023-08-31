using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class Auction:BaseEntity
    {
        public DateTime? AuctionStart { get; set; }
        public DateTime? AuctionEnd { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
