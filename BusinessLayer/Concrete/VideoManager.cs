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
    public class VideoManager : IVideoService
    {
        IVideoDal _videoDal;
        public VideoManager(IVideoDal videoDal)
        {
            _videoDal = videoDal;
        }

        public void Add(Video video)
        {
            _videoDal.Add(video);
        }

        public List<Video> GetAll()
        {
            return _videoDal.GetAll();
        }

        public Video GetByDateTime(DateTime dateTime)
        {
            return _videoDal.Get(v=>v.ReleaseDate==dateTime);
        }

        public Video GetByEpisode(byte episode)
        {
            return _videoDal.Get(v => v.EpisodeNo==episode);
        }

        public Video GetById(int id)
        {
            return _videoDal.Get(v => v.VideoId==id);
        }

        public Video GetBySeason(byte season)
        {
            return _videoDal.Get(v => v.SeasonNo==season);
        }

        public Video GetByUrl(string url)
        {
            return _videoDal.Get(v => v.VideoUrl==url);
        }

        public void Remove(Video video)
        {
            _videoDal.Delete(video);
        }

        public void Update(Video video)
        {
            _videoDal.Update(video);
        }
    }
}
