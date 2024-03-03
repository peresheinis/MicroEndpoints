using MicroEndpoints.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MicroEndpoints.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Register all micro endpoints that are
    /// implemented using EdpointBase in your project
    /// </summary>
    /// <param name="services"></param>
    /// <param name="assembly"></param>
    /// <returns></returns>
    public static IServiceCollection AddMicroEndpoints(this IServiceCollection services, Assembly? assembly = null)
    {
        assembly = assembly ?? Assembly.GetExecutingAssembly();

        var endpointConfigurationType = typeof(IEndpointConfiguration);
        var endpointConfigurationImplementations = assembly
            .ExportedTypes
            .Where(t => endpointConfigurationType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

        foreach (var endpointConfigurationImplementation in endpointConfigurationImplementations)
        {
            services.AddScoped(endpointConfigurationType, endpointConfigurationImplementation);
        }

        return services;
    }
}