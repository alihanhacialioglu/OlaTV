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
    public class StyleManager : IStyleService
    {
        IStyleDal _styleDal;
        public StyleManager(IStyleDal styleDal)
        {
            _styleDal = styleDal;
        }

        public void Add(Style style)
        {
            _styleDal.Add(style);
        }

        public List<Style> GetAll()
        {
           return _styleDal.GetAll();
        }

        public Style GetById(int id)
        {
            return _styleDal.Get(s => s.StyleId == id);
        }

        public Style GetByName(string name)
        {
           return _styleDal.Get(s=>s.StyleName==name);
        }

        public void Remove(Style style)
        {
            _styleDal.Delete(style);
        }

        public void Update(Style style)
        {
            _styleDal.Update(style);
        }
    }
}
