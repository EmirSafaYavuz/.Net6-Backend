namespace Core.Utilities.Security.JWT
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  public class AccessToken
  {
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
  }
}
