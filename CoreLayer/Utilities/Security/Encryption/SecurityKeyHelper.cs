namespace CoreLayer.Utilities.Security.Encryption
{
  using Microsoft.IdentityModel.Tokens;
  using System;
  using System.Collections.Generic;
  using System.Text;

  public class SecurityKeyHelper
  {
    public static SecurityKey CreateSecurityKey(string securityKey)
    {
      return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
    }
  }
}
