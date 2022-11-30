using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Font
    {
        [Key]
        public int FontId { get; set; }

        [StringLength(30)]
        public string FontName { get; set; }

        //Relation with Color
        public int ColorId { get; set; }
        public Color color { get; set; }
        //Relation with SubtitleAppearance
        public ICollection<SubtitleAppearance> SubtitleAppearance { get; set; }
    }
}
