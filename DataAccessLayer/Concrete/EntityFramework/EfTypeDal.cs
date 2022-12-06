using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = EntityLayer.Concrete.Type;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfTypeDal : GenericRepository<Type>, ITypeDal
    {
    }
}
