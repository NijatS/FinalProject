using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.ViewModels
{
    public class AdminPanelVM
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<Bid> Bids { get; set; }
        public IEnumerable<AppUser> Admins { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
        public IEnumerable<Staff> Staffs { get; set; }

    }
}
