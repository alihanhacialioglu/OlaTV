using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }

        [StringLength(25)]
        public string ContentName { get; set; }

        //Relation with MaturityRating
        public int MaturityRatingId { get; set; }
        public MaturityRating maturityRating { get; set; }

        //Relation with GenreContent
        public int GenreId { get; set; }
        public Genre genre { get; set; }

        //Relation with TypeContent
        public int TypeContentId { get; set; }
        public TypeContent typeContent { get; set; }

        //Relation with StyleContent
        public int StylrContentId { get; set; }
        public StyleContent styleContent { get; set; }

        //Relation with ContentCastTitle
        public ICollection<ContentCastTitle> ContentCastTitles { get; set; }


        //Relation with ProfileContent
        public ICollection<ProfileContent> ProfileContents { get; set; }

        //Relation with Video
        public ICollection<Video> Videos { get; set; }
    }
}
