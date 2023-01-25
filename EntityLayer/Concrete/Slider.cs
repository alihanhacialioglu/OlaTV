using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Slider:BaseEntity
    {
        [Key]
        public int SliderId { get; set; }
        [StringLength(50)]
        public string SliderName { get; set; }
        public bool IsDelete { get; set; }
        [StringLength(100)]
        public string ContentUrl { get; set; }
    }
}
