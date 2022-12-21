using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IGenreContentService
    {
        void Add(GenreContent genreContent);
        void Remove(GenreContent genreContent);
        void Update(GenreContent genreContent);
        List<GenreContent> GetAll();
        GenreContent GetById(int id);
       
    }
}
