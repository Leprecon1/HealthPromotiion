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
            app.UseMvcWithDefaultRoute();
         
            app.UseRouting();
            app.UseEndpoints(endpoint =>
            endpoint.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{Id?}"));

        }
    }
}
