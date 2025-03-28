#pragma checksum "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a032a957d873a1a9527601bd2848bb9861dfce231048e4c855fbcc8f8509759a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
namespace AspNetCoreGeneratedDocument
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
#line 1 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\_ViewImports.cshtml"
using Dot_Net_Core_Project

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\_ViewImports.cshtml"
using Dot_Net_Core_Project.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a032a957d873a1a9527601bd2848bb9861dfce231048e4c855fbcc8f8509759a", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"85c612690cbe8c201a9340df3effb17cb9edeaf74ca322c72f7a2fe563d7770c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
       List<Portfolio>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Ana Görsel</th>
                                <th> Proje Adı </th>
                                <th> URL </th>
                                <th> Fiyat </th>
                                <th> Tamamlanma Oranı </th>
                                <th> Durum </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n                                    <td> ");
            Write(
#nullable restore
#line 25 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.PortfolioID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1135, "\"", 1155, 1);
            WriteAttributeValue("", 1141, 
#nullable restore
#line 28 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                                                   item.ImageUrl

#line default
#line hidden
#nullable disable
            , 1141, 14, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>");
            Write(
#nullable restore
#line 30 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 31 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.ProjectUrl

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 32 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 33 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.Value

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" % </td>\r\n\r\n                                    <td>\r\n                                        <div class=\"badge badge-outline-success\">Approved</div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
