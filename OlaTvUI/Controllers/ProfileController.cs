using BusinessLayer.Manager;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class ProfileController : Controller
    {
        ProfileManager profileManager = new ProfileManager(new EfProfileDal());
        UserManager userManager = new UserManager(new EfUserDal());
        LanguageManager languageManager = new LanguageManager(new EfLanguageDal());
        MaturityRatingManager maturityRatingManager = new MaturityRatingManager(new EfMaturityRatingDal());
        TextColorManager textColorManager = new TextColorManager(new EfTextColorDal());
        TextSizeManager textSizeManager = new TextSizeManager(new EfTextSizeDal());

        public IActionResult Profile_Index()
        {
            var profiles = profileManager.GetAll();
            return View(profiles);
        }

        [HttpGet]
        public IActionResult Profile_Add()
        {
            ProfileModel profileModel = new ProfileModel
            {
                Profile = new Profile(),
                Users = userManager.GetAll(),
                Languages = languageManager.GetAll(),
                MaturityRatings = maturityRatingManager.GetAll(),
                TextColors = textColorManager.GetAll(),
                TextSizes = textSizeManager.GetAll()
            };
            return View(profileModel);
        }

        [HttpPost]
        public IActionResult Profile_Add(Profile profile)
        {
            ProfileModel profileModel = new ProfileModel
            {
                Profile = profile,
                Users = userManager.GetAll(),
                Languages = languageManager.GetAll(),
                MaturityRatings = maturityRatingManager.GetAll(),
                TextColors = textColorManager.GetAll(),
                TextSizes = textSizeManager.GetAll()
            };

            ProfileValidator validator = new ProfileValidator();
            var result = validator.Validate(profile);
            if (result.IsValid)
            {
                profileManager.Add(profile);
                return RedirectToAction("Profile_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(profileModel);
            }
        }

        public IActionResult Profile_Update(int id)
        {
            Profile profile = profileManager.GetById(id);
            ProfileModel profileModel = new ProfileModel
            {
                Profile = profile,
                Users = userManager.GetAll(),
                Languages = languageManager.GetAll(),
                MaturityRatings = maturityRatingManager.GetAll(),
                TextColors = textColorManager.GetAll(),
                TextSizes = textSizeManager.GetAll()
            };
            return View(profileModel);
        }

        [HttpPost]
        public IActionResult Profile_Update(Profile profile)
        {
            ProfileModel profileModel = new ProfileModel
            {
                Profile = profile,
                Users = userManager.GetAll(),
                Languages = languageManager.GetAll(),
                MaturityRatings = maturityRatingManager.GetAll(),
                TextColors = textColorManager.GetAll(),
                TextSizes = textSizeManager.GetAll()
            };

            ProfileValidator validator = new ProfileValidator();
            var result = validator.Validate(profile);

            if (result.IsValid)
            {
                profileManager.Update(profile);
                return RedirectToAction("Profile_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(profileModel);
            }
        }

        public IActionResult Profile_Activate(int id)
        {
            Profile profile = profileManager.GetById(id);
            profile.IsDelete = false;
            profileManager.Update(profile);
            return RedirectToAction("Profile_Index");
        }

        public IActionResult Profile_Deactivate(int id)
        {
            Profile profile = profileManager.GetById(id);
            profile.IsDelete = true;
            profileManager.Update(profile);
            return RedirectToAction("Profile_Index");
        }

        public IActionResult Profile_Delete(int id)
        {
            Profile profile = profileManager.GetById(id);
            ProfileVideoWatchingManager manager = new ProfileVideoWatchingManager(new EfProfileVideoWatchingDal());
            var list = manager.GetAll();
            foreach (var item in list)
            {
                if (item.ProfileId == profile.ProfileId)
                {
					return RedirectToAction("Profile_Index");
				}
            }
            profileManager.Remove(profile);
            return RedirectToAction("Profile_Index");
        }
    }
}
