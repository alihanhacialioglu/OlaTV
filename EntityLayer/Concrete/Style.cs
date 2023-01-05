using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Style
    {
        [Key]
        public int StyleId { get; set; }

        [StringLength(20)]
        public string StyleName { get; set; }

		public bool IsDelete { get; set; }

		//Relation with StyleContent
		public virtual ICollection<StyleContent> StyleContents { get; set; }
    }
}
