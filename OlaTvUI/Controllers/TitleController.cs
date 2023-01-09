using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
	public class TitleController : Controller
	{
		TitleManager titleManager = new TitleManager(new EfTitleDal());
		public IActionResult Title_Index()
		{
			var titles = titleManager.GetAll();
			return View(titles);
		}

		[HttpGet]
		public IActionResult Title_Add()
		{
			return View();
		}

		[HttpPost] 
		public IActionResult Title_Add(Title title) 
		{			
			titleManager.Add(title);
			return RedirectToAction("Title_Index");
		}

		[HttpGet]
		public IActionResult Title_Update(int id) 
		{
			Title title = titleManager.GetById(id);
			return View(title);
		}
		[HttpPost]
		public IActionResult Title_Update(Title title) 
		{ 
			titleManager.Update(title);
			return RedirectToAction("Title_Index");
		}

		public IActionResult Title_Delete(int id) 
		{
            Title title = titleManager.GetById(id);			
			titleManager.Remove(title);
			return RedirectToAction("Title_Index");
        }

        public IActionResult Title_Activate(int id)
        {
            Title title= titleManager.GetById(id);
            title.IsDelete = false;
            titleManager.Update(title);
            return RedirectToAction("Title_Index");
        }

        public IActionResult Title_Deactivate(int id)
        {

            Title title = titleManager.GetById(id);
            title.IsDelete = true;
            titleManager.Update(title);
            return RedirectToAction("Title_Index");
        }
    }
}
