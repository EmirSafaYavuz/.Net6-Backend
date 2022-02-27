namespace Core.Utilities.IoC
{
  using Microsoft.Extensions.DependencyInjection;
  using System;
  using System.Collections.Generic;
  using System.Text;
  public interface ICoreModule
  {
    void Load(IServiceCollection serviceCollection);
  }
}
