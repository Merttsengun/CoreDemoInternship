#pragma checksum "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ade0ee0b9384a7da8a2adeab61535244c190f0ea1f4c36013ba57863b4680fc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotification), @"mvc.1.0.view", @"/Views/Notification/AllNotification.cshtml")]
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
#line 1 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ade0ee0b9384a7da8a2adeab61535244c190f0ea1f4c36013ba57863b4680fc3", @"/Views/Notification/AllNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Notification_AllNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
  
    ViewData["Title"] = "AllNotification";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<style>
    .custom-table {
        border-collapse: collapse;
        width: 100%;
    }

        .custom-table th, .custom-table td {
            padding: 0.75rem;
            border: 1px solid #dee2e6;
        }

        .custom-table thead th {
            background-color: #343a40;
            color: #fff;
        }

        .custom-table tbody tr:nth-of-type(odd) {
            background-color: #f9f9f9;
        }

        .custom-table tbody tr:hover {
            background-color: #f1f1f1;
        }

        .custom-table tbody tr:not(:last-child) {
            border-bottom: 1px solid #dee2e6;
        }
</style>

<table class=""custom-table"">
    <thead>
        <tr>
            <th>#</th>
            <th>Bildirim</th>
            <th>Tarih</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 46 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 49 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
                     item.NotificationID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 50 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
                     item.NotificationDetails

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 51 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
                     item.NotificationDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
