namespace CoreLayer.Aspects.Autofac.Transaction
{
  using Castle.DynamicProxy;
  using CoreLayer.Utilities.Interceptors;
  using System;
  using System.Collections.Generic;
  using System.Text;
  using System.Transactions;
  public class TransactionScopeAspect : MethodInterception
  {
    public override void Intercept(IInvocation invocation)
    {
      using (TransactionScope transactionScope = new TransactionScope())
      {
        try
        {
          invocation.Proceed();
          transactionScope.Complete();
        }
        catch (Exception e)
        {
          transactionScope.Dispose();
          throw;
        }
      }
    }
  }
}
