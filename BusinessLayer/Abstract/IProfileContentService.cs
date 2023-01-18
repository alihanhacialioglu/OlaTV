using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProfileContentService
    {
        void Add(ProfileContent profileContent);
        void Remove(ProfileContent profileContent);
        void Update(ProfileContent profileContent);
        List<ProfileContent> GetAll();
        ProfileContent GetById(int id);
    }
}
