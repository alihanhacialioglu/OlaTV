using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentCastTitleService
    {
        void Add(ContentCastTitle contentCastTitle);
        void Remove(ContentCastTitle contentCastTitle);
        void Update(ContentCastTitle contentCastTitle);
        List<ContentCastTitle> GetAll();
        ContentCastTitle GetById(int id);


    }
}
