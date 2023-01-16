using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class VideoLanguage : BaseEntity
    {
        [Key]
        public int VideoLanguageId { get; set; }

        //Relation with Video
        public int VideoId { get; set; }
        public virtual Video Video { get; set; }

        //Relation with Language
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }

		public bool IsDelete { get; set; }
	}
}
