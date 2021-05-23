using System;
using System.ComponentModel.DataAnnotations;

namespace BurseFMI.appModels{
 public class Result{
     [Key]
  
     public int ResultId { get; set; }
    [Required]
    [Display(Name="Treatment")]
    public string Diagnose { get; set; }
    [Required]
    [Display(Name="Treatment")]
    public string Treatment { get; set; }
    
    // public Dialog dialog{get;set;}
    public int? DialogId { get; set; }
    
    


 }   
}
