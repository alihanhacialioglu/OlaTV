using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProfileCommunicationSettingService
    {
        void Add(ProfileCommunicationSetting profileCommunicationSetting);
        void Remove(ProfileCommunicationSetting profileCommunicationSetting);
        void Update(ProfileCommunicationSetting profileCommunicationSetting);
        List<ProfileCommunicationSetting> GetAll();
        ProfileCommunicationSetting GetById(int id);
        ProfileCommunicationSetting GetBySelection(bool isSelection);
    }
}
