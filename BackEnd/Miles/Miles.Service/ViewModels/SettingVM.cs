using Miles.Core.Entities;

namespace Miles.Service.ViewModels
{
    public class SettingVM
    {
        public Setting Setting { get; set; }
        public List<Blog> Blogs { get; set; }
        public AppUser? AppUser { get; set; }
        public IEnumerable<CarImage> CarImages { get; set; }
        public IEnumerable<Message> Messages { get; set; }

    }
}
