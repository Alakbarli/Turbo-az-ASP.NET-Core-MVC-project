#pragma checksum "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bfe9d18db8b67648c5099418c99ad054cb298ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Meqale_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Meqale/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Meqale/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Meqale_Detail))]
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
#line 1 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\_ViewImports.cshtml"
using Turbo;

#line default
#line hidden
#line 2 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\_ViewImports.cshtml"
using Turbo.Models;

#line default
#line hidden
#line 3 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\_ViewImports.cshtml"
using Turbo.DAL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfe9d18db8b67648c5099418c99ad054cb298ce", @"/Areas/Admin/Views/Meqale/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c703f19b5a3f3e46f815516d0d7428f4f374a388", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Meqale_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Turbo.ViewModel.ElanYaratViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Meqale", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Please login or sign to write a comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "signin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(49, 79, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">");
            EndContext();
            BeginContext(128, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba8d8394151c4ae092494b0cad01370e", async() => {
                BeginContext(196, 11, true);
                WriteLiteral("Go to Posts");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(211, 53, true);
            WriteLiteral("</div>\r\n        <div class=\"col-lg-10\">\r\n            ");
            EndContext();
            BeginContext(264, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "336a426bc8e24a0a9281cf62f2f6e7c9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 312, "~/images/Cars/", 312, 14, true);
#line 9 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
AddHtmlAttributeValue("", 326, Model.Meqale.Sekil, 326, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(349, 36, true);
            WriteLiteral("\r\n            <h2>\r\n                ");
            EndContext();
            BeginContext(386, 19, false);
#line 11 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
           Write(Model.Meqale.Basliq);

#line default
#line hidden
            EndContext();
            BeginContext(405, 74, true);
            WriteLiteral("\r\n            </h2>\r\n            <p class=\"text-nowrap\">\r\n                ");
            EndContext();
            BeginContext(480, 30, false);
#line 14 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
           Write(Html.Raw(Model.Meqale.Melumat));

#line default
#line hidden
            EndContext();
            BeginContext(510, 56, true);
            WriteLiteral("\r\n            </p>\r\n            <span>\r\n                ");
            EndContext();
            BeginContext(567, 56, false);
#line 17 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
           Write(Model.Meqale.YazilmaVaxti.ToString("dd MMMM yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(623, 106, true);
            WriteLiteral("\r\n            </span>\r\n            <p>\r\n                Yazici:\r\n                <a>\r\n                    ");
            EndContext();
            BeginContext(730, 20, false);
#line 22 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
               Write(Model.Meqale.User.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(750, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(753, 23, false);
#line 22 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                                      Write(Model.Meqale.User.Soyad);

#line default
#line hidden
            EndContext();
            BeginContext(776, 42, true);
            WriteLiteral("\r\n                </a>\r\n            </p>\r\n");
            EndContext();
#line 25 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(875, 35, true);
            WriteLiteral("                <button data-post=\"");
            EndContext();
            BeginContext(911, 15, false);
#line 27 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                              Write(Model.Meqale.Id);

#line default
#line hidden
            EndContext();
            BeginContext(926, 71, true);
            WriteLiteral("\" class=\"btn btn-danger delete\">Meqaleni sil</button>\r\n                ");
            EndContext();
            BeginContext(997, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be53bd10e6c24d508d9fd7c4c0a15b38", async() => {
                BeginContext(1095, 6, true);
                WriteLiteral("Yenile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                                                               WriteLiteral(Model.Meqale.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"


            }

#line default
#line hidden
            BeginContext(1126, 225, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h3>\r\n                Reyler\r\n            </h3>\r\n        </div>\r\n        <hr />\r\n        <div class=\"col-lg-8\">\r\n");
            EndContext();
#line 45 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
              


                if (!User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(1443, 87, true);
            WriteLiteral("                    <textarea disabled id=\"commentText\" style=\"width:70%\"></textarea>\r\n");
            EndContext();
#line 51 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1590, 78, true);
            WriteLiteral("                    <textarea id=\"commentText\" style=\"width:70%\"></textarea>\r\n");
            EndContext();
#line 55 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                }

            

#line default
#line hidden
            BeginContext(1704, 48, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-4\">\r\n");
            EndContext();
#line 60 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
              
                if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(1839, 81, true);
            WriteLiteral("                    <a class=\"writeComment btn btn-success\">Write a comment</a>\r\n");
            EndContext();
#line 64 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1980, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2000, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129a5d1b4f2440cfb6808de7afc8d7c1", async() => {
                BeginContext(2121, 15, true);
                WriteLiteral("Write a comment");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 68 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                }

            

#line default
#line hidden
            BeginContext(2178, 84, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <hr />\r\n    <div class=\"row userComments\">\r\n");
            EndContext();
#line 79 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
         if (@Model.Reyler != null)
        {
            

#line default
#line hidden
#line 81 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
             foreach (var comment in Model.Reyler)
            {

#line default
#line hidden
            BeginContext(2377, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2393, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12f5912b67eb40ea837e35ab672a77db", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 83 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = comment;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2444, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 84 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
            }

#line default
#line hidden
#line 84 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2472, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2509, 956, true);
                WriteLiteral(@"
    <script>

        $("".delete"").click(function (e) {
            e.preventDefault();
            let id = $(this).attr(""data-post"");
            let res = true;

            $.ajax({
                url: ""/admin/Meqale/delete/"" + id,
                type: ""POST"",
                success: function (res) {
                    if (res === ""false"") {
                        alert(""Post is not found"");
                        res = false;
                        return;
                    }
                    res = true;
                    alert(""Post deleted"");


                }


            })
            if (res) {
                $(this).parent(""div"").html(""Post Deleted"");
            }

        })

        $("".writeComment"").click(function () {

            let text = $(""#commentText"").val();
            if (text.trim()) {
                $.ajax({
                    url: ""/Meqale/WriteComment/"" +");
                EndContext();
                BeginContext(3466, 15, false);
#line 124 "C:\Users\Ulvi\source\repos\Turbo\Turbo\Areas\Admin\Views\Meqale\Detail.cshtml"
                                             Write(Model.Meqale.Id);

#line default
#line hidden
                EndContext();
                BeginContext(3481, 387, true);
                WriteLiteral(@"+""/""+ text,
                    type: ""POST"",
                    success: function (res) {


                        $("".userComments"").append(res);
                        $(""#commentText"").val("""");

                    }
                })
            }
            else {

                alert(""Write comment!!!!"");
            }
        }
        )
    </script>
");
                EndContext();
            }
            );
            BeginContext(3871, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Turbo.ViewModel.ElanYaratViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
