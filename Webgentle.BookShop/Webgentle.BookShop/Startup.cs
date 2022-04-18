using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookShop
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
            //services.AddRazorPages();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.Map("/", async context =>
                //{
                        
                //    await context.Response.WriteAsync(env.EnvironmentName);
                //});
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/store", async context =>
                {
                    await context.Response.WriteAsync("Welcome To Store");
                });
            });



            //ye new middle wear creat horha hai created by zain for practice
            //app.Use(async (context,next) => 
            //{
            //    await context.Response.WriteAsync("Hello from the first middle wear");

            //    await next();

            //    await context.Response.WriteAsync("Hello First M W");
            //});

            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("Hello From The Second Midlle Wear");

            //    await next();

            //    await context.Response.WriteAsync("Hello Second M W");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello From The 3rd Midlle Wear");

            //    next();

            //});
            //ye new middle wear creat horha hai created by zain for practice

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //}

            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
        }
    }
}
