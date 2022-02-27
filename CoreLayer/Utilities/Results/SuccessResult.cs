namespace CoreLayer.Utilities.Results
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  public class SuccessResult : Result
  {
    public SuccessResult() : base(true)
    {
    }

    public SuccessResult(string message) : base(true, message)
    {
    }
  }
}
