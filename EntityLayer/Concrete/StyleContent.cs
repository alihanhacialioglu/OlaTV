using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class StyleContent
    {
        [Key]
        public int StyleContentId { get; set; }

        //Relation with Style
        public int StyleId { get; set; }
        public virtual Style style { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public virtual Content content { get; set; }

    }
}
