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
    public class PlaybackSettingManager : IPlaybackSettingService
    {
        IPlaybackSettingDal _playbackSettingDal;
        public PlaybackSettingManager(IPlaybackSettingDal playbacSettingDal) 
        {
            _playbackSettingDal= playbacSettingDal;
        }
        public void Add(PlaybackSetting playback)
        {
            _playbackSettingDal.Add(playback);
        }

        public List<PlaybackSetting> GetAll()
        {
            return _playbackSettingDal.GetAll();
        }

        public PlaybackSetting GetByExplanation(string explanation)
        {
            return _playbackSettingDal.Get(p=>p.PlaybackSettingExplanation==explanation);
        }

        public PlaybackSetting GetById(int id)
        {
            return _playbackSettingDal.Get(p => p.PlaybackSettingId == id);
        }

        public PlaybackSetting GetByName(string name)
        {
            return _playbackSettingDal.Get(p => p.PlaybackSettingName == name);
        }

        public void Remove(PlaybackSetting playback)
        {
            _playbackSettingDal.Delete(playback);
        }

        public void Update(PlaybackSetting playback)
        {
            _playbackSettingDal.Update(playback);
        }
    }
}
