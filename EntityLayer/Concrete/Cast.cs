using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cast
    {
        [Key]
        public int CastId { get; set; }

        [StringLength(40)]
        public string CastNameSurname { get; set; }

        //Relation with CastTitle
        public ICollection<Cast> Casts { get; set; }
    }
}
