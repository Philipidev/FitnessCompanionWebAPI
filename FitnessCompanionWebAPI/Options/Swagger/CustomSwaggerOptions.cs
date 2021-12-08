using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.Reflection;

namespace FitnessCompanionWebAPI.Options.Swagger
{
    public class CustomSwaggerOptions
    {
        public static Action<SwaggerGenOptions> SetupAction(IHostEnvironment Environment)
        {
            return swaggerGenOptions =>
            {
                string xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFileName);
                swaggerGenOptions.IncludeXmlComments(xmlFilePath);
                swaggerGenOptions.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}_{apiDesc.RelativePath}");
                swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = $"FitnessCompanionWebAPI - ({Environment.EnvironmentName})",
                    Description = "Api for the Fitness Companion App",
                    Contact = new OpenApiContact
                    {
                        Name = "Philipi Carvalho",
                        Email = "philipi.altoe@gmail.com",
                        Url = new Uri("https://github.com/Philipidev"),
                    },
                });
            };
        }
    }
}
