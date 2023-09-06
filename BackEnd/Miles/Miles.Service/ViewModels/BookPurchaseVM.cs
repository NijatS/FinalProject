using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.ViewModels
{
    public class BookPurchaseVM : Book
    {
        public string Nonce { get; set; }
        public int PricingId { get; set; }
    }
}
