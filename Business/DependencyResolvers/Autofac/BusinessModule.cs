using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OperationClaimService>().As<IOperationClaimService>();


            builder.RegisterType<OperationClaimRepository>().As<IOperationClaimRepository>();


            base.Load(builder);
        }
    }
}
