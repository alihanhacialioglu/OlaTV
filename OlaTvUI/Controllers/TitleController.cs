using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Text;

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
            TitleValidator validator = new TitleValidator();
            var result = validator.Validate(title);
            if (result.IsValid)
            {
                titleManager.Add(title);
                return RedirectToAction("Title_Index");
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
		public IActionResult Title_Update(int id) 
		{
			Title title = titleManager.GetById(id);
			return View(title);
		}
		[HttpPost]
		public IActionResult Title_Update(Title title) 
		{
            TitleValidator validator = new TitleValidator();
            var result = validator.Validate(title);
            if (result.IsValid)
            {
                titleManager.Update(title);
                return RedirectToAction("Title_Index");
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
