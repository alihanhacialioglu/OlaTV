using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Genre : BaseEntity
    {
        [Key]
        public int GenreId { get; set; }

        [StringLength(30)]
        public string GenreName { get; set; }
		public bool IsDelete { get; set; }

		//Relation with GenreContent
		public virtual ICollection<GenreContent> GenreContents { get; set; }
    }
}
