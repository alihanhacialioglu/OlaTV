using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class CastTitleController : Controller
	{
		CastTitleManager castTitleManager = new CastTitleManager(new EfCastTitleDal());
		CastManager castManager = new CastManager(new EfCastDal());
		TitleManager titleManager = new TitleManager(new EfTitleDal());
		public IActionResult CastTitle_Index(int page = 1,string searchText = "")
        {
            int pageSize = 5;
            OlaTvDBContext c = new OlaTvDBContext();
            Pager pager;
            List<CastTitle> data;
            var itemCounts = 0;
            if (searchText != "" && searchText != null)
            {
                data = c.CastTitles.Where(x => x.Cast.CastNameSurname.Contains(searchText) || 
				x.Title.TitleName.Contains(searchText)).Skip((page - 1) * pageSize).Take(pageSize).ToList();

                itemCounts = c.CastTitles.Where(x => x.Cast.CastNameSurname.Contains(searchText) ||
                x.Title.TitleName.Contains(searchText)).ToList().Count;
            }
            else
            {
                data = c.CastTitles.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                itemCounts = c.CastTitles.ToList().Count;
            }
            pager = new Pager(page, pageSize, itemCounts);

            ViewBag.pager = pager;
            ViewBag.actionName = "CastTitle_Index";
            ViewBag.contrName = "CastTitle";
            ViewBag.searchText = searchText;
            return View(data);
        }
		[HttpGet]
		public IActionResult CastTitle_Add()
		{
            CastTitleModel castTitleModel = new CastTitleModel();
			castTitleModel.CastTitle = new CastTitle();
			castTitleModel.Casts = castManager.GetAll();
			castTitleModel.Titles = titleManager.GetAll();
			return View(castTitleModel);
		}
		[HttpPost]
		public IActionResult CastTitle_Add(CastTitle castTitle)
		{
            CastTitleModel castTitleModel = new CastTitleModel();
			castTitleModel.CastTitle = castTitle;
			castTitleModel.Casts = castManager.GetAll();
			castTitleModel.Titles = titleManager.GetAll();
			CastTitleValidator validator = new CastTitleValidator();
			var result = validator.Validate(castTitle);
			if (result.IsValid)
			{
				castTitleManager.Add(castTitle);
				return RedirectToAction("CastTitle_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(castTitleModel);
			}
		}

        [HttpGet]
        public IActionResult CastTitle_Update(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
            CastTitleModel castTitleModel = new CastTitleModel();
			castTitleModel.CastTitle = castTitle;
			castTitleModel.Casts = castManager.GetAll();
			castTitleModel.Titles = titleManager.GetAll();
			return View(castTitleModel);
		}

		[HttpPost]
		public IActionResult CastTitle_Update(CastTitle castTitle)
		{
			castTitleManager.Update(castTitle);
			return RedirectToAction("CastTitle_Index");
		}

		public IActionResult CastTitle_Activate(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
			castTitle.IsDelete = false;
			castTitleManager.Update(castTitle);
			return RedirectToAction("CastTitle_Index");
		}

		public IActionResult CastTitle_Deactivate(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
			castTitle.IsDelete = true;
			castTitleManager.Update(castTitle);
			return RedirectToAction("CastTitle_Index");
		}

		public IActionResult CastTitle_Delete(int id)
		{
            CastTitle castTitle = castTitleManager.GetById(id);
			castTitleManager.Remove(castTitle);
			return RedirectToAction("CastTitle_Index");
		}
	}
}
