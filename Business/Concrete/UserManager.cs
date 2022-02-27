namespace Business.Concrete
{
  using Business.Abstract;
  using CoreLayer.Entities.Concrete;
  using System.Collections.Generic;

  public class UserManager : IUserService
  {
    IUserDal _userDal;

    public UserManager(IUserDal userDal)
    {
      _userDal = userDal;
    }

    public List<OperationClaim> GetClaims(User user)
    {
      return _userDal.GetClaims(user);
    }

    public void Add(User user)
    {
      _userDal.Add(user);
    }

    public User GetByMail(string email)
    {
      return _userDal.Get(u => u.Email == email);
    }

    public User GetByName(string name)
    {
      return _userDal.Get(u=>u.FirstName + " " + u.LastName == name);
    }
  }
}
