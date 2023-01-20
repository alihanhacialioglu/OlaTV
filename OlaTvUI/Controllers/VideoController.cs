using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OlaTvUI.Models;
using OlaTvUI.PagedList;

namespace OlaTvUI.Controllers
{
    public class VideoController : Controller
    {
        VideoManager videoManager = new VideoManager(new EfVideoDal());
        LanguageManager languageManager = new LanguageManager(new EfLanguageDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public IActionResult Video_Index(int page = 1)
        {
            int pageSize = 5;
            var itemCounts = videoManager.GetAll().Count;
            Pager pager = new Pager(page, pageSize, itemCounts);
            var videos = videoManager.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.pager = pager;
            ViewBag.actionName = "Video_Index";
            ViewBag.contrName = "Video";
            return View(videos);
        }

        [HttpGet]
        public IActionResult Video_Add()
        {
            VideoModel videoModel = new VideoModel();
            videoModel.Video = new Video();
            videoModel.Languages = languageManager.GetAll();
            videoModel.Contents = contentManager.GetAll();
            videoModel.Categories = categoryManager.GetAll();
            return View(videoModel);
        }
        [HttpPost]
        public IActionResult Video_Add(Video video)
        {
            VideoModel videoModel = new VideoModel();
            videoModel.Video = video;
            videoModel.Languages = languageManager.GetAll();
            videoModel.Contents = contentManager.GetAll();
            videoModel.Categories = categoryManager.GetAll();
            VideoValidator validator = new VideoValidator();
            var result = validator.Validate(video);
            if (result.IsValid)
            {
                videoManager.Add(video);
                return RedirectToAction("Video_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(videoModel);
            }
        }
        [HttpGet]
        public IActionResult Video_Update(int id)
        {
            Video video = videoManager.GetById(id);
            VideoModel videoModel = new VideoModel();
            videoModel.Video = video;
            videoModel.Languages = languageManager.GetAll();
            videoModel.Contents = contentManager.GetAll();
            videoModel.Categories = categoryManager.GetAll();
            return View(videoModel);
        }

        [HttpPost]
        public IActionResult Video_Update(Video video)
        {
            VideoModel videoModel = new VideoModel();
            videoModel.Video = video;
            videoModel.Languages = languageManager.GetAll();
            videoModel.Contents = contentManager.GetAll();
            videoModel.Categories = categoryManager.GetAll();

            VideoValidator validator = new VideoValidator();
            var result = validator.Validate(video);

            if (result.IsValid)
            {
                videoManager.Update(video);
                return RedirectToAction("Video_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(videoModel);
            }
        }

        public IActionResult Video_Activate(int id)
        {
            Video video = videoManager.GetById(id);
            video.IsDelete = false;
            videoManager.Update(video);
            return RedirectToAction("Video_Index");
        }

        public IActionResult Video_Deactivate(int id)
        {
            Video video = videoManager.GetById(id);
            video.IsDelete = true;
            videoManager.Update(video);
            return RedirectToAction("Video_Index");
        }

        public IActionResult Video_Delete(int id)
        {
            Video video = videoManager.GetById(id);
            videoManager.Remove(video);
            return RedirectToAction("Video_Index");
        }
    }
}
