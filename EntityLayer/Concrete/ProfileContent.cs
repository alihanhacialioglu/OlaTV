using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProfileContent
    {
        [Key]
        public int ProfileContentId { get; set; }

        //Relation with Profile
        public int ProfileId { get; set; }
        public virtual Profile profile { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public virtual Content content { get; set; }
    }
}
