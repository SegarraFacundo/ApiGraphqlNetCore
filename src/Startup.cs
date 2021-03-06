﻿using MyApi.Datos;
using MyApi.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyApi
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
            services.AddScoped<AlmacenamientoDeConsultas>();   
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<IProductoRepositorio, ProductoRepositorio>();   
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
            services.AddTransient<CategoriaTipo>();
            services.AddTransient<ProductoTipo>();
            var sp = services.BuildServiceProvider();
            services.AddScoped<ISchema>(_ => new EsquemaDeAlmacenamientoDeConsultas(type => (GraphType) sp.GetService(type)) {Query = sp.GetService<AlmacenamientoDeConsultas>()});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
