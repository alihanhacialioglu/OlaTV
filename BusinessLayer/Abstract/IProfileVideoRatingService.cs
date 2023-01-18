using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProfileVideoRatingService
    {
        void Add(ProfileVideoRating profileVideoRating);
        void Remove(ProfileVideoRating profileVideoRating);
        void Update(ProfileVideoRating profileVideoRating);
        List<ProfileVideoRating> GetAll();
        ProfileVideoRating GetById(int id);
        ProfileVideoRating GetByRate(string rate);

    }
}
