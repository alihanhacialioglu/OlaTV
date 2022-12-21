using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ILanguageService
    {
        void Add(Language language);
        void Remove(Language language);
        void Update(Language language);
        List<Language> GetAll();
        Language GetById(int id);
        Language GetByName(string name);
    }
}
