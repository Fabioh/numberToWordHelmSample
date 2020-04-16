using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;

namespace Services.Extensions
{
    public static class DependencyInjectionServiceCollectionExtension
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services) 
            => services.AddSingleton<INumberToWord, NumberToWord>();
    }
}
