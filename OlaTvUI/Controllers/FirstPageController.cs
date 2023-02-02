using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
	public class FirstPageController : Controller
	{
		[AllowAnonymous]
		[HttpGet]
		public IActionResult FirstPage_Index()
		{
			return View();
		}
	}
}
