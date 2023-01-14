using BusinessLayer.Manager;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class InvoiceDetailController : Controller
    {
        InvoiceDetailManager invoiceDetailManager = new InvoiceDetailManager(new EfInvoiceDetailDal());
        CreditCardManager creditCardManager = new CreditCardManager(new EfCreditCardDal());
        public IActionResult InvoiceDetail_Index()
        {
            var details = invoiceDetailManager.GetAll();
            return View(details);
        }

        [HttpGet]
        public IActionResult InvoiceDetail_Add()
        {
            InvoiceDetailModel invoiceDetailModel = new InvoiceDetailModel();
            invoiceDetailModel.InvoiceDetail = new InvoiceDetail();
            invoiceDetailModel.CreditCards = creditCardManager.GetAll();
            return View(invoiceDetailModel);
        }

        [HttpPost]
        public IActionResult InvoiceDetail_Add(InvoiceDetail invoiceDetail)
        {
            InvoiceDetailModel invoiceDetailModel = new InvoiceDetailModel();
            invoiceDetailModel.InvoiceDetail = invoiceDetail;
            invoiceDetailModel.CreditCards = creditCardManager.GetAll();

            InvoiceDetailValidator validator = new InvoiceDetailValidator();
            var result = validator.Validate(invoiceDetail);
            if (result.IsValid)
            {
                invoiceDetailManager.Add(invoiceDetail);
                return RedirectToAction("InvoiceDetail_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(invoiceDetailModel);
            }          
        }

        [HttpGet]

        public IActionResult InvoiceDetail_Update(int id) 
        {
            InvoiceDetail invoiceDetail = invoiceDetailManager.GetById(id);
            return View(invoiceDetail);
        }

        [HttpPost]
        public IActionResult InvoiceDetail_Update(InvoiceDetail invoiceDetail)
        {
            InvoiceDetailModel invoiceDetailModel = new InvoiceDetailModel();
            invoiceDetailModel.InvoiceDetail = invoiceDetail;
            invoiceDetailModel.CreditCards = creditCardManager.GetAll();

            InvoiceDetailValidator invoiceDetailValidator = new InvoiceDetailValidator();
            var result = invoiceDetailValidator.Validate(invoiceDetail);
            if (result.IsValid)
            {
                invoiceDetailManager.Add(invoiceDetail);
                return RedirectToAction("InvoiceDetail_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(invoiceDetailModel);
            }
        }
        public IActionResult InvoiceDetail_Activate(int id)
        {
            InvoiceDetail invoiceDetail = invoiceDetailManager.GetById(id);
            invoiceDetail.IsDelete = false;
            invoiceDetailManager.Update(invoiceDetail);
            return RedirectToAction("InvoiceDetail_Index");
        }

        public IActionResult InvoiceDetail_Deactivate(int id)
        {
            InvoiceDetail invoiceDetail = invoiceDetailManager.GetById(id);
            invoiceDetail.IsDelete = true;
            invoiceDetailManager.Update(invoiceDetail);
            return RedirectToAction("InvoiceDetail_Index");
        }

        public IActionResult InvoiceDetail_Delete(int id)
        {
            InvoiceDetail invoiceDetail = invoiceDetailManager.GetById(id);
            invoiceDetailManager.Remove(invoiceDetail);
            return RedirectToAction("InvoiceDetail_Index");
        }



    }
}
