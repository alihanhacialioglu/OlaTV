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
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        PacketManager packetManager = new PacketManager(new EfPacketDal());
        public IActionResult User_Index(int page = 1)
        {
            int pageSize = 5;
            var itemCounts = userManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var users = userManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "User_Index";
            ViewBag.contrName = "User";
            return View(users);
        }

        [HttpGet]
        public IActionResult User_Add()
        {
            UserModel userModel = new UserModel();
            userModel.User = new User();
            userModel.Packets = packetManager.GetAll();
            return View(userModel);
        }

        [HttpPost]
        public IActionResult User_Add(User user)
        {
            UserValidator userValidator = new UserValidator();
            UserModel userModel = new UserModel();
            userModel.User = user;
            userModel.Packets = packetManager.GetAll();
            var result = userValidator.Validate(user);

            if (result.IsValid)
            {
                userManager.Add(user);
                return RedirectToAction("User_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(userModel);
            }
        }


        [HttpGet]
        public IActionResult User_Update(int id)
        {
            User user = userManager.GetById(id);
            UserModel userModel = new UserModel();
            userModel.User = user;
            userModel.Packets = packetManager.GetAll();
            return View(userModel);
        }

        [HttpPost]
        public IActionResult User_Update(User user)
        {
            UserValidator userValidator = new UserValidator();
            UserModel userModel = new UserModel();
            userModel.User = user;
            userModel.Packets = packetManager.GetAll();
            var result = userValidator.Validate(user);

            if (result.IsValid)
            {
                userManager.Update(user);
                return RedirectToAction("User_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(userModel);
            }
        }

        public IActionResult User_Delete(int id)
        {
            User user = userManager.GetById(id);
            userManager.Remove(user);
            return RedirectToAction("User_Index");
        }

        public IActionResult User_Activate(int id)
        {
            User user = userManager.GetById(id);
            user.IsDelete = false;
            userManager.Update(user);
            return RedirectToAction("User_Index");
        }

        public IActionResult User_Deactivate(int id)
        {
            User user = userManager.GetById(id);
            user.IsDelete = true;
            userManager.Update(user);
            return RedirectToAction("User_Index");
        }

    }
}
