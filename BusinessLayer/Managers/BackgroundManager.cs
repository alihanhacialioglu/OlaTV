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
    public class BackgroundManager : IBackgroundService
    {
        IBackgroundDal _backgroundDal;

        public BackgroundManager(IBackgroundDal backgroundDal)
        {
            _backgroundDal = backgroundDal;
        }

        public void Add(Background background)
        {
            _backgroundDal.Add(background);
        }

        public List<Background> GetAll()
        {
            return _backgroundDal.GetAll();
        }

        public Background GetById(int id)
        {
            return _backgroundDal.Get(b => b.BackgroundId == id);
        }

        public void Remove(Background background)
        {
            _backgroundDal.Delete(background);
        }

        public void Update(Background background)
        {
            _backgroundDal.Update(background);
        }
    }
}
