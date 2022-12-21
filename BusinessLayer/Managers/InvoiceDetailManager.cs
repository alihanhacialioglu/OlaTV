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
    public class InvoiceDetailManager : IInvoiceDetailService
    {
        IInvoiceDetailDal _invoiceDetailDal;
        public InvoiceDetailManager(IInvoiceDetailDal invoiceDetailDal)
        {
            _invoiceDetailDal= invoiceDetailDal;
        }
        public void Add(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDal.Add(invoiceDetail);
        }

        public List<InvoiceDetail> GetAll()
        {
           return _invoiceDetailDal.GetAll();
        }

        public InvoiceDetail GetById(int id)
        {
            return _invoiceDetailDal.Get(g=>g.InvoiceDetailId==id);
        }

        public void Remove(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDal.Delete(invoiceDetail);
        }

        public void Update(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDal.Update(invoiceDetail);
        }
    }
}
