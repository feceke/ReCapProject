using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);


        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetUsersById(int id);
        IDataResult<List<User>> GetUsersByUserFirstName(string FirstName);
        IDataResult<List<User>> GetUsersByUserLastName(string LastName);

    }

}
