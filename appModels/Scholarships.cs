using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using BurseFMI.dbModels;
using System;
namespace BurseFMI.appModels{
    public class ViewScholarshipsModel
    {
        
        public string category { get; set; }

        public List<SolicitareSummaryModel> sholarshipRequests { get; set; }
        public List<SelectListItem> selectListScholarships { get; set; }
        public List<SelectListItem> selectListGroups { get; set; }
        public string scholarshipType{ get; set;}
        public string groupType { get; set; }


    }
    public class SolicitareSummaryModel{
        public string CodMatricol { get; set; }
        public double? MedieDepartajare { get; set; }
        public double? MedieGenAnAnterior { get; set; }
        public double? MedieGenSemAnterior { get; set; }
        public double? MedieAdmitere { get; set; }
        public double? MedieBac { get; set; }
        public string NumeStudent{get;set;}
        public string CodBursa { get; set; }
        public DateTime? DataSolicitare { get; set; }
        public DateTime? DataUltimeiModificari { get; set; }
        public string Status { get; set; }
    }
 public class ReplyModel{
        [Required]
        [MaxLength(250)]
        [Display(Name = "Write message:")]
        public string newMessage{get;set;}
        public string messages { get; set; }
        // public Dialog dialog{get;set;}
        public string adjustName{get;set;}
    }
    
    
    public class DeadlineModel{
        public bool beforeDeadlineReview { get; set; }
        public bool beforeDeadlineContest { get; set; }
        public bool beforeDeadlineRequest { get; set; }
        public bool beforeDeadlineFinal { get; set; }
        public bool afterStartingDate { get; set; }
    }
    public  class RequestScholarshipModel
    {   public string CurrentViewer{get;set;}
        public bool beforeDeadlineReview { get; set; }
        public string ? selectedRequest { get; set; }
        public string Observatii{get;set;}
        public List<SelectListItem> selectListItems { get; set; }
        
        
        [Display(Name = "CodMatricol:")]
        public string CodMatricol { get; set; }
        [Required]

        [Display(Name = "TipBursa:")]
        public string TipBursa { get; set; }
        [Required]
        [Display(Name = "Testare:")]
        public DateTime Testare { get; set; }
        [Display(Name = "AnInmatriculare:")]
        public int? AnInmatriculare { get; set; }
        [Display(Name = "VenitLunarMembru:")]
        public int? VenitLunarMembru { get; set; }
        [Display(Name = "VenitLunarMembruSecretar:")]
        public int? VenitLunarMembruSecretar { get; set; }
        

        [Display(Name = "ContributiiStiintifice:")]
        public BitArray ContributiiStiintifice { get; set; }
        

        [Display(Name = "DiplomePremii:")]
        public BitArray DiplomePremii { get; set; }
        [Required]

        [Display(Name = "AcordGdpr:")]
        public bool AcordGdpr { get; set; }
        [Required]

        [Display(Name = "NumeArhivaDocsSociala:")]
        public string NumeArhivaDocsSociala { get; set; }
        [Required]

        [Display(Name = "CaleArhiva:")]
        public string CaleArhiva { get; set; }
        [Required]

        [Display(Name = "TipArhiva:")]
        public string TipArhiva { get; set; }
        [Required]

        [Display(Name = "Cnp:")]
        public string Cnp { get; set; }
        [Required]

        [Display(Name = "AlteDetalii:")]
        public string AlteDetalii { get; set; }
        [Required]

        [Display(Name = "Iban:")]
        public string Iban { get; set; }
        [Required]

        [Display(Name = "NumeFisierExtrasCont:")]
        public string NumeFisierExtrasCont { get; set; }
        [Required]

        [Display(Name = "CaleExtrasCont:")]
        public string CaleExtrasCont { get; set; }
        
        [Display(Name = "Nume fisier:")]
        public string NumeFisierDeclAcceptare { get; set; }
        
        [Display(Name = "Cale fisier:")]
        public BitArray CaleFisier { get; set; }
        
        [Display(Name = "Motiv:")]
        public string Motiv { get; set; }
        
        [Display(Name = "Status:")]
        public string Status { get; set; }
        
        [Display(Name = "Observatii contestatie:")]
        public string ObservatiiSefComisie { get; set; }
        public string StatusSolicitare { get; set; }
        [Display(Name = "Status contestatie:")]
        public string StatusContestatie { get; set; }

    }
    
    public class ContestScholarshipModel{
    public string CodMatricol { get; set; }
    public string CodBursa { get; set; }
    
    }
    public class ApprovedScholarshipModel{
        public string CodMatricol { get; set; }
        public string CodBursa { get; set; }
        

    }
}