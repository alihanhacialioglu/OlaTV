using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int WindowColorId { get; set; }
		public virtual Color WindowColor { get; set; }

		//Relation with Background
        public int BackgroundColorId { get; set; }
		public virtual Color BackgroundColor { get; set; }

		//Relation with Font
		public int FontId { get; set; }
        public virtual Font Font { get; set; }

        //Relation with Shadow
        public int ShadowId { get; set; }
        public virtual Shadow Shadow { get; set; }

        //Relation with TextSize
        public int TextSizeId { get; set; }
        public virtual TextSize TextSize { get; set; }

		public bool IsDelete { get; set; }

		//Relation with Profile
		public virtual ICollection<Profile> Profiles { get; set; }
    }
}
