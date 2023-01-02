using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CastTitle
    {
        [Key]
        public int CastTitleId { get; set; }

        //Relation with Cast
        public int CastId { get; set; }
        public virtual Cast cast { get; set; }
        //Relation with Title
        public int TitleId { get; set; }
        public virtual Title title { get; set; }
        //Relation with ContentCastTitle
        public virtual ICollection<ContentCastTitle> ContentCastTitles { get; set; }
    }
}
