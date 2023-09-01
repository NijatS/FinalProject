using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.ViewModels
{
    public class InfoVM
    {
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<Car> AuctionCars { get; set; }
        public AppUser AppUser { get; set; }
    }
}
