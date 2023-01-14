using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class VideoModel
    {
        public Video Video { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Content> Contents { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
