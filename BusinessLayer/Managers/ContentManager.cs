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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void Add(Content content)
        {
            _contentDal.Add(content);
        }

        public List<Content> GetAll()
        {
            return _contentDal.GetAll();
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(c => c.ContentId == id); ;
        }

        public Content GetByName(string name)
        {
            return _contentDal.Get(c => c.ContentName == name); ;
        }

        public void Remove(Content content)
        {
            _contentDal.Delete(content);
        }

        public void Update(Content content)
        {
            _contentDal.Update(content);
        }
    }
}
