using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class CreditCardController : Controller
    {
        CreditCardManager creditCardManager = new CreditCardManager(new EfCreditCardDal());
        UserManager userManager = new UserManager(new EfUserDal());
        public IActionResult CreditCard_Index(int page = 1, string searchText = "")
		{
			int pageSize = 5;
			OlaTvDBContext c = new OlaTvDBContext();
			Pager pager;
			List<CreditCard> data;
			var itemCounts = 0;
			if (searchText != "" && searchText != null)
			{
				data = c.CreditCards.Where(x => x.CreditCardHolder.Contains(searchText) ||
				x.User.UserName.Contains(searchText)).Skip((page - 1) * pageSize).Take(pageSize).ToList();

				itemCounts = c.CreditCards.Where(x => x.CreditCardHolder.Contains(searchText) ||
				x.User.UserName.Contains(searchText)).ToList().Count;
			}
			else
			{
				data = c.CreditCards.Skip((page - 1) * pageSize).Take(pageSize).ToList();
				itemCounts = c.CreditCards.ToList().Count;
			}
			pager = new Pager(page, pageSize, itemCounts);

			ViewBag.pager = pager;
			ViewBag.actionName = "CastTitle_Index";
			ViewBag.contrName = "CastTitle";
			ViewBag.searchText = searchText;
			return View(data);
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
