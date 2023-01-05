using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Reflection.Metadata.BlobBuilder;

namespace OlaTvUI.Controllers
{
    public class BackgroundController : Controller
    {
        BackgroundManager backgroundManager = new BackgroundManager(new EfBackgroundDal());
        ColorManager colorManager = new ColorManager(new EfColorDal());
        public IActionResult Background_Index()
        {
            var backgrounds = backgroundManager.GetAll();
            return View(backgrounds);
        }

        [HttpGet]
        public IActionResult Background_Add()
        {
            var allcolors = colorManager.GetAll();
            List<SelectListItem> colors = (from i in allcolors
                                             select new SelectListItem
                                             {
                                                 Text = i.ColorName,
                                                 Value = i.ColorId.ToString()
                                             }).ToList();
            ViewBag.value = colors;
            return View();
        }

        [HttpPost]
        public IActionResult Background_Add(Background background)
        {
            
            var colors = colorManager.GetAll();
            Color color = colors.Where(m => m.ColorId == background.Color.ColorId).FirstOrDefault();
            background.Color = color;
            backgroundManager.Add(background);
            return RedirectToAction("Background_Index");
        }

        public IActionResult Background_Update(int id)
        {
            Background background = backgroundManager.GetById(id);
            return View(background);
        }

        [HttpPost]
        public IActionResult Background_Update(Background background)
        {
            backgroundManager.Update(background);
            return RedirectToAction("Background_Index");
        }

        public IActionResult Background_Delete(int id)
        {
            Background background = backgroundManager.GetById(id);
            backgroundManager.Remove(background);
            return RedirectToAction("Background_Index");
        }
    }
}
