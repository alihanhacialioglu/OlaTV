﻿using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class ContentCastTitleController : Controller
	{
		ContentCastTitleManager contentCastTitleManager = new ContentCastTitleManager(new EfContentCastTitleDal());
		ContentManager contentManager = new ContentManager(new EfContentDal());
		CastTitleManager castTitleManager = new CastTitleManager(new EfCastTitleDal());

        public IActionResult ContentCastTitle_Index(int page = 1)
		{
			int pageSize = 5;
            var itemCounts = contentCastTitleManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var contentCastTitles = contentCastTitleManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "ContentCastTitle_Index";
            ViewBag.contrName = "ContentCastTitle";
            return View(contentCastTitles);
        }

        [HttpGet]
		public IActionResult ContentCastTitle_Add()
		{
			ContentCastTitleModel contentCastTitleModel = new ContentCastTitleModel();
			contentCastTitleModel.ContentCastTitle = new ContentCastTitle();
			contentCastTitleModel.Contents = contentManager.GetAll();
			contentCastTitleModel.CastTitles = castTitleManager.GetAll();
			return View(contentCastTitleModel);
		}
		[HttpPost]
		public IActionResult ContentCastTitle_Add(ContentCastTitle contentCastTitle)
		{
			ContentCastTitleModel contentCastTitleModel = new ContentCastTitleModel();
			contentCastTitleModel.ContentCastTitle = contentCastTitle;
			contentCastTitleModel.Contents = contentManager.GetAll();
			contentCastTitleModel.CastTitles = castTitleManager.GetAll();
			ContentCastTitleValidator validator = new ContentCastTitleValidator();
			var result = validator.Validate(contentCastTitle);
			if (result.IsValid)
			{
				contentCastTitleManager.Add(contentCastTitle);
				return RedirectToAction("ContentCastTitle_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(contentCastTitleModel);
			}
		}
        [HttpGet]
        public IActionResult ContentCastTitle_Update(int id)
		{
			ContentCastTitle contentCastTitle = contentCastTitleManager.GetById(id);
			ContentCastTitleModel contentCastTitleModel = new ContentCastTitleModel();
			contentCastTitleModel.ContentCastTitle = contentCastTitle;
			contentCastTitleModel.Contents = contentManager.GetAll();
			contentCastTitleModel.CastTitles = castTitleManager.GetAll();
			return View(contentCastTitleModel);
		}

		[HttpPost]
		public IActionResult ContentCastTitle_Update(ContentCastTitle contentCastTitle)
		{
			contentCastTitleManager.Update(contentCastTitle);
			return RedirectToAction("ContentCastTitle_Index");
		}

		public IActionResult ContentCastTitle_Activate(int id)
		{
			ContentCastTitle contentCastTitle = contentCastTitleManager.GetById(id);
			contentCastTitle.IsDelete = false;
			contentCastTitleManager.Update(contentCastTitle);
			return RedirectToAction("ContentCastTitle_Index");
		}

		public IActionResult ContentCastTitle_Deactivate(int id)
		{
			ContentCastTitle contentCastTitle = contentCastTitleManager.GetById(id);
			contentCastTitle.IsDelete = true;
			contentCastTitleManager.Update(contentCastTitle);
			return RedirectToAction("ContentCastTitle_Index");
		}

		public IActionResult ContentCastTitle_Delete(int id)
		{
			ContentCastTitle contentCastTitle = contentCastTitleManager.GetById(id);
			contentCastTitleManager.Remove(contentCastTitle);
			return RedirectToAction("ContentCastTitle_Index");
		}
	}
}
