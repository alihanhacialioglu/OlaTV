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
    public class CheckDetailController : Controller
    {
        CheckDetailManager checkDetailManager = new CheckDetailManager(new EfCheckDetailDal());
        CreditCardManager creditCardManager=new CreditCardManager(new EfCreditCardDal());
        public IActionResult CheckDetail_Index(int page = 1, string searchText = "")
		{
			int pageSize = 5;
			OlaTvDBContext c = new OlaTvDBContext();
			Pager pager;
			List<CheckDetail> data;
			var itemCounts = 0;
			if (searchText != "" && searchText != null)
			{
				data = c.CheckDetails.Where(x => x.CreditCard.CreditCardHolder.Contains(searchText)).Skip((page - 1) * pageSize).Take(pageSize).ToList();
				itemCounts = c.CheckDetails.Where(x => x.CreditCard.CreditCardHolder.Contains(searchText)).ToList().Count;
			}
			else
			{
				data = c.CheckDetails.Skip((page - 1) * pageSize).Take(pageSize).ToList();
				itemCounts = c.CheckDetails.ToList().Count;
			}
			pager = new Pager(page, pageSize, itemCounts);

			ViewBag.pager = pager;
			ViewBag.actionName = "CheckDetail_Index";
			ViewBag.contrName = "CheckDetail";
			ViewBag.searchText = searchText;
			return View(data);
		}

        [HttpGet]
        public IActionResult CheckDetail_Add()
        {
            CheckDetailModel checkDetailModel = new CheckDetailModel();
            checkDetailModel.CheckDetail=new CheckDetail();
            checkDetailModel.CreditCards=creditCardManager.GetAll();
            return View(checkDetailModel);
        }

        [HttpPost]
        public IActionResult CheckDetail_Add(CheckDetail checkDetail)
        {
            CheckDetailModel checkDetailModel = new CheckDetailModel();
            checkDetailModel.CheckDetail = checkDetail;
            checkDetailModel.CreditCards = creditCardManager.GetAll();

            CheckDetailValidator validator = new CheckDetailValidator();
            var result = validator.Validate(checkDetail);

            if(result.IsValid)
            {
                checkDetailManager.Add(checkDetail);
                return RedirectToAction("CheckDetail_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(checkDetailModel);
            }
          
        }


		[HttpGet]
		public IActionResult CheckDetail_Update(int id)
		{
            CheckDetail checkDetail=checkDetailManager.GetById(id);
			CheckDetailModel checkDetailModel = new CheckDetailModel();
            checkDetailModel.CheckDetail = checkDetail;
			checkDetailModel.CreditCards = creditCardManager.GetAll();
			return View(checkDetailModel);
		}

		[HttpPost]
		public IActionResult CheckDetail_Update(CheckDetail checkDetail)
		{
			CheckDetailModel checkDetailModel = new CheckDetailModel();
			checkDetailModel.CheckDetail = checkDetail;
			checkDetailModel.CreditCards = creditCardManager.GetAll();

			CheckDetailValidator validator = new CheckDetailValidator();
			var result = validator.Validate(checkDetail);

			if (result.IsValid)
			{
				checkDetailManager.Update(checkDetail);
				return RedirectToAction("CheckDetail_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(checkDetailModel);
			}

		}

		public IActionResult CheckDetail_Activate(int id)
		{
			CheckDetail checkDetail = checkDetailManager.GetById(id);
			checkDetail.IsDelete = false;
			checkDetailManager.Update(checkDetail);
			return RedirectToAction("CheckDetail_Index");
		}

		public IActionResult CheckDetail_Deactivate(int id)
		{
			CheckDetail checkDetail = checkDetailManager.GetById(id);
			checkDetail.IsDelete = true;
			checkDetailManager.Update(checkDetail);
			return RedirectToAction("CheckDetail_Index");
		}

		public IActionResult CheckDetail_Delete(int id)
		{
			CheckDetail checkDetail = checkDetailManager.GetById(id);
			checkDetailManager.Remove(checkDetail);
			return RedirectToAction("CheckDetail_Index");
		}



	}
}
