#pragma checksum "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd24256c822c7d4d57b62c9a2560d37353d36ea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blood_Index), @"mvc.1.0.view", @"/Views/Blood/Index.cshtml")]
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
#line 1 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd24256c822c7d4d57b62c9a2560d37353d36ea3", @"/Views/Blood/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b72c2ed3edca8ecdac64786a0e23cd9f0fab80", @"/Views/_ViewImports.cshtml")]
    public class Views_Blood_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blood>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Type</th>\r\n        <th>Stock</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 16 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml"
                   Write(item.BloodID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml"
                   Write(item.BloodType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml"
                   Write(item.BloodStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 20 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Blood\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blood>> Html { get; private set; }
    }
}
#pragma warning restore 1591
