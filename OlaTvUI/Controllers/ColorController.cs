using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
	public class ColorController : Controller
	{
		ColorManager colorManager = new ColorManager(new EfColorDal());
		public IActionResult Color_Index()
		{
			var colors = colorManager.GetAll();
			return View(colors);
		}

		[HttpGet]
		public IActionResult Color_Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Color_Add(Color color)
		{
			colorManager.Add(color);
			return RedirectToAction("Color_Index");
		}

		public IActionResult Color_Update(int id)
		{
			Color color = colorManager.GetById(id);
			return View(color);
		}

		[HttpPost]
		public IActionResult Color_Update(Color color)
		{
			colorManager.Update(color);
			return RedirectToAction("Color_Index");
		}

		public IActionResult Color_Activate(int id)
		{
			Color color = colorManager.GetById(id);
			color.IsDelete = false;
			colorManager.Update(color);
			return RedirectToAction("Color_Index");
		}

		public IActionResult Color_Deactivate(int id)
		{
			Color color = colorManager.GetById(id);
			color.IsDelete = true;
			colorManager.Update(color);
			return RedirectToAction("Color_Index");
		}

		public IActionResult Color_Delete(int id)
		{
			Color color = colorManager.GetById(id);
			colorManager.Remove(color);
			return RedirectToAction("Color_Index");
		}
	}
}
