using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using NToastNotify;
using XSystem.Security.Cryptography;
using System.Text;

namespace OlaTvUI.Controllers
{

    public class AdminController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        private readonly ILogger<AdminController> _logger;
        private readonly IToastNotification _toastNotification;
        public AdminController(ILogger<AdminController> logger, IToastNotification toastNotification)
        {

            _logger = logger;
            _toastNotification = toastNotification;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Admin_Login()
        {
            return View();

        }

        public IActionResult profile()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Enter(Admin admin)
        {

            OlaTvDBContext context = new OlaTvDBContext();
            var result = context.Admins.Where(x => x.EmailAddress == admin.EmailAddress && x.AdminPassword == admin.AdminPassword).SingleOrDefault();
            if (result != null)
            {

                var claims = new List<Claim> { new Claim(ClaimTypes.Email, result.EmailAddress), new Claim(ClaimTypes.Name, result.AdminName) };

                var userIdentify = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentify);
                //await HttpContext.SignInAsync(principal);
                await HttpContext
                    .SignInAsync(
                    principal,
                    new AuthenticationProperties { ExpiresUtc = DateTime.UtcNow.AddMinutes(60) });
                return RedirectToAction("Admin_Index", "Admin");

            }
            _toastNotification.AddErrorToastMessage("Your mail address or  password are incorrect");
            TempData["init"] = 1;
            return RedirectToAction("Admin_Login");



        }
        public async Task<IActionResult> Exit()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("login");

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

        [HttpGet]
        public IActionResult Admin_Index(int page = 1)
        {

            var admin = adminManager.GetAll();
            return View(admin);
        }

        [HttpGet]
        public IActionResult Admin_Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Admin_Add(Admin admin)
        {
            AdminValidator adminValidator = new AdminValidator();
            var result = adminValidator.Validate(admin);
            if (result.IsValid)
            {
                adminManager.Add(admin);
                return RedirectToAction("Admin_Index");

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
        


        public IActionResult Admin_Update(int id)
        {
            Admin admin = adminManager.GetById(id);

            return View(admin);
        }
        [HttpPost]
        public IActionResult Admin_Update(Admin admin)
        {
            AdminValidator adminValidator = new AdminValidator();
            var result = adminValidator.Validate(admin);
            if (result.IsValid)
            {
                adminManager.Update(admin);
                return RedirectToAction("Admin_Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(admin);
            }

        }
        public IActionResult Admin_Delete(int id)
        {
            Admin admin = adminManager.GetById(id);
            adminManager.Remove(admin);
            return RedirectToAction("Admin_Index");
        }
        public IActionResult Admin_Activate(int id)
        {
            Admin admin = adminManager.GetById(id);
            admin.IsDelete = false;
            adminManager.Update(admin);
            return RedirectToAction("Admin_Index");
        }

        public IActionResult Admin_Deactivate(int id)
        {
            Admin admin = adminManager.GetById(id);
            admin.IsDelete = true;
            adminManager.Update(admin);
            return RedirectToAction("Admin_Index");
        }
    }
}

