using Microsoft.Extensions.DependencyInjection;

namespace Mediatr.ApplicationLayer.Core.Extensions.ServiceCollectionExtensions
{
    public static class MediatrExtensions
    {
        public static IServiceCollection UseMediatr<TProgram>(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<TProgram>();
                cfg.AutoRegisterRequestProcessors = true;
            });
            
            return services;
        }
    }
}