#pragma checksum "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebStatus\Views\Home\Config.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e580d746ed1e64322cead10842441896562948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Config), @"mvc.1.0.view", @"/Views/Home/Config.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Config.cshtml", typeof(AspNetCore.Views_Home_Config))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e580d746ed1e64322cead10842441896562948", @"/Views/Home/Config.cshtml")]
    public class Views_Home_Config : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebStatus\Views\Home\Config.cshtml"
  
    ViewData["Title"] = "WebStatus Configuration";

#line default
#line hidden
            BeginContext(91, 40, true);
            WriteLiteral("\n<h1>Configuration Values</h1>\n\n<table>\n");
            EndContext();
#line 10 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebStatus\Views\Home\Config.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(170, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(200, 8, false);
#line 13 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebStatus\Views\Home\Config.cshtml"
           Write(item.Key);

#line default
#line hidden
            EndContext();
            BeginContext(208, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(231, 10, false);
#line 14 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebStatus\Views\Home\Config.cshtml"
           Write(item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(241, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 16 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebStatus\Views\Home\Config.cshtml"
    }

#line default
#line hidden
            BeginContext(267, 9, true);
            WriteLiteral("</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591