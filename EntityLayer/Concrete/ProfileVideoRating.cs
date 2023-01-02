﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProfileVideoRating
    {
        [Key]
        public int ProfileVideoRatingId { get; set; }
        public string ProfileVideoRate { get; set; }

        //Relation with Profile
        public int ProfileId { get; set; }
        public virtual Profile profile { get; set; }

        //Relation with Video
        public int VideoId { get; set; }
        public virtual Video video { get; set; }
    }
}
