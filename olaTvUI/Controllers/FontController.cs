using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace OlaTvUI.Controllers
{
    public class FontController : Controller
    {
        FontManager fontManager = new FontManager(new EfFontDal());
        public IActionResult Font_Index()
        {
            var fonts = fontManager.GetAll();
            return View(fonts);
        }

        [HttpGet]
        public IActionResult Font_Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Font_Add(EntityLayer.Concrete.Font font)
        {
            fontManager.Add(font);
            return RedirectToAction("Font_Index");
        }

        public IActionResult Font_Update(int id)
        {
            EntityLayer.Concrete.Font font = fontManager.GetById(id);
            return View(font);
        }

        [HttpPost]
        public IActionResult Font_Update(EntityLayer.Concrete.Font font)
        {
            fontManager.Update(font);
            return RedirectToAction("Font_Index");
        }

        public IActionResult Font_Delete(int id)
        {
            EntityLayer.Concrete.Font font = fontManager.GetById(id);
            font.IsDelete = true;
            fontManager.Update(font);
            return View("Font_Index");
        }
    }
}
