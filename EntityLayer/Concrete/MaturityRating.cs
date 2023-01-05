using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MaturityRating
    {
        [Key]
        public int MaturityRatingId { get; set; }

        [StringLength(20)]
        public string StatusName { get; set; }

        [StringLength(100)]
        public string MaturityExplanation { get; set; }
		public bool IsDelete { get; set; }

		//Relation with Profile
		public virtual ICollection<Profile> Profiles { get; set; }

        //Relation with Content
        public virtual ICollection<Content> Contents { get; set; }
    }
}
