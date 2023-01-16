using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CreditCard
    {
        [Key]
        public int CreditCardId { get; set; }

        [StringLength(25)]
        public string CreditCardHolder{ get; set; }
        [StringLength(16)]
        public string CreditCardNo { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Cvv { get; set; }

        //Relation with User
        public int UserId { get; set; }
        public virtual User User { get; set; }

		public bool IsDelete { get; set; }

		//Relation with InvoiceDetail
		public virtual ICollection<CheckDetail> CheckDetails { get; set; }


    }
}
