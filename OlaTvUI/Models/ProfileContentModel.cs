using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class ProfileContentModel
    {
        public ProfileContent ProfileContent { get; set; }
        public IEnumerable<Profile> Profiles { get; set; }
        public IEnumerable<Content> Contents { get; set; }
    }
}
