using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TextSize : BaseEntity
    {
        [Key]
        public int TextSizeId { get; set; }

        [StringLength(10)]
        public string TextSizeName { get; set; }
		public bool IsDelete { get; set; }

		//Relation with Profile
		public virtual ICollection<Profile> Profiles { get; set; }
	}
}
