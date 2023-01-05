using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class ShadowController : Controller
    {
        ShadowManager shadowManager = new ShadowManager(new EfShadowDal());
        ColorManager colorManager = new ColorManager(new EfColorDal());
        public IActionResult Shadow_Index()
        {
            var shadows = shadowManager.GetAll();
            return View(shadows);
        }

        [HttpGet]
        public IActionResult Shadow_Add()
        {
            ShadowColorModel shadowColorModal = new ShadowColorModel();
            shadowColorModal.Colors = colorManager.GetAll();
            shadowColorModal.ShadowModal = new Shadow();
            return View(shadowColorModal);
        }

        [HttpPost]
        public IActionResult Shadow_Add(Shadow shadow)
        {
            shadowManager.Add(shadow);
            return RedirectToAction("Shadow_Index");
        }

        public IActionResult Shadow_Update(int id)
        {
            Shadow shadow = shadowManager.GetById(id);
            return View(shadow);
        }

        [HttpPost]
        public IActionResult Shadow_Update(Shadow shadow)
        {
            shadowManager.Update(shadow);
            return RedirectToAction("Shadow_Index");
        }

        public IActionResult Shadow_Delete(int id)
        {
            Shadow shadow = shadowManager.GetById(id);
            shadow.IsDelete = true;
            shadowManager.Update(shadow);
            return RedirectToAction("Shadow_Index");
        }
    }
}
