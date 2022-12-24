using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ITypeService
    {
        void Add(EntityLayer.Concrete.Type type);
        void Update(EntityLayer.Concrete.Type type);
        void Remove(EntityLayer.Concrete.Type type);
        List<EntityLayer.Concrete.Type> GetAll();
        EntityLayer.Concrete.Type GetById(int id);
        EntityLayer.Concrete.Type GetByName(string name);
    }
}
