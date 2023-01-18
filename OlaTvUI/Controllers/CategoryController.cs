using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult Category_Index()
        {
            var categories = categoryManager.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Category_Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Category_Add(Category category)
        {
            CategoryValidator validator = new CategoryValidator();
            var result = validator.Validate(category);
            if (result.IsValid)
            {
                categoryManager.Add(category);
                return RedirectToAction("Category_Index");
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
        public IActionResult Category_Update(int id) 
        { 
            Category category= categoryManager.GetById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Category_Update(Category category)
        {
            CategoryValidator validator = new CategoryValidator();
            var result = validator.Validate(category);
            if (result.IsValid)
            {
                categoryManager.Update(category);
                return RedirectToAction("Category_Index");
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

        public ActionResult Category_Delete(int id)
        {
            Category category=categoryManager.GetById(id);
            categoryManager.Remove(category);
            return RedirectToAction("Category_Index");
        }

        public IActionResult Category_Activate(int id)
        {
            Category category = categoryManager.GetById(id);
            category.IsDelete = false;
            categoryManager.Update(category);
            return RedirectToAction("Category_Index");
        }

        public IActionResult Category_Deactivate(int id)
        {
            Category category = categoryManager.GetById(id);
            category.IsDelete = true;
            categoryManager.Update(category);
            return RedirectToAction("Category_Index");
        }

    }
}
