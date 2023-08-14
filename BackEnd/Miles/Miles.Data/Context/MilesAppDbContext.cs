using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Data.Context
{
    public class MilesAppDbContext : DbContext
    {
        public MilesAppDbContext(DbContextOptions<MilesAppDbContext> options) : base(options)
        {
        }
    }
}
