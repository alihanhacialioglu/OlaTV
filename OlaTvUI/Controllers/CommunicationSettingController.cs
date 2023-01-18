using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class CommunicationSettingController : Controller
    {
        CommunicationSettingManager communicationSettingManager = new CommunicationSettingManager(new EfCommunicationSettingDal());
        public IActionResult CommunicationSetting_Index()
        {
            var settings = communicationSettingManager.GetAll();
            return View(settings);
        }

        [HttpGet]
        public IActionResult CommunicationSetting_Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CommunicationSetting_Add(CommunicationSetting communicationSetting)
        {
            CommunicationSettingValidator validator = new CommunicationSettingValidator();
            var result = validator.Validate(communicationSetting);
            if (result.IsValid)
            {
                communicationSettingManager.Add(communicationSetting);
                return RedirectToAction("CommunicationSetting_Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        [HttpGet]
        public IActionResult CommunicationSetting_Update(int id) 
        { 
            CommunicationSetting communicationSetting=communicationSettingManager.GetById(id);
            return View(communicationSetting);
        }

        [HttpPost]
        public IActionResult CommunicationSetting_Update(CommunicationSetting communicationSetting)
        {
            CommunicationSettingValidator validator = new CommunicationSettingValidator();
            var result = validator.Validate(communicationSetting);
            if (result.IsValid)
            {
                communicationSettingManager.Update(communicationSetting);
                return RedirectToAction("CommunicationSetting_Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public ActionResult CommunicationSetting_Delete(int id)
        {
            CommunicationSetting communicationSetting = communicationSettingManager.GetById(id);
            communicationSettingManager.Remove(communicationSetting);
            return RedirectToAction("CommunicationSetting_Index");
        }

        public IActionResult CommunicationSetting_Activate(int id)
        {
            CommunicationSetting communicationSetting = communicationSettingManager.GetById(id);
            communicationSetting.IsDelete = false;
            communicationSettingManager.Update(communicationSetting);
            return RedirectToAction("CommunicationSetting_Index");
        }

        public IActionResult CommunicationSetting_Deactivate(int id)
        {
            CommunicationSetting communicationSetting = communicationSettingManager.GetById(id);
            communicationSetting.IsDelete = true;
            communicationSettingManager.Update(communicationSetting);
            return RedirectToAction("CommunicationSetting_Index");
        }



    }
}
