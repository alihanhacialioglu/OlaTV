using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ICreditCardService
    {
        void Add(CreditCard creditCard);
        void Remove(CreditCard creditCard);
        void Update(CreditCard creditCard);
        List<CreditCard> GetAll();

        CreditCard GetById(int id);
        CreditCard GetByNo(int no);
        CreditCard GetByName(string name);
    }
}
