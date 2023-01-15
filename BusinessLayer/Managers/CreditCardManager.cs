using BusinessLayer.Services;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;
        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }
        public void Add(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
        }

        public List<CreditCard> GetAll()
        {
            return _creditCardDal.GetAll();
        }

        public CreditCard GetById(int id)
        {
            return _creditCardDal.Get(cc => cc.CreditCardId == id);
        }

        public CreditCard GetByName(string name)
        {
            return _creditCardDal.Get(cc=>cc.CreditCardHolder==name);
        }

        public CreditCard GetByNo(string no)
        {
            return _creditCardDal.Get(cc => cc.CreditCardNo == no);
        }

        public void Remove(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
        }

        public void Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
        }
    }
}
