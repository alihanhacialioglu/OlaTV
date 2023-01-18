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
    public class ProfileContentManager : IProfileContentService
    {
        IProfileContentDal _profileContentDal;
        public ProfileContentManager(IProfileContentDal profileContentDal) 
        { 
          _profileContentDal= profileContentDal;
        }
        public void Add(ProfileContent profileContent)
        {
            _profileContentDal.Add(profileContent);
        }

        public List<ProfileContent> GetAll()
        {
            return _profileContentDal.GetAll();
        }

        public ProfileContent GetById(int id)
        {
            return _profileContentDal.Get(p=>p.ProfileContentId==id);
        }

        public void Remove(ProfileContent profileContent)
        {
            _profileContentDal.Delete(profileContent);
        }

        public void Update(ProfileContent profileContent)
        {
            _profileContentDal.Update(profileContent);
        }
    }
}
