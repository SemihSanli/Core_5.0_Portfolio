#pragma checksum "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\AdminMessageSend.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c4373a0144c396c23b7fce566e065fd105279820e622c6916b4b0e9fed60b08e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_AdminMessage_AdminMessageSend), @"mvc.1.0.view", @"/Views/AdminMessage/AdminMessageSend.cshtml")]
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

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c4373a0144c396c23b7fce566e065fd105279820e622c6916b4b0e9fed60b08e", @"/Views/AdminMessage/AdminMessageSend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"85c612690cbe8c201a9340df3effb17cb9edeaf74ca322c72f7a2fe563d7770c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_AdminMessage_AdminMessageSend : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\AdminMessageSend.cshtml"
       EntityLayer.Concrete.WriterMessage

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\AdminMessageSend.cshtml"
  
    ViewData["Title"] = "AdminMessageSend";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n\r\n            <p class=\"card-description\"> Yeni Mesaj Gönderme Paneli </p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4373a0144c396c23b7fce566e065fd105279820e622c6916b4b0e9fed60b08e4970", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label>Konu</label>\r\n                    ");
                Write(
#nullable restore
#line 15 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\AdminMessageSend.cshtml"
                     Html.TextBoxFor(x => x.Subject, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Alıcı</label>\r\n                    ");
                Write(
#nullable restore
#line 19 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\AdminMessageSend.cshtml"
                     Html.TextBoxFor(x => x.Receiver, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Mesaj</label>\r\n                    ");
                Write(
#nullable restore
#line 23 "C:\Users\Semih\source\repos\Dot_Net_Core_Project\Dot_Net_Core_Project\Views\AdminMessage\AdminMessageSend.cshtml"
                     Html.TextAreaFor(x => x.MessageContent,8,3, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary mr-2\">Gönder</button>\r\n                <button class=\"btn btn-dark\">İptal</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.WriterMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
