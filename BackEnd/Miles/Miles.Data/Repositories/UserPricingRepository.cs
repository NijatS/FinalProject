using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Data.Repositories
{
    public class UserPricingRepository : Repository<UserPricing>, IUserPricingRepository
    {
        public UserPricingRepository(MilesAppDbContext context) : base(context)
        {
        }
    }
}
