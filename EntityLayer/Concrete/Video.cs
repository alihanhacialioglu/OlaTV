﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Video : BaseEntity
    {
        [Key]
        public int VideoId { get; set; }

        [StringLength(100)]
        public string VideoUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte SeasonNo { get; set; }
        public byte EpisodeNo { get; set; }

        //Relation with Language
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public virtual Content Content { get; set; }

        //Relation with Category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

		public bool IsDelete { get; set; }

		//Relation with VideoLanguage
		public virtual ICollection<VideoLanguage> VideoLanguages { get; set; }

        //Relation with ProfileVideoWatching
        public virtual ICollection<ProfileVideoWatching> ProfileVideoWatchings { get; set; }

        //Relation with ProfileVideoRating
        public virtual ICollection<ProfileVideoRating> ProfileVideoRatings { get; set; }

        
    }
}
