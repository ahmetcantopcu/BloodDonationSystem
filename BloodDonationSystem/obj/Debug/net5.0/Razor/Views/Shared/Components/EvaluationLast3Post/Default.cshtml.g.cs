#pragma checksum "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a0c6e821c614994d4e451e2082558811e768d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EvaluationLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EvaluationLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a0c6e821c614994d4e451e2082558811e768d7", @"/Views/Shared/Components/EvaluationLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b72c2ed3edca8ecdac64786a0e23cd9f0fab80", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EvaluationLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Evaluation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>Last Posts</h3>\r\n");
#nullable restore
#line 6 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 258, "\"", 313, 2);
            WriteAttributeValue("", 265, "/Evaluation/EvaluationReadAll/", 265, 30, true);
#nullable restore
#line 10 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
WriteAttributeValue("", 295, item.EvaluationID, 295, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 341, "\"", 368, 1);
#nullable restore
#line 11 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
WriteAttributeValue("", 347, item.EvaluationImage, 347, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 400, "\"", 406, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 550, "\"", 605, 2);
            WriteAttributeValue("", 557, "/Evaluation/EvaluationReadAll/", 557, 30, true);
#nullable restore
#line 17 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
WriteAttributeValue("", 587, item.EvaluationID, 587, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
                                                                          Write(item.EvaluationContent.Substring(0, item.EvaluationContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i>  ");
#nullable restore
#line 21 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
                                                  Write(((DateTime)item.EvaluationCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>           \r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationLast3Post\Default.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Evaluation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
