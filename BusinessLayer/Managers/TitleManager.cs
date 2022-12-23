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
    public class TitleManager : ITitleService
    {
        ITitleDal _titleDal;
        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public void Add(Title title)
        {
            _titleDal.Add(title);
        }

        public List<Title> GetAll()
        {
            return _titleDal.GetAll();
        }

        public Title GetById(int id)
        {
            return _titleDal.Get(t => t.TitleId == id);
        }

        public Title GetByName(string name)
        {
            return _titleDal.Get(t=>t.TitleName== name);    
        }

        public void Remove(Title title)
        {
            _titleDal.Delete(title);
        }

        public void Update(Title title)
        {
            _titleDal.Update(title);
        }
    }
}
