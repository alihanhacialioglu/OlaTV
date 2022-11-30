using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(15)]
        public string CategoryName { get; set; }

        //Relation with Video
        public ICollection<Video> Videos { get; set; }
    }
}
