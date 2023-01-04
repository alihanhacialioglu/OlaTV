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
        public IActionResult Cast_Add(Cast Cast) 
        { 
            cm.Add(Cast);
            return RedirectToAction("Cast_Index");
        }
    }
}
