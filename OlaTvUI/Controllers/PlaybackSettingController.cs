using BusinessLayer.Manager;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class PlaybackSettingController : Controller
    {
        PlaybackSettingManager playbackSettingManager = new PlaybackSettingManager(new EfPlaybackSettingDal());

		public IActionResult PlaybackSetting_Index()
		{
			var playbackSettings = playbackSettingManager.GetAll();
			return View(playbackSettings);
		}

		[HttpGet]
		public IActionResult PlaybackSetting_Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult PlaybackSetting_Add(PlaybackSetting playbackSetting)
		{
			PlaybackSettingValidator validator = new PlaybackSettingValidator();
			var result = validator.Validate(playbackSetting);

			if (result.IsValid)
			{
				playbackSettingManager.Add(playbackSetting);
				return RedirectToAction("PlaybackSetting_Index");
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
		public IActionResult PlaybackSetting_Update(int id)
		{
			PlaybackSetting playbackSetting = playbackSettingManager.GetById(id);
			return View(playbackSetting);
		}

		[HttpPost]
		public IActionResult PlaybackSetting_Update(PlaybackSetting playbackSetting)
		{
			PlaybackSettingValidator validator = new PlaybackSettingValidator();
			var result = validator.Validate(playbackSetting);

			if (result.IsValid)
			{
				playbackSettingManager.Update(playbackSetting);
				return RedirectToAction("PlaybackSetting_Index");
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

		public IActionResult PlaybackSetting_Delete(int id)
		{
			PlaybackSetting textsize = playbackSettingManager.GetById(id);
			playbackSettingManager.Remove(textsize);
			return RedirectToAction("PlaybackSetting_Index");

		}

		public IActionResult PlaybackSetting_Activate(int id)
		{
			PlaybackSetting playbackSetting = playbackSettingManager.GetById(id);
			playbackSetting.IsDelete = false;
			playbackSettingManager.Update(playbackSetting);
			return RedirectToAction("PlaybackSetting_Index");
		}

		public IActionResult PlaybackSetting_Deactivate(int id)
		{
			PlaybackSetting playbackSetting = playbackSettingManager.GetById(id);
			playbackSetting.IsDelete = true;
			playbackSettingManager.Update(playbackSetting);
			return RedirectToAction("PlaybackSetting_Index");
		}
    }
}
