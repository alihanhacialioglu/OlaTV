using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IMaturityRatingService
    {
        void Add(MaturityRating maturityRating);
        void Remove(MaturityRating maturityRating);
        void Update(MaturityRating maturityRating);
        List<MaturityRating> GetAll();
        MaturityRating GetById(int id);
        MaturityRating GetByName(string name);
        MaturityRating GetByExplanation(string explanation);
    }
}
