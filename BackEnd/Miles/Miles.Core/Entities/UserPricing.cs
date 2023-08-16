using Miles.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Core.Entities
{
    public class UserPricing:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Feature> Features { get; set; }
    }
}
