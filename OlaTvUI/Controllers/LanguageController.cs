using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class LanguageController : Controller
    {
        LanguageManager languageManager = new LanguageManager(new EfLanguageDal());
        public IActionResult Language_Index()
        {
            var languages = languageManager.GetAll();
            return View(languages);
        }

        [HttpGet]
        public IActionResult Language_Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Language_Add(Language language )
        {
            languageManager.Add(language);
            return RedirectToAction("Language_Index");
        }

        public IActionResult Language_Update(int id) 
        {
            Language language=languageManager.GetById(id);
            return View(language);
        }


        [HttpPost]
        public IActionResult Language_Update(Language language)
        {
            languageManager.Update(language);
            return RedirectToAction("Language_Index");
        }
        public IActionResult Language_Delete(int id)
        {
            Language language = languageManager.GetById(id);
            languageManager.Remove(language);
            return RedirectToAction("Cast_Index");
        }
        public IActionResult Language_Activate(int id)
        {
            Language language = languageManager.GetById(id);
            language.IsDelete = false;
            languageManager.Update(language);
            return RedirectToAction("Language_Index");
        }

        public IActionResult Cast_Deactivate(int id)
        {
            Language language = languageManager.GetById(id);
            language.IsDelete = true;
            languageManager.Update(language);
            return RedirectToAction("Language_Index");
        }


    }
}
