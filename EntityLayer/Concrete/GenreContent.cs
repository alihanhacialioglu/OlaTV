using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GenreContent
    {
        [Key]
        public int GenreContentId { get; set; }

        //Relation with Genre
        public int GenreId { get; set; }
        public Genre genre { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public Content content { get; set; }
    }
}
