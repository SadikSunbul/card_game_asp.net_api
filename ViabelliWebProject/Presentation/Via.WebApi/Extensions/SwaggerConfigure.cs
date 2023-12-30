using Microsoft.OpenApi.Models;

namespace Via.WebApi.Extensions;

public static class SwaggerConfigure
{
    public static IServiceCollection AddSwaggerConfigure(this IServiceCollection services)
    {
        services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "ViaBelli",
                Description = "Viabelli Web Project Team ",
                TermsOfService = new Uri("https://github.com/ViaBelliPlus"),
                Contact = new()
                {
                    Name = "Via Team Sadık",
                    Email = "jsjsqwe12@gmail.com",
                    Url = new Uri("https://github.com/SadikSunbul")
                },
                Version = "v1",
                License = new OpenApiLicense
                {
                    Name = "License",
                    Url = new Uri("https://opensource.org/license/mit/")
                }
            });

            s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                In = ParameterLocation.Header,
                Description = "Place to add JWT with Bearer",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });

            //oturum acma ıslemlerı ıcın yazıldı 
            s.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference=new OpenApiReference()
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            },
                            Name="Baerer"
                        },
                        new List<string>()
                    }
                });
        });




        return services;
    }
}
