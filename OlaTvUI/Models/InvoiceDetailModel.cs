using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class InvoiceDetailModel
    {
        public InvoiceDetail InvoiceDetail { get; set; }

        public IEnumerable<CreditCard> CreditCards { get;set; }
    }
}
