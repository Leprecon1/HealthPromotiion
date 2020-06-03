using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthPromotion.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace HealthPromotion
{
    public class Startup
    {

        private IConfigurationRoot Configuration;
        public Startup(IHostEnvironment hostEnvironment)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(hostEnvironment.ContentRootPath).AddJsonFile("DBsettings.json").Build();

        }
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddHttpContextAccessor();
            services.AddSession();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/Login");
                });



            services.AddMvc(o => {
                o.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
 
         
            app.UseRouting();
            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация

            app.UseMvc(route =>
            {
                route.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{Id?}");
            });
            
           
        }
    }
}
