using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class MaturityRatingController : Controller
	{
		MaturityRatingManager maturityRatingManager = new MaturityRatingManager(new EfMaturityRatingDal());

        public IActionResult MaturityRating_Index(int page = 1)
		{
			int pageSize = 5;
            var itemCounts = maturityRatingManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var maturityRatings = maturityRatingManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "MaturityRating_Index";
            ViewBag.contrName = "MaturityRating";
            return View(maturityRatings);
        }

        [HttpGet]
		public IActionResult MaturityRating_Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult MaturityRating_Add(MaturityRating maturityRating)
		{
			MaturityRatingValidator validator = new MaturityRatingValidator();
			var result = validator.Validate(maturityRating);
			if (result.IsValid)
			{
				maturityRatingManager.Add(maturityRating);
				return RedirectToAction("MaturityRating_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}
		}

		[HttpGet]
		public IActionResult MaturityRating_Update(int id)
		{
			MaturityRating maturityRating = maturityRatingManager.GetById(id);
			return View(maturityRating);
		}

		[HttpPost]
		public IActionResult MaturityRating_Update(MaturityRating maturityRating)
		{
			MaturityRatingValidator validator = new MaturityRatingValidator();
			var result = validator.Validate(maturityRating);
			if (result.IsValid)
			{
				maturityRatingManager.Update(maturityRating);
				return RedirectToAction("MaturityRating_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}
		}

		public IActionResult MaturityRating_Delete(int id)
		{
			MaturityRating textsize = maturityRatingManager.GetById(id);
			maturityRatingManager.Remove(textsize);
			return RedirectToAction("MaturityRating_Index");

		}

		public IActionResult MaturityRating_Activate(int id)
		{
			MaturityRating maturityRating = maturityRatingManager.GetById(id);
			maturityRating.IsDelete = false;
			maturityRatingManager.Update(maturityRating);
			return RedirectToAction("MaturityRating_Index");
		}

		public IActionResult MaturityRating_Deactivate(int id)
		{
			MaturityRating maturityRating = maturityRatingManager.GetById(id);
			maturityRating.IsDelete = true;
			maturityRatingManager.Update(maturityRating);
			return RedirectToAction("MaturityRating_Index");
		}
	}
}
