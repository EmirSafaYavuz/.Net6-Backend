namespace DataAccess.Abstract
{
  using CoreLayer.DataAccess;
  using CoreLayer.Entities.Concrete;
  using System;
  using System.Collections.Generic;
  using System.Text;

  public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
