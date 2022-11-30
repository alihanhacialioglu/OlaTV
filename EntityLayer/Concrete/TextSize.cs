using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TextSize
    {
        [Key]
        public int TextSizeId { get; set; }

        [StringLength(10)]
        public string TextSizeName { get; set; }

        //Relation with SubtitleAppearance
        public ICollection<SubtitleAppearance> SubtitleAppearances { get; set; }
    }
}
