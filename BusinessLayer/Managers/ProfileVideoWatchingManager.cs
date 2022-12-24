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
    public class ProfileVideoWatchingManager : IProfileVideoWatchingService
    {
        IProfileVideoWatchingDal _profileVideoWatchingDal;
        public ProfileVideoWatchingManager(IProfileVideoWatchingDal profileVideoWatchingDal)
        { 
          _profileVideoWatchingDal= profileVideoWatchingDal;
        }
        public void Add(ProfileVideoWatching profileVideoWatching)
        {
            _profileVideoWatchingDal.Add(profileVideoWatching);
        }

        public List<ProfileVideoWatching> GetAll()
        {
            return _profileVideoWatchingDal.GetAll();
        }

        public ProfileVideoWatching GetByDateTime(DateTime dateTime)
        {
            return _profileVideoWatchingDal.Get(p => p.VideoDateOfWached == dateTime);
        }

        public ProfileVideoWatching GetById(int id)
        {
            return _profileVideoWatchingDal.Get(p=>p.ProfileVideoWatchingId==id);
        }

        public void Remove(ProfileVideoWatching profileVideoWatching)
        {
            _profileVideoWatchingDal.Delete(profileVideoWatching);
        }

        public void Update(ProfileVideoWatching profileVideoWatching)
        {
            _profileVideoWatchingDal.Update(profileVideoWatching);
        }
    }
}
