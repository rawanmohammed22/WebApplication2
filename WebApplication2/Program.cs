using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var WenApplication2Builder = WebApplication.CreateBuilder(args);

            #region configure services
            WenApplication2Builder.Services.AddControllersWithViews();
            #endregion


            #region build

            var app = WenApplication2Builder.Build();

            #endregion




            #region configure
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

                app.MapGet("/", async context =>
                {

                    await context.Response.WriteAsync("Hello World!");
                });

                app.MapGet("/RAWAN", async context =>
                {
                    await context.Response.WriteAsync("Hello rawan!");

                });

            app.MapControllers();

            app.MapControllerRoute(

                    name: "default",
                    pattern: "{Controller=Home}/{action=Index}");














            #endregion


            #region run 


            app.Run();
            #endregion

        }

    }
}
