using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Dtos.Features
{
    public class FeaturePostDto
    {
        public string Name { get; set; }
        public bool Icon { get; set; }
        public int UserPricingId { get; set; }
    }
}
