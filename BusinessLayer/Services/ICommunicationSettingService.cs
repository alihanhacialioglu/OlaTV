using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ICommunicationSettingService
    {
        void Add(CommunicationSetting communicationSetting);
        void Update(CommunicationSetting communicationSetting);
        void Remove(CommunicationSetting communicationSetting);
        List<CommunicationSetting> GetAll();
        CommunicationSetting GetById(int id);
        CommunicationSetting GetByName(string name);

    }
}
