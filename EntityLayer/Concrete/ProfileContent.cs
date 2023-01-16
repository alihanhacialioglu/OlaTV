using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProfileContent : BaseEntity
    {
        [Key]
        public int ProfileContentId { get; set; }

        //Relation with Profile
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public virtual Content Content { get; set; }

		public bool IsDelete { get; set; }
	}
}
