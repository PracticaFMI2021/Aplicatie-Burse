#pragma checksum "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51a6ff2a96d7108b8e5258d18c2cc4451dffe744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_RequestScholarship), @"mvc.1.0.view", @"/Views/Student/RequestScholarship.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a6ff2a96d7108b8e5258d18c2cc4451dffe744", @"/Views/Student/RequestScholarship.cshtml")]
    public class Views_Student_RequestScholarship : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BurseFMI.appModels.RequestScholarshipModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51a6ff2a96d7108b8e5258d18c2cc4451dffe7442813", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <Title>New Scholarship</Title>
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <title>");
#nullable restore
#line 10 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    \r\n");
                WriteLiteral(@"    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
        <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
      <link href=""  https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"" rel=""stylesheet""></link>
    
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51a6ff2a96d7108b8e5258d18c2cc4451dffe7445217", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    <h1 style=\"align:center\"><strong>Submit a new message</strong></h1>\r\n\r\n\r\n\r\n    \r\n        \r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <section id=\"loginForm\">\r\n");
#nullable restore
#line 33 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                 using (Html.BeginForm("RequestScholarship", "Student",FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
                {
                    
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
               Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
               Write(Html.DropDownListFor(m=>m.TipBursa,new SelectList(Model.selectListItems,"Value","Text"),"Selecteaza tipul bursei"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.AnInmatriculare, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 42 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.AnInmatriculare, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 45 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.VenitLunarMembru, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 46 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.VenitLunarMembru, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.VenitLunarMembruSecretar, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 50 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.VenitLunarMembruSecretar, new { @class = "form-control " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.ContributiiStiintifice, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 54 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.ContributiiStiintifice, new { @class = "form-control " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.DiplomePremii, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 58 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.DiplomePremii, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
                WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.NumeArhivaDocsSociala, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 64 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.NumeArhivaDocsSociala, new { @class = "form-control " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 67 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.CaleArhiva, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 68 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.CaleArhiva, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.TipArhiva, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 72 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.TipArhiva, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 75 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.Cnp, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 76 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.Cnp, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 79 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.AlteDetalii, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 80 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.AlteDetalii, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 83 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.Iban, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 84 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.Iban, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 87 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.NumeFisierExtrasCont, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 88 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.NumeFisierExtrasCont, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 91 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.LabelFor(m => m.CaleExtrasCont, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 92 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.CaleExtrasCont, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\" >\r\n                            <div style=\"display:flex;flex-direction:row\">\r\n                   <p><span>");
#nullable restore
#line 96 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                       Write(Html.CheckBoxFor(m => m.AcordGdpr, new { @checked = false }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>  Sunt de acord cu <span><a");
                BeginWriteAttribute("href", " href=\"", 5917, "\"", 5959, 1);
#nullable restore
#line 96 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
WriteAttributeValue("", 5924, Url.Action("AcordGdpr", "Student"), 5924, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">termenii si conditii</a></span> </p> \r\n                        </div>\r\n                    \r\n                        \r\n                    </div>\r\n");
                WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Submit message"" class=""btn btn-default"" />
                        </div>
                    </div>
");
#nullable restore
#line 116 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                     if(!string.IsNullOrEmpty(ViewBag.message))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h2 style=\"color:green\">");
#nullable restore
#line 118 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                                           Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 119 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                    }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Avram\Desktop\Burse-App\Views\Student\RequestScholarship.cshtml"
                              
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </section>\r\n        </div>\r\n    </div>\r\n  \r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n    \r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BurseFMI.appModels.RequestScholarshipModel> Html { get; private set; }
    }
}
#pragma warning restore 1591