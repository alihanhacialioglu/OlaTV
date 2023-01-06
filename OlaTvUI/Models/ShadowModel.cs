using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OlaTvUI.Models
{
    public class ShadowModel
    {
        public Shadow? Shadow { get; set;}
        public IEnumerable<Color>? Colors { get; set; }
    }
}
