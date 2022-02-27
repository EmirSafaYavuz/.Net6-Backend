namespace CoreLayer.DependencyResolvers
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Text;
  using CoreLayer.CrossCuttingConcerns.Caching;
  using CoreLayer.CrossCuttingConcerns.Caching.Microsoft;
  using CoreLayer.Utilities.IoC;
  using Microsoft.AspNetCore.Http;
  using Microsoft.Extensions.DependencyInjection;
  public class CoreModule : ICoreModule
  {
    public void Load(IServiceCollection serviceCollection)
    {
      serviceCollection.AddMemoryCache();
      serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
      serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
      serviceCollection.AddSingleton<Stopwatch>();
    }
  }
}
