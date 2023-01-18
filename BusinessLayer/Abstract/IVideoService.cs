using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IVideoService
    {
        void Add(Video video);
        void Remove(Video video);
        void Update(Video video);
        List<Video> GetAll();
        Video GetById(int id);
        Video GetByUrl(string url);
        Video GetByDateTime(DateTime dateTime);
        Video GetBySeason(byte season);
        Video GetByEpisode(byte episode);
    }
}
