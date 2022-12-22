using BusinessLayer.Services;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class ProfilePlaybackSettingManager : IProfilePlaybackSettingService
    {
        IProfilePlaybackSettingDal _profilePlaybackSettingDal;

        public ProfilePlaybackSettingManager(IProfilePlaybackSettingDal profilePlaybackSettingDal)
        {
            _profilePlaybackSettingDal = profilePlaybackSettingDal;

        }
        public void Add(ProfilePlaybackSetting profilePlaybackSetting)
        {
            _profilePlaybackSettingDal.Add(profilePlaybackSetting);
        }

        public List<ProfilePlaybackSetting> GetAll()
        {
            return _profilePlaybackSettingDal.GetAll();
        }

        public ProfilePlaybackSetting GetById(int id)
        {
            return _profilePlaybackSettingDal.Get(p => p.ProfilePlaybackSettingId == id);
        }

        public void Remove(ProfilePlaybackSetting profilePlaybackSetting)
        {
            _profilePlaybackSettingDal.Delete(profilePlaybackSetting);
        }

        public void Update(ProfilePlaybackSetting profilePlaybackSetting)
        {
            _profilePlaybackSettingDal.Update(profilePlaybackSetting);
        }
    }
}
