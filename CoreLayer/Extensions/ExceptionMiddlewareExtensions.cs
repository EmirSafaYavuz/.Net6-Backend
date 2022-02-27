namespace CoreLayer.Extensions
{
  using Microsoft.AspNetCore.Builder;
  using System;
  using System.Collections.Generic;
  using System.Text;
  public static class ExceptionMiddlewareExtensions
  {
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
    {
      app.UseMiddleware<ExceptionMiddleware>();
    }
  }
}
