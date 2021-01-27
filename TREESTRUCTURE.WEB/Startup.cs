using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TREESTRUCTURE.DB.DAL;
using TREESTRUCTURE.DB.Repositories;
using TREESTRUCTURE.DB.Repositories.Interfaces;
using TREESTRUCTURE.WEB.Profiles;
using TREESTRUCTURE.WEB.Services;
using TREESTRUCTURE.WEB.Services.Shared;

namespace TREESTRUCTURE.WEB
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

            services.AddDbContext<TreeContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("NodesConnection")));

            services.AddScoped<INodesRepo, NodesSqlRepo>();

            services.AddScoped<INodesService, NodesService>();

            services.AddAutoMapper(typeof(NodeProfile));
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
                    pattern: "{controller=Tree}/{action=Index}/{id?}");
            });
        }
    }
}
