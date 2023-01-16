using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CheckDetail
    {
        [Key]
        public int CheckDetailId { get; set; }

        public float TotalPrice { get; set; }

        [StringLength(100)]
        public string CheckExplanation { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime ServiceDate { get; set; }


        //Relation to CreditCard
        public int CreditCardId { get; set; }
        public virtual CreditCard CreditCard { get; set; }

		public bool IsDelete { get; set; }
	}
}
