#pragma checksum "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a1cadb917ebc0d05bd81167d8365895c952f7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Basket), @"mvc.1.0.view", @"/Views/Home/Basket.cshtml")]
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
#line 1 "C:\Users\aynur\source\repos\B4P\B4P\Views\_ViewImports.cshtml"
using B4P;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aynur\source\repos\B4P\B4P\Views\_ViewImports.cshtml"
using B4P.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a1cadb917ebc0d05bd81167d8365895c952f7e", @"/Views/Home/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b3877403e845933dc6a0df672316162953ca10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<B4P.ViewModels.GoodsInBasketModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"top-main\">\r\n    <div class=\"basket\">\r\n        <div><p class=\"main-popular\">У вас в корзине следующие товары</p></div>\r\n");
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td>\r\n                    <table class=\"basket1\">\r\n");
#nullable restore
#line 33 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
                         foreach (var item in Model?.Goods)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <div class=\"product-img-basket\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1316, "\"", 1323, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1375, "\"", 1399, 1);
#nullable restore
#line 39 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
WriteAttributeValue("", 1381, item.GoodPhotoUrl, 1381, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        </a>
                                    </div>
                                </td>
                                <td>
                                    <div class=""product-list"">
                                        <h3>");
#nullable restore
#line 45 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
                                       Write(item.GoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </div>\r\n                                    <div class=\"product-list\">\r\n                                        <p>");
#nullable restore
#line 48 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
                                      Write(item.GoodDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </td>\r\n                <td>\r\n                    <ul>\r\n");
#nullable restore
#line 57 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
                         foreach (var item in Model.Amount)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"product-list list-amount\"><p>Количество: ");
#nullable restore
#line 59 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
                                                                           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n");
#nullable restore
#line 60 "C:\Users\aynur\source\repos\B4P\B4P\Views\Home\Basket.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <div class=\"basket_pay\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a1cadb917ebc0d05bd81167d8365895c952f7e7918", async() => {
                WriteLiteral("Оплатить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<B4P.ViewModels.GoodsInBasketModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
