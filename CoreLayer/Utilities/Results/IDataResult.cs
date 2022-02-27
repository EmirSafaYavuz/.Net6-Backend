namespace Core.Utilities.Results
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  public interface IDataResult<T> : IResult
  {
    T Data { get; }
  }
}
