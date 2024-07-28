using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;
public static class ServiceCollectionExtension
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        var applicationAssemble = typeof(ServiceCollectionExtension).Assembly;
        services.AddAutoMapper(applicationAssemble);

        services.AddValidatorsFromAssembly(applicationAssemble)
            .AddFluentValidationAutoValidation();


    }
}
