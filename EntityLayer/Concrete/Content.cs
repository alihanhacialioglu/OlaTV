﻿using System;
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
        public virtual MaturityRating maturityRating { get; set; }

        //Relation with GenreContent
        public virtual ICollection<GenreContent> GenreContents { get; set; }

        //Relation with TypeContent
        public virtual ICollection<TypeContent> TypeContents { get; set; }

        //Relation with StyleContent
        public virtual ICollection<StyleContent> StyleContents { get; set; }

        //Relation with ContentCastTitle
        public virtual ICollection<ContentCastTitle> ContentCastTitles { get; set; }

        //Relation with ProfileContent
        public virtual ICollection<ProfileContent> ProfileContents { get; set; }

        //Relation with Video
        public virtual ICollection<Video> Videos { get; set; }
    }
}
