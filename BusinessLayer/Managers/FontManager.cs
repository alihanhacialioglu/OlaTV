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
    public class FontManager : IFontService
    {
        IFontDal _fontDal;
        public FontManager(IFontDal fontDal)
        {
            _fontDal = fontDal;
        }

        public void Add(Font font)
        {
            
            _fontDal.Add(font);
        }

        public List<Font> GetAll()
        {
            return _fontDal.GetAll();
        }

        public Font GetById(int id)
        {
            return _fontDal.Get(f => f.FontId == id);
        }

        public Font GetByName(string name)
        {
            return _fontDal.Get(f=>f.FontName==name);
        }

        public void Remove(Font font)
        {
            _fontDal.Delete(font);
        }

        public void Update(Font font)
        {
            _fontDal.Update(font);
        }
    }
}
