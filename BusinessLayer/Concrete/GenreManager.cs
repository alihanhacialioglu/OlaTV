using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenreManager : IGenreService
    {
        IGenreDal _genreDal;
        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }
        public void Add(Genre genre)
        {
            _genreDal.Add(genre);
        }

        public List<Genre> GetAll()
        {
            return _genreDal.GetAll();
        }

        public Genre GetById(int id)
        {
            return _genreDal.Get(g => g.GenreId == id);
        }

        public Genre GetByName(string name)
        {
            return _genreDal.Get(g => g.GenreName == name);
        }

        public void Remove(Genre genre)
        {
            _genreDal.Delete(genre);
        }

        public void Update(Genre genre)
        {
            _genreDal.Update(genre);
        }
    }
}
