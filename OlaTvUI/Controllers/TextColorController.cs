using BusinessLayer.Manager;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

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
            TextColorValidator validator = new TextColorValidator();
            var result = validator.Validate(textColor);
            if (result.IsValid)
            {
                textColorManager.Add(textColor);
                return RedirectToAction("TextColor_Index");
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
        public IActionResult TextColor_Update(int id)
        {
            TextColor textColor = textColorManager.GetById(id);
            return View(textColor);
        }

        [HttpPost]
        public IActionResult TextColor_Update(TextColor textColor)
        {
            TextColorValidator validator = new TextColorValidator();
            var result = validator.Validate(textColor);
            if (result.IsValid)
            {
                textColorManager.Update(textColor);
                return RedirectToAction("TextColor_Index");
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
