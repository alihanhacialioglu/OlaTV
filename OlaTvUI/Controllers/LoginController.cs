using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;
using System.Text;
using XSystem.Security.Cryptography;

namespace OlaTvUI.Controllers
{
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        private readonly ILogger<LoginController> _logger;
        private readonly IToastNotification _toastNotification;
        public LoginController(ILogger<LoginController> logger, IToastNotification toastNotification)
        {
            _logger = logger;
            _toastNotification = toastNotification;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login_Index()
        {
            return View();
        }

		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Enter(User user)
        {
            OlaTvDBContext context = new OlaTvDBContext();
            var result = context.Users.Where(x => x.EmailAddress == user.EmailAddress && x.Password == user.Password).SingleOrDefault();
            if (result != null)
            {

                var claims = new List<Claim> { new Claim(ClaimTypes.Email, result.EmailAddress), new Claim(ClaimTypes.Name, result.UserName) };

                var userIdentify = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentify);
                //await HttpContext.SignInAsync(principal);
                await HttpContext
                    .SignInAsync(
                    principal,
                    new AuthenticationProperties { ExpiresUtc = DateTime.UtcNow.AddMinutes(60) });
                return RedirectToAction("Home", "HomePage");

            }
            _toastNotification.AddErrorToastMessage("Your mail address or  password are incorrect");
            TempData["init"] = 1;
            return RedirectToAction("Login_Index");

        }
		public async Task<IActionResult> Exit()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Login_Index");

		}

		public string sifreleme(string value)
		{
			MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
			byte[] dizi = Encoding.UTF8.GetBytes(value);
			dizi = provider.ComputeHash(dizi);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte bayt in dizi)
			{
				stringBuilder.Append(bayt.ToString().ToLower());
			}
			return stringBuilder.ToString();
		}
	}
}
