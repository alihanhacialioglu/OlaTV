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
    public class CastTitleManager : ICastTitleService
    {

        ICastTitleDal _castTitleDal;
        public CastTitleManager(ICastTitleDal castTitleDal) 
        { 
            _castTitleDal= castTitleDal;
        }
        public void Add(CastTitle castTitle)
        {
            _castTitleDal.Add(castTitle);
        }

        public List<CastTitle> GetAll()
        {
            return _castTitleDal.GetAll();
        }

        public CastTitle GetById(int id)
        {
            return _castTitleDal.Get(ct => ct.CastTitleId == id);
        }

        public void Remove(CastTitle castTitle)
        {
            _castTitleDal.Delete(castTitle);
        }

        public void Update(CastTitle castTitle)
        {
            
            _castTitleDal.Update(castTitle);
        }
    }
}
