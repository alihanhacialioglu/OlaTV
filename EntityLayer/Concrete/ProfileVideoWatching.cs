﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProfileVideoWatching : BaseEntity
    {
        [Key]
        public int ProfileVideoWatchingId { get; set; }
        public DateTime ProfileVideoDateOfWached { get; set; }

        //Relation with Profile
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        //Relation with Video
        public int VideoId { get; set; }
        public virtual Video Video { get; set; }

		public bool IsDelete { get; set; }
	}
}
