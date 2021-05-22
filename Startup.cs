using System;
using System.Collections.Generic;
using System.Linq;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;
using BurseFMI.dbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using SendGrid;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.IO;
namespace BurseFMI
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


            
            // services.AddDbContext<BurseFMIContext>(config =>
            //  {
            //      config.UseSqlite("Filename=./BurseFMI3.db");
            //  });
            // services.AddIdentity<IdentityUser, IdentityRole>(config =>
            // {
            //     config.Password.RequiredLength = 4;
            //     config.Password.RequireDigit = false;
            //     config.Password.RequireNonAlphanumeric = false;
            //     config.Password.RequireUppercase = false;
            //     config.SignIn.RequireConfirmedEmail = true;
            // })
            //    .AddEntityFrameworkStores<BurseFMIContext>()
            //    .AddDefaultUI()
            //    .AddDefaultTokenProviders();
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
            services.AddScoped<ExternalResources>();
            services.AddTransient<SendMailService>();
            services.AddTransient<Strings>();
            services.AddTransient<GlobalMethods>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ExternalResources externalResources)
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
                // endpoints.MapControllers();
            });
            externalResources.SeedUserRolesAndAdministrator().Wait();
            // SeedData.Initialize(app.ApplicationServices);
        }
    }
    public class SendMailService
    {
        private IConfiguration _config;
        public SendMailService(IConfiguration config)
        {
            _config = config;
        }
        public async Task SendEmailAsync(string toEmail, string subject, string content)
        {
            var apiKey = _config["MAIL_API_KEY"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("adrian-constantin.avram@my.fmi.unibuc.ro", "IdentityRole");
            var to = new EmailAddress(toEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, content);
            var response = await client.SendEmailAsync(msg);
        }
    }
    public class GlobalMethods{
        public string convertMailToName(string Email){
           
            if(Email.Split('@')[0].Split('.').Length==1)
                {string onlyName=Email.Split('@')[0].Split('.')[0];
                    return char.ToUpper(onlyName.First()) + onlyName.Substring(1).ToLower();
            }
            string nume = Email.Split('@')[0].Split('.')[1];
            nume = char.ToUpper(nume.First()) + nume.Substring(1).ToLower();
        string prenume = Email.Split('@')[0].Split('.')[0].Split('-')[0];
        prenume = char.ToUpper(prenume.First()) + prenume.Substring(1).ToLower();
        
        return nume+" "+prenume;
        }
    }
    public class Strings{
        public string PENDING="IN ASTEPTARE";
        public string SUCCESS="ACCEPTAT";
        public string CONTESTATION="CONTESTATIE";
        public string FAILED="REFUZAT";
    }
    public class ExternalResources
    {
        private IConfiguration _config;
        
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<IdentityUser> _userManager;

        public string[] secretariat { get; set; }
        public string[] comisie { get; set; }
        public string [] files {get;set;}
        public string admin { get; set; }

        public ExternalResources(IConfiguration config,RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {   _roleManager=roleManager;
            _userManager=userManager;
            _config = config;
            secretariat = _config["Secretariat"].Split(',');
            admin = _config["Admin"];
            comisie = _config["Comisie"].Split(',');
            // Console.WriteLine(Directory.Exists("C:\\Users\\Avram\\Desktop\\Burse-App\\liste")+"BRRRRRRRRRRRRRRRR");
            files = Directory.GetFiles("C:\\Users\\Avram\\Desktop\\Burse-App\\liste", "*.csv");

        }   
        
        public async Task SeedUserRolesAndAdministrator()
        {


            // var roleManager=services.GetRequiredService<RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_appDbContext))>




            if (!await _roleManager.RoleExistsAsync("Disabled"))
            {
                var newRole = new IdentityRole();
                newRole.Name = "Disabled";
                await _roleManager.CreateAsync(newRole);
            }
            if (!await _roleManager.RoleExistsAsync("Student"))
            {
                var newRole = new IdentityRole();
                newRole.Name = "Student";
                await _roleManager.CreateAsync(newRole);
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                var newRole = new IdentityRole();
                newRole.Name= "Admin";
                await _roleManager.CreateAsync(newRole);
            }

            if (!await _roleManager.RoleExistsAsync("Secretar"))
            {
                var newRole = new IdentityRole();
                newRole.Name = "Secretar";
                await _roleManager.CreateAsync(newRole);
            }
            if (!await _roleManager.RoleExistsAsync("Comisie"))
            {
                var newRole = new IdentityRole();
                newRole.Name = "Comisie";
                await _roleManager.CreateAsync(newRole);
            }
            
        }
    }
}
