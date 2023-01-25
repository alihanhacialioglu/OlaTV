using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;
        public SliderManager (ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }
        public void Add(Slider slider)
        {
            _sliderDal.Add(slider);
        }

        public List<Slider> GetAll()
        {
           return _sliderDal.GetAll();
        }

        public Slider GetById(int id)
        {
            return _sliderDal.Get(x => x.SliderId == id);
        }

        public Slider GetByUrl(string url)
        {
            return _sliderDal.Get(x => x.ContentUrl == url);
        }

        public void Remove(Slider slider)
        {
            _sliderDal.Delete(slider);
        }

        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
