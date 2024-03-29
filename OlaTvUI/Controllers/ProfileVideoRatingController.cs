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
    public class ProfileVideoRatingController : Controller
	{
		ProfileVideoRatingManager profileVideoRatingManager = new ProfileVideoRatingManager(new EfProfileVideoRatingDal());
		ProfileManager profileManager = new ProfileManager(new EfProfileDal());
		VideoManager videoManager = new VideoManager(new EfVideoDal());

        public IActionResult ProfileVideoRating_Index(int page = 1)
		{
			int pageSize = 5;
            var itemCounts = profileVideoRatingManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var profileVideoRatings = profileVideoRatingManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "ProfileVideoRating_Index";
            ViewBag.contrName = "ProfileVideoRating";
            return View(profileVideoRatings);
        }

        [HttpGet]
		public IActionResult ProfileVideoRating_Add()
		{
			ProfileVideoRatingModel profileVideoRatingModel = new ProfileVideoRatingModel
			{
				ProfileVideoRating = new ProfileVideoRating(),
				Videos = videoManager.GetAll(),
				Profiles = profileManager.GetAll()
			};

			return View(profileVideoRatingModel);
		}
		[HttpPost]
		public IActionResult ProfileVideoRating_Add(ProfileVideoRating profileVideoRating)
		{
			ProfileVideoRatingModel profileVideoRatingModel = new ProfileVideoRatingModel
			{
				ProfileVideoRating = profileVideoRating,
				Videos = videoManager.GetAll(),
				Profiles = profileManager.GetAll()
			};

			ProfileVideoRatingValidator validator = new ProfileVideoRatingValidator();
			var result = validator.Validate(profileVideoRating);
			if (result.IsValid)
			{
				profileVideoRatingManager.Add(profileVideoRating);
				return RedirectToAction("ProfileVideoRating_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(profileVideoRatingModel);
			}
		}

		public IActionResult ProfileVideoRating_Update(int id)
		{
			ProfileVideoRating profileVideoRating = profileVideoRatingManager.GetById(id);
			ProfileVideoRatingModel profileVideoRatingModel = new ProfileVideoRatingModel
			{
				ProfileVideoRating = profileVideoRating,
				Videos = videoManager.GetAll(),
				Profiles = profileManager.GetAll()
			};
			return View(profileVideoRatingModel);
		}

		[HttpPost]
		public IActionResult ProfileVideoRating_Update(ProfileVideoRating profileVideoRating)
		{
			ProfileVideoRatingModel profileVideoRatingModel = new ProfileVideoRatingModel
			{
				ProfileVideoRating = profileVideoRating,
				Videos = videoManager.GetAll(),
				Profiles = profileManager.GetAll()
			};

			ProfileVideoRatingValidator validator = new ProfileVideoRatingValidator();
			var result = validator.Validate(profileVideoRating);
			if (result.IsValid)
			{
				profileVideoRatingManager.Update(profileVideoRating);
				return RedirectToAction("ProfileVideoRating_Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View(profileVideoRatingModel);
			}
		}

		public IActionResult ProfileVideoRating_Activate(int id)
		{
			ProfileVideoRating profileVideoRating = profileVideoRatingManager.GetById(id);
			profileVideoRating.IsDelete = false;
			profileVideoRatingManager.Update(profileVideoRating);
			return RedirectToAction("ProfileVideoRating_Index");
		}

		public IActionResult ProfileVideoRating_Deactivate(int id)
		{
			ProfileVideoRating profileVideoRating = profileVideoRatingManager.GetById(id);
			profileVideoRating.IsDelete = true;
			profileVideoRatingManager.Update(profileVideoRating);
			return RedirectToAction("ProfileVideoRating_Index");
		}

		public IActionResult ProfileVideoRating_Delete(int id)
		{
			ProfileVideoRating profileVideoRating = profileVideoRatingManager.GetById(id);
			profileVideoRatingManager.Remove(profileVideoRating);
			return RedirectToAction("ProfileVideoRating_Index");
		}
	}
}
