using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public int UserPricingId { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public UserPricing UserPricing { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Car> Cars { get; set; }
        public List<Bid> Bids { get; set; }
        public List<Book> Book { get; set; }
    }
}
