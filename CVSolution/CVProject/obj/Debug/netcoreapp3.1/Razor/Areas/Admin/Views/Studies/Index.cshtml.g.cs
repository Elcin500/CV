#pragma checksum "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e12adfdbd434bec81435431e298a51deb4eb71c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Studies_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Studies/Index.cshtml")]
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
#line 3 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\_ViewImports.cshtml"
using CVProject.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\_ViewImports.cshtml"
using CVProject.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\_ViewImports.cshtml"
using CVProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\_ViewImports.cshtml"
using CVProject.Models.FormModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\_ViewImports.cshtml"
using CVProject.Models.Entity.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e12adfdbd434bec81435431e298a51deb4eb71c3", @"/Areas/Admin/Views/Studies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cad3be45c2c275747e1b2b3c49e3b7fbf1c85d6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Studies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CVProject.Models.Entity.Study>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <ul class=""breadcrumb"">
        <li>
            <p>YOU ARE HERE</p>
        </li>
        <li><a href=""#"" class=""active"">Tehsil</a> </li>
    </ul>
    <div class=""page-title"">
        <i class=""icon-custom-left""></i>
        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e12adfdbd434bec81435431e298a51deb4eb71c37164", async() => {
                WriteLiteral("Tehsil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" - <span class=""semi-bold"">Əsas səhifə</span></h3>
    </div>
    <div class=""row"" id=""inbox-wrapper"">
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""grid simple"">
                        <div class=""grid-body no-border email-body"">
                            <br>
                            <div class=""row-fluid"">

                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>
                                                ");
#nullable restore
#line 31 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 34 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.StudyArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 37 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Years));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 40 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 43 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 46 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.DiplomaPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e12adfdbd434bec81435431e298a51deb4eb71c311721", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"> </i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 54 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 58 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 61 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.StudyArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 64 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Years));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 67 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 70 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 73 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.DiplomaPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e12adfdbd434bec81435431e298a51deb4eb71c316467", async() => {
                WriteLiteral("\r\n                                                        <i class=\"fa fa-pencil\"> </i>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e12adfdbd434bec81435431e298a51deb4eb71c318937", async() => {
                WriteLiteral("\r\n                                                        <i class=\"fa fa-location-arrow\"> </i>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4578, "\"", 4621, 5);
            WriteAttributeValue("", 4588, "postRemove(", 4588, 11, true);
#nullable restore
#line 82 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
WriteAttributeValue("", 4599, item.Id, 4599, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4607, ",`", 4607, 2, true);
#nullable restore
#line 82 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
WriteAttributeValue("", 4609, item.Name, 4609, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4619, "`)", 4619, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm btn-danger"">
                                                        <i class=""fa fa-trash""></i>
                                                    </a>
                                                </td>
                                            </tr>
");
#nullable restore
#line 87 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>


                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e12adfdbd434bec81435431e298a51deb4eb71c323133", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        function postRemove(_id,name) {
            swal({
                title: ""Are you sure?"",
                text:  `${name} bazadan silinecek! Razisinizmi?`,
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete) {

                        $.ajax({
                            url: `");
#nullable restore
#line 120 "C:\Users\hp\source\repos\CV\CVSolution\CVProject\Areas\Admin\Views\Studies\Index.cshtml"
                             Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                            type: ""post"",
                            data: { id: _id },
                            success: function (response) {

                                swal(""Məlumat Silindi!"", {
                                    icon: ""success"",
                                });
                                window.location.reload();
                            },
                            error: function (response) {
                                alert(""Xeta bas verdi"");
                                console.log(response.error);
                            }
                        })

                    }
                    else {
                        swal(""Məlumat silinmədi!"");
                    }
                });
        }
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CVProject.Models.Entity.Study>> Html { get; private set; }
    }
}
#pragma warning restore 1591