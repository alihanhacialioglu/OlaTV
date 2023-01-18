using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProfileVideoWatchingService
    {
        void Add(ProfileVideoWatching profileVideoWatching);
        void Remove(ProfileVideoWatching profileVideoWatching);
        void Update(ProfileVideoWatching profileVideoWatching);
        List<ProfileVideoWatching> GetAll();
        ProfileVideoWatching GetById(int id);
        ProfileVideoWatching GetByDateTime(DateTime dateTime);

    }
}
