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
    public class ContentCastTitleManager : IContentCastTitleService
    {
        IContentCastTitleDal _contentCastTitleDal;

        public ContentCastTitleManager(IContentCastTitleDal contentCastTitleDal)
        {
            _contentCastTitleDal = contentCastTitleDal;
        }

        public void Add(ContentCastTitle contentCastTitle)
        {
            _contentCastTitleDal.Add(contentCastTitle);
        }

        public List<ContentCastTitle> GetAll()
        {
            return _contentCastTitleDal.GetAll();
        }

        public ContentCastTitle GetById(int id)
        {
            return _contentCastTitleDal.Get(cct=>cct.ContentCastTitleId==id);
        }

        public void Remove(ContentCastTitle contentCastTitle)
        {
            _contentCastTitleDal.Delete(contentCastTitle);
        }

        public void Update(ContentCastTitle contentCastTitle)
        {
            _contentCastTitleDal.Update(contentCastTitle);
        }
    }
}
