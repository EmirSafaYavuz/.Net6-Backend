namespace Core.Utilities.Results
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  public class ErrorResult : Result
  {
    public ErrorResult() : base(false)
    {
    }

    public ErrorResult(string message) : base(false, message)
    {
    }
  }
}
