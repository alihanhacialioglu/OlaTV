using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IInvoiceDetailService
    {
        void Add(InvoiceDetail invoiceDetail);
        void Update(InvoiceDetail invoiceDetail);
        void Remove(InvoiceDetail invoiceDetail);
        List<InvoiceDetail> GetAll();
        InvoiceDetail GetById(int id);
    }
}
