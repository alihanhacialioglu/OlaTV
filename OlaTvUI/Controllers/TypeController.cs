using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Type = EntityLayer.Concrete.Type;

namespace OlaTvUI.Controllers
{
	public class TypeController : Controller
	{
		TypeManager typeManager = new TypeManager(new EfTypeDal());

		public IActionResult Type_Index()
		{
			var types = typeManager.GetAll();
			return View(types);
		}

		[HttpGet]
		public IActionResult Type_Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Type_Add(Type type)
		{
			typeManager.Add(type);
			return RedirectToAction("Type_Index");
		}

		public IActionResult Type_Update(int id)
		{
			Type type = typeManager.GetById(id);
			return View(type);
		}

		[HttpPost]
		public IActionResult Type_Update(Type type)
		{
			typeManager.Update(type);
			return RedirectToAction("Type_Index");
		}

		public IActionResult Type_Delete(int id)
		{
			Type type = typeManager.GetById(id);
			typeManager.Remove(type);
			return RedirectToAction("Type_Index");
		}

		public IActionResult Type_Activate(int id)
		{
			Type type = typeManager.GetById(id);
			type.IsDelete = false;
			typeManager.Update(type);
			return RedirectToAction("Type_Index");
		}

		public IActionResult Type_Deactivate(int id)
		{
			Type type = typeManager.GetById(id);
			type.IsDelete = true;
			typeManager.Update(type);
			return RedirectToAction("Type_Index");
		}
	}
}
