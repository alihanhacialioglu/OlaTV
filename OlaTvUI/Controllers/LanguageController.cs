using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class LanguageController : Controller
	{
		LanguageManager languageManager = new LanguageManager(new EfLanguageDal());
		public IActionResult Language_Index(int page = 1)
		{
            int pageSize = 5;
			var itemCounts = languageManager.GetAll().Count;
			Pager pager = new Pager(page, pageSize, itemCounts);
			var languages = languageManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "Language_Index";
            ViewBag.contrName = "Language";
            return View(languages);
		}

		[HttpGet]
		public IActionResult Language_Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Language_Add(Language language)
		{
			LanguageValidator validator = new LanguageValidator();
			var result = validator.Validate(language);
			if (result.IsValid)
			{
				languageManager.Add(language);
				return RedirectToAction("Language_Index");
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
		public IActionResult Language_Update(int id)
		{
			Language language = languageManager.GetById(id);
			return View(language);
		}


		[HttpPost]
		public IActionResult Language_Update(Language language)
		{
			LanguageValidator validator = new LanguageValidator();
			var result = validator.Validate(language);
			if (result.IsValid)
			{
				languageManager.Update(language);
				return RedirectToAction("Language_Index");
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
		public IActionResult Language_Delete(int id)
		{
			Language language = languageManager.GetById(id);

			ProfileManager profileManager = new ProfileManager(new EfProfileDal());
			VideoManager videoManager = new VideoManager(new EfVideoDal());

			var profileList = profileManager.GetAll();
			var videoList = videoManager.GetAll();

			foreach (var prof in profileList)
			{
				if (prof.LanguageId == language.LanguageId)
				{
					return RedirectToAction("Language_Index");
				}
			}

			foreach (var vid in videoList)
			{
				if (vid.LanguageId == language.LanguageId)
				{
					return RedirectToAction("Language_Index");
				}
			}

			languageManager.Remove(language);
			return RedirectToAction("Language_Index");
		}
		public IActionResult Language_Activate(int id)
		{
			Language language = languageManager.GetById(id);
			language.IsDelete = false;
			languageManager.Update(language);
			return RedirectToAction("Language_Index");
		}

		public IActionResult Language_Deactivate(int id)
		{
			Language language = languageManager.GetById(id);
			language.IsDelete = true;
			languageManager.Update(language);
			return RedirectToAction("Language_Index");
		}
	}
}
