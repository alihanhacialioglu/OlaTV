using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class CastController : Controller
    {
        CastManager cm = new CastManager(new EfCastDal());

        public IActionResult Cast_Index()
        {
            var casts = cm.GetAll();
            return View(casts);
        }

        [HttpGet]
        public IActionResult Cast_Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Cast_Add(Cast cast)
        {
            cm.Add(cast);
            return RedirectToAction("Cast_Index");
        }

        [HttpGet]
        public IActionResult Cast_Update(int id)
        {
            Cast cast = cm.GetById(id);

            return View(cast);
        }

        [HttpPost]
        public IActionResult Cast_Update(Cast cast)
        {
            cm.Update(cast);

            return RedirectToAction("Cast_Index");
        }

        [HttpPost]
        public IActionResult Cast_Delete(int id)
        {
            Cast cast=cm.GetById(id);
            cast.IsDelete = true;
            cm.Remove(cast);
            return RedirectToAction("Cast_Index");
        }

    }   

}
