using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Core.Entities.BaseEntities;

namespace Miles.Core.Entities
{
    public class Feature : BaseEntity
    {
        public string Name { get; set; }
        public bool Icon { get; set; }
        public int UserPricingId { get; set; }
        public UserPricing UserPricing { get; set; }
    }
}
