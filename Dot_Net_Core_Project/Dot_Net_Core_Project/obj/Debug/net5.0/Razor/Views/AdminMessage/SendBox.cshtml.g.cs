#pragma checksum "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ba173b3ad2e5a2f13f39661f6d7f76fba72c8a087ea97c18a2cbe7e2966021b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_AdminMessage_SendBox), @"mvc.1.0.view", @"/Views/AdminMessage/SendBox.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ba173b3ad2e5a2f13f39661f6d7f76fba72c8a087ea97c18a2cbe7e2966021b4", @"/Views/AdminMessage/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"85c612690cbe8c201a9340df3effb17cb9edeaf74ca322c72f7a2fe563d7770c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_AdminMessage_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
       List<WriterMessage>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
  
    ViewData["Title"] = "SendBox";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar-Admin Gelen Mesaj Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th class=""text-warning"">#</th>
                            <th class=""text-warning"">Alıcı</th>
                            <th class=""text-warning"">Konu</th>
                            <th class=""text-warning"">Tarih</th>
                            <th class=""text-danger"">Sil</th>
                            <th class=""text-success"">Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <td class=\"text-secondary\">");
            Write(
#nullable restore
#line 28 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                                                            item.WriterMessageID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td class=\"text-secondary\">");
            Write(
#nullable restore
#line 29 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                                                            item.ReceiverName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td class=\"text-secondary\">");
            Write(
#nullable restore
#line 30 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                                                            item.Subject

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td class=\"text-secondary\">");
            Write(
#nullable restore
#line 31 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                                                            item.Date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1434, "\"", 1495, 2);
            WriteAttributeValue("", 1441, "/AdminMessage/AdminMessageDelete/", 1441, 33, true);
            WriteAttributeValue("", 1474, 
#nullable restore
#line 32 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                                                                               item.WriterMessageID

#line default
#line hidden
#nullable disable
            , 1474, 21, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1580, "\"", 1642, 2);
            WriteAttributeValue("", 1587, "/AdminMessage/AdminMessageDetails/", 1587, 34, true);
            WriteAttributeValue("", 1621, 
#nullable restore
#line 33 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                                                                                item.WriterMessageID

#line default
#line hidden
#nullable disable
            , 1621, 21, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesajı Gör</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\SendBox.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                \r\n\r\n                    </tbody>\r\n\r\n                </table>\r\n\r\n                <br />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
