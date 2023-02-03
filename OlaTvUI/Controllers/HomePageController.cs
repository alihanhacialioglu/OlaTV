using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
	public class HomePageController : Controller
	{
		VideoManager videoManager = new VideoManager(new EfVideoDal());
		GenreContentManager genreContentManager = new GenreContentManager(new EfGenreContentDal());

		public IActionResult HomePage()
		{
			MainModel mainModel = new MainModel
			{
				Videos = videoManager.GetAll(),
				GenreContents = genreContentManager.GetAll(),
			};

			return View(mainModel);
		}

	}
}
