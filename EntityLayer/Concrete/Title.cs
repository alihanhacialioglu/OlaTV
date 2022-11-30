using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Title
    {
        [Key]
        public int TitleId { get; set; }

        [StringLength(30)]
        public string TitleName { get; set; }

        //Relation with CastTitle
        public ICollection<CastTitle> CastTitles { get; set; }
    }
}
