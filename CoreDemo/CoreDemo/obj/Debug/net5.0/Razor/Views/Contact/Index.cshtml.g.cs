#pragma checksum "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Contact\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e4eec9f8f5db77e8eb5f1fd3af78b91643f886a3e8cf26bf5b69959d4fa8ec54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e4eec9f8f5db77e8eb5f1fd3af78b91643f886a3e8cf26bf5b69959d4fa8ec54", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Tema/css/contact.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mert\source\repos\CoreDemo\CoreDemo\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4eec9f8f5db77e8eb5f1fd3af78b91643f886a3e8cf26bf5b69959d4fa8ec545590", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eec9f8f5db77e8eb5f1fd3af78b91643f886a3e8cf26bf5b69959d4fa8ec546815", async() => {
                WriteLiteral(@"


	<section class=""main-content-w3layouts-agileits"">

		<h3 class=""tittle"">Bize Ulaşın</h3>
		<p class=""sub text-center"">Düşünceleriniz Bizim İçin Çok Önemli</p>
		<div class=""contact-map inner-sec"">

			<iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d50365.79908708993!2d28.28536338652007!3d37.91027781928826!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14b8b8eb92e2f661%3A0x7ab49f06aabe2341!2zTmF6aWxsaSwgQXlkxLFu!5e0!3m2!1str!2str!4v1723911272719!5m2!1str!2str"" width=""600"" height=""450"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 717, "\"", 735, 0);
                EndWriteAttribute();
                WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
		</div>
		<div class=""ad-inf-sec bg-light"">
			<div class=""container"">
				<div class=""address row"">

					<div class=""col-lg-4 address-grid"">
						<div class=""row address-info"">
							<div class=""col-md-4 address-left text-center"">
								<i class=""far fa-map""></i>
							</div>
							<div class=""col-md-8 address-right text-left"">
								<h6>Adres</h6>
								<p> İstanbul, Türkiye

								</p>
							</div>
						</div>

					</div>
					<div class=""col-lg-4 address-grid"">
						<div class=""row address-info"">
							<div class=""col-md-4 address-left text-center"">
								<i class=""far fa-envelope""></i>
							</div>
							<div class=""col-md-8 address-right text-left"">
								<h6>Mail</h6>
								<p>Email :
									<a href=""mailto:example@email.com""> mail@example.com</a>

								</p>
							</div>

						</div>
					</div>
					<div class=""col-lg-4 address-grid"">
						<div class=""row address");
                WriteLiteral(@"-info"">
							<div class=""col-md-4 address-left text-center"">
								<i class=""fas fa-mobile-alt""></i>
							</div>
							<div class=""col-md-8 address-right text-left"">
								<h6>Phone</h6>
								<p>+90 234 567 8901</p>

							</div>

						</div>
					</div>
				</div>
			</div>
		</div>
		<div class=""container"">
			<div class=""contact_grid_right"">
				");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eec9f8f5db77e8eb5f1fd3af78b91643f886a3e8cf26bf5b69959d4fa8ec549314", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t<div class=\"row contact_left_grid\">\r\n\t\t\t\t\t\t<div class=\"col-md-6 con-left\">\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"validationCustom01 my-2\">Adınız</label>\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"ContactUserName\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 2420, "\"", 2434, 0);
                    EndWriteAttribute();
                    BeginWriteAttribute("required", " required=\"", 2435, "\"", 2446, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"exampleFormControlInput1\">Mail Adresiniz</label>\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"email\" name=\"ContactMail\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 2635, "\"", 2649, 0);
                    EndWriteAttribute();
                    BeginWriteAttribute("required", " required=\"", 2650, "\"", 2661, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"validationCustom03 my-2\">Konu</label>\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"ContactSubject\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 2841, "\"", 2855, 0);
                    EndWriteAttribute();
                    BeginWriteAttribute("required", " required=\"", 2856, "\"", 2867, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-md-6 con-right\">\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"textarea\">Mesajınız</label>\r\n\t\t\t\t\t\t\t\t<textarea id=\"textarea\" name=\"ContactMessage\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 3075, "\"", 3089, 0);
                    EndWriteAttribute();
                    WriteLiteral("></textarea>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<input class=\"form-control\" type=\"submit\" value=\"Gönder\">\r\n\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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