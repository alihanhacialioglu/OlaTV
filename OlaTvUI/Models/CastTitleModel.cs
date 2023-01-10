using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class CastTitleModel
    {
        public CastTitle? CastTitle { get; set; }

        public IEnumerable<Cast> Casts { get; set; }
        public IEnumerable<Title> Titles { get; set; }
    }
}
