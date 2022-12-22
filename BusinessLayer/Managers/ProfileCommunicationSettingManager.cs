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
    public class ProfileCommunicationSettingManager : IProfileCommunicationSettingService
    {
        IProfileCommunicationSettingDal _profileCommunicationSettingDal;
        public ProfileCommunicationSettingManager(IProfileCommunicationSettingDal profileCommunicationSettingDal)
        {
            _profileCommunicationSettingDal = profileCommunicationSettingDal;
        }

        public void Add(ProfileCommunicationSetting profileCommunicationSetting)
        {
            _profileCommunicationSettingDal.Add(profileCommunicationSetting);
        }

        public List<ProfileCommunicationSetting> GetAll()
        {
            return _profileCommunicationSettingDal.GetAll(); 
        }

        public ProfileCommunicationSetting GetById(int id)
        {
            return _profileCommunicationSettingDal.Get(p => p.ProfileCommunicationSettingId== id);
        }

        public ProfileCommunicationSetting GetBySelection(bool isSelection)
        {
            return _profileCommunicationSettingDal.Get(p => p.ProfileCommunicationSettingSelection == isSelection);
        }

        public void Remove(ProfileCommunicationSetting profileCommunicationSetting)
        {
            _profileCommunicationSettingDal.Delete(profileCommunicationSetting);
        }

        public void Update(ProfileCommunicationSetting profileCommunicationSetting)
        {
            _profileCommunicationSettingDal.Update(profileCommunicationSetting);
        }
    }
}
