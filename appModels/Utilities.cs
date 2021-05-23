using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
// using BurseFMI.Controllers;
namespace BurseFMI.appModels{
        public class ValidEmail:ValidationAttribute{
            private readonly string allowedDomain1;
        private readonly string allowedDomain2;
            public ValidEmail(string allowedDomain1,string allowedDomain2){
                // this.allowedDomain=allowedDomain;
                this.allowedDomain1=allowedDomain1;
                this.allowedDomain2=allowedDomain2;
            }
            public override bool IsValid(object value){
                if(value!=null)
                {string[] firstSplit=value.ToString().Split('@');
                
                Console.WriteLine(firstSplit[1]);
                return (firstSplit[1].Equals(allowedDomain1)||firstSplit[1].Equals(allowedDomain2));}
                else
                return false;
            }
    }
    public class ValidCNP:ValidationAttribute{
        
            public override bool IsValid(object value){
               if(value!=null)
               return ((value.ToString().Length==10&&value.ToString().All(Char.IsDigit))?true:false);
               else
               return false;
                    
            }
    }
    public class ValidPassword : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            if(value!=null)
            return ((value.ToString().Length >8 && value.ToString().Any(char.IsUpper)&&value.ToString().Any(char.IsDigit)) ? true : false);
            else
            return false;
        }
    }
}