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
    public class LanguageManager : ILanguageService
    {
        ILanguageDal _languageDal;
        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public void Add(Language language)
        {
            _languageDal.Add(language);
        }

        public List<Language> GetAll()
        {
            return _languageDal.GetAll();
        }

        public Language GetById(int id)
        {
            return _languageDal.Get(l => l.LanguageId == id);
        }

        public Language GetByName(string name)
        {
            return _languageDal.Get(l=>l.LanguageName==name);
        }

        public void Remove(Language language)
        {
            _languageDal.Delete(language);
        }

        public void Update(Language language)
        {
            _languageDal.Update(language);
        }
    }
}
