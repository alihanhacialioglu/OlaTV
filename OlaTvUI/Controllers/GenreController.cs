using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class GenreController : Controller
    {
        GenreManager genreManager = new GenreManager(new EfGenreDal());

        public IActionResult Genre_Index(int page = 1)
        {
            int pageSize = 5;
            var itemCounts = genreManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var genres = genreManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "Genre_Index";
            ViewBag.contrName = "Genre";
            return View(genres);
        }

        [HttpGet]
        public IActionResult Genre_Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Genre_Add(Genre genre)
        {
            GenreValidator validator = new GenreValidator();
            var result = validator.Validate(genre);
            if (result.IsValid)
            {
                genreManager.Add(genre);
                return RedirectToAction("Genre_Index");
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
        public IActionResult Genre_Update(int id)
        {
            Genre genre = genreManager.GetById(id);
            return View(genre);
        }

        [HttpPost]
        public IActionResult Genre_Update(Genre genre)
        {
            GenreValidator validator = new GenreValidator();
            var result = validator.Validate(genre);
            if (result.IsValid)
            {
                genreManager.Update(genre);
                return RedirectToAction("Genre_Index");
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

        public IActionResult Genre_Delete(int id)
        {
            Genre genre = genreManager.GetById(id);
            genreManager.Remove(genre);
            return RedirectToAction("Genre_Index");
        }

        public IActionResult Genre_Activate(int id)
        {
            Genre genre = genreManager.GetById(id);
            genre.IsDelete = false;
            genreManager.Update(genre);
            return RedirectToAction("Genre_Index");
        }

        public IActionResult Genre_Deactivate(int id)
        {
            Genre genre = genreManager.GetById(id);
            genre.IsDelete = true;
            genreManager.Update(genre);
            return RedirectToAction("Genre_Index");
        }
    }
}
