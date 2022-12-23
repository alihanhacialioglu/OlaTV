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
    public class SubtitleAppearanceManager : ISubtitleAppearanceService
    {
        ISubtitleAppearanceDal _subtitleAppearanceDal;
        public SubtitleAppearanceManager(ISubtitleAppearanceDal subtitleAppearanceDal)
        {
            _subtitleAppearanceDal = subtitleAppearanceDal;
        }

        public void Add(SubtitleAppearance subtitleAppearance)
        {
            _subtitleAppearanceDal.Add(subtitleAppearance);
        }

        public List<SubtitleAppearance> GetAll()
        {
            return _subtitleAppearanceDal.GetAll();
        }

        public SubtitleAppearance GetById(int id)
        {
            return _subtitleAppearanceDal.Get(s => s.SubtitleAppearanceId == id);
        }

        public void Remove(SubtitleAppearance subtitleAppearance)
        {
            _subtitleAppearanceDal.Delete(subtitleAppearance);
        }

        public void Update(SubtitleAppearance subtitleAppearance)
        {
            _subtitleAppearanceDal.Update(subtitleAppearance);
        }
    }
}
