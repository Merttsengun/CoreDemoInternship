#pragma checksum "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f470fa3e626fbe370f8d9a83b9a6d0199ea27dc9f5ab33951b79d939fd4eeefa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f470fa3e626fbe370f8d9a83b9a6d0199ea27dc9f5ab33951b79d939fd4eeefa", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<h1>Yazarın Blogları</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog başlığı</th>
        <th>Oluşturma tarihi</th>
        <th>Kategori</th>
        <th>Sil</th>
        <th>Düzenle</th>
        

        
    </tr>
");
#nullable restore
#line 21 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <th>");
            Write(
#nullable restore
#line 24 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                 item.BlogID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n            <td>");
            Write(
#nullable restore
#line 25 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                 item.BlogTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 26 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                  ((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 27 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                 item.Category.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href =\"", 700, "\"", 737, 2);
            WriteAttributeValue("", 708, "/Blog/DeleteBlog/", 708, 17, true);
            WriteAttributeValue("", 725, 
#nullable restore
#line 28 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                             item.BlogID

#line default
#line hidden
#nullable disable
            , 725, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 795, "\"", 829, 2);
            WriteAttributeValue("", 802, "/Blog/EditBlog/", 802, 15, true);
            WriteAttributeValue("", 817, 
#nullable restore
#line 29 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                          item.BlogID

#line default
#line hidden
#nullable disable
            , 817, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table> \r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-primary\">Yeni Blog Oluştur</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591