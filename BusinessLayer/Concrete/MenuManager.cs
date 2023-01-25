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
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal) 
        { 
          _menuDal= menuDal;
        }
        public void Add(Menu menu)
        {
            _menuDal.Add(menu);
        }

        public void Remove(Menu menu)
        {
            _menuDal.Delete(menu);
        }

        public List<Menu> GetAll()
        {
            return _menuDal.GetAll();
        }

        public Menu GetById(int id)
        {
            return _menuDal.Get(x => x.MenuId == id);
        }

        public Menu GetByUrl(string url)
        {
            return _menuDal.Get(x => x.SeoUrl == url);
        }

        public void Update(Menu menu)
        {
            _menuDal.Update(menu);
        }
    }
}
