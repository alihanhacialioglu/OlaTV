using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContentCastTitle
    {
        [Key]
        public int ContentCastTitleId { get; set; }

        //Relation with CastTitle
        public int CastTitleId { get; set; }
        public virtual CastTitle CastTitle { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public virtual Content Content { get; set; }
		public bool IsDelete { get; set; }
	}
}
