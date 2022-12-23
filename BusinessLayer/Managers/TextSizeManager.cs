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
    public class TextSizeManager : ITextSizeService
    {
        ITextSizeDal _textSizeDal;
        public TextSizeManager(ITextSizeDal textSizeDal) 
        { 
          _textSizeDal= textSizeDal;
        }    
        public void Add(TextSize textSize)
        {
            _textSizeDal.Add(textSize);
        }

        public List<TextSize> GetAll()
        {
            return _textSizeDal.GetAll();
        }

        public TextSize GetById(int id)
        {
            return _textSizeDal.Get(t => t.TextSizeId == id);
        }

        public TextSize GetByName(string name)
        {
            return _textSizeDal.Get(t=>t.TextSizeName==name);
        }

        public void Remove(TextSize textSize)
        {
            _textSizeDal.Delete(textSize);
        }

        public void Update(TextSize textSize)
        {
             _textSizeDal.Update(textSize);
        }
    }
}
