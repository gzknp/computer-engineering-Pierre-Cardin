using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLService.Model;
using GraphQLService.IService;
using GraphQLService.Service;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Http;

namespace GraphQLService
{
    public class Startup
    {


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<Query>();
            services.AddGraphQL(p => SchemaBuilder.New().AddServices(p)
            .AddType<CategoryType>()
            .AddQueryType<Query>()
            .Create()
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions
                {
                    QueryPath = "/api",
                    Path = "/playground"
                });
            }
            app.UseGraphQL("/api");


            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/",async context=>
                {
                    await context.Response.WriteAsync("Pierre Cardin Kategoriler");
                });
            });
        }
    }
}
