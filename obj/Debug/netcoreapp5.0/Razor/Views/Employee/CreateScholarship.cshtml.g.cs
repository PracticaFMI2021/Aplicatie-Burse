#pragma checksum "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff352e67116ef0aa7ba0ae0209a59f5102b0abc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_CreateScholarship), @"mvc.1.0.view", @"/Views/Employee/CreateScholarship.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff352e67116ef0aa7ba0ae0209a59f5102b0abc7", @"/Views/Employee/CreateScholarship.cshtml")]
    public class Views_Employee_CreateScholarship : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BurseFMI.appModels.CreateScholarshipModel>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff352e67116ef0aa7ba0ae0209a59f5102b0abc72812", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <Title>New Message</Title>
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <title>");
#nullable restore
#line 10 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>
<script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
        <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
      <link href=""  https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"" rel=""stylesheet""></link>
    <script>
   $(document).ready(
  function () {
    $("".mydatepicker"").datepicker({ dateFormat: ""dd.mm.yy"",
                    changeYear: true,
  ");
                WriteLiteral("                  yearRange: \"-1:+0\",\r\n                    });\r\n  }\r\n);  \r\n    </script>\r\n  ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff352e67116ef0aa7ba0ae0209a59f5102b0abc75646", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    <h1 style=\"align:center\"><strong>Submit a new message</strong></h1>\r\n\r\n\r\n\r\n    \r\n        \r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <section id=\"loginForm\">\r\n");
#nullable restore
#line 41 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                 using (Html.BeginForm("CreateScholarship", "Employee",FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
                {
                    
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
               Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 48 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.Tip, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 49 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.Tip, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.DataLimitaSolicitare, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 53 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.DataLimitaSolicitare, new { @class = "form-control mydatepicker", @placeholder = "dd.mm.yyyy" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 56 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.DataLimitaRecenzie, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 57 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.DataLimitaRecenzie, new { @class = "form-control mydatepicker", @placeholder = "dd.mm.yyyy" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.DataLimitaContestatie, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 61 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.DataLimitaContestatie, new { @class = "form-control mydatepicker", @placeholder = "dd.mm.yyyy" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 64 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.DataInceput, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 65 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.DataInceput, new { @class = "form-control mydatepicker", @placeholder = "dd.mm.yyyy" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 68 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.DataFinal, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 69 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m=>m.DataFinal, new { @class = "form-control mydatepicker", @placeholder = "dd.mm.yyyy" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 72 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.Descriere, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 73 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.Descriere, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 76 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.Suma, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 77 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.Suma, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 80 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.Buget, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 81 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.Buget, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 84 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.LabelFor(m => m.NrBurse, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 85 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.TextBoxFor(m => m.NrBurse, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                     <div class=\"form-group\">\r\n                         ");
#nullable restore
#line 88 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                    Write(Html.LabelFor(m => m.Cod, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 89 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                   Write(Html.DropDownListFor(m=>m.Cod,new SelectList(Model.selectListItems,"Value","Text"),"Select list"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
                WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Submit message"" class=""btn btn-default"" />
                        </div>
                    </div>
");
#nullable restore
#line 105 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                     if(!string.IsNullOrEmpty(ViewBag.message))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h2 style=\"color:green\">");
#nullable restore
#line 107 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                                           Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 108 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                    }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\CreateScholarship.cshtml"
                              
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </section>\r\n        </div>\r\n    </div>\r\n  ");
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
            WriteLiteral("\r\n</html>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(function () { // will trigger when the document is ready
            //Initialise all datepickers whose class name are mydatepicker
            // Display them with a button which containes a small calendar icon.
            $("".mydatepicker"")
                .wrap('＜div class=""input-group""＞')
                .datepicker({
                    dateFormat: ""dd.mm.yy"",
                    changeYear: true,
                    yearRange: ""-70:+0"",//year selection is possible from starting 70 years before now
                    showOn: ""both""
                })
                .next(""button"").button({
                    icons: { primary: ""ui-icon-calendar"" },
                    label: ""Select Date"",
                    text: false
                })
                .addClass(""btn btn-default"")
                .wrap('＜span class=""input-group-btn""＞')
                .find('.ui-button-text')
                .css({
                    'visibility': 'h");
                WriteLiteral("idden\',\r\n                    \'display\': \'inline\'\r\n                });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BurseFMI.appModels.CreateScholarshipModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
