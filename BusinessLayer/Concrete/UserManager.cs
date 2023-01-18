using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
           return _userDal.GetAll();    
        }

        public User GetByDateTime(DateTime dateTime)
        {
            return _userDal.Get(u => u.DateOfRegistration == dateTime);
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(u => u.EmailAddress == email);
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.UserId == id);
        }

        public User GetByName(string name)
        {
            return _userDal.Get(u => u.UserName == name);
        }

        public User GetByPassword(string password)
        {
            return _userDal.Get(u => u.Password == password);
        }

        public User GetByPhoneNumber(string number)
        {
            return _userDal.Get(u => u.PhoneNumber == number);
        }

        public User GetByPin(int pin)
        {
            return _userDal.Get(u=>u.AccessPin==pin);
        }

        public void Remove(User user)
        {
            _userDal.Delete(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
