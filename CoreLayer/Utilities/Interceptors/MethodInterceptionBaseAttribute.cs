namespace Core.Utilities.Interceptors
{
  using Castle.DynamicProxy;
  using System;
  using System.Linq;
  using System.Reflection;

  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
  public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
  {
    public int Priority { get; set; }

    public virtual void Intercept(IInvocation invocation)
    {

    }

  }
}
