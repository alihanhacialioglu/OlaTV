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
    public class WindowManager : IWindowService
    {
        IWindowDal _windowDal;
        public WindowManager(IWindowDal windowDal)
        {
            _windowDal = windowDal;
        }
        public void Add(Window window)
        {
            _windowDal.Add(window);
        }

        public List<Window> GetAll()
        {
            return _windowDal.GetAll();
        }

        public Window GetById(int id)
        {
            return _windowDal.Get(w => w.WindowId == id);
        }

        public void Remove(Window window)
        {
            _windowDal.Delete(window);
        }

        public void Update(Window window)
        {
            _windowDal.Update(window);
        }
    }
}
