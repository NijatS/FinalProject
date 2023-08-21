using Miles.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.ViewModels
{
    public class AboutVM
    {
        public AboutText AboutText { get; set; }
        public IEnumerable<AboutSkill> AboutSkills { get; set; }
        public IEnumerable<Staff> Staffs { get; set; }
        public IEnumerable<Associate> Associates { get; set; }
        public IEnumerable<Comment> Comments { get; set; }


    }
}
