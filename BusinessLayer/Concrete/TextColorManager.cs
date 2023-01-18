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
    public class TextColorManager : ITextColorService
    {
        ITextColor _textColorDal;
        
        public TextColorManager(ITextColor textColorDal) 
        {
            _textColorDal = textColorDal;
        } 
        public void Add(TextColor textColor)
        {
            _textColorDal.Add(textColor);
        }

        public List<TextColor> GetAll()
        {
           return _textColorDal.GetAll();
        }

        public TextColor GetById(int id)
        {
            return _textColorDal.Get(c=> c.TextColorId== id);
        }

        public TextColor GetByName(string name)
        {
           return _textColorDal.Get(c=>c.TextColorName == name);
        }

        public void Remove(TextColor textColor)
        {
            _textColorDal.Delete(textColor);
        }

        public void Update(TextColor textColor)
        {
            _textColorDal.Update(textColor);
        }
    }
}
