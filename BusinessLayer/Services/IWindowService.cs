using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IWindowService
    {
        void Add(Window window);
        void Remove(Window window);
        void Update(Window window);
        List<Window> GetAll();
        Window GetById(int id);
    }
}
