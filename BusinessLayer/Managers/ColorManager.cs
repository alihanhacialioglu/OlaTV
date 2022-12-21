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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        
        public ColorManager(IColorDal colorDal) 
        {
            _colorDal = colorDal;
        } 
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public List<Color> GetAll()
        {
           return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c=> c.ColorId== id);
        }

        public Color GetByName(string name)
        {
           return _colorDal.Get(c=>c.ColorName== name);
        }

        public void Remove(Color color)
        {
            _colorDal.Delete(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
