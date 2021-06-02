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
using Microsoft.EntityFrameworkCore;
using Web_BanXeMoTo.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Web_BanXeMoTo
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
            services.AddControllersWithViews();
<<<<<<< HEAD
            services.AddDbContext<QLMTContext>(options => options.UseSqlServer("Server=DESKTOP-1N34MNR;Database=QLMT;Trusted_Connection=True;"));
=======
            services.AddDbContext<QLMTContext>(options => options.UseSqlServer("Server=DESKTOP-I7EOLFR\\SQLEXPRESS;Database=QLMT;Trusted_Connection=True;"));
>>>>>>> master
            services.AddMvc();
            services.AddSession();
  
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(opt =>
             {
                 opt.LoginPath = "/";
                 opt.AccessDeniedPath = "/login";
                 opt.ReturnUrlParameter = "returnUrl";
                 opt.LogoutPath = "/logout";
                 opt.ExpireTimeSpan = TimeSpan.FromMinutes(5);
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Customer}/{action=Home}/{id?}");
            });
        }
    }
}
