#pragma checksum "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ed17fd1e6761a923e9593cbdf076408da01c80b65bbc89945b5e6e737d3e5283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ed17fd1e6761a923e9593cbdf076408da01c80b65bbc89945b5e6e737d3e5283", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"85c612690cbe8c201a9340df3effb17cb9edeaf74ca322c72f7a2fe563d7770c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
       List<Skill>

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
#line 3 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"


<div class=""card-header border-0"">
    <h3 class=""mb-0"">Yetenek Listesi</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">      
");
#nullable restore
#line 27 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
             foreach(var item in Model){

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <th class=\"text-light\">");
            Write(
#nullable restore
#line 29 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
                                        item.SkillID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <td class=\"text-primary\">\r\n                    ");
            Write(
#nullable restore
#line 31 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
                     item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"d-flex align-items-center\">\r\n                        <span class=\"text-warning\">");
            Write(
#nullable restore
#line 35 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
                                                    item.Value

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" %</span>\r\n                        <div>\r\n                            <div class=\"progress\">\r\n                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1411, "\"", 1438, 1);
            WriteAttributeValue("", 1427, 
#nullable restore
#line 38 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
                                                                                                            item.Value

#line default
#line hidden
#nullable disable
            , 1427, 11, false);
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1477, "\"", 1505, 3);
            WriteAttributeValue("", 1485, "width:", 1485, 6, true);
            WriteAttributeValue(" ", 1491, 
#nullable restore
#line 38 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
                                                                                                                                                                             item.Value

#line default
#line hidden
#nullable disable
            , 1492, 11, false);
            WriteAttributeValue("", 1503, "%;", 1503, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1660, "\"", 1699, 2);
            WriteAttributeValue("", 1667, "/Skill/DeleteSkill/", 1667, 19, true);
            WriteAttributeValue("", 1686, 
#nullable restore
#line 43 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
                                                     item.SkillID

#line default
#line hidden
#nullable disable
            , 1686, 13, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n             <td><a");
            BeginWriteAttribute("href", " href=\"", 1765, "\"", 1802, 2);
            WriteAttributeValue("", 1772, "/Skill/EditSkill/", 1772, 17, true);
            WriteAttributeValue("", 1789, 
#nullable restore
#line 44 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
                                            item.SkillID

#line default
#line hidden
#nullable disable
            , 1789, 13, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Skill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </table>\r\n   \r\n    <a href=\"/Skill/AddSkill/\" class=\"btn btn-outline-primary\">Yeni Yetenek Ekle</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
