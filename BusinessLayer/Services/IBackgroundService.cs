using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IBackgroundService
    {
        void Add(Background background);
        void Remove(Background background);

        void Update(Background background);

        List<Background> GetAll();

        Background GetById(int id);

    }
}
