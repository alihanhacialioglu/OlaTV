using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPlaybackSettingService
    {
        void Add(PlaybackSetting playback);
        void Remove(PlaybackSetting playback);
        void Update(PlaybackSetting playback);

        List<PlaybackSetting> GetAll();
        PlaybackSetting GetById(int id);
        PlaybackSetting GetByName(string name);
        PlaybackSetting GetByExplanation(string explanation);


    }
}
