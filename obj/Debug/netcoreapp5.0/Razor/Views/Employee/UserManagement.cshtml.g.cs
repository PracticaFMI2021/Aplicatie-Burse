#pragma checksum "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5640223ce21b75e74da1330657d72d590f15aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_UserManagement), @"mvc.1.0.view", @"/Views/Employee/UserManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5640223ce21b75e74da1330657d72d590f15aaf", @"/Views/Employee/UserManagement.cshtml")]
    public class Views_Employee_UserManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BurseFMI.appModels.UserManagementsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/employee.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5640223ce21b75e74da1330657d72d590f15aaf4001", async() => {
                WriteLiteral("\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5640223ce21b75e74da1330657d72d590f15aaf4428", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <Title>New Message</Title>
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <title>");
#nullable restore
#line 11 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5640223ce21b75e74da1330657d72d590f15aaf7547", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    \r\n        \r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <section id=\"loginForm\">\r\n");
#nullable restore
#line 30 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                 using (Html.BeginForm("UserManagement", "Employee", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
                {
                       

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <table class=\"table\">\r\n                                <thead>\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                               Write(Html.LabelFor(m => m.userList[0].email, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                               Write(Html.LabelFor(m => m.userList[0].name, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                               Write(Html.LabelFor(m => m.userList[0].role, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                               Write(Html.LabelFor(m => m.userList[0].selectListItems, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                             for(int i=0;i<Model.userList.Count();i++){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                         \r\n");
                WriteLiteral("                               <td> ");
#nullable restore
#line 47 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                               Write(Html.TextBoxFor(m => m.userList[i].email, new { @class = "form-control",@readonly="true" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                               <td> ");
#nullable restore
#line 48 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                               Write(Html.TextBoxFor(m => m.userList[i].name, new { @class = "form-control",@readonly="true" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                       <td> ");
#nullable restore
#line 49 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                                       Write(Html.TextBoxFor(m => m.userList[i].role, new { @class = "form-control",@readonly="true" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                               <td> ");
#nullable restore
#line 50 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                               Write(Html.DropDownListFor(m=>m.fixbugs[i],new SelectList(Model.userList[i].selectListItems,"Value","Text"),"Selecteaza rol"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
                WriteLiteral(@"                        <div class=""form-group"">
                            <div class=""col-md-offset-2 col-md-10"">
                                <input type=""submit"" value=""Modifica"" class=""btn btn-default"" />
                            </div>
                    
                    </div>
");
#nullable restore
#line 70 "C:\Users\Avram\Desktop\Burse-App\Views\Employee\UserManagement.cshtml"
                              
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BurseFMI.appModels.UserManagementsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
