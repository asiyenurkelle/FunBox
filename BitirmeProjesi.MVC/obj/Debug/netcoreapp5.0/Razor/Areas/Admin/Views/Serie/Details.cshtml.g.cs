#pragma checksum "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b34804fd0ebf5cba7c11e7cebed123235e8ba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Serie_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Serie/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b34804fd0ebf5cba7c11e7cebed123235e8ba3", @"/Areas/Admin/Views/Serie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Serie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BitirmeProjesi.Entities.Dtos.SerieDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 9 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
   Write(await Html.PartialAsync("_LayoutListGroupPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"col-lg-7\">\r\n\r\n            <div class=\"card mt-6\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "53b34804fd0ebf5cba7c11e7cebed123235e8ba33924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 348, "~/img/", 348, 6, true);
#nullable restore
#line 15 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
AddHtmlAttributeValue("", 354, Model.Serie.ThumbNail, 354, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"card-title\"></h3>\r\n                    <h4 class=\"text-info text-center\">");
#nullable restore
#line 18 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
                                                 Write(Model.Serie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
                                    Write(Model.Serie.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span class=\"text-info\">Yönetmen:</span>\r\n                    ");
#nullable restore
#line 21 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
               Write(Model.Serie.Scenarist);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <span class=\"text-info\">Süre:</span>\r\n                    ");
#nullable restore
#line 24 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
               Write(Model.Serie.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    <br />\r\n                    <span class=\"text-info\">Kategori:</span>\r\n                    ");
#nullable restore
#line 27 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
               Write(Model.Serie.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <span class=\"text-info\">Dizi Tarzı:</span>\r\n                    ");
#nullable restore
#line 30 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
               Write(Model.Serie.Production);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <br />
                </div>
            </div>
            <!-- /.card -->

            <div class=""card card-outline-secondary my-4"">
                <div class=""card-header  text-center"">
                    Dizi Yorumları
                </div>
                <div class=""card-body"">
                    <p>");
#nullable restore
#line 41 "C:\Users\asus\source\repos\BitirmeProjesi\BitirmeProjesi.MVC\Areas\Admin\Views\Serie\Details.cshtml"
                  Write(Model.Serie.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <small class=""text-muted"">Posted by Anonymous on 3/1/17</small>
                    <hr>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.</p>
                    <small class=""text-muted"">Posted by Anonymous on 3/1/17</small>
                    <hr>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.</p>
                    <small class=""text-muted"">Posted by Anonymous on 3/1/17</small>
                    <hr>
                    <a href=""#"" class=""btn btn-warning text-center"">Aktivitelere Ekle</a>
                </div>
            </div>
         
            <");
            WriteLiteral("!-- /.card -->\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BitirmeProjesi.Entities.Dtos.SerieDto> Html { get; private set; }
    }
}
#pragma warning restore 1591