using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
	
	public class ErrorController : Controller
	{
        [Route("/Error/HandleError/{code:int}")]
        [Route("error/404")]
        public IActionResult HandleError()
		{
			return View();
		}
	}
}
