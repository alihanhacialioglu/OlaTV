using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InvoiceDetail
    {
        [Key]
        public int InvoiceDetailId { get; set; }

        public float TotalPrice { get; set; }

        [StringLength(100)]
        public string InvoiceExplanation { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime ServiceDate { get; set; }


        //Relation to CreditCard
        public int CreditCardId { get; set; }
        public virtual CreditCard CreditCard { get; set; }




    }
}
