#pragma checksum "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ef8ca37b3e67fff6997a6da4d7462804b6084b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_ViewImports.cshtml"
using AuthSystem.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_ViewImports.cshtml"
using AuthSystem.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_ViewImports.cshtml"
using AuthSystem.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ef8ca37b3e67fff6997a6da4d7462804b6084b", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b6287429dcd4167a992a9d30197053880dde704", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_AuthLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""col-5 mt-5"">
        <div class=""card login-logout-card"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Identity/Account/Login"">
                            Log In
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Identity/Account/Register"">
                            Register
                        </a>
                    </li>
                </ul>
            </div>
            <div class=""card-body"">
                <div class=""row justify-content-center"">
                    <div class=""col-10 my-4"">
                        ");
#nullable restore
#line (25,26)-(25,38) 6 "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line (34,6)-(34,58) 6 "C:\Users\Chanaka\Desktop\Asp.Net-Core-MVC-Identity---Complete-User-Authentication-System-main\AuthSystem\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
        $(function () {
            const currentPage = location.pathname;
            $('.nav-tabs li a').each(function () {
                const $this = $(this);
                if (currentPage.toLowerCase().indexOf($this.attr('href').toLowerCase()) !== -1) {
                    $this.addClass('active');
                }
            })
        })
    </script>
");
            }
            );
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
