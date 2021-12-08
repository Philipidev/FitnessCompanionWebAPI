using FitnessCompanionWebAPI.Aplicacao;
using FitnessCompanionWebAPI.Infraestrutura;
using FitnessCompanionWebAPI.Middleware;
using FitnessCompanionWebAPI.Options.Cors;
using FitnessCompanionWebAPI.Options.Mvc;
using FitnessCompanionWebAPI.Options.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Reflection;

namespace FitnessCompanionWebAPI
{
    public class Startup
    {
        public IHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddCors(CustomCorsOptions.SetupAction);

            services.AddSwaggerGen(CustomSwaggerOptions.SetupAction(Environment));

            services.AddControllers(CustomMvcOptions.SetupAction);

            //services.AddMvc().AddControllersAsServices();

            services.AddInfrastructure(Configuration);

            services.AddApplication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            string xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFileName);
            Console.WriteLine($"Variavel de ambiente: {Environment.EnvironmentName}");
            Console.WriteLine($"Caminho do xml: {xmlFilePath}");

            app.UseCors();

            app.UseExceptionHandler(ExceptionHandlerMiddleware.ExceptionHandler());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseMiddleware<RequestResponseLoggingMiddleware>();

            app.UseEndpoints(endpointRouterBuilder => endpointRouterBuilder.MapControllers());

            app.UseSwagger();

            app.UseSwaggerUI(swaggerUIOptions =>
            {
                swaggerUIOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "FitnessCompanionAPI");
                swaggerUIOptions.RoutePrefix = string.Empty;
                swaggerUIOptions.DisplayRequestDuration();
                swaggerUIOptions.EnableFilter();
                swaggerUIOptions.EnableDeepLinking();
                swaggerUIOptions.DefaultModelsExpandDepth(-1);
            });
        }
    }
}
