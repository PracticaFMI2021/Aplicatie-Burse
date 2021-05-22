using BurseFMI.appModels;
using BurseFMI.dbModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.JsonPatch;
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
    public class StudentController : Controller
    {
        private readonly Strings _strings;
        private readonly BurseFMIContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly GlobalMethods _globalMethods;
        private readonly SendMailService _sendMailService;
        private readonly ExternalResources _externalResources;
        private string currentUser;
        private string username;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> _roleManager;
        public StudentController(
                Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
                Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager,
                SignInManager<IdentityUser> signInManager,
                SendMailService sendMailService,
                ExternalResources externalResources,
                BurseFMIContext context,
                Strings strings,
                GlobalMethods globalMethods)
        {
            _strings = strings;
            _sendMailService = sendMailService;
            _context = context;
            _userManager = userManager;
            _globalMethods = globalMethods;
            _signInManager = signInManager;
            _externalResources = externalResources;

        }
        public IActionResult Welcome()
        {
            ViewBag.Name=_globalMethods.convertMailToName(User.Identity.Name);
            
            DeadlineModel deadlineModel = new DeadlineModel
            {
                
                beforeDeadlineRequest=beforeDeadlineRequest(),
                afterStartingDate=afterStartingDate()
            };
            Console.WriteLine(afterStartingDate()+" "+!beforeDeadlineRequest());
            return View(deadlineModel);
        }
        public bool SavedChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public List<SelectListItem> getScholarshipLists()
        {
            Student student = _context.Students.Where(ie => ie.Email.Equals(User.Identity.Name)).FirstOrDefault();
            Specializare specializare = _context.Specializares.Where(ie => ie.Acronim.Equals(student.Acronim)).FirstOrDefault();
            List<SelectListItem> dr = new List<SelectListItem>();
            Solicitare solicitare = null;
            foreach (Bursa bursa in _context.Bursas.ToList())
            {
                solicitare = _context.Solicitares.Where(ie => ie.CodMatricol.Equals(student.CodMatricol)&&ie.CodBursa.Equals(bursa.Cod)).FirstOrDefault();
                Console.WriteLine("HEEEEEEiII");
                if (solicitare!= null)
                    continue;
                var text = bursa.Tip;
                var value = bursa.Tip;
                SelectListItem newElement = new SelectListItem() { Text=text, Value=value };
                if (!dr.Contains(newElement)&&bursa.Cod.Split(" ")[0].Equals(specializare.ProgramStudii+"-"+student.Acronim+"-"+student.AnCurent))
                { dr.Add(newElement); }
            }
            Console.WriteLine("RIGHT HERE????"+dr.Count());
            return dr;
        }
        [Authorize(Roles = "Student")]
        public IActionResult ViewScholarshipRequests()
        {
            DeadlineModel deadlineModel = new DeadlineModel{
                beforeDeadlineContest=beforeDeadlineContestation() ,
                beforeDeadlineFinal=beforeFinalDeadline() ,
                beforeDeadlineRequest=beforeDeadlineRequest() ,
            
            };
            Console.WriteLine(beforeFinalDeadline());
            Student student = _context.Students.Where(ie => ie.Email.Equals(User.Identity.Name)).FirstOrDefault();

            return View((_context.Solicitares.Where(ie => ie.CodMatricol.Equals(student.CodMatricol)).ToList(),deadlineModel));
        }
        public Bursa getFirstDateToCompare()
        {   
            Student student = _context.Students.Where(ie => ie.Email.Equals(User.Identity.Name)).FirstOrDefault();
            Specializare specializare = _context.Specializares.Where(ie => ie.Acronim.Equals(student.Acronim)).FirstOrDefault();
            var mockLocalData="Merit";
            Bursa requestedBursa = _context.Bursas.Where(ie => ie.Cod.Equals(specializare.ProgramStudii+"-"+student.Acronim+"-"+student.AnCurent+" "+mockLocalData)).FirstOrDefault();
           
            return requestedBursa;
        }
        public bool afterStartingDate()
        {
            Console.WriteLine(DateTime.Compare(getFirstDateToCompare().DataInceput.Value, DateTime.Now));
            return DateTime.Compare(getFirstDateToCompare().DataInceput.Value, DateTime.Now)<=0 ? true : false;
        }
        public bool beforeDeadlineRequest()
        {
            Console.WriteLine(DateTime.Compare(getFirstDateToCompare().DataLimitaSolicitare.Value, DateTime.Now)+ "AOC");
            return DateTime.Compare(getFirstDateToCompare().DataLimitaSolicitare.HasValue ? getFirstDateToCompare().DataLimitaSolicitare.Value : DateTime.Now, DateTime.Now)>=0 ? true : false;
        }
       
        public bool beforeDeadlineContestation()
        {

            return DateTime.Compare(getFirstDateToCompare().DataLimitaContestatie.HasValue ? getFirstDateToCompare().DataLimitaContestatie.Value : DateTime.Now, DateTime.Now)>=0 ? true : false;
        }
        public bool beforeFinalDeadline()
        {
            Console.WriteLine(getFirstDateToCompare().DataFinal.Value);
            return DateTime.Compare(getFirstDateToCompare().DataFinal.HasValue ? getFirstDateToCompare().DataFinal.Value : DateTime.Now, DateTime.Now)>=0 ? true : false;
        }
        [Authorize(Roles = "Student")]
        public IActionResult RequestScholarship()
        {
            if (afterStartingDate()==false||beforeDeadlineRequest()==false)
                return RedirectToAction(nameof(Welcome));
            RequestScholarshipModel requestScholarshipModel = new RequestScholarshipModel();
            requestScholarshipModel.selectListItems=getScholarshipLists();
            return View(requestScholarshipModel);
        }
        [Authorize(Roles = "Student")]
        [HttpPost]
        public async Task<IActionResult> RequestScholarship(RequestScholarshipModel newScholarship)
        {
            if (afterStartingDate()==false||beforeDeadlineRequest()==false)
                return RedirectToAction(nameof(Welcome));
            if (!ModelState.IsValid||newScholarship.AcordGdpr!=true)
            {
                newScholarship.selectListItems=getScholarshipLists();
                ModelState.AddModelError("", "Trebuie se accepti termenii si conditiile");
                return View(newScholarship);
            }
            Student student = _context.Students.Where(ie => ie.Email.Equals(User.Identity.Name)).FirstOrDefault();
            Console.WriteLine(User.Identity.Name);
            Specializare specializare = _context.Specializares.Where(ie => ie.Acronim.Equals(student.Acronim)).FirstOrDefault();
            Completate completate = _context.Completates.Where(ie => ie.CodMatricol.Equals(student.CodMatricol)).FirstOrDefault();
            if (completate==null)
            {
                completate = new Completate
                {
                    CodMatricol=student.CodMatricol,
                    CodMatricolNavigation=student,
                    AnInmatriculare=newScholarship.AnInmatriculare,
                    VenitLunarMembru=newScholarship.VenitLunarMembru,
                    VenitLunarMembruSecretar=newScholarship.VenitLunarMembruSecretar,
                    ContributiiStiintifice=newScholarship.ContributiiStiintifice,
                    DiplomePremii=newScholarship.DiplomePremii,
                    AcordGdpr=newScholarship.AcordGdpr.ToString(),
                    NumeArhivaDocsSociala=newScholarship.NumeArhivaDocsSociala,
                    CaleArhiva=newScholarship.CaleArhiva,
                    TipArhiva=newScholarship.TipArhiva,
                    Cnp=newScholarship.Cnp,
                    AlteDetalii=newScholarship.AlteDetalii,
                    Iban=newScholarship.Iban,
                    NumeFisierExtrasCont=newScholarship.NumeFisierExtrasCont,
                    CaleExtrasCont=newScholarship.CaleExtrasCont,

                };
                _context.Completates.Add(completate);
            }

            student.Completate=completate;

            Bursa requestedBursa = _context.Bursas.Where(ie => ie.Cod.Equals(specializare.ProgramStudii+"-"+student.Acronim+"-"+student.AnCurent+" "+newScholarship.TipBursa)).FirstOrDefault();
            Console.WriteLine(specializare.ProgramStudii+"-"+student.Acronim+"-"+student.AnCurent+" "+newScholarship.TipBursa);
            Solicitare solicitare = new Solicitare
            {
                CodMatricol=student.CodMatricol,
                CodBursa=requestedBursa.Cod,
                DataSolicitare=DateTime.Now,
                Status=_strings.PENDING,
                CodMatricolNavigation=student,
                CodBursaNavigation=requestedBursa



            };
            Console.WriteLine("FREEEE");
            _context.Solicitares.Add(solicitare);
            SavedChanges();
            Console.WriteLine("BBREEEEEe");
            student.Solicitares.Add(solicitare);


            _context.Students.Update(student);
            if (SavedChanges())
            {
                return RedirectToAction(nameof(ViewScholarshipRequests));
            }
            ModelState.AddModelError("", "Wrong data entry");
            return View();
        }
        [Authorize(Roles = "Student")]
        public IActionResult ModifyScholarshipRequest(string selectedRequest)
        {

            string[] solicitare_pkeys = selectedRequest.Split('_');

            Completate completate = _context.Completates.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])).FirstOrDefault();
            Solicitare solicitare = _context.Solicitares.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
            Bursa bursa = _context.Bursas.Where(ie => ie.Cod.Equals(solicitare_pkeys[1])).FirstOrDefault();

            if (solicitare.Status.Equals(_strings.FAILED)&&!beforeDeadlineContestation())
                return RedirectToAction(nameof(Welcome));
            if (!beforeFinalDeadline()) { return RedirectToAction(nameof(Welcome)); }
            RequestScholarshipModel requestScholarshipModel = new RequestScholarshipModel
            {
                AcordGdpr=true,
                TipBursa=bursa.Tip,
                selectedRequest=selectedRequest,
                AnInmatriculare=completate.AnInmatriculare,
                AlteDetalii=completate.AlteDetalii,
                CaleArhiva=completate.CaleArhiva,
                CaleExtrasCont=completate.CaleExtrasCont,
                Cnp=completate.Cnp,
                CodMatricol=completate.CodMatricol,
                ContributiiStiintifice=completate.ContributiiStiintifice,
                CurrentViewer="Student",
                DiplomePremii=completate.DiplomePremii,
                Iban=completate.Iban,
                NumeArhivaDocsSociala=completate.NumeArhivaDocsSociala,
                NumeFisierExtrasCont=completate.NumeFisierExtrasCont,
                TipArhiva=completate.TipArhiva,
                VenitLunarMembru=completate.VenitLunarMembru,
                VenitLunarMembruSecretar=completate.VenitLunarMembruSecretar,
                StatusSolicitare=solicitare.Status,
                Observatii=solicitare.ObservatiiSecretar+"\n \n"+solicitare.ObservatiiSefComisie

            };
            Contesta contesta = _context.Contestas.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
            if (contesta!=null)
            {


                requestScholarshipModel.Motiv=contesta.Motiv;
                requestScholarshipModel.StatusContestatie=_strings.PENDING;
                requestScholarshipModel.ObservatiiSefComisie=contesta.ObservatiiSefComisie;


            }
            Beneficiaza beneficiaza = _context.Beneficiazas.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
            if (beneficiaza!=null)
            {


                requestScholarshipModel.NumeFisierDeclAcceptare=beneficiaza.NumeFisierDeclAcceptare;
                requestScholarshipModel.CaleFisier=beneficiaza.CaleFisier;


            }

            requestScholarshipModel.selectListItems=getScholarshipLists();

            return View(requestScholarshipModel);
        }
        public IActionResult AcordGdpr()
        {
            return View();
        }
        [Authorize(Roles = "Student")]
        [HttpPost]
        public async Task<IActionResult> ModifyScholarshipRequest(RequestScholarshipModel modifiedScholarship)
        {
            if (!ModelState.IsValid)
            {
                return View(modifiedScholarship);
            }
            string[] solicitare_pkeys = modifiedScholarship.selectedRequest.Split('_');
            Student student = _context.Students.Where(ie => ie.Email.Equals(User.Identity.Name)).FirstOrDefault();
            Completate completate = _context.Completates.Where(ie => ie.CodMatricol.Equals(student.CodMatricol)).FirstOrDefault();
            Solicitare solicitare = _context.Solicitares.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
          
            if (solicitare.Status.Equals(_strings.FAILED)&&!beforeDeadlineContestation())
                return RedirectToAction(nameof(Welcome));
            if (!beforeFinalDeadline()) { return RedirectToAction(nameof(Welcome)); }
            student.Solicitares.Remove(solicitare);
            Completate completateToCompare = completate;
            completate.CodMatricol=student.CodMatricol;
            completate.CodMatricolNavigation=student;
            completate.AnInmatriculare=modifiedScholarship.AnInmatriculare;
            completate.VenitLunarMembru=modifiedScholarship.VenitLunarMembru;
            completate.VenitLunarMembruSecretar=modifiedScholarship.VenitLunarMembruSecretar;
            completate.ContributiiStiintifice=modifiedScholarship.ContributiiStiintifice;
            completate.DiplomePremii=modifiedScholarship.DiplomePremii;
            completate.AcordGdpr=modifiedScholarship.AcordGdpr.ToString();
            completate.NumeArhivaDocsSociala=modifiedScholarship.NumeArhivaDocsSociala;
            completate.CaleArhiva=modifiedScholarship.CaleArhiva;
            completate.TipArhiva=modifiedScholarship.TipArhiva;
            completate.Cnp=modifiedScholarship.Cnp;
            completate.AlteDetalii=modifiedScholarship.AlteDetalii;
            completate.Iban=modifiedScholarship.Iban;
            completate.NumeFisierExtrasCont=modifiedScholarship.NumeFisierExtrasCont;
            completate.CaleExtrasCont=modifiedScholarship.CaleExtrasCont;
            solicitare.DataUltimeiModificari=DateTime.Now;
            if (!DeepEquals(completateToCompare, completate))
            {

                _context.Completates.Update(completate);
                _context.Solicitares.Update(solicitare);

            }
            student.Completate=completate;

            student.Solicitares.Add(solicitare);
            _context.Completates.Update(completate);
            _context.Students.Update(student);


            if (solicitare.Status.Equals(_strings.FAILED))
            {
                Contesta contesta = _context.Contestas.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
                if (contesta==null)
                {
                    contesta=new Contesta
                    {
                        CodMatricol=solicitare_pkeys[0],
                        CodBursa=solicitare_pkeys[1],
                        DataContestatie=DateTime.Now,
                        Motiv=modifiedScholarship.Motiv,
                        Status=_strings.PENDING

                    };
                    _context.Contestas.Add(contesta);
                }
                else
                {
                    contesta.Motiv=modifiedScholarship.Motiv;
                    _context.Contestas.Update(contesta);
                }
            }
            if (solicitare.Status.Equals(_strings.SUCCESS))
            {
                Beneficiaza beneficiaza = _context.Beneficiazas.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
                if (beneficiaza==null)
                {
                    beneficiaza=new Beneficiaza
                    {
                        CodMatricol=solicitare_pkeys[0],
                        CodBursa=solicitare_pkeys[1],
                        DataValidare=DateTime.Now,
                        NumeFisierDeclAcceptare=modifiedScholarship.NumeFisierDeclAcceptare,
                        CaleFisier=modifiedScholarship.CaleFisier

                    };
                    _context.Beneficiazas.Add(beneficiaza);
                }

            }

            if (SavedChanges())
            {
                ViewBag.message = "Success";
                return RedirectToAction(nameof(ViewScholarshipRequests));
            }
            ModelState.AddModelError("", "Wrong data entry");
            return RedirectToAction(nameof(ModifyScholarshipRequest), new { selectedRequest = modifiedScholarship.selectedRequest });
        }
        [Authorize(Roles = "Student")]
        public IActionResult ContestScholarshipRequest(string selectedRequest)
        {
            string[] requestData = selectedRequest.Split('_');
            ContestScholarshipModel contestModel = new ContestScholarshipModel()
            {
                CodMatricol=requestData[0],
                CodBursa=requestData[1]
            };
            return View(contestModel);
        }

        public IActionResult ViewScholarships() { return View(_context.Solicitares.ToList()); }
        // [HttpPost]
        // [Authorize(Roles = "Student")]
        // public async Task<IActionResult> ContestScholarshipRequest(ContestScholarshipModel contestModel){
        //     if(!ModelState.IsValid){
        //         return View(contestModel);
        //     }
        //     Contesta contesta =new Contesta(){
        //         CodMatricol=contestModel.CodMatricol,
        //         CodBursa=contestModel.CodBursa,
        //         Motiv=contestModel.Motiv,
        //         Status=contestModel.Status,
        //     };
        //     _context.Contestas.Add(contesta);
        //     SavedChanges();
        //     return RedirectToAction(nameof(ViewScholarshipRequests));
        // }
        // [Authorize(Roles = "Student")]
        // public IActionResult ApprovedScholarshipRequest(string selectedRequest)
        // {
        //     string[] requestData = selectedRequest.Split('_');
        //     ApprovedScholarshipModel contestModel = new ApprovedScholarshipModel()
        //     {
        //         CodMatricol=requestData[0],
        //         CodBursa=requestData[1]
        //     };
        //     return View(contestModel);
        // }
        // [HttpPost]
        // [Authorize(Roles = "Student")]
        // public async Task<IActionResult> ApprovedScholarshipRequest(ApprovedScholarshipModel approvedModel)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return View(approvedModel);
        //     }
        //     Beneficiaza beneficiaza = new Beneficiaza()
        //     {
        //         CodMatricol=approvedModel.CodMatricol,
        //         CodBursa=approvedModel.CodBursa,
        //         DataValidare=DateTime.Now,
        //         NumeFisierDeclAcceptare=approvedModel.NumeFisierDeclAcceptare,
        //         CaleFisier=approvedModel.CaleFisier


        //     };
        //     _context.Beneficiazas.Add(beneficiaza);
        //     SavedChanges();
        //     return RedirectToAction(nameof(ViewScholarshipRequests));
        // }













        public static bool DeepEquals(object obj, object another)
        {

            if (ReferenceEquals(obj, another)) return true;
            if ((obj==null) || (another == null)) return false;
            // Comparing class of 2 objects, if different, then fail
            if (obj.GetType().ToString() != another.GetType().ToString()) return false;

            var result = true;
            // Get all properties of obj
            // then compare the value of each property
            foreach (var property in obj.GetType().GetProperties())
            {
                var objValue = property.GetValue(obj);
                var anotherValue = property.GetValue(another);
                if (!objValue.Equals(anotherValue)) result = false;
            }

            return result;
        }


    }
}