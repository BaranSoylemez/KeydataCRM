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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void TAdd(User entity)
        {
            _userDal.Add(entity);
        }

        public User TGetById(int id)
        {
           return _userDal.GetByID(id);
            
        }

        public void TRemove(User entity)
        {
            _userDal.Delete(entity);
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
