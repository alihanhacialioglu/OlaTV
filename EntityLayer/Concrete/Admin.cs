using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin : BaseEntity
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(20)]
        public string AdminName { get; set; }
        [StringLength(20)]
        public string AdminPassword { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [StringLength(20)]
        public string AdminType { get; set; }
        public bool IsDelete { get; set; }
    }
}
