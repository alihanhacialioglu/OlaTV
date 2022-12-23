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
    public class StyleContentManager : IStyleContentService
    {
        IStyleContentDal _styleContentDal;
        public StyleContentManager(IStyleContentDal styleContentDal)
        {
            _styleContentDal = styleContentDal;
        }

        public void Add(StyleContent styleContent)
        {
            _styleContentDal.Add(styleContent);
        }

        public List<StyleContent> GetAll()
        {
            return _styleContentDal.GetAll();
        }

        public StyleContent GetById(int id)
        {
           return  _styleContentDal.Get(s=>s.StyleContentId==id);
        }

        public void Remove(StyleContent styleContent)
        {
            _styleContentDal.Delete(styleContent);
        }

        public void Update(StyleContent styleContent)
        {
            _styleContentDal.Update(styleContent);
        }
    }
}
