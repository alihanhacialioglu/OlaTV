using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICheckDetailService
    {
        void Add(CheckDetail invoiceDetail);
        void Update(CheckDetail invoiceDetail);
        void Remove(CheckDetail invoiceDetail);
        List<CheckDetail> GetAll();
        CheckDetail GetById(int id);
    }
}
