#pragma checksum "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7353207e3e0b06fa6674c39426da2b88d6fe00b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ImageProducts_DetailImages), @"mvc.1.0.view", @"/Areas/Admin/Views/ImageProducts/DetailImages.cshtml")]
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
#line 1 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\_ViewImports.cshtml"
using DA_TOTNGHIEP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\_ViewImports.cshtml"
using DA_TOTNGHIEP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7353207e3e0b06fa6674c39426da2b88d6fe00b", @"/Areas/Admin/Views/ImageProducts/DetailImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69eb05b105e90de7f973b2b4fc25a1aaa61369ec", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ImageProducts_DetailImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DA_TOTNGHIEP.Models.ImageProduct>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 130px;height: 130px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .modal-content {\r\n        width: 40rem;\r\n    }\r\n</style>\r\n<div>\r\n    <h3>Tất cả ảnh của <span class=\"badge bg-info\">");
#nullable restore
#line 13 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
                                              Write(Model.CodeImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n    <hr />\r\n    <div class=\"row\" style=\"text-align:center\">\r\n        <div class=\"col-md-4\">\r\n");
#nullable restore
#line 17 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
             if (Model.ImageName != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6 style=\"color:red\">*Hình ảnh chính*</h6>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7353207e3e0b06fa6674c39426da2b88d6fe00b5173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 529, "~/assetsAdmin/imgProducts/", 529, 26, true);
#nullable restore
#line 21 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
AddHtmlAttributeValue("", 555, Model.ImageName, 555, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 23 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 27 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-4\">\r\n");
#nullable restore
#line 30 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
             if (Model.ImageName1 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6>Hình ảnh 1</h6>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7353207e3e0b06fa6674c39426da2b88d6fe00b7774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 928, "~/assetsAdmin/imgProducts/", 928, 26, true);
#nullable restore
#line 34 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
AddHtmlAttributeValue("", 954, Model.ImageName1, 954, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 36 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 40 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-4\">\r\n");
#nullable restore
#line 43 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
             if (Model.ImageName2 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6>Hình ảnh 2</h6>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7353207e3e0b06fa6674c39426da2b88d6fe00b10376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1328, "~/assetsAdmin/imgProducts/", 1328, 26, true);
#nullable restore
#line 47 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
AddHtmlAttributeValue("", 1354, Model.ImageName2, 1354, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 49 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 53 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-4\" style=\"margin-top: 20px;\">\r\n");
#nullable restore
#line 56 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
             if (Model.ImageName3 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6>Hình ảnh 3</h6>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7353207e3e0b06fa6674c39426da2b88d6fe00b13011", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1754, "~/assetsAdmin/imgProducts/", 1754, 26, true);
#nullable restore
#line 60 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
AddHtmlAttributeValue("", 1780, Model.ImageName3, 1780, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 62 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 66 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-4\" style=\"margin-top: 20px;\">\r\n");
#nullable restore
#line 69 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
             if (Model.ImageName4 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6>Hình ảnh 4</h6>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7353207e3e0b06fa6674c39426da2b88d6fe00b15646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2180, "~/assetsAdmin/imgProducts/", 2180, 26, true);
#nullable restore
#line 73 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
AddHtmlAttributeValue("", 2206, Model.ImageName4, 2206, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 75 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\r\n");
#nullable restore
#line 79 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Areas\Admin\Views\ImageProducts\DetailImages.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DA_TOTNGHIEP.Models.ImageProduct> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
