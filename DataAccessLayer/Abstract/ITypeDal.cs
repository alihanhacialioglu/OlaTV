using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = EntityLayer.Concrete.Type;

namespace DataAccessLayer.Abstract
{
    public interface ITypeDal : IGenericDal<Type>
    {
        void Add(System.Type type);
    }
}
