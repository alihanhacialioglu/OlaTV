using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMenuService
    {
        void Add(Menu menu);
        void Update(Menu menu);
        void Remove(Menu menu);
        List<Menu> GetAll();
        Menu GetById(int id);
        Menu GetByUrl(string url);
    }
}
