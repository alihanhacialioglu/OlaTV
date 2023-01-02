using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class BackgroundController : Controller
    {
        public IActionResult Background_Index()
        {
            return View();
        }
    }
}
