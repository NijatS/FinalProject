using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.ViewModels
{
    public class ServiceVM
    {
        public IEnumerable<TextWhy> Why { get; set; }
        public IEnumerable<UserPricing> UserPricings { get; set; }
        public Setting Setting { get; set; }
    }
}
