using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        [StringLength(15)]
        public string ColorName { get; set; }
		public bool IsDelete { get; set; }

		//Relation with Font
		public virtual ICollection<Font> Fonts { get; set; }
        //Relation with Shadow
        public virtual ICollection<Shadow> Shadows { get; set; }

		public IEnumerable<SubtitleAppearance> SubtitleAppearances
		=> SubtitleAppearances1.Concat(SubtitleAppearances2).Distinct();
		public virtual ICollection<SubtitleAppearance> SubtitleAppearances1 { get; set; }
		public virtual ICollection<SubtitleAppearance> SubtitleAppearances2 { get; set; }
	}
}
