using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IShadowService
    {
        void Add(Shadow shadow);
        void Remove(Shadow shadow);
        void Update(Shadow shadow);
        List<Shadow> GetAll();
        Shadow GetById(int id);
        Shadow GetByName(string name);
    }
}
