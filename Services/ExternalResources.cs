using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

using System.IO;
namespace BurseFMI.services{
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