using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IStyleService
    {
        void Add(Style style);
        void Remove(Style style);
        void Update(Style style);
        List<Style> GetAll();
        Style GetById(int id);
        Style GetByName(string name);
    }
}
