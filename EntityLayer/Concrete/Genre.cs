using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [StringLength(30)]
        public string GenreName { get; set; }

        //Relation with GenreContent
        public ICollection<GenreContent> GenreContents { get; set; }
    }
}
