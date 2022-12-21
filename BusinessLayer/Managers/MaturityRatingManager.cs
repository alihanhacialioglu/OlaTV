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
    public class MaturityRatingManager : IMaturityRatingService
    {
        IMaturityRatingDal _maturityRatingDal;
        public MaturityRatingManager(IMaturityRatingDal maturityRatingDal) 
        { 
            _maturityRatingDal= maturityRatingDal;
        }
        public void Add(MaturityRating maturityRating)
        {
            _maturityRatingDal.Add(maturityRating);
        }

        public List<MaturityRating> GetAll()
        {
            return _maturityRatingDal.GetAll();
        }

        public MaturityRating GetByExplanation(string explanation)
        {
            return _maturityRatingDal.Get(m => m.MaturityExplanation == explanation);
        }

        public MaturityRating GetById(int id)
        {
            return _maturityRatingDal.Get(m => m.MaturityRatingId == id);
        }

        public MaturityRating GetByName(string name)
        {
            return _maturityRatingDal.Get(m => m.StatusName == name);
        }

        public void Remove(MaturityRating maturityRating)
        {
            _maturityRatingDal.Delete(maturityRating);
        }

        public void Update(MaturityRating maturityRating)
        {
            _maturityRatingDal.Update(maturityRating);
        }
    }
}
