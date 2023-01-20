using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class ProfilePlaybackSettingController : Controller
	{
		ProfilePlaybackSettingManager profilePlaybackSettingManager = new ProfilePlaybackSettingManager(new EfProfilePlaybackSettingDal());
		ProfileManager profileManager = new ProfileManager(new EfProfileDal());
		PlaybackSettingManager playbackSettingManager = new PlaybackSettingManager(new EfPlaybackSettingDal());

        public IActionResult ProfilePlaybackSetting_Index(int page = 1)
		{
			int pageSize = 5;
            var itemCounts = profilePlaybackSettingManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var profilePlaybackSettings = profilePlaybackSettingManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "ProfilePlaybackSetting_Index";
            ViewBag.contrName = "ProfilePlaybackSetting";
            return View(profilePlaybackSettings);
        }

        [HttpGet]
		public IActionResult ProfilePlaybackSetting_Add()
		{
			ProfilePlaybackSettingModel profilePlaybackSettingModel = new ProfilePlaybackSettingModel
			{
				ProfilePlaybackSetting = new ProfilePlaybackSetting(),
				PlaybackSettings = playbackSettingManager.GetAll(),
				Profiles = profileManager.GetAll()
			};

			return View(profilePlaybackSettingModel);
		}
		[HttpPost]
		public IActionResult ProfilePlaybackSetting_Add(ProfilePlaybackSetting profilePlaybackSetting)
		{
			ProfilePlaybackSettingModel profilePlaybackSettingModel = new ProfilePlaybackSettingModel
			{
				ProfilePlaybackSetting = profilePlaybackSetting,
				PlaybackSettings = playbackSettingManager.GetAll(),
				Profiles = profileManager.GetAll()
			};

			ProfilePlaybackSettingValidator validator = new ProfilePlaybackSettingValidator();
			var result = validator.Validate(profilePlaybackSetting);

			if (result.IsValid)
			{
				profilePlaybackSettingManager.Add(profilePlaybackSetting);
				return RedirectToAction("ProfilePlaybackSetting_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(profilePlaybackSettingModel);
			}
		}

		public IActionResult ProfilePlaybackSetting_Update(int id)
		{
			ProfilePlaybackSetting profilePlaybackSetting = profilePlaybackSettingManager.GetById(id);
			ProfilePlaybackSettingModel profilePlaybackSettingModel = new ProfilePlaybackSettingModel
			{
				ProfilePlaybackSetting = profilePlaybackSetting,
				PlaybackSettings = playbackSettingManager.GetAll(),
				Profiles = profileManager.GetAll()
			};
			return View(profilePlaybackSettingModel);
		}

		[HttpPost]
		public IActionResult ProfilePlaybackSetting_Update(ProfilePlaybackSetting profilePlaybackSetting)
		{
			ProfilePlaybackSettingModel profilePlaybackSettingModel = new ProfilePlaybackSettingModel
			{
				ProfilePlaybackSetting = profilePlaybackSetting,
				PlaybackSettings = playbackSettingManager.GetAll(),
				Profiles = profileManager.GetAll()
			};

			ProfilePlaybackSettingValidator validator = new ProfilePlaybackSettingValidator();
			var result = validator.Validate(profilePlaybackSetting);
			if (result.IsValid)
			{
				profilePlaybackSettingManager.Update(profilePlaybackSetting);
				return RedirectToAction("ProfilePlaybackSetting_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(profilePlaybackSettingModel);
			}
		}

		public IActionResult ProfilePlaybackSetting_Activate(int id)
		{
			ProfilePlaybackSetting profilePlaybackSetting = profilePlaybackSettingManager.GetById(id);
			profilePlaybackSetting.IsDelete = false;
			profilePlaybackSettingManager.Update(profilePlaybackSetting);
			return RedirectToAction("ProfilePlaybackSetting_Index");
		}

		public IActionResult ProfilePlaybackSetting_Deactivate(int id)
		{
			ProfilePlaybackSetting profilePlaybackSetting = profilePlaybackSettingManager.GetById(id);
			profilePlaybackSetting.IsDelete = true;
			profilePlaybackSettingManager.Update(profilePlaybackSetting);
			return RedirectToAction("ProfilePlaybackSetting_Index");
		}

		public IActionResult ProfilePlaybackSetting_Delete(int id)
		{
			ProfilePlaybackSetting profilePlaybackSetting = profilePlaybackSettingManager.GetById(id);
			profilePlaybackSettingManager.Remove(profilePlaybackSetting);
			return RedirectToAction("ProfilePlaybackSetting_Index");
		}
	}
}
