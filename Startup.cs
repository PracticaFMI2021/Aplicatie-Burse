
using BurseFMI.dbModels;

using BurseFMI.services;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.OpenApi.Models;

namespace BurseFMI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {



            services.AddDbContext<BurseFMIContext>(config =>

                           config.UseNpgsql(Configuration.GetConnectionString("postgreConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
.AddDefaultTokenProviders().AddEntityFrameworkStores<BurseFMIContext>();
            services.ConfigureApplicationCookie(config =>
{
    config.Cookie.Name = "Identity.Cookie";
    config.LoginPath = "/Home/Welcome";

});


            services.AddControllers();
            services.AddRazorPages();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Test", Version = "v1" });
            });
            services.AddTransient<ExternalResources>();
            services.AddSingleton<SendMailService>();
            services.AddSingleton<Strings>();
            services.AddTransient<GlobalMethods>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ExternalResources externalResources)
        {



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test v1"));
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();

            });
            externalResources.SeedUserRolesAndAdministrator().Wait();

        }
    }




}
