#pragma checksum "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\Shared\_CommentBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48617cddeaf36624d542eb458e16947b095455ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentBox), @"mvc.1.0.view", @"/Views/Shared/_CommentBox.cshtml")]
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
#line 1 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\_ViewImports.cshtml"
using DA_TOTNGHIEP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\_ViewImports.cshtml"
using DA_TOTNGHIEP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\Shared\_CommentBox.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48617cddeaf36624d542eb458e16947b095455ca", @"/Views/Shared/_CommentBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ddd6a516917612813d59b90239939edd58e3a79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__CommentBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .starFade {
        background-image: url('https://upload.wikimedia.org/wikipedia/commons/archive/4/49/20120902203235%21Star_empty.svg');
        background-size: 30px 30px;
        min-width: 30px;
        min-height: 30px;
        display: inline-block;
        cursor: pointer;
    }

    .starFadeN {
        background-image: url('https://upload.wikimedia.org/wikipedia/commons/archive/4/49/20120902203235%21Star_empty.svg');
        background-size: 30px 30px;
        min-width: 30px;
        min-height: 30px;
        display: inline-block;
    }

    .starGlow {
        background-image: url('https://upload.wikimedia.org/wikipedia/commons/8/83/Article_de_qualit%C3%A9.svg');
        background-size: 30px 30px;
        min-width: 30px;
        min-height: 30px;
        display: inline-block;
        cursor: pointer;
    }

    .starGlowN {
        background-image: url('https://upload.wikimedia.org/wikipedia/commons/8/83/Article_de_qualit%C3%A9.svg');
        backgrou");
            WriteLiteral(@"nd-size: 30px 30px;
        min-width: 30px;
        min-height: 30px;
        display: inline-block;
    }

    .rating-count-details {
        font-size: 30px;
        padding: 10px 0px;
    }

        .rating-count-details .fa-star.checked {
            color: #F59E0B;
        }

        .rating-count-details .fa-star.unchecked {
            color: #808080;
        }
</style>
");
#nullable restore
#line 52 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\Shared\_CommentBox.cshtml"
 using (Html.BeginForm("Create", "Comments", FormMethod.Post, new { onsubmit = "return SubmitComment()" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\Shared\_CommentBox.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""comment-box"" style=""margin-top:2rem"">
        <div class=""form-group"">
            <h1>Đánh giá</h1>
            <div class=""col-md-7"">
                <div onmouseout=""CRateSelected()"">
                    <div class=""rating-count-details"">
                        <i class=""fas fa-star unchecked"" id=""Rate1"" onclick=""CRate(1)"" onmouseover=""CRateOver(1)"" onmouseout=""CRateOut(1)""></i>
                        <i class=""fas fa-star unchecked"" id=""Rate2"" onclick=""CRate(2)"" onmouseover=""CRateOver(2)"" onmouseout=""CRateOut(2)""></i>
                        <i class=""fas fa-star unchecked"" id=""Rate3"" onclick=""CRate(3)"" onmouseover=""CRateOver(3)"" onmouseout=""CRateOut(3)""></i>
                        <i class=""fas fa-star unchecked"" id=""Rate4"" onclick=""CRate(4)"" onmouseover=""CRateOver(4)"" onmouseout=""CRateOut(4)""></i>
                        <i class=""fas fa-star unchecked"" id=""Rate5"" onclick=""CRate(5)"" onmouseover=""CRateOver(5)"" onmouseout=""CRateOut(5)""></i>
                    </div>
       ");
            WriteLiteral(@"         </div>
            </div>
        </div>

        <h1>Bình luận</h1>
            <input class=""inputName"" type=""text"" name=""Email"" id=""Email"" placeholder=""Nhập tên..."" style=""font-family: 'Montserrat'; background: none;
          border: 1px solid #277cea; border-radius: 5px; color: #000; font-size: 15px;
          font-weight: bold; padding-left: 12px; margin-bottom: 5px;margin-top: 8px;"" required />
        <textarea class=""comment"" name=""ContentComment"" id=""ContentComment"" required rows=""5"" style=""width:100%;"" placeholder=""Nhập bình luận...""></textarea>
        <br>
        <div class=""form-group"">
            <div class=""col-md-12"">
                <input type=""hidden"" name=""ProductId""");
            BeginWriteAttribute("value", " value=\"", 3452, "\"", 3478, 1);
#nullable restore
#line 79 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\Shared\_CommentBox.cshtml"
WriteAttributeValue("", 3460, ViewBag.ProductId, 3460, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                <input type=""hidden"" name=""Rating"" id=""Rating"" value=""0"" />
                <button type=""submit"" id=""btnRegister"" name=""btnRegister"" value=""Gửi đánh giá"" class=""btn btn-warning"" style=""padding: 10px; border-radius: 5px; background: #d70018; color: #fff; cursor: pointer;"">Gửi đánh giá <i class=""far fa-paper-plane""></i></button>
            </div>
        </div>
    </div>
");
#nullable restore
#line 85 "D:\Project CKC\DATN - Main\DA_TOTNGHIEP\Views\Shared\_CommentBox.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function SubmitComment() {
        if ($(""#Rating"").val() == ""0"") {
            alert(""Ban chưa đánh giá !!!"");
            return false;
        }
        else {
            return true;
        }
    }
    function CRate(r) {
        $(""#Rating"").val(r);
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'fas fa-star checked');
        }
        // unselect remaining
        for (var i = r + 1; i <= 5; i++) {
            $(""#Rate"" + i).attr('class', 'fas fa-star unchecked');
        }
    }

    function CRateOver(r) {
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'fas fa-star checked');
        }
    }

    function CRateOut(r) {
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'fas fa-star unchecked');
        }
    }

    function CRateSelected() {
        var setRating = $(""#Rating"").val();
        for (var i = 1; i <= setRating; i++) {
            $(""#Rate"" + i)");
            WriteLiteral(".attr(\'class\', \'fas fa-star checked\');\r\n        }\r\n    }\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
