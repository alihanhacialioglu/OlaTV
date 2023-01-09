using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class CastController : Controller
    {
        CastManager castManager = new CastManager(new EfCastDal());

        public IActionResult Cast_Index()
        {
            var casts = castManager.GetAll();
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
            castManager.Add(cast);
            return RedirectToAction("Cast_Index");
        }

      
        public IActionResult Cast_Update(int id)
        {
            Cast cast = castManager.GetById(id);

            return View(cast);
        }

        [HttpPost]
        public IActionResult Cast_Update(Cast cast)
        {
            castManager.Update(cast);

            return RedirectToAction("Cast_Index");
        }

        
        public IActionResult Cast_Delete(int id)
        {
            Cast cast = castManager.GetById(id);
            castManager.Remove(cast);
            return RedirectToAction("Cast_Index");
        }
        public IActionResult Cast_Activate(int id)
        {
            Cast cast = castManager.GetById(id);
            cast.IsDelete = false;
            castManager.Update(cast);
            return RedirectToAction("Cast_Index");
        }

        public IActionResult Cast_Deactivate(int id)
        {
            Cast cast = castManager.GetById(id);
            cast.IsDelete = true;
            castManager.Update(cast);
            return RedirectToAction("Cast_Index");
        }

    }   

}
