using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurseFMI.appModels{
    public class RegisterViewModel
    {   
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [ValidEmail(allowedDomain1:"s.unibuc.ro",allowedDomain2:"fmi.unibuc.ro",ErrorMessage="Email domain must be s.unibuc.ro or fmi.unibuc.ro")]
        public string email { get; set; }

        [Required]
        
        [DataType(DataType.Password)]
        [ValidPassword(ErrorMessage = "Password must contain at least 8 characters , one digit and one uppercase")]
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string lastName { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
       
        }
    
    public class ChangePasswordViewModel{
        [Required]
        [Display(Name="Current password")]
        public string currentPassword { get; set; }
        [Required]
        [Display(Name="New password")]
        public string newPassword { get; set; }
        [Required]
        [Display(Name="CNP/Special Code")]
        public long confirmCode { get; set; }
    }
    public class RecoverPasswordViewModel{
        [Required]
        [Display(Name="Email")]
        public string username { get; set; }
        [Required]
        [Display(Name="New password")]
        public string newPassword { get; set; }
        
    }
    public class LoginViewModel{
        [Required]
        public string username { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

    }
    public class NewMessageModel{
        
        [Required]
        [MaxLength(220)]
        [Display(Name = "New Message:")]
        public string message{get;set;}
        [Required]
        [MaxLength(220)]
        [Display(Name = "Doctor:")]
        public string doctorId{get;set;}
        public List<SelectListItem> selectListItems{get;set;}

        

    }
    public class DetailsViewModel{
        [Display(Name = "Last Name:")]
        [Required]
        public string lastName { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "First Name:")]
        public string firstName { get; set; }
         
        [Required]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string email { get; set; }
        [Display(Name="Username:")]
        public string username{get;set;}

    }
   

}