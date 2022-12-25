using BusinessLayer.Services;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class ProfileVideoRatingManager : IProfileVideoRatingService
    {
        IProfileVideoRatingDal _profileVideoRatingDal;
        public ProfileVideoRatingManager(IProfileVideoRatingDal profileVideoRatingDal)
        {
            _profileVideoRatingDal = profileVideoRatingDal;
        }
        public void Add(ProfileVideoRating profileVideoRating)
        {
            _profileVideoRatingDal.Add(profileVideoRating);
        }

        public List<ProfileVideoRating> GetAll()
        {
            return _profileVideoRatingDal.GetAll();
        }

        public ProfileVideoRating GetById(int id)
        {
            return _profileVideoRatingDal.Get(p => p.ProfileVideoRatingId == id);
        }

        public ProfileVideoRating GetByRate(string rate)
        {
            return _profileVideoRatingDal.Get(p => p.ProfileVideoRate == rate);
        }

        public void Remove(ProfileVideoRating profileVideoRating)
        {
            _profileVideoRatingDal.Delete(profileVideoRating);
        }

        public void Update(ProfileVideoRating profileVideoRating)
        {
            _profileVideoRatingDal.Update(profileVideoRating);
        }
    }
}
