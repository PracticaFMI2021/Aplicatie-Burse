using BurseFMI.appModels;
using BurseFMI.dbModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using System.Web;
using System.Collections.Generic;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace BurseFMI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly BurseFMIContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly SendMailService _sendMailService;
        private readonly ExternalResources _externalResources;
        private readonly GlobalMethods _globalMethods;
        private readonly Strings _strings;
        private string currentUser;
        private string username;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> _roleManager;
        public EmployeeController(
                Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
                Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager,
                SignInManager<IdentityUser> signInManager,
                SendMailService sendMailService,
                ExternalResources externalResources,
                BurseFMIContext context,
                Strings strings,
                GlobalMethods globalMethods)
        {
            _sendMailService = sendMailService;
            _context = context;
            _globalMethods = globalMethods;
            _strings = strings;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _externalResources = externalResources;

        }
        public async Task<IActionResult> Welcome()
        {
            Console.WriteLine(_globalMethods.convertMailToName(User.Identity.Name));
            // return View((nameof(GenerateLists), await getUserRole()));
            return View((_globalMethods.convertMailToName(User.Identity.Name),await getUserRole()));
        }


        [Authorize(Roles = "Secretar")]
        public IActionResult GenerateLists()
        {


            GenerateListModel generateListModel = new GenerateListModel();
            generateListModel.selectListItems=getLists();
            generateListModel.degeaba=new List<int>{4,2,3};
            string[] nothing = new string[0];

            generateListModel.headOfColumns=nothing;
            return View(generateListModel);
        }
        public async Task<UserManagementsModel> getUsersManagement(){
            
            List<SelectListItem> dr = new List<SelectListItem>();
            List<string> ls=new List<string>();
            foreach (IdentityRole role in _roleManager.Roles.ToList())
            {
                
                dr.Add(new SelectListItem() { Text=role.Name, Value=role.Name });
            }
            List<UserManagementModel> userManagementModels = new List<UserManagementModel>();
            Console.WriteLine("BLEAAAAAh");
            for (int i=0;i<_userManager.Users.Count();i++)
            {   
                IdentityUser user=_userManager.Users.ToList()[i];
                if(user.Email.Equals("anca.dobrovat@fmi.unibuc.ro"))
                    continue;
                
                var roles = await _userManager.FindByNameAsync(user.UserName);
                var userRole = await _userManager.GetRolesAsync(roles);
                ls.Add(userRole[0]);
                Console.WriteLine(userRole[0]);
                UserManagementModel userManagementModel = new UserManagementModel
                {
                    selectListItems = dr,
                    email=user.Email,
                    name=_globalMethods.convertMailToName(user.Email),
                    role=userRole[0]
                    

                };
                userManagementModels.Add(userManagementModel);

            }
            UserManagementsModel userManagementsModel = new UserManagementsModel{userList=userManagementModels,fixbugs=ls};
            return userManagementsModel;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UserManagement()
        {
            Console.WriteLine("IIIIIIIIIIIIIIIIIIIIII");

            return View(await getUsersManagement());
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UserManagement(UserManagementsModel userManagementsModel){
            var x=await getUsersManagement();
            userManagementsModel.userList=x.userList;
            Console.WriteLine("AICI E IN POST");
            for (int i=0;i<userManagementsModel.userList.Count();i++)
            {   if (userManagementsModel.userList[i].email.Equals("anca.dobrovat@fmi.unibuc.ro"))
                    continue;
                var user = await _userManager.FindByNameAsync(userManagementsModel.userList[i].email);
                var userRole = await _userManager.GetRolesAsync(user);
                await _userManager.RemoveFromRolesAsync(user, userRole.ToArray());
                
                await _userManager.AddToRoleAsync(user, userManagementsModel.fixbugs[i]);
                Console.WriteLine(userManagementsModel.fixbugs[i]);
                
            }
           
            SavedChanges();
            return RedirectToAction(nameof(UserManagement));
        }
        public List<SelectListItem> getLists()
        {
            List<SelectListItem> dr = new List<SelectListItem>();
            foreach (string fileName in _externalResources.files)
            {
                var text = fileName.Split(@"\")[fileName.Split(@"\").Length-1].Split('.')[0];
                var value = fileName.Split(@"\")[fileName.Split(@"\").Length-1];
                dr.Add(new SelectListItem() { Text=text, Value=value });
            }
            return dr;
        }
        [Authorize(Roles = "Secretar")]
        [HttpPost]
        public async Task<IActionResult> GenerateLists(GenerateListModel generateList)
        {
            Console.WriteLine($"C:\\Users\\Avram\\Desktop\\Burse-App\\liste\\{generateList.category}"+"  EEEEU");

            

            using (TextFieldParser parser = new TextFieldParser($"C:\\Users\\Avram\\Desktop\\Burse-App\\liste\\{generateList.category}"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                var nr = 0;
                string[] headColumns = parser.ReadFields();
                var studentLists = new List<string[]>();
                var extraDetails = generateList.category.Split('-');
                foreach (Student entity in _context.Students.ToList())
                {
                    
                        IdentityUser user = _userManager.Users.Where(ie=>ie.Email.Equals(entity.Email)).FirstOrDefault();
                        if(user!=null)
                            continue;
                    if (entity.AnCurent==long.Parse(extraDetails[2].Split('.')[0])&&entity.Acronim.Trim()==extraDetails[1])
                    {   string codMatricol=entity.CodMatricol;
                        ImportSecretar importSecretar = _context.ImportSecretars.Where(ie => ie.CodMatricol==codMatricol).FirstOrDefault();
                        Specializare specializare = _context.Specializares.Where(ie => ie.Students.Contains(entity)&&ie.Acronim.Equals(extraDetails[1])).FirstOrDefault();
                        specializare.Students.Remove(entity);
                        
                        _context.ImportSecretars.Remove(importSecretar);
                        SavedChanges();
                        _context.Students.Remove(entity);
                        _context.Specializares.Update(specializare);
                        
                        SavedChanges();
                    }
                }

                while (!parser.EndOfData)
                {

                    string[] fields = parser.ReadFields();

                    
                    var student = new Student
                    {
                        Nume=fields[1],
                        Prenume=fields[2],
                        InitialaTata=fields[3],
                        CodMatricol=fields[4],
                        Acronim=extraDetails[1],
                        GrupaCurenta=int.Parse(fields[5]),
                        AnCurent=int.Parse(extraDetails[2].Split('.')[0]),
                        Email=fields[14]
                    };
                    studentLists.Add(fields);
                    IdentityUser user = _userManager.Users.Where(ie => ie.Email.Equals(student.Email)).FirstOrDefault();
                    if (user!=null)
                        continue;





                    var specializare = _context.Specializares.Where(ie => ie.Acronim.Equals(student.Acronim)).FirstOrDefault();
                    if (specializare==null)
                    {
                        specializare=new Specializare
                        {
                            Acronim=student.Acronim,
                            Domeniu=fields[6],
                            ProgramStudii=extraDetails[0],
                            NrStudenti=1,


                        };
                        specializare.Students.Add(student);
                        _context.Specializares.Add(specializare);
                    }
                    else
                    {
                        specializare.NrStudenti+=1;
                        _context.Specializares.Update(specializare);
                    }
                    student.AcronimNavigation=specializare;
                    var importSecretar = new ImportSecretar
                    {
                        CodMatricol=fields[4],
                        MedieGenAnAnterior=fields[10]!="" ? double.Parse(fields[10]) : null,
                        MedieGenSemAnterior=fields[11]!="" ? double.Parse(fields[11]) : null,
                        MedieAdmitere=double.Parse(fields[9]),
                        MedieBac=double.Parse(fields[8]),
                        CodMatricolNavigation=student
                    };
                    Console.WriteLine("CEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                    _context.Students.Add(student);
                    Console.WriteLine("PANA AICIIIIIIIIIIIIIIIIIII");
                    _context.ImportSecretars.Add(importSecretar);
                    Console.WriteLine("PANA AICIIIIIIIIIIIIIIIIIII");
                    SavedChanges();
                    Console.WriteLine("PANA AICIIIIIIIIIIIIIIIIIII");
                    
                }
                generateList.studentsData=studentLists;
                Console.WriteLine(generateList.studentsData.Count()+"NUMAR STUDENTIII");
                generateList.headOfColumns=headColumns;
                List<SelectListItem> dr = new List<SelectListItem>();
                foreach (string fileName in _externalResources.files)
                {
                    var text = fileName.Split(@"\")[fileName.Split(@"\").Length-1].Split('.')[0];
                    var value = fileName.Split(@"\")[fileName.Split(@"\").Length-1];
                    dr.Add(new SelectListItem() { Text=text, Value=value });
                }
                generateList.selectListItems=dr;
            }
            return View(generateList);
        }
        public bool SavedChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult CreateScholarship()
        {
            CreateScholarshipModel CreateScholarshipModel = new CreateScholarshipModel();
            CreateScholarshipModel.selectListItems=getLists();
            return View(CreateScholarshipModel);
        }
        public async Task<string> getUserRole()
        {
            var user= await _userManager.FindByNameAsync(User.Identity.Name);
            var myRoles = await _userManager.GetRolesAsync(user);
            return myRoles[0];
        }
        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public async Task<IActionResult> VerifyScholarshipRequest(string selectedRequest, string scholarshipType)
        {   
            string[] solicitare_pkeys = selectedRequest.Split('_');
            Solicitare solicitare=_context.Solicitares.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1]+" "+solicitare_pkeys[2])).FirstOrDefault();
            Completate completate = _context.Completates.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])).FirstOrDefault();
            Contesta contesta = _context.Contestas.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1]+" "+solicitare_pkeys[2])).FirstOrDefault();
            Beneficiaza beneficiaza = _context.Beneficiazas.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1]+" "+solicitare_pkeys[2])).FirstOrDefault();
            Bursa bursa = _context.Bursas.Where(ie => ie.Cod.Equals(solicitare_pkeys[1]+" "+solicitare_pkeys[2])).FirstOrDefault();
            RequestScholarshipModel requestScholarshipModel = new RequestScholarshipModel()
            {   
                AcordGdpr=true,
                AlteDetalii=completate.AlteDetalii,
                AnInmatriculare=completate.AnInmatriculare,
                CaleArhiva=completate.CaleArhiva,
                CaleExtrasCont=completate.CaleExtrasCont,
                Cnp=completate.Cnp,
                beforeDeadlineReview=DateTime.Compare(bursa.DataLimitaRecenzie.HasValue ? bursa.DataLimitaRecenzie.Value : DateTime.Now, DateTime.Now)>=0 ? true : false,
                NumeFisierDeclAcceptare=beneficiaza!=null ? beneficiaza.NumeFisierDeclAcceptare :null,
                CaleFisier=beneficiaza!=null ? beneficiaza.CaleFisier : null,
                Motiv=contesta!=null?contesta.Motiv:"",
                CodMatricol=completate.CodMatricol,
                Status=solicitare.Status,
                ContributiiStiintifice=completate.ContributiiStiintifice,
                DiplomePremii=completate.DiplomePremii,
                Iban=completate.Iban,
                NumeArhivaDocsSociala=completate.NumeArhivaDocsSociala,
                NumeFisierExtrasCont=completate.NumeFisierExtrasCont,
                StatusSolicitare=solicitare.Status,
                TipArhiva=completate.TipArhiva,
                TipBursa=scholarshipType,
                VenitLunarMembru=completate.VenitLunarMembru,
                VenitLunarMembruSecretar=completate.VenitLunarMembruSecretar
            };
            requestScholarshipModel.CurrentViewer=await getUserRole();
            return View(requestScholarshipModel);
        }
        [HttpPost]
        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public async Task<IActionResult> VerifyScholarshipRequest(RequestScholarshipModel modifiedScholarship)
        {   Console.WriteLine("IEEEE");
            if (!ModelState.IsValid)
            {   ModelState.AddModelError("", "Wrong data entry");
                return View(modifiedScholarship);
            }
            string[] solicitare_pkeys = modifiedScholarship.selectedRequest.Split('_');
            
            Student student = _context.Students.Where(ie => ie.CodMatricol.Equals(modifiedScholarship.CodMatricol)).FirstOrDefault();
            Completate completate = _context.Completates.Where(ie => ie.CodMatricol.Equals(student.CodMatricol)).FirstOrDefault();
            Solicitare solicitare = _context.Solicitares.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1]+" "+solicitare_pkeys[2])).FirstOrDefault();
            Contesta contesta = _context.Contestas.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])).FirstOrDefault();
            Console.WriteLine("AAAAA"+completate.CodMatricol);
            _context.Solicitares.Remove(solicitare);
            SavedChanges();
            Console.WriteLine("BBBBB"+solicitare.CodMatricol);
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
        
            if (!DeepEquals(completateToCompare, completate))
            {

                _context.Completates.Update(completate);
                solicitare.DataUltimeiModificari=DateTime.Now;

            }
            if (modifiedScholarship.Observatii.Length>0)
            {
                switch (await getUserRole())
                {
                    case "Secretar":
                        solicitare.ObservatiiSecretar=modifiedScholarship.Observatii;
                        break;
                    case "Comisie":
                        solicitare.ObservatiiSefComisie=modifiedScholarship.Observatii;
                        solicitare.DataUltimeiRecenziiSef=DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
            _context.Solicitares.Add(solicitare);
            student.Completate=completate;

            
            _context.Completates.Update(completate);
            _context.Students.Update(student);
            if (SavedChanges())
     
            Console.WriteLine("BREEEE"+solicitare.Status+" "+_strings.CONTESTATION+" "+solicitare.Status.Equals(_strings.CONTESTATION));
            if(solicitare.Status.Equals(_strings.FAILED))
            return RedirectToAction(nameof(ViewScholarshipsContest));
            if(solicitare.Status.Equals(_strings.SUCCESS))
                return RedirectToAction(nameof(ViewApprovedScholarships));
            return RedirectToAction(nameof(ViewScholarshipRequests));
        }
        public List<SelectListItem> getListScholarships(){
            List<SelectListItem> ls =new List<SelectListItem>();
            List<string> onlyCodes = new List<string>();
            foreach (var codBursa in _context.Bursas.Select(ie => ie.Cod))
            {
                onlyCodes.Add(codBursa.Split()[1]);
            }
            onlyCodes=onlyCodes.Distinct().ToList();
            foreach (var onlyCode in onlyCodes)
            {
                SelectListItem selectListItem = new SelectListItem { Text=onlyCode, Value=onlyCode };
                ls.Add(new SelectListItem { Text=onlyCode, Value=onlyCode });

            }
            return ls;
        }
        public ViewScholarshipsModel initiateViewScholarships()
        {
            ViewScholarshipsModel viewScholarshipsModel = new ViewScholarshipsModel();
            viewScholarshipsModel.selectListGroups=getLists();
            viewScholarshipsModel.sholarshipRequests=new List<SolicitareSummaryModel>();
            viewScholarshipsModel.selectListScholarships=getListScholarships();
            
        
            return viewScholarshipsModel;
        }
        public ViewScholarshipsModel postViewScholarships(ViewScholarshipsModel viewScholarshipsModel, string status)
        {   var nrBurse=_context.Bursas.Select(ie=>ie.NrBurse).FirstOrDefault();
            string groupType=viewScholarshipsModel.groupType.Split(".")[0];
            Console.WriteLine(groupType+" "+viewScholarshipsModel.scholarshipType);
            viewScholarshipsModel.sholarshipRequests=new List<SolicitareSummaryModel>();
            foreach (var solicitare in _context.Solicitares.Where(ie => ie.CodBursa.Equals(groupType+" "+viewScholarshipsModel.scholarshipType)&&ie.Status.Equals(status)).ToList())
            {   Console.WriteLine("INTRAMMM");
                Student student = _context.Students.Where(ie => ie.CodMatricol.Equals(solicitare.CodMatricol)).FirstOrDefault();
                ImportSecretar importSecretar =_context.ImportSecretars.Where(ie => ie.CodMatricol.Equals(solicitare.CodMatricol)).FirstOrDefault();
                viewScholarshipsModel.sholarshipRequests.Add(new SolicitareSummaryModel()
                {
                    CodBursa=solicitare.CodBursa,
                    CodMatricol=solicitare.CodMatricol,
                    DataSolicitare=solicitare.DataSolicitare,
                    DataUltimeiModificari=solicitare.DataUltimeiModificari, 
                    MedieDepartajare=importSecretar.MedieGenAnAnterior!=null?importSecretar.MedieGenAnAnterior:importSecretar.MedieAdmitere,
                    MedieGenAnAnterior=importSecretar.MedieGenAnAnterior!=null ? importSecretar.MedieGenAnAnterior :null,
                    MedieGenSemAnterior=importSecretar.MedieGenSemAnterior!=null ? importSecretar.MedieGenSemAnterior : null,
                    MedieBac=importSecretar.MedieBac!=null ? importSecretar.MedieBac : null,
                    MedieAdmitere=importSecretar.MedieAdmitere!=null ? importSecretar.MedieAdmitere : null,
                    Status=solicitare.Status,
                    NumeStudent=student.Nume+" "+student.Prenume
                });
            }
           
            if(viewScholarshipsModel.groupType.Split('-')[2].Split('.')[0].Equals('1'))
                viewScholarshipsModel.sholarshipRequests=viewScholarshipsModel.sholarshipRequests.OrderByDescending(ie=>ie.MedieAdmitere).ThenByDescending(ie=>ie.MedieBac).ToList();
            else{
              
                viewScholarshipsModel.sholarshipRequests=viewScholarshipsModel.sholarshipRequests.OrderByDescending(ie=>ie.MedieGenAnAnterior).ThenByDescending(ie=>ie.MedieGenSemAnterior).ThenByDescending(ie => ie.MedieAdmitere).ThenByDescending(ie => ie.MedieBac).ToList();
            }
           
            if(status.Equals("PENDING"))
                viewScholarshipsModel.sholarshipRequests.Take(nrBurse.Value);
            viewScholarshipsModel.selectListScholarships=getListScholarships();
            viewScholarshipsModel.selectListGroups=getLists();
            //viewScholarshipsModel.selectedStudents=getStudents(care au codul bursei x)
            return viewScholarshipsModel;
        }

        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public IActionResult ViewScholarshipRequests()
        {
            return View(initiateViewScholarships());

        }

        [HttpPost]
        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public async Task<IActionResult> ViewScholarshipRequests(ViewScholarshipsModel viewScholarshipsModel)
        {
            return View(postViewScholarships(viewScholarshipsModel, _strings.PENDING));
        }
        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public IActionResult ViewApprovedScholarships()
        {
            return View(initiateViewScholarships());

        }

        [HttpPost]
        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public async Task<IActionResult> ViewApprovedScholarships(ViewScholarshipsModel viewScholarshipsModel)
        {
            return View(postViewScholarships(viewScholarshipsModel, _strings.SUCCESS));
        }
        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public IActionResult ViewScholarshipsContest()
        {
            return View(initiateViewScholarships());

        }

        [HttpPost]
        [Authorize(Roles = "Secretar,Admin,Comisie")]
        public async Task<IActionResult> ViewScholarshipsContest(ViewScholarshipsModel viewScholarshipsModel)
        {
            return View(postViewScholarships(viewScholarshipsModel, _strings.FAILED));
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateScholarship(CreateScholarshipModel newScholarship)
        {   Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            Console.WriteLine((newScholarship.Cod.Split(".")[0]+" "+newScholarship.Tip).Length);
            if (!ModelState.IsValid)
            {   newScholarship.selectListItems=getLists();
                return RedirectToAction(nameof(CreateScholarship));
            }
            
            Bursa bursa = new Bursa
            {
                Cod=newScholarship.Cod.Split(".")[0]+" "+newScholarship.Tip,
                Tip=newScholarship.Tip,
                DataFinal=DateTime.ParseExact(newScholarship.DataFinal,"dd.mm.yyyy",null),
                DataInceput=DateTime.ParseExact(newScholarship.DataInceput,"dd.mm.yyyy",null),
                DataLimitaContestatie=DateTime.ParseExact(newScholarship.DataLimitaContestatie,"dd.mm.yyyy",null),
                DataLimitaRecenzie=DateTime.ParseExact(newScholarship.DataLimitaRecenzie,"dd.mm.yyyy",null),
                DataLimitaSolicitare=DateTime.ParseExact(newScholarship.DataLimitaSolicitare,"dd.mm.yyyy",null),
                Descriere=newScholarship.Descriere,
                Suma=newScholarship.Suma,
                Buget=newScholarship.Buget,
                NrBurse=newScholarship.NrBurse

            };
            _context.Bursas.Add(bursa);
            if (SavedChanges())
            {
                ViewBag.message = "Success";
                return RedirectToAction(nameof(Welcome));
            }
            ModelState.AddModelError("", "Wrong data entry");
            return View(newScholarship);
        }
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
        [Authorize(Roles = "Secretar,Comisie,Admin")]
        public IActionResult ScholarshipRefused(string selectedRequest)
        {
            string[] solicitare_pkeys = selectedRequest.Split('_');
            Solicitare solicitare = _context.Solicitares.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
            solicitare.Status=_strings.FAILED;
            solicitare.DataUltimeiRecenziiSef=null;
            solicitare.ObservatiiSecretar="";
            solicitare.ObservatiiSefComisie="";
            _context.Solicitares.Update(solicitare);
            SavedChanges();
            return RedirectToAction(nameof(ViewScholarshipRequests));


        }
        [Authorize(Roles = "Secretar,Comisie,Admin")]
        public IActionResult ScholarshipAccepted(string selectedRequest)
        {
            string[] solicitare_pkeys = selectedRequest.Split('_');
            Solicitare solicitare = _context.Solicitares.Where(ie => ie.CodMatricol.Equals(solicitare_pkeys[0])&&ie.CodBursa.Equals(solicitare_pkeys[1])).FirstOrDefault();
            solicitare.Status=_strings.SUCCESS;
            solicitare.DataUltimeiRecenziiSef=null;
            solicitare.ObservatiiSecretar="";
            solicitare.ObservatiiSefComisie="";
            _context.Solicitares.Update(solicitare);
            Bursa bursa=_context.Bursas.Where(ie => ie.Cod.Equals(solicitare_pkeys[1])).FirstOrDefault();
            bursa.NrBurse-=1;
            _context.Bursas.Update(bursa);
            SavedChanges();
            return RedirectToAction(nameof(ViewScholarshipRequests));


        }
    }

}