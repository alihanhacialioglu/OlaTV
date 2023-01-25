using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Menu:BaseEntity
    {
        [Key]
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string SeoUrl { get; set; }
        [ForeignKey("parent")]
        public int? ParentId { get; set; }
        public virtual Menu Parent { get; set; }
        [InverseProperty("parent")]
        public virtual ICollection<Menu> Children { get; set; }
        public bool IsDelete { get; set; }



    }
}
