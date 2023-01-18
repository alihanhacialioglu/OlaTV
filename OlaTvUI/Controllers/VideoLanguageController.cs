using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class VideoLanguageController : Controller
	{
		VideoLanguageManager videoLanguageManager = new VideoLanguageManager(new EfVideoLanguageDal());
		VideoManager videoManager = new VideoManager(new EfVideoDal());
		LanguageManager languageManager = new LanguageManager(new EfLanguageDal());

		public IActionResult VideoLanguage_Index()
		{
			var videoLanguages = videoLanguageManager.GetAll();
			return View(videoLanguages);
		}

		[HttpGet]
		public IActionResult VideoLanguage_Add()
		{
			VideoLanguageModel videoLanguageModel = new VideoLanguageModel();
			videoLanguageModel.VideoLanguage = new VideoLanguage();
			videoLanguageModel.Videos = videoManager.GetAll();
			videoLanguageModel.Languages = languageManager.GetAll();
			return View(videoLanguageModel);
		}
		[HttpPost]
		public IActionResult VideoLanguage_Add(VideoLanguage videoLanguage)
		{
			VideoLanguageModel videoLanguageModel = new VideoLanguageModel();
			videoLanguageModel.VideoLanguage = videoLanguage;
			videoLanguageModel.Videos = videoManager.GetAll();
			videoLanguageModel.Languages = languageManager.GetAll();
			VideoLanguageValidator validator = new VideoLanguageValidator();
			var result = validator.Validate(videoLanguage);
			if (result.IsValid)
			{
				videoLanguageManager.Add(videoLanguage);
				return RedirectToAction("VideoLanguage_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(videoLanguageModel);
			}
		}

		public IActionResult VideoLanguage_Update(int id)
		{
			VideoLanguage videoLanguage = videoLanguageManager.GetById(id);
			VideoLanguageModel videoLanguageModel = new VideoLanguageModel();
			videoLanguageModel.VideoLanguage = videoLanguage;
			videoLanguageModel.Videos = videoManager.GetAll();
			videoLanguageModel.Languages = languageManager.GetAll();
			return View(videoLanguageModel);
		}

		[HttpPost]
		public IActionResult VideoLanguage_Update(VideoLanguage videoLanguage)
		{
			videoLanguageManager.Update(videoLanguage);
			return RedirectToAction("VideoLanguage_Index");
		}

		public IActionResult VideoLanguage_Activate(int id)
		{
			VideoLanguage videoLanguage = videoLanguageManager.GetById(id);
			videoLanguage.IsDelete = false;
			videoLanguageManager.Update(videoLanguage);
			return RedirectToAction("VideoLanguage_Index");
		}

		public IActionResult VideoLanguage_Deactivate(int id)
		{
			VideoLanguage videoLanguage = videoLanguageManager.GetById(id);
			videoLanguage.IsDelete = true;
			videoLanguageManager.Update(videoLanguage);
			return RedirectToAction("VideoLanguage_Index");
		}

		public IActionResult VideoLanguage_Delete(int id)
		{
			VideoLanguage videoLanguage = videoLanguageManager.GetById(id);
			videoLanguageManager.Remove(videoLanguage);
			return RedirectToAction("VideoLanguage_Index");
		}
	}
}
