using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITextSizeService
    {
        void Add(TextSize textSize);
        void Remove(TextSize textSize);
        void Update(TextSize textSize);
        List<TextSize> GetAll();
        TextSize GetById(int id);
        TextSize GetByName(string name);

    }
}
