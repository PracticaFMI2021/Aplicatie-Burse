using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurseFMI.appModels{
         public class GenerateListModel{
        public List<int> degeaba{ get; set;}
        public string category {get;set;}
        public string [] headOfColumns{get;set;}

        public List<string[]> studentsData{get;set;}
        public ICollection<SelectListItem> selectListItems { get; set; }

        

    }
}
    