namespace CoreLayer.Utilities.Results
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  public interface IResult
  {
    bool Success { get; }
    string Message { get; }
  }
}
