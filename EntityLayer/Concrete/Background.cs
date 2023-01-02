using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Background
    {
        [Key]
        public int BackgroundId { get; set; }

        //Relation with Color
        public int ColorId { get; set; }
        public virtual Color color { get; set; }
        //Relation with SubtitleAppearance
        public virtual ICollection<SubtitleAppearance> SubtitleAppearances { get; set; }
    }
}
