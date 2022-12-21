using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IFontService
    {
        void Add(Font font);
        void Remove(Font font);
        void Update(Font font);
        List<Font> GetAll();
        Font GetById(int id);
        Font GetByName(string name);
    }
}
