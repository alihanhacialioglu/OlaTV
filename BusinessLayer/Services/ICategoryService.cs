using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Remove(Category category);
        List<Category> GetAll();
        Category GetById(int id);
        Category GetByName(string name);
    }
}
