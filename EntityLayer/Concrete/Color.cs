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

        //Relation with Window
        public ICollection<Window> windows { get; set; }
        //Relation with Background
        public ICollection<Background> backgrounds { get; set; }
        //Relation with Font
        public ICollection<Font> fonts { get; set; }
        //Relation with Shadow
        public ICollection<Shadow> shadows { get; set; }



    }
}
