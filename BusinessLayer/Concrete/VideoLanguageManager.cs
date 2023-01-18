using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class VideoLanguageManager : IVideoLanguageService
    {
        IVideoLanguageDal _videoLanguageDal;
        public VideoLanguageManager(IVideoLanguageDal videoLanguageDal) 
        { 
          _videoLanguageDal= videoLanguageDal;
        }
        public void Add(VideoLanguage videoLanguage)
        {
            _videoLanguageDal.Add(videoLanguage);
        }

        public List<VideoLanguage> GetAll()
        {
            return _videoLanguageDal.GetAll();
        }

        public VideoLanguage GetById(int id)
        {
            return _videoLanguageDal.Get(v=>v.VideoLanguageId==id);
        }

        public void Remove(VideoLanguage videoLanguage)
        {
            _videoLanguageDal.Delete(videoLanguage);
        }

        public void Update(VideoLanguage videoLanguage)
        {
            _videoLanguageDal.Update(videoLanguage);
        }
    }
}
