using System.Reflection;
using Jaeger;
using Jaeger.Reporters;
using Jaeger.Samplers;
using OpenTracing;

namespace MICROSERVICES.Common.Jaeger.Jaeger
{
    public class DShopDefaultTracer
    {
        public static ITracer Create()
           => new Tracer.Builder(Assembly.GetEntryAssembly().FullName)
               .WithReporter(new NoopReporter())
               .WithSampler(new ConstSampler(false))
               .Build();
    }
}
