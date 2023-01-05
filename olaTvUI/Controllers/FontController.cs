using BusinessLayer.Manager;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class FontController : Controller
    {
        FontManager fontManager = new FontManager(new EfFontDal());
        public IActionResult Font_Index()
        {
            var fonts = fontManager.GetAll();
            return View(fonts);
        }

       
    }
}
