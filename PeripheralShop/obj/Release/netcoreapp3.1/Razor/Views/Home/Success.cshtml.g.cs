#pragma checksum "C:\Users\abuni\source\repos\PeripheralShop\PeripheralShop\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b64fc6571bbd3ed0d0a2025ccb766aab89b09374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "C:\Users\abuni\source\repos\PeripheralShop\PeripheralShop\Views\_ViewImports.cshtml"
using PeripheralShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abuni\source\repos\PeripheralShop\PeripheralShop\Views\_ViewImports.cshtml"
using PeripheralShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b64fc6571bbd3ed0d0a2025ccb766aab89b09374", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f601a164d5825b6672bd4590d3beedc16e90cba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\abuni\source\repos\PeripheralShop\PeripheralShop\Views\Home\Success.cshtml"
  
    ViewData["Title"] = "Success";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"" style=""margin:20px; padding:50px;"">
    <h2> Congratulations!</h2>
    <p style=""text-align:center""> You have successfully placed an order. Please viist the store to make a payment and pick up your order.</p>
    <button class=""btn btn-dark""");
            BeginWriteAttribute("onclick", "\r\n            onclick=\"", 430, "\"", 497, 3);
            WriteAttributeValue("", 453, "location.href=\'", 453, 15, true);
#nullable restore
#line 12 "C:\Users\abuni\source\repos\PeripheralShop\PeripheralShop\Views\Home\Success.cshtml"
WriteAttributeValue("", 468, Url.Action("Index", "Home"), 468, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 496, "\'", 496, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        Continue Shopping\r\n    </button>\r\n</div>\r\n");
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
