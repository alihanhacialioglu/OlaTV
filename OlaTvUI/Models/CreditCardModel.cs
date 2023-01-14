using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace OlaTvUI.Models
{
    public class CreditCardModel
    {
       public CreditCard CreditCard { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
