using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class CheckDetailModel
    {
        public CheckDetail CheckDetail { get; set; }
        public IEnumerable<CreditCard> CreditCards { get; set;}

    }
}
