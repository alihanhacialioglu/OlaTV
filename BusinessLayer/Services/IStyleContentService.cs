using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IStyleContentService
    {
        void Add(StyleContent styleContent);
        void Remove(StyleContent styleContent);
        void Update(StyleContent styleContent);
        List<StyleContent> GetAll();
        StyleContent GetById(int id);
    }
}
