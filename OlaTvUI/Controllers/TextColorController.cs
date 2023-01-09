using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class TextColorController : Controller
    {
        TextColorManager textColorManager = new TextColorManager(new EfTextColorDal());

        public IActionResult TextColor_Index()
        {
            var textColors = textColorManager.GetAll();
            return View(textColors);
        }

        [HttpGet]
        public IActionResult TextColor_Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextColor_Add(TextColor textColor)
        {
            textColorManager.Add(textColor);
            return RedirectToAction("TextColor_Index");
        }

        public IActionResult TextColor_Update(int id)
        {
            TextColor textColor = textColorManager.GetById(id);
            return View(textColor);
        }

        [HttpPost]
        public IActionResult TextColor_Update(TextColor textColor)
        {
            textColorManager.Update(textColor);
            return RedirectToAction("TextColor_Index");
        }

        public IActionResult TextColor_Delete(int id)
        {
            TextColor textColor = textColorManager.GetById(id);
            textColorManager.Remove(textColor);
            return RedirectToAction("TextColor_Index");

        }

        public IActionResult TextColor_Activate(int id)
        {
            TextColor textColor = textColorManager.GetById(id);
            textColor.IsDelete = false;
            textColorManager.Update(textColor);
            return RedirectToAction("TextColor_Index");
        }

        public IActionResult TextColor_Deactivate(int id)
        {
            TextColor textColor = textColorManager.GetById(id);
            textColor.IsDelete = true;
            textColorManager.Update(textColor);
            return RedirectToAction("TextColor_Index");
        }
    }
}
