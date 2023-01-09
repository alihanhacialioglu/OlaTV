using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
	public class StyleController : Controller
	{
		StyleManager styleManager = new StyleManager(new EfStyleDal());

		public IActionResult Style_Index()
		{
			var styles = styleManager.GetAll();
			return View(styles);
		}

		[HttpGet]
		public IActionResult Style_Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Style_Add(Style style)
		{
			styleManager.Add(style);
			return RedirectToAction("Style_Index");
		}

		public IActionResult Style_Update(int id)
		{
			Style textsize = styleManager.GetById(id);
			return View(textsize);
		}

		[HttpPost]
		public IActionResult Style_Update(Style style)
		{
			styleManager.Update(style);
			return RedirectToAction("Style_Index");
		}

		public IActionResult Style_Delete(int id)
		{
			Style textsize = styleManager.GetById(id);
			styleManager.Remove(textsize);
			return RedirectToAction("Style_Index");

		}

		public IActionResult Style_Activate(int id)
		{
			Style style = styleManager.GetById(id);
			style.IsDelete = false;
			styleManager.Update(style);
			return RedirectToAction("Style_Index");
		}

		public IActionResult Style_Deactivate(int id)
		{
			Style style = styleManager.GetById(id);
			style.IsDelete = true;
			styleManager.Update(style);
			return RedirectToAction("Style_Index");
		}
	}
}
