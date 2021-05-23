// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace BurseFMI.appModels{
//  public class ReplyModel{
//         [Required]
//         [MaxLength(250)]
//         [Display(Name = "Write message:")]
//         public string newMessage{get;set;}
//         public string messages { get; set; }
//         // public Dialog dialog{get;set;}
//         public string adjustName{get;set;}
//     }
//     public class DiagnoseModel{
//         [Required]
//         [MaxLength(250)]
//         [Display(Name = "Diagnose:")]
//         public string diagnose{get;set;}
//         [Required]
//         [MaxLength(250)]
//         [Display(Name = "Treatement:")]
//         public string treatement { get; set; }
        
//         public int dialogId{get;set;}

//     }
//     public class CardDetails{
//         public string lastMessage{get;set;}
//         public string doctor{get;set;}
//         public string patient{get;set;}
//         public string speaker{get;set;}
//         public int isChecked { get; set; }
//         public int dialogId{get;set;}


//     }
// }