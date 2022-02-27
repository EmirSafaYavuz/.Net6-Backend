namespace CoreLayer.Utilities.Security.Encryption
{
  using Microsoft.IdentityModel.Tokens;
  using System;
  using System.Collections.Generic;
  using System.Text;
  public class SigningCredentialsHelper
  {
    public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
    {
      return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
    }
  }
}
