#pragma checksum "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\SlideList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "af0f26a03d03fff8360b5b71708d17d5afb8b0b104575ddfabe7de4301da29f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_SlideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SlideList/Default.cshtml")]
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
#line 1 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\SlideList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"af0f26a03d03fff8360b5b71708d17d5afb8b0b104575ddfabe7de4301da29f7", @"/Views/Shared/Components/SlideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"85c612690cbe8c201a9340df3effb17cb9edeaf74ca322c72f7a2fe563d7770c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_SlideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\SlideList\Default.cshtml"
       List<Portfolio>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/faces/face12.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-6 col-xl-4 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Proje Görselleri</h4>
            <div class=""owl-carousel owl-theme full-width owl-carousel-dash portfolio-carousel"" id=""owl-carousel-basic"">
");
#nullable restore
#line 8 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\SlideList\Default.cshtml"
                 foreach(var item in Model){

#line default
#line hidden
#nullable disable

            WriteLiteral("             <div class=\"item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 451, "\"", 471, 1);
            WriteAttributeValue("", 457, 
#nullable restore
#line 10 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\SlideList\Default.cshtml"
                               item.ImageUrl

#line default
#line hidden
#nullable disable
            , 457, 14, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 472, "\"", 478, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"350\">\r\n                </div>\r\n");
#nullable restore
#line 12 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\Shared\Components\SlideList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </div>\r\n            <div class=\"d-flex py-4\">\r\n                <div class=\"preview-list w-100\">\r\n                    <div class=\"preview-item p-0\">\r\n                        <div class=\"preview-thumbnail\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af0f26a03d03fff8360b5b71708d17d5afb8b0b104575ddfabe7de4301da29f76813", async() => {
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
            WriteLiteral(@"
                        </div>
                        <div class=""preview-item-content d-flex flex-grow"">
                            <div class=""flex-grow"">
                                <div class=""d-flex d-md-block d-xl-flex justify-content-between"">
                                    <h6 class=""preview-subject"">Semih Şanlı</h6>
                                </div>
                                <p class=""text-muted""> Jr.Net Dev.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <p class=""text-muted"">Projeler ait görseller. </p>
            <div class=""progress progress-md portfolio-progress"">
                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </div>
          
        </div>
    </div>
</div>");
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
