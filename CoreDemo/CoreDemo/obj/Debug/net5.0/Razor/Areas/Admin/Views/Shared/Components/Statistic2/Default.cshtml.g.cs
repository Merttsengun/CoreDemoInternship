#pragma checksum "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fb46b284fb8e390b3472e3365b2b5d05f6b338f1d80906b0cf3227408bf9f3cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic2_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
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
#line 1 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fb46b284fb8e390b3472e3365b2b5d05f6b338f1d80906b0cf3227408bf9f3cb", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"afe8a1861b2325a0e2ffbf73c668777b7cf235b50137f9ca74274e5dba590322", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""widget navy-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Dashboard</h1>

                <h3 class=""font-bold no-margins"">
                    ASP.Net Core 5.0
                </h3>
                <small>Projemizin bu panelinde admin işlemleri bir area yapısı üzerinden gerçekleşmektedir </small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart1""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget lazur-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Son Blog</h1>

                <h3 class=""font-bold no-margins"">
                    ");
            Write(
#nullable restore
#line 23 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml"
                     ViewBag.v1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
                </h3>
                <small>Tüm Bloglar</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart2""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget yellw-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">₺ 2687,22</h1>

                <h3 class=""font-bold no-margins"">
                    Blog Site Kazancı
                </h3>
                <small>Ürün Tanıtımları,Prosmosyonlar,Reklamlar,</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart3""></div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
