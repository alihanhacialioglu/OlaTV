using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TypeContent
    {
        [Key]
        public int TypeContentId { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public virtual Content content { get; set; }

        //Relation with Type
        public int TypeId { get; set; }
        public virtual Type type { get; set; }
    }
}
