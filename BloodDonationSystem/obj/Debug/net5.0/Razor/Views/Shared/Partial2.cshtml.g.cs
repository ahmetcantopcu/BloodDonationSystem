#pragma checksum "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Partial2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31eb351293f4d853a949395ac60cf89525eb6b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial2), @"mvc.1.0.view", @"/Views/Shared/Partial2.cshtml")]
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
#line 1 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\_ViewImports.cshtml"
using BloodDonationSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\_ViewImports.cshtml"
using BloodDonationSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Partial2.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31eb351293f4d853a949395ac60cf89525eb6b47", @"/Views/Shared/Partial2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b72c2ed3edca8ecdac64786a0e23cd9f0fab80", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Partial2.cshtml"
   
    string fullname = Context.Session.GetString("fullname");

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<div class=\"col-md-4 top-forms text-center mt-lg-3 mt-md-1 mt-0\">\r\n    <span>Welcome, ");
#nullable restore
#line 7 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Partial2.cshtml"
              Write(fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
    <span class=""mx-lg-4 mx-md-2  mx-1"">
        <a href=""/Login/Index/"">
            <font class=""fas fa-lock"" color=""#FF0000""></font> Sign In
        </a>
    </span>
    <span class=""mx-lg-4 mx-md-2  mx-1"">
        <a href=""/Dashboard/Index/"">
            <font class=""fas fa-lock"" color=""#FF0000""></font> My Profile
        </a>
    </span>
    <span>
        <a href=""/Register/Index/"">
            <font class=""fas fa-lock"" color=""#FF0000""></font> Sign Up
        </a>
    </span>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
