using BusinessLayer.Manager;
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
        public IActionResult TextSize_Add(EntityLayer.Concrete.TextSize textSize) 
        {
            textSizeManager.Add(textSize);
            return RedirectToAction("TextSize_Index");
        }

        public IActionResult TextSize_Update(int id) 
        {
            TextSize textsize =textSizeManager.GetById(id);
            return View(textsize);
        }

        [HttpPost]
        public IActionResult TextSize_Update(EntityLayer.Concrete.TextSize textSize)
        {
            textSizeManager.Update(textSize);
            return RedirectToAction("TextSize_Index");
        }

        public IActionResult TextSize_Delete(int id) 
        {
            TextSize textsize=textSizeManager.GetById(id);
            textsize.IsDelete = true;
            textSizeManager.Update(textsize);
            return RedirectToAction("TextSize_Index");
        
        }




    }
}
