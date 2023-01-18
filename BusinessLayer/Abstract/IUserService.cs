using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Remove(User user);
        void Update(User user);
        List<User> GetAll();
        User GetById(int id);
        User GetByName(string name);
        User GetByPassword(string password);
        User GetByEmail(string email);
        User GetByPhoneNumber(string number);
        User GetByPin(int pin);
        User GetByDateTime(DateTime dateTime);
    }
}
