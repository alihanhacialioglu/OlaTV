using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class FontController : Controller
    {
        FontManager fontManager = new FontManager(new EfFontDal());
        ColorManager colorManager = new ColorManager(new EfColorDal());
        public IActionResult Font_Index()
        {
            var fonts = fontManager.GetAll();
            return View(fonts);
        }

        [HttpGet]
        public IActionResult Font_Add()
        {
            FontModel fontModel = new FontModel();
            fontModel.Font = new Font();
            fontModel.Colors=colorManager.GetAll();
            return View(fontModel);
        }
        [HttpPost]
        public IActionResult Font_Add(Font font)
        {
            fontManager.Add(font);
            return RedirectToAction("Font_Index");
        }

        public IActionResult Font_Update(int id)
        {
            Font font = fontManager.GetById(id);
            FontModel fontModel= new FontModel();
            fontModel.Colors= colorManager.GetAll();
            fontModel.Font = font;
            return View(fontModel);
        }

        [HttpPost]
        public IActionResult Font_Update(Font font)
        {
            fontManager.Update(font);
            return RedirectToAction("Font_Index");
        }

        public IActionResult Font_Delete(int id)
        {
            Font font = fontManager.GetById(id);
            font.IsDelete = true;
            fontManager.Update(font);
            return View("Font_Index");
        }
    }
}
