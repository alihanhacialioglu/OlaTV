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
    public class CommunicationSettingManager : ICommunicationSettingService
    {
        ICommunicationSettingDal _communicationSettingDal;

        public CommunicationSettingManager(ICommunicationSettingDal communicationSettingDal)
        {
            _communicationSettingDal = communicationSettingDal;
        }

        public void Add(CommunicationSetting communicationSetting)
        {
            _communicationSettingDal.Add(communicationSetting);
        }

        public List<CommunicationSetting> GetAll()
        {
            return _communicationSettingDal.GetAll();
        }

        public CommunicationSetting GetById(int id)
        {
            return _communicationSettingDal.Get(cs => cs.CommunicationSettingId ==id);
        }

        public CommunicationSetting GetByName(string name)
        {
           return _communicationSettingDal.Get(cs => cs.CommunicationSettingName == name);
        }

        public void Remove(CommunicationSetting communicationSetting)
        {
            _communicationSettingDal.Delete(communicationSetting);
        }

        public void Update(CommunicationSetting communicationSetting)
        {
            _communicationSettingDal.Update(communicationSetting);
        }
    }

}
