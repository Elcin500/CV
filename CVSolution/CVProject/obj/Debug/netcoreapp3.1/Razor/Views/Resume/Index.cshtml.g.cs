#pragma checksum "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "293cfe06bb526b3242c9198d80f0a309557d226b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resume_Index), @"mvc.1.0.view", @"/Views/Resume/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\_ViewImports.cshtml"
using CVProject.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\_ViewImports.cshtml"
using CVProject.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\_ViewImports.cshtml"
using CVProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\_ViewImports.cshtml"
using Cv.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293cfe06bb526b3242c9198d80f0a309557d226b", @"/Views/Resume/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97be81b825b1e0adac82e5f4c90c52b14ff6e4f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Resume_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-md-8\">\r\n    <div class=\"inside-sec\">\r\n        <!-- BIO AND SKILLS -->\r\n        <h5 class=\"tittle\">Bio & Skills</h5>\r\n        <div class=\"bio-info padding-30\">\r\n            <p>\r\n                ");
#nullable restore
#line 13 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
           Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <div class=\"skills\">\r\n\r\n                <!-- HARD SKILLS -->\r\n                <h5 class=\"margin-top-30\">Hard Skills</h5>\r\n\r\n                <div class=\"panel-group accordion\" id=\"accordion\">\r\n");
#nullable restore
#line 21 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                     foreach (var item in Model.Skills.Where(s=>s.Category=="Hard Skill"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""panel panel-default"">
                            <div class=""row"">
                                <div class=""col-sm-4"">
                                    <!-- PANEL HEADING -->
                                    <div class=""panel-heading"">
                                        <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne""> ");
#nullable restore
#line 28 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> </h4>
                                    </div>
                                </div>

                                <!-- Skillls Bars -->
                                <div class=""col-sm-8"">
                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1405, "\"", 1434, 1);
#nullable restore
#line 35 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
WriteAttributeValue("", 1421, item.Percent, 1421, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1473, "\"", 1503, 3);
            WriteAttributeValue("", 1481, "width:", 1481, 6, true);
#nullable restore
#line 35 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
WriteAttributeValue(" ", 1487, item.Percent, 1488, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1501, "%;", 1501, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"sr-only\">");
#nullable restore
#line 35 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                                                                                                                                                                                          Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"% Complete</span> </div>
                                    </div>

                                    <!-- Skillls Text -->
                                    <div id=""collapseOne"" class=""panel-collapse collapse in"">
                                        <div class=""panel-body"">
                                            <p>");
#nullable restore
#line 41 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 47 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <!-- Soft Skills -->\r\n                <h5 class=\"margin-top-30\">Soft Skills</h5>\r\n\r\n                <div class=\"panel-group accordion\" id=\"accordion1\">\r\n");
#nullable restore
#line 55 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                     foreach (var item in Model.Skills.Where(s => s.Category == "Soft Skill"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""panel panel-default"">
                            <div class=""row"">
                                <div class=""col-sm-4"">
                                    <!-- PANEL HEADING -->
                                    <div class=""panel-heading"">
                                        <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne""> ");
#nullable restore
#line 62 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> </h4>
                                    </div>
                                </div>

                                <!-- Skillls Bars -->
                                <div class=""col-sm-8"">
                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar""");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3229, "\"", 3258, 1);
#nullable restore
#line 69 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
WriteAttributeValue("", 3245, item.Percent, 3245, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 3297, "\"", 3327, 3);
            WriteAttributeValue("", 3305, "width:", 3305, 6, true);
#nullable restore
#line 69 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
WriteAttributeValue(" ", 3311, item.Percent, 3312, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3325, "%;", 3325, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"sr-only\">");
#nullable restore
#line 69 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                                                                                                                                                                                          Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"% Complete</span> </div>
                                    </div>

                                    <!-- Skillls Text -->
                                    <div id=""collapseOne"" class=""panel-collapse collapse in"">
                                        <div class=""panel-body"">
                                            <p>");
#nullable restore
#line 75 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 81 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>

                <!-- Follow ethical -->
                <div class=""ethical"">
                    <h6>Follow ethical work practices</h6>
                    <a href=""#."">Prioritize Learning Tasks</a> <a href=""#."">Make Ethical Choices</a> <a href=""#."">Social Work</a> <a href=""#."">Community Work</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Professional Experience -->
    <div class=""inside-sec margin-top-30"">
        <!-- Professional Experience -->
        <h5 class=""tittle"">Professional Experience</h5>
        <div class=""padding-30 exp-history"">

");
#nullable restore
#line 100 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
             foreach (var item in Model.Experiences)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 104 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                                          Write(item.Years);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                    <div class=\"media-body\">\r\n\r\n                        <!-- COmpany Logo -->\r\n                        <div class=\"company-logo\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "293cfe06bb526b3242c9198d80f0a309557d226b14378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4957, "~/uploads/", 4957, 10, true);
#nullable restore
#line 108 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
AddHtmlAttributeValue("", 4967, item.CompanyLogoImgPath, 4967, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n                        <h6>");
#nullable restore
#line 109 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                       Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 110 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                      Write(item.JobArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 111 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                      Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"margin-top-10\" style=\"width: 350px;\"> ");
#nullable restore
#line 112 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"#.\">Read More</a> </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 115 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Academic Background -->\r\n    <div class=\"inside-sec margin-top-30\">\r\n        <!-- Academic Background -->\r\n        <h5 class=\"tittle\">Academic Background</h5>\r\n        <div class=\"padding-30 exp-history\">\r\n");
#nullable restore
#line 125 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
             foreach (var item in Model.Studies)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 129 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                                          Write(item.Years);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </div>
                    <div class=""media-body"">
                        <!-- COmpany Logo -->
                        <div class=""company-logo""> <span class=""diploma""><i class=""fa fa-graduation-cap""></i> Download Diploma</span> </div>
                        <h6>");
#nullable restore
#line 133 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 134 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                      Write(item.StudyArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 135 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                      Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"margin-top-10\"> ");
#nullable restore
#line 136 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (...) <a href=\"#.\">Read More</a> </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 139 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\Resume\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591