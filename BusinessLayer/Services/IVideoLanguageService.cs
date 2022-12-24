using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IVideoLanguageService
    {
        void Add(VideoLanguage videoLanguage);
        void Remove(VideoLanguage videoLanguage);
        void Update(VideoLanguage videoLanguage);
        List<VideoLanguage> GetAll();
        VideoLanguage GetById(int id);
    }
}
