﻿using System;
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
        public virtual Window window { get; set; }
        //Relation with Background
        public int BackgroundId { get; set; }
        public virtual Background background { get; set; }

        //Relation with Font
        public int FontId { get; set; }
        public virtual Font font { get; set; }

        //Relation with Shadow
        public int ShadowId { get; set; }
        public virtual Shadow shadow { get; set; }

        //Relation with TextSize
        public int TextSizeId { get; set; }
        public virtual TextSize textSize { get; set; }

        //Relation with Profile
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
