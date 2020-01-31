using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaBox.DataAccess.Models;
using PizzaBox.DataAccess.Repositories;
using PizzaBox.Library.Interfaces;

namespace PizzaBox.WebUI
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
            var constr = Configuration.GetConnectionString("sqlConnection");
            services.AddDbContext<PizzaBoxContext>(options => options.UseSqlServer(constr));
            services.AddScoped<IRepository<PizzaBox.Library.Models.Pizza>, Repository<PizzaBox.Library.Models.Pizza>>();
            services.AddScoped<IRepository<PizzaBox.Library.Models.Inventory>, Repository<PizzaBox.Library.Models.Inventory>>();
            services.AddScoped<IRepository<PizzaBox.Library.Models.Store>, Repository<PizzaBox.Library.Models.Store>>();
            

            
            
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
