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
    public class ShadowManager : IShadowService
    {
        IShadowDal _shadowDal;
        public ShadowManager(IShadowDal shadowDal) 
        { 
            _shadowDal = shadowDal;
        }
        public void Add(Shadow shadow)
        {
            _shadowDal.Add(shadow);
        }

        public List<Shadow> GetAll()
        {
            return _shadowDal.GetAll();
        }

        public Shadow GetById(int id)
        {
            return _shadowDal.Get(s => s.ShadowId== id);
        }

        public Shadow GetByName(string name)
        {
            return _shadowDal.Get(s=>s.ShadowName==name);
        }

        public void Remove(Shadow shadow)
        {
            _shadowDal.Delete(shadow);
        }

        public void Update(Shadow shadow)
        {
            _shadowDal.Update(shadow);
        }
    }
}
