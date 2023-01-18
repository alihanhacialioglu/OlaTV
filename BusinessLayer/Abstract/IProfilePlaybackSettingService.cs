using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProfilePlaybackSettingService
    {
        void Add(ProfilePlaybackSetting profilePlaybackSetting);
        void Remove(ProfilePlaybackSetting profilePlaybackSetting);
        void Update(ProfilePlaybackSetting profilePlaybackSetting);
        List<ProfilePlaybackSetting> GetAll();
        ProfilePlaybackSetting GetById(int id);
    }
}
