using BusinessLayer.Services;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class GenreContentManager : IGenreContentService
    {
        IGenreContentDal _genreContentDal;
        public GenreContentManager(IGenreContentDal genreContentDal)
        {
            _genreContentDal = genreContentDal;
        }
        public void Add(GenreContent genreContent)
        {
            _genreContentDal.Add(genreContent);
        }

        public List<GenreContent> GetAll()
        {
            return _genreContentDal.GetAll();
        }

        public GenreContent GetById(int id)
        {
            return  _genreContentDal.Get(g=>g.GenreContentId==id);
        }

        public void Remove(GenreContent genreContent)
        {
            _genreContentDal.Delete(genreContent);
        }

        public void Update(GenreContent genreContent)
        {
            _genreContentDal.Update(genreContent);
        }
    }
}
