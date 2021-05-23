﻿using BurseFMI.appModels;
using BurseFMI.dbModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.JsonPatchd;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.FileIO;
using System.Web;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BurseFMI.Controllers
{
    public class HomeController : Controller
    {
            
        public static int authorizeCode = 1010111;
        private readonly BurseFMIContext _context;
        private readonly GlobalMethods _globalMethods;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly SendMailService _sendMailService;
        private readonly ExternalResources _externalResources;
        private  string currentUser;
        private string username;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> _roleManager;

        public HomeController(
            Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
            Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager,
            SendMailService sendMailService,
            ExternalResources externalResources,
            BurseFMIContext context,
            GlobalMethods globalMethods)
        {   _sendMailService = sendMailService;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _globalMethods = globalMethods;
            _signInManager = signInManager;
            _externalResources = externalResources;



        }
       
        public IActionResult Index()
        {   
            return RedirectToAction(nameof(Login));
        }
        
        
        
        // public Itable getStatus(string username)
        // {
        //     var patient = _context.Patients.Include(Patient => Patient.User).Where(Predicate => Predicate.User.UserName.Equals(username)).FirstOrDefault();
        //     if (patient!=null)
        //     {
        //         var patientUsername = _context.PatientsSettings.Include(PS => PS.Patient).Where(Predicate => Predicate.PatientId.Equals(patient.PatientId).FirstOrDefault();
        //         return (patient);
        //     }
        //     else
        //     {
        //         var doctor = _context.Doctors.Include(Doctor => Doctor.User).Where(Predicate => Predicate.User.UserName.Equals(username)).FirstOrDefault();
        //         return doctor;
        //     }
        // }

            // [Authorize(Roles = "Student,Secretar,Admin,Comisie")]

            public async Task<IActionResult> Welcome()
            {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            var roles=await _userManager.FindByNameAsync(User.Identity.Name);
            var myRoles=await _userManager.GetRolesAsync(roles);
            Console.WriteLine(myRoles.Count+"MY ROLESSSSSSSSSSSS");
            Console.WriteLine(myRoles[0]+"ROLESSS");
            ViewBag.role=myRoles[0];
            if(myRoles[0].Equals("Student"))
            return RedirectToAction("Welcome","Student");
            else
            return RedirectToAction("Welcome","Employee");


        }
            // Itable myStatus = getStatus(username);
            // if(myStatus is Doctor)
            // {
            //     Doctor dctr=(Doctor)myStatus;
            //     return View((username,dctr.FirstName+" "+dctr.LastName,"Doctor"));
            // }
            // else{
            //     Patient petn=(Patient)myStatus;
            //     return View((username,petn.FirstName+" "+petn.LastName,"notDoctor"));
            // }
            
            
        public IActionResult Login()
        {   if(User.Identity.IsAuthenticated)
            {   
                return RedirectToAction("Index");
            }
            
            return View();
        }

       
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {   if (!ModelState.IsValid)
            {
                return View();
            }
     
            var user = await _userManager.FindByNameAsync(login.username);

            if (user != null)
            {
                //sign in
                var signInResult = await _signInManager.PasswordSignInAsync(user, login.password, false, false);

                if (signInResult.Succeeded)
                {   
                    
                    return RedirectToAction("Welcome",new {username=login.username});
                }
            }
            ModelState.AddModelError("","Wrong username or password");
            return View();
        }
        
        public IActionResult Register()
        { 
             if(User.Identity.IsAuthenticated)
            {   
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult RecoverPassword(){
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
     
        
        [HttpPost]
        public async Task<IActionResult> RecoverPassword(RecoverPasswordViewModel recover)
        {  if (!ModelState.IsValid)
            {
                return View();
            }
            

            var foundUser = await _userManager.FindByNameAsync(recover.username);
  

                if (foundUser != null)
                {
                    var codeResetPass = await _userManager.GeneratePasswordResetTokenAsync(foundUser);
                    var codeEmail = await _userManager.GenerateEmailConfirmationTokenAsync(foundUser);
                    
                    var link = Url.Action(nameof(VerifyNewPassword), "Home", new { userId = foundUser.Id, codeEmail,codeResetPass,recover.newPassword }, Request.Scheme, Request.Host.ToString());
                // await _emailService.SendAsync("userTest@testmail.com", "email verify", $"<a href=\"{link}\">Verify Email</a>", true);
                    await _sendMailService.SendEmailAsync("aditaavram19@gmail.com", "Recover password", $"Hi!<br>Please verify your email in order to confirm your new password.<br>In the case you didn't send this request , please ignore this email.<br><a href=\"{link}\">Verify Email</a>");
                ViewBag.message = "Please confirm your new password via email";
                return View();
                // if(result.Succeeded)
                //     {ViewBag.message = "Success";
                //     return View();}
                }
            
            ModelState.AddModelError("","Wrong data entry");
            return View();
        }
        
        

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel register) 
        {   List<string> role=new List<string>();
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {   
                
                   for(int i=0;i<_externalResources.secretariat.Length;++i)
                        Console.WriteLine(_externalResources.secretariat[i]);
                    Console.WriteLine("IS TRUE?  "+_externalResources.secretariat.Contains(register.email));
                    if(_externalResources.admin.Equals(register.email))
                        {role.Add("Admin");}
                    if (_externalResources.secretariat.Contains(register.email))
                        {role.Add("Secretar");Console.WriteLine(role.Count+"ROLLLL INSIDE SECRETARR"+role[0]);
                        }
                    if (_externalResources.comisie.Contains(register.email))
                        role.Add("Comisie");
                    if(role.Count()==0)
                       { role.Add("Student");
                        Student student = _context.Students.Where(ie=>ie.Email.Equals(register.email)).FirstOrDefault();
                        if(student==null)
                        {ModelState.AddModelError("", "Invalid email");
                        return View();
                        }
                       }
                var user = new IdentityUser { UserName=register.email, Email = register.email, };

                var result = await _userManager.CreateAsync(user, register.password);
                if (SavedChanges()&&result.Succeeded)
                    {for(int i=0;i<role.Count();++i)
                        Console.WriteLine("ROLE=",role[i]);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var action="create_account";
                    var link = Url.Action(nameof(VerifyEmail), "Home", new { userId = user.Id, code,role }, Request.Scheme, Request.Host.ToString());
                    await _sendMailService.SendEmailAsync("aditaavram19@gmail.com","Email verification",$"Hi!<br>Please verify your email in order to confirm your new account.<br>In the case you didn't send this request , please ignore this email.<br><a href=\"{link}\">Verify Email</a>");
                    // await _emailService.SendAsync("userTest@testmail.com", "email verify", $"<a href=\"{link}\">Verify Email</a>", true);

                    ViewBag.message = "Please confirm your account via email";
                    return View(nameof(Register));}
                
                else{
                    ModelState.AddModelError("", "Email already exists");
                return View();
                }
            }


        }
        
        public async Task<IActionResult> VerifyEmail(string userId, string code,List<string> role)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user==null) return BadRequest();


            var result = await _userManager.ConfirmEmailAsync(user, code);
            Console.WriteLine("ROLURI ",role.Count(),"count  ",role.Count());
            if (result.Succeeded)
            {   for(int i=0;i<role.Count();++i)
                {   Console.WriteLine(role[i]);
                    await _userManager.AddToRoleAsync(user, role[i]);}
               
                return View();
            }
            

            return BadRequest();
        }
        public async Task<IActionResult> VerifyNewPassword(string userId, string codeEmail, string codeResetPass,string newPassword)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user==null) return BadRequest();


            var result = await _userManager.ConfirmEmailAsync(user, codeEmail);

            if (result.Succeeded)
            {
                await _userManager.ResetPasswordAsync(user, codeResetPass,newPassword);

                return View(nameof(VerifyEmail));
            }


            return BadRequest();
        }

        public IActionResult EmailVerification() => View();

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        public bool SavedChanges()
        {   
            return (_context.SaveChanges() >= 0);
        }
    }
}
