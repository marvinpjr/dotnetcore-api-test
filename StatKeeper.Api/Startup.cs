﻿using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StatKeeper.Api.Repositories;
using StatKeeper.Api.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace StatKeeperApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    //Title = "Stat Keeper Api",
                    Version = "v1",
                    Description = "Api for Stat Keeper Application",
                    TermsOfService = "Use wisely.",
                    Contact = new Contact {  Name = "Marvin Palmer", Url = "http://www.marvinpalmer.com" }
                });

                // Set the comments path for the Swagger JSON and UI.
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "StatKeeper.Api.xml"); // bin\Debug\netcoreapp2.0\StatKeeper.Api.xml
                c.IncludeXmlComments(xmlPath);
            });

            // dependency injection
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // see https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?tabs=aspnetcore2x
            // and https://cpratt.co/customizing-swagger-ui-in-asp-net-core/
            app.UseStaticFiles();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix ="help";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Stat Keeper API");
                c.InjectStylesheet("/swagger/ui/custom.css");
                c.InjectOnCompleteJavaScript("/swagger/ui/custom.js");
            });

            // this isn't working for me on azure, not sure why
            app.UseRewriter(new RewriteOptions().AddRedirect("^$", "help", (int)HttpStatusCode.Redirect));

            app.UseMvc();
        }
    }
}
