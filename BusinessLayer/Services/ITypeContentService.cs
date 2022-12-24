using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ITypeContentService
    {
        void Add(TypeContent typeContent);
        void Remove(TypeContent typeContent);
        void Update(TypeContent typeContent);
        List<TypeContent> GetAll();
        TypeContent GetById(int id);
    }
}
