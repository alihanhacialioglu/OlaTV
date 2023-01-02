using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Type
    {
        [Key]
        public int TypeId { get; set; }

        [StringLength(20)]
        public string TypeName { get; set; }

        //Relation with TypeContent
        public virtual ICollection<TypeContent> TypeContents { get; set; }
    }
}
