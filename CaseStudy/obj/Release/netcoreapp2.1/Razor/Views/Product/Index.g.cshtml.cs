#pragma checksum "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab47720e38a699ae61b611365dea0d0e454099d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab47720e38a699ae61b611365dea0d0e454099d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be391ecc98a96d33b0c2948e08797b31802bbf57", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 24, true);
            WriteLiteral("<h4>Products By Brand - ");
            EndContext();
            BeginContext(95, 15, false);
#line 5 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
                   Write(Model.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(110, 51, true);
            WriteLiteral("</h4>\r\n<ul class=\"list-group col-sm-8 col-xs-12\">\r\n");
            EndContext();
#line 7 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
      
        foreach (Product item in Model.Products)
        {

#line default
#line hidden
            BeginContext(230, 58, true);
            WriteLiteral("            <li class=\"list-group-item\">\r\n                ");
            EndContext();
            BeginContext(289, 16, false);
#line 11 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(305, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 13 "C:\Users\Phuc-pc\source\repos\CaseStudy\CaseStudy\Views\Product\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(344, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
