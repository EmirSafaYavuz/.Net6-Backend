namespace CoreLayer.Utilities.Security.JWT
{
  using CoreLayer.Entities.Concrete;
  using System;
  using System.Collections.Generic;
  using System.Text;

  public interface ITokenHelper
  {
    AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    string? IsTokenHasUserEmail(string token);
  }
}
