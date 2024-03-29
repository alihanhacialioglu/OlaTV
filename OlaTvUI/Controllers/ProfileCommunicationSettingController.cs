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
    public class ProfileCommunicationSettingController : Controller
    {
        ProfileCommunicationSettingManager profileCommunicationSettingManager = new ProfileCommunicationSettingManager(new EfProfileCommunicationSettingDal());
        ProfileManager profileManager = new ProfileManager(new EfProfileDal());
        CommunicationSettingManager communicationSettingManager = new CommunicationSettingManager(new EfCommunicationSettingDal());
        public IActionResult ProfileCommunicationSetting_Index(int page = 1)
        {
            int pageSize = 5;
            var itemCounts = profileCommunicationSettingManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var profileCommunicationSettings = profileCommunicationSettingManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "ProfileCommunicationSetting_Index";
            ViewBag.contrName = "ProfileCommunicationSetting";
            return View(profileCommunicationSettings);
        }

        [HttpGet]
        public IActionResult ProfileCommunicationSetting_Add()
        {
            ProfileCommunicationSettingModel profileCommunicationSettingModel = new ProfileCommunicationSettingModel();
            ProfileCommunicationSetting profileCommunicationSetting= new ProfileCommunicationSetting();
            profileCommunicationSettingModel.Profiles=profileManager.GetAll();
            profileCommunicationSettingModel.CommunicationSettings=communicationSettingManager.GetAll();  
            return View(profileCommunicationSettingModel); 
        }

        [HttpPost]
        public IActionResult ProfileCommunicationSetting_Add(ProfileCommunicationSetting profileCommunicationSetting)
        {
            ProfileCommunicationSettingModel profileCommunicationSettingModel = new ProfileCommunicationSettingModel();
            profileCommunicationSettingModel.ProfileCommunicationSetting= profileCommunicationSetting;
            profileCommunicationSettingModel.Profiles = profileManager.GetAll();
            profileCommunicationSettingModel.CommunicationSettings = communicationSettingManager.GetAll();

            ProfileCommunicationSettingValidator validator = new ProfileCommunicationSettingValidator();
            var result = validator.Validate(profileCommunicationSetting);
            if (result.IsValid)
            {
                profileCommunicationSettingManager.Add(profileCommunicationSetting);
                return RedirectToAction("ProfileCommunicationSetting_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(profileCommunicationSettingModel);
            }

        }
        [HttpGet]

        public IActionResult ProfileCommunicationSetting_Update(int id)
        {
            ProfileCommunicationSettingModel profileCommunicationSettingModel = new ProfileCommunicationSettingModel();
            ProfileCommunicationSetting profileCommunicationSetting = profileCommunicationSettingManager.GetById(id);
            profileCommunicationSettingModel.ProfileCommunicationSetting= profileCommunicationSetting;
            profileCommunicationSettingModel.Profiles = profileManager.GetAll();
            profileCommunicationSettingModel.CommunicationSettings = communicationSettingManager.GetAll();
            return View(profileCommunicationSettingModel);
        }

        [HttpPost]
        public IActionResult ProfileCommunicationSetting_Update(ProfileCommunicationSetting profileCommunicationSetting)
        {
            ProfileCommunicationSettingModel profileCommunicationSettingModel = new ProfileCommunicationSettingModel();
            profileCommunicationSettingModel.ProfileCommunicationSetting = profileCommunicationSetting;
            profileCommunicationSettingModel.Profiles = profileManager.GetAll();
            profileCommunicationSettingModel.CommunicationSettings = communicationSettingManager.GetAll();

            ProfileCommunicationSettingValidator validator = new ProfileCommunicationSettingValidator();
            var result = validator.Validate(profileCommunicationSetting);
            if (result.IsValid)
            {
                profileCommunicationSettingManager.Update(profileCommunicationSetting);
                return RedirectToAction("ProfileCommunicationSetting_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(profileCommunicationSettingModel);
            }


        }

        public IActionResult ProfileCommunicationSetting_Activate(int id)
        {
            ProfileCommunicationSetting profileCommunicationSetting = profileCommunicationSettingManager.GetById(id);
            profileCommunicationSetting.IsDelete = false;
            profileCommunicationSettingManager.Update(profileCommunicationSetting);
            return RedirectToAction("ProfileCommunicationSetting_Index");
        }

        public IActionResult ProfileCommunicationSetting_Deactivate(int id)
        {
            ProfileCommunicationSetting profileCommunicationSetting = profileCommunicationSettingManager.GetById(id);
            profileCommunicationSetting.IsDelete = true;
            profileCommunicationSettingManager.Update(profileCommunicationSetting);
            return RedirectToAction("ProfileCommunicationSetting_Index");
        }

        public IActionResult ProfileCommunicationSetting_Delete(int id)
        {
            ProfileCommunicationSetting profileCommunicationSetting = profileCommunicationSettingManager.GetById(id);
            profileCommunicationSettingManager.Remove(profileCommunicationSetting);
            return RedirectToAction("ProfileCommunicationSetting_Index");
        }


    }
}
