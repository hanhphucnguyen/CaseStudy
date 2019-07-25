#pragma checksum "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b419afb12d8003f67838cba26c44ffd086bab4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy;

#line default
#line hidden
#line 2 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Models;

#line default
#line hidden
#line 3 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Utils;

#line default
#line hidden
#line 4 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b419afb12d8003f67838cba26c44ffd086bab4a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be391ecc98a96d33b0c2948e08797b31802bbf57", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 255, true);
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-title text-center mt-5\">\r\n        <h3 class=\"font-weight-bold\">Cart Contents</h3>\r\n        <img src=\"/images/cart.png\" style=\"height:10%;width:10%;padding-bottom:5%;\" />\r\n    </div>\r\n    <div class=\"text-center\">\r\n");
            EndContext();
#line 11 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
          
            Dictionary<int, object> cart = Context.Session.Get<Dictionary<int, Object>>("cart");
            float priceTot = 0.0f;
            float taxTot = 0.0f;
            float priceFinal = 0.0f;
        

#line default
#line hidden
            BeginContext(572, 275, true);
            WriteLiteral(@"        <table class=""table table-striped"">
            <tr style=""font-weight:bolder;"">
                <th class=""text-center"">Qty</th>
                <th class=""text-center"">Product Name</th>
                <th class=""text-left"">Description</th>
            </tr>
");
            EndContext();
#line 23 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
              
                if (cart != null)
                {
                    foreach (var key in cart.Keys)
                    {
                        MenuProductViewModel item = JsonConvert.DeserializeObject
                        <MenuProductViewModel>
                        (Convert.ToString(cart[key]));
                        if (item.Qty > 0)
                        {
                            priceTot += item.MSRP * item.Qty;
                            taxTot = priceTot * 0.13f;
                            priceFinal = taxTot + priceTot;

#line default
#line hidden
            BeginContext(1429, 82, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\">");
            EndContext();
            BeginContext(1512, 8, false);
#line 37 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                                               Write(item.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(1520, 59, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
            EndContext();
            BeginContext(1580, 8, false);
#line 38 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                                               Write(item.PRO);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-left\">");
            EndContext();
            BeginContext(1646, 16, false);
#line 39 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                                             Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                        }
                    }
                }
            

#line default
#line hidden
            BeginContext(1784, 422, true);
            WriteLiteral(@"        </table>
        <hr />
        <table class=""table table-striped"">
            <tr>
                <th colspan=""4"" class=""text-left"" style=""font-size:large;font-weight:bold;"">
                    Cart
                    Totals
                </th>
            </tr>
            <tr>
                <td class=""text-right font-weight-bold"">Price:$</td>
                <td class=""text-left"" id=""cal"">");
            EndContext();
            BeginContext(2207, 8, false);
#line 56 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                                          Write(priceTot);

#line default
#line hidden
            EndContext();
            BeginContext(2215, 159, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"text-right font-weight-bold\">Tax:$</td>\r\n                <td class=\"text-left\" id=\"cal\">");
            EndContext();
            BeginContext(2375, 6, false);
#line 60 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                                          Write(taxTot);

#line default
#line hidden
            EndContext();
            BeginContext(2381, 161, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"text-right font-weight-bold\">Total:$</td>\r\n                <td class=\"text-left\" id=\"cal\">");
            EndContext();
            BeginContext(2543, 10, false);
#line 64 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                                          Write(priceFinal);

#line default
#line hidden
            EndContext();
            BeginContext(2553, 96, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n        <div class=\"text-center mb-3\">\r\n            ");
            EndContext();
            BeginContext(2649, 409, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4480917772442da8d29749bd36e47ed", async() => {
                BeginContext(2724, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 69 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                 if (Context.Session.Get(SessionVariables.User) != null)
                {

#line default
#line hidden
                BeginContext(2819, 106, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-sm btn-primary\" id=\"modalbtn\">Add Cart</button>\r\n");
                EndContext();
#line 72 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2944, 107, true);
                WriteLiteral("                &nbsp;<a href=\"/Cart/ClearCart\" class=\"btn btn-sm btn-success\">Clear Cart</a>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3058, 47, true);
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
