using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class ProfileVideoWatchingController : Controller
	{
		ProfileVideoWatchingManager profileVideoWatchingManager = new ProfileVideoWatchingManager(new EfProfileVideoWatchingDal());
		ProfileManager profileManager = new ProfileManager(new EfProfileDal());
		VideoManager videoManager = new VideoManager(new EfVideoDal());

		public IActionResult ProfileVideoWatching_Index()
		{
			var profileVideoWatchings = profileVideoWatchingManager.GetAll();
			return View(profileVideoWatchings);
		}

		[HttpGet]
		public IActionResult ProfileVideoWatching_Add()
		{
			ProfileVideoWatchingModel profileVideoWatchingModel = new ProfileVideoWatchingModel();
			profileVideoWatchingModel.ProfileVideoWatching = new ProfileVideoWatching();
			profileVideoWatchingModel.Videos = videoManager.GetAll();
			profileVideoWatchingModel.Profiles = profileManager.GetAll();
			return View(profileVideoWatchingModel);
		}
		[HttpPost]
		public IActionResult ProfileVideoWatching_Add(ProfileVideoWatching profileVideoWatching)
		{
			ProfileVideoWatchingModel profileVideoWatchingModel = new ProfileVideoWatchingModel();
			profileVideoWatchingModel.ProfileVideoWatching = profileVideoWatching;
			profileVideoWatchingModel.Videos = videoManager.GetAll();
			profileVideoWatchingModel.Profiles = profileManager.GetAll();
			ProfileVideoWatchingValidator validator = new ProfileVideoWatchingValidator();
			var result = validator.Validate(profileVideoWatching);
			if (result.IsValid)
			{
				profileVideoWatchingManager.Add(profileVideoWatching);
				return RedirectToAction("ProfileVideoWatching_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(profileVideoWatchingModel);
			}
		}

		public IActionResult ProfileVideoWatching_Update(int id)
		{
			ProfileVideoWatching profileVideoWatching = profileVideoWatchingManager.GetById(id);
			ProfileVideoWatchingModel profileVideoWatchingModel = new ProfileVideoWatchingModel();
			profileVideoWatchingModel.ProfileVideoWatching = profileVideoWatching;
			profileVideoWatchingModel.Videos = videoManager.GetAll();
			profileVideoWatchingModel.Profiles = profileManager.GetAll();
			return View(profileVideoWatchingModel);
		}

		[HttpPost]
		public IActionResult ProfileVideoWatching_Update(ProfileVideoWatching profileVideoWatching)
		{
			profileVideoWatchingManager.Update(profileVideoWatching);
			return RedirectToAction("ProfileVideoWatching_Index");
		}

		public IActionResult ProfileVideoWatching_Activate(int id)
		{
			ProfileVideoWatching profileVideoWatching = profileVideoWatchingManager.GetById(id);
			profileVideoWatching.IsDelete = false;
			profileVideoWatchingManager.Update(profileVideoWatching);
			return RedirectToAction("ProfileVideoWatching_Index");
		}

		public IActionResult ProfileVideoWatching_Deactivate(int id)
		{
			ProfileVideoWatching profileVideoWatching = profileVideoWatchingManager.GetById(id);
			profileVideoWatching.IsDelete = true;
			profileVideoWatchingManager.Update(profileVideoWatching);
			return RedirectToAction("ProfileVideoWatching_Index");
		}

		public IActionResult ProfileVideoWatching_Delete(int id)
		{
			ProfileVideoWatching profileVideoWatching = profileVideoWatchingManager.GetById(id);
			profileVideoWatchingManager.Remove(profileVideoWatching);
			return RedirectToAction("ProfileVideoWatching_Index");
		}
	}
}
