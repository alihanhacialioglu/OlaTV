using BusinessLayer.Manager;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
	public class ContentController : Controller
	{
		ContentManager contentManager = new ContentManager(new EfContentDal());
		MaturityRatingManager maturityRatingManager = new MaturityRatingManager(new EfMaturityRatingDal());
		
		public IActionResult Content_Index()
		{
			var contents = contentManager.GetAll();
			return View(contents);
		}

		[HttpGet]
		public IActionResult Content_Add()
		{
			ContentModel contentModel = new ContentModel();
			contentModel.Content = new Content();
			contentModel.MaturityRatings = maturityRatingManager.GetAll();
			return View(contentModel);
		}

		[HttpPost]
		public IActionResult Content_Add(Content content)
		{
			ContentModel contentModel = new ContentModel();
			contentModel.Content = content;
			contentModel.MaturityRatings = maturityRatingManager.GetAll();

			ContentValidator validator = new ContentValidator();
			var result = validator.Validate(content);
			if (result.IsValid)
			{
				contentManager.Add(content);
				return RedirectToAction("Content_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(contentModel);
			}
		}

		public IActionResult Content_Update(int id)
		{
			Content content = contentManager.GetById(id);
			ContentModel contentModel = new ContentModel();
			contentModel.Content = content;
			contentModel.MaturityRatings = maturityRatingManager.GetAll();

			return View(contentModel);
		}

		[HttpPost]
		public IActionResult Content_Update(Content content)
		{
			contentManager.Update(content);
			return RedirectToAction("Content_Index");
		}

		public IActionResult Content_Delete(int id)
		{
			Content content = contentManager.GetById(id);
			contentManager.Remove(content);
			return RedirectToAction("Content_Index");
		}

		public IActionResult Content_Activate(int id)
		{
			Content content = contentManager.GetById(id);
			content.IsDelete = false;
			contentManager.Update(content);
			return RedirectToAction("Content_Index");
		}

		public IActionResult Content_Deactivate(int id)
		{
			Content content = contentManager.GetById(id);
			content.IsDelete = true;
			contentManager.Update(content);
			return RedirectToAction("Content_Index");
		}
	}
}
