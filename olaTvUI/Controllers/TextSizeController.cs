using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class TextSizeController : Controller
    {
        TextSizeManager textSizeManager = new TextSizeManager(new EfTextSizeDal());

        public IActionResult TextSize_Index()
        {
            var textsizes = textSizeManager.GetAll();
            return View(textsizes);
        }

        [HttpGet]
        public IActionResult TextSize_Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextSize_Add(TextSize textSize) 
        {
            TextSizeValidator validator = new TextSizeValidator();
            var result = validator.Validate(textSize);
            if (result.IsValid)
            {
                textSizeManager.Add(textSize);
                return RedirectToAction("TextSize_Index");
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
        public IActionResult TextSize_Update(int id) 
        {
            TextSize textsize =textSizeManager.GetById(id);
            return View(textsize);
        }

        [HttpPost]
        public IActionResult TextSize_Update(TextSize textSize)
        {
            TextSizeValidator validator = new TextSizeValidator();
            var result = validator.Validate(textSize);
            if (result.IsValid)
            {
                textSizeManager.Update(textSize);
                return RedirectToAction("TextSize_Index");
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

        public IActionResult TextSize_Delete(int id) 
        {
            TextSize textsize=textSizeManager.GetById(id);
            textSizeManager.Remove(textsize);
            return RedirectToAction("TextSize_Index");
        
        }

		public IActionResult TextSize_Activate(int id)
		{
			TextSize textSize = textSizeManager.GetById(id);
			textSize.IsDelete = false;
			textSizeManager.Update(textSize);
			return RedirectToAction("TextSize_Index");
		}

		public IActionResult TextSize_Deactivate(int id)
		{
			TextSize textSize = textSizeManager.GetById(id);
			textSize.IsDelete = true;
			textSizeManager.Update(textSize);
			return RedirectToAction("TextSize_Index");
		}

	}
}
