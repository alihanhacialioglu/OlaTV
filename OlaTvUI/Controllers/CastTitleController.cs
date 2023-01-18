using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class CastTitleController : Controller
	{
		CastTitleManager castTitleManager = new CastTitleManager(new EfCastTitleDal());
		CastManager castManager = new CastManager(new EfCastDal());
		TitleManager titleManager = new TitleManager(new EfTitleDal());
		public IActionResult CastTitle_Index()
		{
			var castTitles = castTitleManager.GetAll();
			return View(castTitles);
		}
		[HttpGet]
		public IActionResult CastTitle_Add()
		{
            CastTitleModel castTitleModel = new CastTitleModel();
			castTitleModel.CastTitle = new CastTitle();
			castTitleModel.Casts = castManager.GetAll();
			castTitleModel.Titles = titleManager.GetAll();
			return View(castTitleModel);
		}
		[HttpPost]
		public IActionResult CastTitle_Add(CastTitle castTitle)
		{
            CastTitleModel castTitleModel = new CastTitleModel();
			castTitleModel.CastTitle = castTitle;
			castTitleModel.Casts = castManager.GetAll();
			castTitleModel.Titles = titleManager.GetAll();
			CastTitleValidator validator = new CastTitleValidator();
			var result = validator.Validate(castTitle);
			if (result.IsValid)
			{
				castTitleManager.Add(castTitle);
				return RedirectToAction("CastTitle_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(castTitleModel);
			}
		}

        [HttpGet]
        public IActionResult CastTitle_Update(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
            CastTitleModel castTitleModel = new CastTitleModel();
			castTitleModel.CastTitle = castTitle;
			castTitleModel.Casts = castManager.GetAll();
			castTitleModel.Titles = titleManager.GetAll();
			return View(castTitleModel);
		}

		[HttpPost]
		public IActionResult CastTitle_Update(CastTitle castTitle)
		{
			castTitleManager.Update(castTitle);
			return RedirectToAction("CastTitle_Index");
		}

		public IActionResult CastTitle_Activate(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
			castTitle.IsDelete = false;
			castTitleManager.Update(castTitle);
			return RedirectToAction("CastTitle_Index");
		}

		public IActionResult CastTitle_Deactivate(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
			castTitle.IsDelete = true;
			castTitleManager.Update(castTitle);
			return RedirectToAction("CastTitle_Index");
		}

		public IActionResult CastTitle_Delete(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
			castTitleManager.Remove(castTitle);
			return RedirectToAction("CastTitle_Index");
		}
	}
}
