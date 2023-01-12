using BusinessLayer.Manager;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OlaTvUI.Models;

namespace OlaTvUI.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        PacketManager packetManager = new PacketManager(new EfPacketDal());
        public IActionResult User_Index()
        {
            var users = userManager.GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult User_Add()
        {
            UserModel userPacketModel = new UserModel();
            userPacketModel.User = new User();
            userPacketModel.Packets = packetManager.GetAll();
            return View(userPacketModel);
        }

        [HttpPost]
        public IActionResult User_Add(User user)
        {
            UserValidator userValidator = new UserValidator();
            UserModel userPacketModel = new UserModel();
            userPacketModel.User = user;
            userPacketModel.Packets = packetManager.GetAll();
            var result=userValidator.Validate(user);

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
                return View(userPacketModel);
            }
        }
            

        [HttpGet]
        public IActionResult User_Update(int id)
        {
            User user = userManager.GetById(id);
            UserModel userPacketModel = new UserModel();
            userPacketModel.User = new User();
            userPacketModel.Packets = packetManager.GetAll();
            return View(user);
        }
        [HttpPost]
        public IActionResult User_Update(User user)
        {
            userManager.Update(user);
            return View(user);
        }

        public IActionResult User_Delete(int id)
        {
            User user=userManager.GetById(id);
            userManager.Remove(user);
            return View();
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
