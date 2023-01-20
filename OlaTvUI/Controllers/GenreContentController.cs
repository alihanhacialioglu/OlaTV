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
    public class GenreContentController : Controller
	{
		GenreContentManager genreContentManager = new GenreContentManager(new EfGenreContentDal());
		GenreManager genreManager = new GenreManager(new EfGenreDal());
		ContentManager contentManager = new ContentManager(new EfContentDal());

        public IActionResult GenreContent_Index(int page = 1)
		{
			int pageSize = 5;
            var itemCounts = genreContentManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var genreContents = genreContentManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "GenreContent_Index";
            ViewBag.contrName = "GenreContent";
            return View(genreContents);
        }

        [HttpGet]
		public IActionResult GenreContent_Add()
		{
			GenreContentModel genreContentModel = new GenreContentModel();
			genreContentModel.GenreContent = new GenreContent();
			genreContentModel.Genres = genreManager.GetAll();
			genreContentModel.Contents = contentManager.GetAll();
			return View(genreContentModel);
		}
		[HttpPost]
		public IActionResult GenreContent_Add(GenreContent genreContent)
		{
			GenreContentModel genreContentModel = new GenreContentModel();
			genreContentModel.GenreContent = genreContent;
			genreContentModel.Genres = genreManager.GetAll();
			genreContentModel.Contents = contentManager.GetAll();
			GenreContentValidator validator = new GenreContentValidator();
			var result = validator.Validate(genreContent);
			if (result.IsValid)
			{
				genreContentManager.Add(genreContent);
				return RedirectToAction("GenreContent_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(genreContentModel);
			}
		}
        [HttpGet]
        public IActionResult GenreContent_Update(int id)
		{
			GenreContent genreContent = genreContentManager.GetById(id);
			GenreContentModel genreContentModel = new GenreContentModel();
			genreContentModel.GenreContent = genreContent;
			genreContentModel.Genres = genreManager.GetAll();
			genreContentModel.Contents = contentManager.GetAll();
			return View(genreContentModel);
		}

		[HttpPost]
		public IActionResult GenreContent_Update(GenreContent genreContent)
		{
			genreContentManager.Update(genreContent);
			return RedirectToAction("GenreContent_Index");
		}

		public IActionResult GenreContent_Activate(int id)
		{
			GenreContent genreContent = genreContentManager.GetById(id);
			genreContent.IsDelete = false;
			genreContentManager.Update(genreContent);
			return RedirectToAction("GenreContent_Index");
		}

		public IActionResult GenreContent_Deactivate(int id)
		{
			GenreContent genreContent = genreContentManager.GetById(id);
			genreContent.IsDelete = true;
			genreContentManager.Update(genreContent);
			return RedirectToAction("GenreContent_Index");
		}

		public IActionResult GenreContent_Delete(int id)
		{
			GenreContent genreContent = genreContentManager.GetById(id);
			genreContentManager.Remove(genreContent);
			return RedirectToAction("GenreContent_Index");
		}
	}
}
