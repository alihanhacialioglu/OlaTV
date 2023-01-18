using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITitleService
    {
        void Add(Title title);
        void Remove(Title title);
        void Update(Title title);
        List<Title> GetAll();
        Title GetById(int id);
        Title GetByName(string name);
    }
}
