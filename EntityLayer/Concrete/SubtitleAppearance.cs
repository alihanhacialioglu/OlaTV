using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubtitleAppearance
    {
        [Key]
        public int SubtitleAppearanceId { get; set; }

        //Relation with Window
        public int WindowId { get; set; }
        public Window window { get; set; }
        //Relation with Background
        public int BackgroundId { get; set; }
        public Background background { get; set; }

        //Relation with Font
        public int FontId { get; set; }
        public Font font { get; set; }

        //Relation with Shadow
        public int ShadowId { get; set; }
        public Shadow shadow { get; set; }

        //Relation with TextSize
        public int TextSizeId { get; set; }
        public TextSize textSize { get; set; }

        //Relation with Profile
        public ICollection<Profile> Profiles { get; set; }
    }
}
