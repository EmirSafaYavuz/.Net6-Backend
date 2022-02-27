namespace Business.Abstract
{
  using CoreLayer.Entities.Concrete;
  using System.Collections.Generic;

  public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        User GetByName(string name);
    }
}
