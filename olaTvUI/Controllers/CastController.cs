using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class CastController : Controller
    {
        CastManager castManager = new CastManager(new EfCastDal());

        public IActionResult Cast_Index(int page = 1)
        {
            int pageSize = 5;
            var itemCounts = castManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var casts = castManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "Cast_Index";
            ViewBag.contrName = "Cast";
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
            CastValidator castValidator= new CastValidator();
            var result=castValidator.Validate(cast);
            if (result.IsValid)
            {
                castManager.Add(cast);
                return RedirectToAction("Cast_Index");
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
        public IActionResult Cast_Update(int id)
        {
            Cast cast = castManager.GetById(id);

            return View(cast);
        }

        [HttpPost]
        public IActionResult Cast_Update(Cast cast)
        {
            CastValidator castValidator = new CastValidator();
            var result = castValidator.Validate(cast);
            if (result.IsValid)
            {
                castManager.Update(cast);
                return RedirectToAction("Cast_Index");
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
