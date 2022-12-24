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
    public class TypeContentManager : ITypeContentService
    {
        ITypeContentDal _typeContentDal;
        public TypeContentManager(ITypeContentDal typeContentDal)
        {
            _typeContentDal = typeContentDal;
        }

        public void Add(TypeContent typeContent)
        {
            _typeContentDal.Add(typeContent);
        }

        public List<TypeContent> GetAll()
        {
            return _typeContentDal.GetAll();
        }

        public TypeContent GetById(int id)
        {
            return _typeContentDal.Get(t=>t.TypeContentId==id);
        }

        public void Remove(TypeContent typeContent)
        {
            _typeContentDal.Delete(typeContent);
        }

        public void Update(TypeContent typeContent)
        {
            _typeContentDal.Update(typeContent);
        }
    }
}
