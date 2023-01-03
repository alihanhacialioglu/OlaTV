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
        public int CreditCardNo { get; set; }
        public DateTime ExpirationDate { get; set; }
        public byte Cvv { get; set; }



        //Relation with User
        public int UserId { get; set; }
        public virtual User User { get; set; }

        //Relation with InvoiceDetail
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }


    }
}
