using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ITextColorService
    {
        void Add(TextColor textColor);
        void Update(TextColor textColor);
        void Remove(TextColor textColor);
        List<TextColor> GetAll();
		TextColor GetById(int id);
		TextColor GetByName(string name);
    }
}
