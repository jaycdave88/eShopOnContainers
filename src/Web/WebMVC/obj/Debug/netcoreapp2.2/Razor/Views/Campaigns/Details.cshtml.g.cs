#pragma checksum "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945efbab4ba6ca3cdcd981f35cb3e6f77ef75540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaigns_Details), @"mvc.1.0.view", @"/Views/Campaigns/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Campaigns/Details.cshtml", typeof(AspNetCore.Views_Campaigns_Details))]
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
#line 1 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\_ViewImports.cshtml"
using Microsoft.eShopOnContainers.WebMVC;

#line default
#line hidden
#line 2 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\_ViewImports.cshtml"
using Microsoft.eShopOnContainers.WebMVC.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945efbab4ba6ca3cdcd981f35cb3e6f77ef75540", @"/Views/Campaigns/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8df6003e341ae5961d037ca28f95085b4c0136", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaigns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampaignItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("esh-campaigns-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/main_banner_text.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml"
  
    ViewData["Title"] = "Campaign details";

    var headerList= new List<Header>() {
        new Header() { Controller = "Catalog", Text = "Back to catalog" },
        new Header() { Controller = "Campaigns", Text = "Back to Campaigns" } };

#line default
#line hidden
            BeginContext(268, 73, true);
            WriteLiteral("<section class=\"esh-campaigns-hero\">\n    <div class=\"container\">\n        ");
            EndContext();
            BeginContext(341, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "945efbab4ba6ca3cdcd981f35cb3e6f77ef755405234", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(412, 24, true);
            WriteLiteral("\n    </div>\n</section>\n\n");
            EndContext();
            BeginContext(436, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "945efbab4ba6ca3cdcd981f35cb3e6f77ef755406510", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 16 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = headerList;

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
            BeginContext(481, 102, true);
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"card esh-campaigns-items\">\n        <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 583, "\"", 606, 1);
#line 20 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml"
WriteAttributeValue("", 589, Model.PictureUri, 589, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(607, 90, true);
            WriteLiteral(" alt=\"Card image cap\">\n        <div class=\"card-body\">\n            <h4 class=\"card-title\">");
            EndContext();
            BeginContext(698, 10, false);
#line 22 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(708, 39, true);
            WriteLiteral("</h4>\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(748, 17, false);
#line 23 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml"
                            Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(765, 114, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"card-footer\">\n            <small class=\"text-muted\">\n                From ");
            EndContext();
            BeginContext(880, 36, false);
#line 27 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml"
                Write(Model.From.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(916, 7, true);
            WriteLiteral(" until ");
            EndContext();
            BeginContext(924, 34, false);
#line 27 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\Campaigns\Details.cshtml"
                                                            Write(Model.To.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(958, 54, true);
            WriteLiteral("\n            </small>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampaignItem> Html { get; private set; }
    }
}
#pragma warning restore 1591