#pragma checksum "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "449dd282b38a7c2b18412a3b57ff30f38a317d021751614a063d6d7e923151b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
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
#line 1 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"449dd282b38a7c2b18412a3b57ff30f38a317d021751614a063d6d7e923151b5", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\r\n");
#nullable restore
#line 5 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 348, "\"", 401, 1);
            WriteAttributeValue("", 355, 
#nullable restore
#line 8 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                     Url.Action("AllNotification", "Notification")

#line default
#line hidden
#nullable disable
            , 355, 46, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 470, "\"", 501, 1);
            WriteAttributeValue("", 478, 
#nullable restore
#line 10 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                             item.NotificationColor

#line default
#line hidden
#nullable disable
            , 478, 23, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 527, "\"", 563, 1);
            WriteAttributeValue("", 535, 
#nullable restore
#line 11 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                               item.NotificationTypeSymbol

#line default
#line hidden
#nullable disable
            , 535, 28, false);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject font-weight-normal mb-1\">");
            Write(
#nullable restore
#line 15 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                                     item.NotificationType

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h6>\r\n                <p class=\"text-gray ellipsis mb-0\">");
            Write(
#nullable restore
#line 16 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                    item.NotificationDetails

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 19 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <a href=\"/Notification/AllNotification/\" class=\"d-block text-decoration-none\">\r\n    <h6 class=\"p-3 mb-0 text-center\">Tüm Bildirimleri Gör</h6>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
