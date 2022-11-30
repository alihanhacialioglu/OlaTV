﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [StringLength(20)]
        public string LanguageName { get; set; }

        //Relation with Profile
        public ICollection<Profile> Profiles { get; set; }

        //Relation with Video
        public ICollection<Video> Videos { get; set; }
        //Relation with VideoLanguage
        public ICollection<VideoLanguage> VideoLanguages { get; set; }

    }
}
