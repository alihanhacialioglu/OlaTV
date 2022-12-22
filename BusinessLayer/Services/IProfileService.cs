using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IProfileService
    {
        void Add(Profile profile);
        void Remove(Profile profile);
        void Update(Profile profile);
        List<Profile> GetAll();
        Profile GetById(int id);
        Profile GetByName(string name);
        Profile GetByPin(int pin);
        Profile GetByAnimation(bool isAnimation);
        Profile GetByMarketing(bool isMarketing);
    }
}
