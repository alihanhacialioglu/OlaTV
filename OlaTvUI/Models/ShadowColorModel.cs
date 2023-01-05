using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class ShadowColorModel
    {
        public Shadow ShadowModal { get; set;}
        public IEnumerable<Color> Colors { get; set; }
    }
}
