#pragma checksum "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42222b041e9fa5957c391a0442d691d825c8dd0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MessageBoard_Index), @"mvc.1.0.view", @"/Views/MessageBoard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MessageBoard/Index.cshtml", typeof(AspNetCore.Views_MessageBoard_Index))]
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
#line 1 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\_ViewImports.cshtml"
using LiubaSys.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\_ViewImports.cshtml"
using LiubaSys.Models;

#line default
#line hidden
#line 2 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42222b041e9fa5957c391a0442d691d825c8dd0d", @"/Views/MessageBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba029598eb64af96f65490fafe6cd129dc78aa6", @"/Views/_ViewImports.cshtml")]
    public class Views_MessageBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessagePublished>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
  
    int year = Model.Select(x => x.Year).First();
    ViewData["Title"] = $"Message Board - Year {year}";

#line default
#line hidden
            BeginContext(193, 72, true);
            WriteLiteral("\r\n<!-- Load partial view for posting a message on the MessageBoard -->\r\n");
            EndContext();
            BeginContext(266, 121, false);
#line 9 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
Write(await Html.PartialAsync("~/Views/MessageBoard/_PublishMessage.cshtml", new LiubaSys.ViewModels.PublishMessageViewModel()));

#line default
#line hidden
            EndContext();
            BeginContext(387, 70, true);
            WriteLiteral("\r\n\r\n<!-- Load all current messages in the database, NEWEST FIRST -->\r\n");
            EndContext();
#line 12 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
 foreach (var row in Model.Reverse())
{

#line default
#line hidden
            BeginContext(499, 145, true);
            WriteLiteral("    <div>\r\n        <div class=\"card grey lighten-3\">\r\n            <div class=\"card-content dark-text\">\r\n                <span class=\"card-title\">");
            EndContext();
            BeginContext(645, 54, false);
#line 17 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                                    Write(String.Format("{0:dd/MM/yy HH:mm}", row.DatePublished));

#line default
#line hidden
            EndContext();
            BeginContext(699, 28, true);
            WriteLiteral("</span>\r\n                <p>");
            EndContext();
            BeginContext(728, 11, false);
#line 18 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
              Write(row.Content);

#line default
#line hidden
            EndContext();
            BeginContext(739, 12, true);
            WriteLiteral("</p><br />\r\n");
            EndContext();
#line 19 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                 if (row.File1 != null)
                {
                    Regex regex = new Regex(@"(?=_).*");
                    Match match = regex.Match(row.File1.ToString());
                    string fileName = match.ToString().Remove(0, 1);

#line default
#line hidden
            BeginContext(1009, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1029, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a55c831c85e34359b3ca90abfc275069", async() => {
                BeginContext(1068, 8, false);
#line 24 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                                                     Write(fileName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1038, "~/Files/", 1038, 8, true);
#line 24 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
AddHtmlAttributeValue("", 1046, row.File1, 1046, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1080, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1101, 174, true);
            WriteLiteral("            </div>\r\n            <div class=\"card-action\">\r\n                <a class=\"waves-effect waves-light btn\">Reply</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\Users\dev01766\source\repos\LiubaSys\LiubaSys\Views\MessageBoard\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1278, 48, true);
            WriteLiteral("\r\n<!-- Load specific scripts for this page -->\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1345, 1212, true);
                WriteLiteral(@"
    <script>
        // Load the buttons bar under the message box onclick()
        // The messagebox comes from the partial view ""_PublishMessage.cshtml""
        $('#message').click(function () {
            $('#actions-bar').slideToggle(""slow"");
            $('#actions-bar').attr(""id"", ""#actions-bar-active"");
        });

        $('#empty-file-input').click(function () {
            $('#files').val('');
        });

        $('#add-file-1, #add-file-2, #add-file-3, #add-file-4').hide();
        var id = 1;
        $('.light-green').click(function () {
            if (id < 5) {
                $('#add-file-' + id).show();
                id++;
                console.log(id);
            }
        });

        // Load thumbnail of loaded file
        document.getElementById(""files"").onchange = function () {
            var reader = new FileReader();

            reader.onload = function (e) {
                // Get loaded data and render thumbnail
                document.getE");
                WriteLiteral("lementById(\"image\").src = e.target.result;\r\n            };\r\n\r\n            // Read the image file as a data URL\r\n            reader.readAsDataURL(this.files[0]);\r\n        }\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessagePublished>> Html { get; private set; }
    }
}
#pragma warning restore 1591
