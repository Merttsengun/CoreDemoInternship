#pragma checksum "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b3045c6e3a8cfced82b40492532bb3d9dd6093a6c9e78cbba584d98eb145852e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b3045c6e3a8cfced82b40492532bb3d9dd6093a6c9e78cbba584d98eb145852e", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog    >>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
 if (TempData["SuccessMessage"] != null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
            Write(
#nullable restore
#line 7 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
         TempData["SuccessMessage"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Blog</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Başlık </th>
                                <th> Kategori </th>
                                <th> Tarih</th>
                                <th>Detaylar</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 28 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model.OrderByDescending(x=>x.BlogCreateDate).Take(10))
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1142, "\"", 1163, 1);
            WriteAttributeValue("", 1148, 
#nullable restore
#line 32 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                   item.BlogImage

#line default
#line hidden
#nullable disable
            , 1148, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> \r\n                                        \r\n                                        </td>\r\n                                        <td>\r\n                                        ");
            Write(
#nullable restore
#line 36 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                         item.BlogTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <label class=\"badge badge-gradient-success\">");
            Write(
#nullable restore
#line 39 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                                     item.Category.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</label>\r\n                                    </td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 41 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                           ((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1825, "\"", 1862, 2);
            WriteAttributeValue("", 1832, "/Blog/BlogReadAll/", 1832, 18, true);
            WriteAttributeValue("", 1850, 
#nullable restore
#line 43 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                    item.BlogID

#line default
#line hidden
#nullable disable
            , 1850, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Detaylar</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog    >> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
