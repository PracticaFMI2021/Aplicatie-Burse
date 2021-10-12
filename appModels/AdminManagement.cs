using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
namespace BurseFMI.appModels
{   
    public class UserManagementsModel{
        public List<string> fixbugs { get; set; }
        public List<UserManagementModel> userList { get; set;}
    }
    public class  UserManagementModel{
    [Display(Name = "Nume")]
    public string name;
        [Display(Name = "Email")]
        public string email;
        [Display(Name = "Rol curent")]
        public string role;
        [Display(Name = "Selecteaza rol")]
        public string newRole;
    public List<SelectListItem> selectListItems { get; set; }
 

    }
    public class CreateScholarshipModel
    {
        
        public List<SelectListItem> selectListItems { get; set; }
    [Required]
    [Display(Name = "Categoria")]
    public string Cod { get; set; }

        [Required]
        [Display(Name = "Tip")]
    public string Tip { get; set; }
    [Required]
        [Display(Name = "DataLimitaSolicitare")]

    public string DataLimitaSolicitare { get; set; }
        [Required]
        [Display(Name = "DataLimitaRecenzie")]
    public string DataLimitaRecenzie { get; set; }
        [Required]
        [Display(Name = "DataLimitaContestatie")]
    public string DataLimitaContestatie { get; set; }
        [Required]
        [Display(Name = "DataInceput")]
    public string DataInceput { get; set; }
        [Required]
        [Display(Name = "DataFinal")]
    public string DataFinal { get; set; }
        [Required]
        [Display(Name = "Descriere")]
    public string Descriere { get; set; }
        [Required]
        [Display(Name = "Suma")]
    public double? Suma { get; set; }
        [Required]
        [Display(Name = "Buget")]
    public double? Buget { get; set; }
        [Required]
        [Display(Name = "NrBurse")]
    public int? NrBurse { get; set; }
        
    }
    
}