using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
	public class GenreController : Controller
	{
		GenreManager genreManager = new GenreManager(new EfGenreDal());

		public IActionResult Genre_Index()
		{
			var genres = genreManager.GetAll();
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
			genreManager.Add(genre);
			return RedirectToAction("Genre_Index");
		}

		public IActionResult Genre_Update(int id)
		{
			Genre genre = genreManager.GetById(id);
			return View(genre);
		}

		[HttpPost]
		public IActionResult Genre_Update(Genre genre)
		{
			genreManager.Update(genre);
			return RedirectToAction("Genre_Index");
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
