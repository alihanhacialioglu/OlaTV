using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISliderService
    {
        void Add(Slider slider);
        void Update(Slider slider);
        void Remove(Slider slider);
        List<Slider> GetAll();
        Slider GetById(int id);
        Slider GetByUrl(string url);
    }
}
