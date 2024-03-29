﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICreditCardService
    {
        void Add(CreditCard creditCard);
        void Remove(CreditCard creditCard);
        void Update(CreditCard creditCard);
        List<CreditCard> GetAll();

        CreditCard GetById(int id);
        CreditCard GetByNo(string no);
        CreditCard GetByName(string name);
    }
}
