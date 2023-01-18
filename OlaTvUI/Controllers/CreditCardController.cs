using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class CreditCardController : Controller
    {
        CreditCardManager creditCardManager = new CreditCardManager(new EfCreditCardDal());
        UserManager userManager = new UserManager(new EfUserDal());
        public IActionResult CreditCard_Index()
        {
            var creditCards = creditCardManager.GetAll();
            return View(creditCards);
        }

        [HttpGet]
        public IActionResult CreditCard_Add()
        {
            CreditCardModel creditCardModel = new CreditCardModel();
            creditCardModel.CreditCard = new CreditCard();
            creditCardModel.Users=userManager.GetAll();

            return View(creditCardModel);
        }
        [HttpPost]
        public IActionResult CreditCard_Add(CreditCard creditCard)
        {
            CreditCardModel creditCardModel = new CreditCardModel();
            creditCardModel.CreditCard = creditCard;
            creditCardModel.Users = userManager.GetAll();

            CreditCardValidator validator = new CreditCardValidator();
            var result=validator.Validate(creditCard);
            if (result.IsValid)
            {
                creditCardManager.Add(creditCard);
                return RedirectToAction("CreditCard_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(creditCardModel);
            }
        }

        [HttpGet]
        public IActionResult CreditCard_Update(int id)
        {
            CreditCard creditCard=creditCardManager.GetById(id);
            CreditCardModel creditCardModel = new CreditCardModel();
            creditCardModel.CreditCard = creditCard;
            creditCardModel.Users = userManager.GetAll();
            return View(creditCardModel);
        }
        [HttpPost]
        public IActionResult CreditCard_Update(CreditCard creditCard)
        {
            CreditCardModel creditCardModel = new CreditCardModel();
            creditCardModel.CreditCard = creditCard;
            creditCardModel.Users = userManager.GetAll();

            CreditCardValidator creditCardValidator = new CreditCardValidator();
            var result = creditCardValidator.Validate(creditCard);
            if (result.IsValid)
            {
                creditCardManager.Update(creditCard);
                return RedirectToAction("CreditCard_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(creditCardModel);
            }

        }
        public IActionResult CreditCard_Delete(int id)
        {
            CreditCard creditCard = creditCardManager.GetById(id);
            creditCardManager.Remove(creditCard);
            return RedirectToAction("CreditCard_Index");
        }

        public IActionResult CreditCard_Activate(int id)
        {
            CreditCard creditCard = creditCardManager.GetById(id);
            creditCard.IsDelete = false;
            creditCardManager.Update(creditCard);
            return RedirectToAction("CreditCard_Index");
        }

        public IActionResult CreditCard_Deactivate(int id)
        {
            CreditCard creditCard = creditCardManager.GetById(id);
            creditCard.IsDelete = true;
            creditCardManager.Update(creditCard);
            return RedirectToAction("CreditCard_Index");
        }



    }
}
