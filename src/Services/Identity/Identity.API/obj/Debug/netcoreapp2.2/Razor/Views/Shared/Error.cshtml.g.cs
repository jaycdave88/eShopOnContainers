#pragma checksum "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ecca12f23fce95b29182002af27df34b17ea6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ecca12f23fce95b29182002af27df34b17ea6d5", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Microsoft.eShopOnContainers.Services.Identity.API.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            BeginContext(168, 232, true);
            WriteLiteral("\n<div class=\"error-page\">\n    <div class=\"page-header\">\n        <h1>Error</h1>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-6\">\n            <div class=\"alert alert-danger\">\n                Sorry, there was an error\n\n");
            EndContext();
#line 18 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
            BeginContext(454, 88, true);
            WriteLiteral("                    <strong>\n                        <em>\n                            : ");
            EndContext();
            BeginContext(543, 5, false);
#line 22 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(548, 61, true);
            WriteLiteral("\n                        </em>\n                    </strong>\n");
            EndContext();
#line 25 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(627, 20, true);
            WriteLiteral("            </div>\n\n");
            EndContext();
#line 28 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
            BeginContext(698, 52, true);
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
            EndContext();
            BeginContext(751, 10, false);
#line 30 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
            EndContext();
            BeginContext(761, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 31 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Services\Identity\Identity.API\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
            BeginContext(782, 33, true);
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microsoft.eShopOnContainers.Services.Identity.API.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591