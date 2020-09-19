using Autofac;
using Mimir.Service.Autofac;
using System.Linq;

namespace Mimir.Server.Autofac
{
    public class AutofacConfiguration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new MimirServiceModule());
        }
    }
}