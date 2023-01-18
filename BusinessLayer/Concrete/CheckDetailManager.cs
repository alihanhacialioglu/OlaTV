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
    public class CheckDetailManager : ICheckDetailService
    {
        ICheckDetailDal _checkDetailDal;
        public CheckDetailManager(ICheckDetailDal checkDetailDal)
        {
            _checkDetailDal= checkDetailDal;
        }
        public void Add(CheckDetail checkDetail)
        {
            _checkDetailDal.Add(checkDetail);
        }

        public List<CheckDetail> GetAll()
        {
           return _checkDetailDal.GetAll();
        }

        public CheckDetail GetById(int id)
        {
            return _checkDetailDal.Get(g=>g.CheckDetailId==id);
        }

        public void Remove(CheckDetail checkDetail)
        {
            _checkDetailDal.Delete(checkDetail);
        }

        public void Update(CheckDetail checkDetail)
        {
            _checkDetailDal.Update(checkDetail);
        }
    }
}
