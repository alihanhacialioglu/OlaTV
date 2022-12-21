using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ICastTitleService
    {

        void Add(CastTitle castTitle);
        void Remove(CastTitle castTitle);
        void Update(CastTitle castTitle);
        List<CastTitle> GetAll();
        CastTitle GetById(int id);
    }
}
