using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GenreContent : BaseEntity
    {
        [Key]
        public int GenreContentId { get; set; }

        //Relation with Genre
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public virtual Content Content { get; set; }

		public bool IsDelete { get; set; }
	}
}
