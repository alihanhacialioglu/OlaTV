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
    public class CastManager : ICastService
    {
        ICastDal _castDal;

        public CastManager(ICastDal castDal)
        {
            _castDal = castDal;
        }
        public void Add(Cast cast)
        {
            _castDal.Add(cast);
        }

        public List<Cast> GetAll()
        {
            return _castDal.GetAll();
        }

        public Cast GetById(int id)
        {
            return _castDal.Get(c => c.CastId == id);
        }

        public void Remove(Cast cast)
        {
            _castDal.Delete(cast);
        }

        public void Update(Cast cast)
        {
           _castDal.Update(cast);
        }
    }
}
