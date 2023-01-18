using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        void Add(Content content);
        void Remove(Content content);
        void Update(Content content);
        List<Content> GetAll();
        Content GetById(int id);
        Content GetByName(string name);
    }
}
