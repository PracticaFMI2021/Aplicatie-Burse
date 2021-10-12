
using System.Linq;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;
using SendGrid;

using Microsoft.Extensions.Configuration;

namespace BurseFMI.services{
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
            var from = new EmailAddress("adrian-constantin.avram@my.fmi.unibuc.ro", "Universitatea Bucuresti");
            var to = new EmailAddress(toEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, content);
            var response = await client.SendEmailAsync(msg);
        }
    }
}