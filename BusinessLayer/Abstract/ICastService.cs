using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICastService
    {
        void Add(Cast cast);
        void Remove(Cast cast);
        void Update(Cast cast);
        List<Cast> GetAll();
        Cast GetById(int id);

    }
}
