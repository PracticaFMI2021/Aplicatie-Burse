#pragma checksum "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358588a0fa4ab83b81ffe332b77fc7e497821fb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358588a0fa4ab83b81ffe332b77fc7e497821fb8", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BurseFMI.appModels.LoginViewModel>
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
            WriteLiteral("<!doctype html>\n<html lang=\"en\">\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358588a0fa4ab83b81ffe332b77fc7e497821fb82726", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <Title>Login</Title>
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <title>");
#nullable restore
#line 10 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
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
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358588a0fa4ab83b81ffe332b77fc7e497821fb84974", async() => {
                WriteLiteral("\n");
                WriteLiteral("\n    <div class=\"row\" style=\"margin-top: 2%;\">\n        <div class=\"col-md-8\">\n            <section id=\"loginForm\">\n");
#nullable restore
#line 22 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                 using (Html.BeginForm("Login", "Home",FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h4>Use a local account to log in.</h4>\n                    <hr />\n");
#nullable restore
#line 27 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
               Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 29 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(m=>m.username, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 31 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                       Write(Html.TextBoxFor(m=>m.username, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 35 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                   Write(Html.LabelFor(m=>m.password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 37 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                       Write(Html.PasswordFor(m=>m.password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Log in"" class=""btn btn-default"" />
                        </div>
                    </div>
                    <div style=""display:flex"" >
                    <p class=""btn btn-default"">
                        ");
#nullable restore
#line 47 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                   Write(Html.ActionLink("Register as a new user", "Register"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </p>\n                    <p class=\"btn btn-default\">\n                        ");
#nullable restore
#line 50 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                   Write(Html.ActionLink("Forgot your password?", "RecoverPassword"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </p>\n                    </div>\n");
#nullable restore
#line 56 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Views\Home\Login.cshtml"
                              
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </section>\n        </div>\n    </div>\n  ");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BurseFMI.appModels.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
