using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class ProfileModel
    {
        public Profile Profile { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<MaturityRating> MaturityRatings { get; set; }
        public IEnumerable<TextColor> TextColors { get; set; }
        public IEnumerable<TextSize> TextSizes { get; set; }
    }
}
