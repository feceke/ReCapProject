using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<List<User>> GetUsersById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.Id == id));
        }

        public IDataResult<List<User>> GetUsersByUserFirstName(string FirstName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(ufn => ufn.FirstName == FirstName));
        }

        public IDataResult<List<User>> GetUsersByUserLastName(string LastName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(ln => ln.LastName == LastName));
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
