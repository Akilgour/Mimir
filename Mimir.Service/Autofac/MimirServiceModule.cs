using Autofac;
using Mimir.Data.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimir.Service.Autofac
{
    public class MimirServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new MimirDataModule());

            //"ThisAssembly" means "any types in the same assembly as the module"
            builder.RegisterAssemblyTypes(ThisAssembly)
                 .Where(t => t.Name.EndsWith("Service"))
                 .AsImplementedInterfaces();
        }
    }
}