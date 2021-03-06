#pragma checksum "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01a8e4b4ad7fef273cf3193d207796cc1ad3a72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EvaluationListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EvaluationListDashboard/Default.cshtml")]
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
#line 1 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01a8e4b4ad7fef273cf3193d207796cc1ad3a72", @"/Views/Shared/Components/EvaluationListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b72c2ed3edca8ecdac64786a0e23cd9f0fab80", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EvaluationListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Evaluation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Recent Evaluations</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Title </th>
                                <th> Subject </th>
                                <th> Date </th>
                                <th> Details </th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 21 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 952, "\"", 979, 1);
#nullable restore
#line 25 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
WriteAttributeValue("", 958, item.EvaluationImage, 958, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\">\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 27 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
                                Write(item.EvaluationTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                \r\n\r\n                                <td> ");
#nullable restore
#line 30 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
                                Write(item.EvaluationContent.Substring(0, item.EvaluationContent.Substring(0, 100).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </td>\r\n\r\n                                <td> ");
#nullable restore
#line 32 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
                                 Write(((DateTime)item.EvaluationCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1479, "\"", 1534, 2);
            WriteAttributeValue("", 1486, "/Evaluation/EvaluationReadAll/", 1486, 30, true);
#nullable restore
#line 35 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
WriteAttributeValue("", 1516, item.EvaluationID, 1516, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-dark\">Details</a>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\ahmet\source\repos\BloodDonationSystem\BloodDonationSystem\Views\Shared\Components\EvaluationListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
