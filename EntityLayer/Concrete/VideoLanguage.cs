using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class VideoLanguage
    {
        [Key]
        public int VideoLanguageId { get; set; }

        //Relation with Video
        public int VideoId { get; set; }
        public virtual Video video { get; set; }

        //Relation with Language
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
