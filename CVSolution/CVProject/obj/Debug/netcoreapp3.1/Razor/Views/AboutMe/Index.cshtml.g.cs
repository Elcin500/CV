#pragma checksum "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8efe3c18087f2bc4d264ae8757e82e61df371b9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutMe_Index), @"mvc.1.0.view", @"/Views/AboutMe/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8efe3c18087f2bc4d264ae8757e82e61df371b9a", @"/Views/AboutMe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97be81b825b1e0adac82e5f4c90c52b14ff6e4f7", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutMe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-md-8"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">About Me</h5>

        <!-- Blog -->
        <section class=""about-me padding-top-10 padding-bottom-50"">

            <!-- Personal Info -->
            <ul class=""personal-info"">
                <li>
                    <p> <span> Ad</span> ");
#nullable restore
#line 18 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                    Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Yaş</span> ");
#nullable restore
#line 21 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                     Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Yer</span> ");
#nullable restore
#line 24 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                     Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Təcrübəs</span> ");
#nullable restore
#line 27 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                          Write(Model.ExperienceYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Dərəcə</span> ");
#nullable restore
#line 30 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                        Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Kariyera</span> ");
#nullable restore
#line 33 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                          Write(Model.CareerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Telefon</span> ");
#nullable restore
#line 36 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                         Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Faks</span> ");
#nullable restore
#line 39 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                      Write(Model.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> E-mail</span> <a href=\"#.\">");
#nullable restore
#line 42 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </p>\r\n                </li>\r\n                <li>\r\n                    <p> <span> Sayt</span><a href=\"#.\"> ");
#nullable restore
#line 45 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                                   Write(Model.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </a></p>\r\n                </li>\r\n            </ul>\r\n\r\n            <!-- I’m Web Designer -->\r\n            <h5 class=\"tittle\">I’m ");
#nullable restore
#line 50 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                              Write(Model.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <div class=\"padding-20\">\r\n                <p>\r\n");
#nullable restore
#line 53 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                     if (Model.Bio.Length > 175)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                   Write(Model.Bio.Substring(0, 175));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                                    
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                   Write(Model.Bio);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                  
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n            </div>\r\n\r\n            <!-- Skills -->\r\n            <h5 class=\"tittle\">Skills</h5>\r\n\r\n            <!-- Sound Engineering -->\r\n            <div class=\"panel-group accordion padding-20\" id=\"accordion\">\r\n");
#nullable restore
#line 69 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                 foreach (var item in Model.Skills.Where(s=>s.Category=="Hard Skill"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                <!-- PANEL HEADING -->
                                <div class=""panel-heading"">
                                    <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"" class=""collapsed""> ");
#nullable restore
#line 76 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
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
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3031, "\"", 3060, 1);
#nullable restore
#line 83 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
WriteAttributeValue("", 3047, item.Percent, 3047, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 3099, "\"", 3129, 3);
            WriteAttributeValue("", 3107, "width:", 3107, 6, true);
#nullable restore
#line 83 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
WriteAttributeValue(" ", 3113, item.Percent, 3114, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3127, "%;", 3127, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"sr-only\">");
#nullable restore
#line 83 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                                                                                                                                                                                      Write(item.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"% Complete</span> </div>
                                </div>

                                <!-- Skillls Text -->
                                <div id=""collapseOne"" class=""panel-collapse collapse"">
                                    <div class=""panel-body"">
                                        <p>");
#nullable restore
#line 89 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 95 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Views\AboutMe\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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