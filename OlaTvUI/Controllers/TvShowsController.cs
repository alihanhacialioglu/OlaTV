using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Web.Helpers;

namespace OlaTvUI.Controllers
{
    public class TvShowsController : Controller
    {
        VideoManager vm = new VideoManager(new EfVideoDal());
        public IActionResult Index()
        {
            var list = vm.GetAll();
            //var result = JsonConvert.SerializeObject(list);
            return View(list);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
