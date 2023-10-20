using Autofac;
using CaneExtract.Business.ValidationRules.FluentValidation;
using CaneExtract.Entities.Dtos;
using FluentValidation;

namespace CaneExtract.Business.DependencyResolvers.Autofac
{
    public class AutofacValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<STIParameterValidator>().As<IValidator<STIWithSTKParameterDto>>().SingleInstance();
        }
    }
}
