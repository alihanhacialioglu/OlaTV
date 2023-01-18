using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProfileManager : IProfileService
    {
        IProfileDal _profileDal;
        public ProfileManager(IProfileDal profileDal) 
        {
            _profileDal = profileDal;
        }
        public void Add(Profile profile)
        {
            _profileDal.Add(profile);
        }

        public List<Profile> GetAll()
        {
            return _profileDal.GetAll();
        }

        public Profile GetByAnimation(bool isAnimation)
        {
            return _profileDal.Get(p => p.IsAnimationTv == isAnimation);
        }

        public Profile GetById(int id)
        {
            return _profileDal.Get(p => p.ProfileId == id);
        }

        public Profile GetByMarketing(bool isMarketing)
        {
            return _profileDal.Get(p => p.IsMarketingApproval == isMarketing);
        }

        public Profile GetByName(string name)
        {
            return _profileDal.Get(p => p.ProfileName == name);
        }

        public Profile GetByPin(int pin)
        {
            return _profileDal.Get(p=>p.ProfilePin==pin);
        }

        public void Remove(Profile profile)
        {
            _profileDal.Delete(profile);
        }

        public void Update(Profile profile)
        {
            _profileDal.Update(profile);
        }
    }
}
