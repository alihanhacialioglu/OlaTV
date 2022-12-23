using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ISubtitleAppearanceService
    {
        void Add(SubtitleAppearance subtitleAppearance);
        void Remove(SubtitleAppearance subtitleAppearance);
        void Update(SubtitleAppearance subtitleAppearance);
        List<SubtitleAppearance> GetAll();
        SubtitleAppearance GetById(int id);
    }
}
