#pragma checksum "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\Shared\Components\DefFooter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04fc0ce78559fb4de856e8bbfa6e3be5bfa24119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DefFooter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DefFooter/Default.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fc0ce78559fb4de856e8bbfa6e3be5bfa24119", @"/Views/Shared/Components/DefFooter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edd5b74f3052de640e5d6a55b39f78c1d3a424fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DefFooter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Social>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<footer>
    <div class=""newsletter"">
        <div class=""container"">
            <div class=""wrapper"">
                <div class=""box"">
                    <div class=""content"">
                        <h3>Join OUr Newsletter</h3>
                        <p>Get E-mail updates about our latest shop and <strong>special offers</strong></p>
                    </div>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04fc0ce78559fb4de856e8bbfa6e3be5bfa241194558", async() => {
                WriteLiteral(@"
                        <span class=""icon-large"">
                            <i class=""ri-mail-line""></i>
                        </span>
                        <input type=""mail"" placeholder=""Your email address"">
                        <button type=""submit"">Sign Up</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <div class=""widgets"">
        <div class=""container"">
            <div class=""wrapper"">
                <div class=""flexwrap"">
                    <div class=""row"">
                        <div class=""item mini-links"">
                            <h4>Help & Contact</h4>
                            <ul class=""flexcol"">
                                <li><a href=""#"">Your Account</a></li>
                                <li><a href=""#"">Your Orders</a></li>
                                <li><a href=""#"">Shipping Rates</a></li>
                                <li><a href=""#"">Returns</a></li>
                                <li><a href=""#"">Assistant</a></li>
                                <li><a href=""#"">Help</a></li>
                                <li><a href=""#"">Contact Us</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""row"">
  ");
            WriteLiteral(@"                      <div class=""item mini-links"">
                            <h4>Product Category</h4>
                            <ul class=""flexcol"">
                                <li><a href=""#"">Beauty</a></li>
                                <li><a href=""#"">Electronic</a></li>
                                <li><a href=""#"">Women's Fashion</a></li>
                                <li><a href=""#"">Men's Fashion</a></li>
                                <li><a href=""#"">Girl's Fashion</a></li>
                                <li><a href=""#"">Boy's Fashion</a></li>
                                <li><a href=""#"">Health & Household</a></li>
                                <li><a href=""#"">Home & Kitchen</a></li>
                                <li><a href=""#"">Pet Supplies</a></li>
                                <li><a href=""#"">Sports</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""row"">
                     ");
            WriteLiteral(@"   <div class=""item mini-links"">
                            <h4>Payment Info</h4>
                            <ul class=""flexcol"">
                                <li><a href=""#"">Business Card</a></li>
                                <li><a href=""#"">Shop with Points</a></li>
                                <li><a href=""#"">Reload Your Balance</a></li>
                                <li><a href=""#"">Paypal</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""item mini-links"">
                            <h4>About Us</h4>
                            <ul class=""flexcol"">
                                <li><a href=""#"">Company Info</a></li>
                                <li><a href=""#"">News</a></li>
                                <li><a href=""#"">Investors</a></li>
                                <li><a href=""#"">Careers</a></li>
                                <li><a href=""");
            WriteLiteral(@"#"">Policies</a></li>
                                <li><a href=""#"">Customer Reviews</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""footer-info"">
        <div class=""container"">
            <div class=""wrapper"">
                <div class=""flexcol"">
                    <div class=""logo"">
                        <a href=""#""><span class=""circle""></span>.Store</a>
                    </div>
                    <div class=""socials"">
                        <ul class=""flexitem"">

");
#nullable restore
#line 99 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\Shared\Components\DefFooter\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4602, "\"", 4618, 1);
#nullable restore
#line 101 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\Shared\Components\DefFooter\Default.cshtml"
WriteAttributeValue("", 4609, item.URL, 4609, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 4622, "\"", 4640, 1);
#nullable restore
#line 101 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\Shared\Components\DefFooter\Default.cshtml"
WriteAttributeValue("", 4630, item.Logo, 4630, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 102 "C:\Users\HP\Desktop\FinalProject-Haqverdi_Mustafayev\FinalProject\Views\Shared\Components\DefFooter\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>

                <p class=""mini-text"">
                    Copyright <span id=""year""></span> &copy; .Store, All rights reserved.
                </p>
            </div>
        </div>
    </div>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Social>> Html { get; private set; }
    }
}
#pragma warning restore 1591
