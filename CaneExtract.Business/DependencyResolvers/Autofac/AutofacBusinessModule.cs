using Autofac;
using CaneExtract.Business.Abstract;
using CaneExtract.Business.Concrete.Managers;
using CaneExtract.DataAccess.Abstract;
using CaneExtract.DataAccess.Concrete.Dapper;

namespace CaneExtract.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StiManager>().As<IStiService>().SingleInstance();
            builder.RegisterType<DpStiDal>().As<IStiDal>().SingleInstance();
        }
    }
}
