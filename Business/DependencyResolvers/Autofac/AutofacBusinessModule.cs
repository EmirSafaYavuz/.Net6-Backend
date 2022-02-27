namespace Business.DependencyResolvers.Autofac
{
  using Business.Abstract;
  using Business.Concrete;
  using Castle.DynamicProxy;
  using CoreLayer.Utilities.Interceptors;
  using CoreLayer.Utilities.Security.JWT;
  using global::Autofac;
  using global::Autofac.Extras.DynamicProxy;

  public class AutofacBusinessModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
      builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

      builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
      builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

      var assembly = System.Reflection.Assembly.GetExecutingAssembly();

      builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
          .EnableInterfaceInterceptors(new ProxyGenerationOptions()
          {
            Selector = new AspectInterceptorSelector()
          }).SingleInstance();
    }
  }
}
