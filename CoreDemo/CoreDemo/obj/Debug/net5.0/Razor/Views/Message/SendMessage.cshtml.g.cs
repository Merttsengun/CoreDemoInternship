#pragma checksum "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "545889deb68c5b67e9baf503a0eb022d9339d16b6cd795d4bea02207ed639cd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendMessage), @"mvc.1.0.view", @"/Views/Message/SendMessage.cshtml")]
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

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"545889deb68c5b67e9baf503a0eb022d9339d16b6cd795d4bea02207ed639cd2", @"/Views/Message/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
  
    ViewData["Title"] = "SendMessage";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Yeni Mesaj Oluştur</h1>\r\n<br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
 using (Html.BeginForm("SendMessage", "Message", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 12 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
     Html.Label("Alıcı")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("     <input type=\"text\" class=\"form-control\" />\r\n    <br />\r\n");
            Write(
#nullable restore
#line 16 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
     Html.Label("Konu")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 17 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
     Html.TextBoxFor(x => x.Subject, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <br />\r\n");
            Write(
#nullable restore
#line 20 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
     Html.Label("Mesajınız")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 21 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
     Html.TextAreaFor(x => x.MessageDetails, 15, 3, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Mesajı Gönder</button>\r\n");
#nullable restore
#line 24 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Message\SendMessage.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral(" \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
