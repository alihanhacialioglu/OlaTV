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
    public class ProfileContentController : Controller
    {
        ProfileContentManager profileContentManager = new ProfileContentManager(new EfProfileContentDal());
        ProfileManager profileManager = new ProfileManager(new EfProfileDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());
        public IActionResult ProfileContent_Index(int page = 1)
        {
            int pageSize = 5;
            var itemCounts = profileContentManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var profileContents = profileContentManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "ProfileContent_Index";
            ViewBag.contrName = "ProfileContent";
            return View(profileContents);
        }

        [HttpGet]

        public IActionResult ProfileContent_Add()
        {
            ProfileContentModel profileContentModel = new ProfileContentModel();
            profileContentModel.ProfileContent = new ProfileContent();
            profileContentModel.Profiles = profileManager.GetAll();
            profileContentModel.Contents = contentManager.GetAll();
            return View(profileContentModel);
        }

        [HttpPost]
        public IActionResult ProfileContent_Add(ProfileContent profileContent)
        {
            ProfileContentModel profileContentModel = new ProfileContentModel();
            profileContentModel.ProfileContent = profileContent;
            profileContentModel.Profiles = profileManager.GetAll();
            profileContentModel.Contents = contentManager.GetAll();

            ProfileContentValidator validator = new ProfileContentValidator();
            var result = validator.Validate(profileContent);
            if (result.IsValid)
            {
                profileContentManager.Add(profileContent);
                return RedirectToAction("ProfileContent_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(profileContentModel);
            }
        }

        [HttpGet]

        public IActionResult ProfileContent_Update(int id)
        {
            ProfileContentModel profileContentModel = new ProfileContentModel();
            ProfileContent profileContent= profileContentManager.GetById(id);
            profileContentModel.ProfileContent = profileContent;
            profileContentModel.Profiles = profileManager.GetAll();
            profileContentModel.Contents = contentManager.GetAll();
            return View(profileContentModel);
        }

        [HttpPost]
        public IActionResult ProfileContent_Update(ProfileContent profileContent)
        {
            ProfileContentModel profileContentModel = new ProfileContentModel();
            profileContentModel.ProfileContent = profileContent;
            profileContentModel.Profiles = profileManager.GetAll();
            profileContentModel.Contents = contentManager.GetAll();

            ProfileContentValidator validator = new ProfileContentValidator();
            var result = validator.Validate(profileContent);
            if (result.IsValid)
            {
                profileContentManager.Update(profileContent);
                return RedirectToAction("ProfileContent_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(profileContentModel);
            }
        }

        public IActionResult ProfileContent_Activate(int id)
        {
            ProfileContent profileContent = profileContentManager.GetById(id);
            profileContent.IsDelete = false;
            profileContentManager.Update(profileContent);
            return RedirectToAction("ProfileContent_Index");
        }

        public IActionResult ProfileContent_Deactivate(int id)
        {
            ProfileContent profileContent = profileContentManager.GetById(id);
            profileContent.IsDelete = true;
            profileContentManager.Update(profileContent);
            return RedirectToAction("ProfileContent_Index");
        }

        public IActionResult ProfileContent_Delete(int id)
        {
            ProfileContent profileContent = profileContentManager.GetById(id);
            profileContentManager.Remove(profileContent);
            return RedirectToAction("ProfileContent_Index");
        }






    }
}
