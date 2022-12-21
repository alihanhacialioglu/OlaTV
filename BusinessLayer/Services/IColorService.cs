using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Remove(Color color);
        List<Color> GetAll();
        Color GetById(int id);
        Color GetByName(string name);
    }
}
