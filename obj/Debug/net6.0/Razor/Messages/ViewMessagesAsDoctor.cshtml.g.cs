#pragma checksum "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "021c620c2ff1a1a6fe35ed875c014f234d0577fd98187057b36728117e86e7e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Messages_ViewMessagesAsDoctor), @"mvc.1.0.view", @"/Messages/ViewMessagesAsDoctor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"021c620c2ff1a1a6fe35ed875c014f234d0577fd98187057b36728117e86e7e6", @"/Messages/ViewMessagesAsDoctor.cshtml")]
    public class Messages_ViewMessagesAsDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<BurseFMI.appModels.CardDetails>,string)>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/myfile3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "021c620c2ff1a1a6fe35ed875c014f234d0577fd98187057b36728117e86e7e64062", async() => {
                WriteLiteral("\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "021c620c2ff1a1a6fe35ed875c014f234d0577fd98187057b36728117e86e7e64513", async() => {
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
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <title>Bellanima Clinic</title>
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.13.0/css/all.css"">
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.13.0/css/v4-shims.css"">
    <link href=""//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.no-icons.min.css"" rel=""stylesheet"">
    <link href=""//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css"" rel=""stylesheet"">
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WL");
                WriteLiteral(@"aUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>
");
                WriteLiteral("  ");
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
            WriteLiteral("\r\n    \r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "021c620c2ff1a1a6fe35ed875c014f234d0577fd98187057b36728117e86e7e67932", async() => {
                WriteLiteral("\r\n\r\n           <nav class=\"navbar navbar-light bg-light flex-container\" style=\"opacity:0.8\">\r\n                    \r\n                    <h3 style=\"margin-right: 10px;\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
                   Write(Html.ActionLink("HOMEPAGE", "Welcome","Home",new{username=Model.Item2}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <i class=\"fas fa-home\"></i>\r\n                    </h3>\r\n                   \r\n             \r\n            </nav>\r\n            <div class=\"myflex\">\r\n");
#nullable restore
#line 33 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
             for(int i=0;i<Model.Item1.Count;++i){
                var card=Model.Item1[i];
                if(card.isChecked==1)
                    continue;

                var isChecked=card.isChecked;
                var text=card.lastMessage;
                var author=text.Substring(0,text.IndexOf(':'));
                
                var date=text.Substring(text.LastIndexOf("Sent:"));
            
                var opacity=isChecked==1?"opacity:0.4;":"opacity:1;";
                
 
                
                var message=(card.speaker.Equals(card.doctor)?"You:":card.patient+":")+text.Substring(text.IndexOf(':')+1,text.LastIndexOf("Sent:")-text.IndexOf(':')-1);
           

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card w-150\"");
                BeginWriteAttribute("style", " style=\"", 2845, "\"", 2908, 2);
                WriteAttributeValue("", 2853, "font-size:20px;height:202px;margin-bottom:15px;", 2853, 47, true);
#nullable restore
#line 50 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
WriteAttributeValue("", 2900, opacity, 2900, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n                    <h2 class=\"card-title\"><h2>");
#nullable restore
#line 52 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
                                          Write(card.patient);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                \r\n                    <p class=\"card-text\">\r\n                 \r\n                        ");
#nullable restore
#line 56 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
                   Write(message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                \r\n                     <div style=\"position:relative;margin-right:0px\"><p class=\"card-text\">");
#nullable restore
#line 58 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
                                                                                     Write(date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></div>\r\n                    </div>\r\n                    <div class=\"card-body\" style=\"text-align: end;\">\r\n               \r\n                        <button type=\"button\" class=\"btn btn-light\">");
#nullable restore
#line 62 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
                                                               Write(Html.ActionLink("REPLY", "Reply","Messages",new {selectedDialog=card.dialogId}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                        \r\n                        <button type=\"button\" class=\"btn btn-light\">");
#nullable restore
#line 64 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
                                                               Write(Html.ActionLink("DIAGNOSE", "Diagnose","Messages",new {selectedDialog=card.dialogId}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    </div>\r\n                  \r\n                </div>\r\n");
#nullable restore
#line 68 "C:\Users\Avram\Desktop\DeTest\BurseFMI\Messages\ViewMessagesAsDoctor.cshtml"
            
                
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            \r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<BurseFMI.appModels.CardDetails>,string)> Html { get; private set; }
    }
}
#pragma warning restore 1591
