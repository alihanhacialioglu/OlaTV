using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TextColor : BaseEntity
    {
        [Key]
        public int TextColorId { get; set; }

        [StringLength(15)]
        public string TextColorName { get; set; }
        public bool IsDelete { get; set; }

		//Relation with Profile
		public virtual ICollection<Profile> Profiles { get; set; }
	}
}
