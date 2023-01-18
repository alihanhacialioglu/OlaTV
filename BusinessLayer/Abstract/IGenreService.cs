using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenreService
    {
        void Add(Genre genre);
        void Remove(Genre genre);
        void Update(Genre genre);
        List<Genre> GetAll();
        Genre GetById(int id);
        Genre GetByName(string name);
    }
}
