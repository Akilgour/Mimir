using Autofac;
using Mimir.Data.Context;
using Mimir.Data.Factorys;
using System.Linq;

namespace Mimir.Data.Autofac
{
    public class MimirDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .WithParameter("context", new MirmirContext())
                .WithParameter("retryPolicy", PollyFactory.CreateAsyncRetryPolicy())
                .AsImplementedInterfaces();
        }
    }
}