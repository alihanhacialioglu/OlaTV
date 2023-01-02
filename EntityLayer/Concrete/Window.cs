using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Window
    {
        [Key]
        public int WindowId { get; set; }

        //Relation with Color
        public int ColorId { get; set; }
        public virtual Color color { get; set; }

        //Relation with SubtitleAppearance
        public  ICollection<SubtitleAppearance> SubtitleAppearances { get; set; }

    }
}
