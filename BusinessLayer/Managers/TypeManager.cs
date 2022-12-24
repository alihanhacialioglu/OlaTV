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
    public class TypeManager : ITypeService
    {
        ITypeDal _typeDal;
        public TypeManager(ITypeDal typeDal)
        {
            _typeDal = typeDal;
        }

        public void Add(EntityLayer.Concrete.Type type)
        {
            _typeDal.Add(type);
        }

        public List<EntityLayer.Concrete.Type> GetAll()
        {
            return _typeDal.GetAll();
        }

        public EntityLayer.Concrete.Type GetById(int id)
        {
            return _typeDal.Get(t=>t.TypeId==id);
        }

        public EntityLayer.Concrete.Type GetByName(string name)
        {
            return _typeDal.Get(t => t.TypeName == name);
        }

        public void Remove(EntityLayer.Concrete.Type type)
        {
            _typeDal.Delete(type);
        }

        public void Update(EntityLayer.Concrete.Type type)
        {
           _typeDal.Update(type);
        }
    }
}
