#pragma checksum "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b53623990d5e894219d4a42dbf2f02d77c37dc0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderManagement_Index), @"mvc.1.0.view", @"/Views/OrderManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderManagement/Index.cshtml", typeof(AspNetCore.Views_OrderManagement_Index))]
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
#line 3 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
using Microsoft.eShopOnContainers.WebMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53623990d5e894219d4a42dbf2f02d77c37dc0d", @"/Views/OrderManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8df6003e341ae5961d037ca28f95085b4c0136", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.eShopOnContainers.WebMVC.ViewModels.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "actionCode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderProcess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(126, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
  
     ViewData["Title"] = "My Orders";
     var headerList = new List<Header>() {
          new Header() { Controller = "Catalog", Text = "Back to catalog" } };

#line default
#line hidden
            BeginContext(292, 30, true);
            WriteLiteral("\n<div class=\"esh-orders\">\n    ");
            EndContext();
            BeginContext(322, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b53623990d5e894219d4a42dbf2f02d77c37dc0d6154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
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
            BeginContext(366, 440, true);
            WriteLiteral(@"

    <div class=""container"">
        <article class=""esh-orders-titles row"">
            <section class=""esh-orders-title col-2"">Order number</section>
            <section class=""esh-orders-title col-4"">Date</section>
            <section class=""esh-orders-title col-2"">Total</section>
            <section class=""esh-orders-title col-2"">Status</section>
            <section class=""esh-orders-title col-2""></section>
        </article>

");
            EndContext();
#line 23 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(853, 106, true);
            WriteLiteral("            <article class=\"esh-orders-items row\">\n                <section class=\"esh-orders-item col-2\">");
            EndContext();
            BeginContext(960, 46, false);
#line 26 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 66, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders-item col-4\">");
            EndContext();
            BeginContext(1073, 39, false);
#line 27 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 68, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders-item col-2\">$ ");
            EndContext();
            BeginContext(1181, 40, false);
#line 28 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 66, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders-item col-2\">");
            EndContext();
            BeginContext(1288, 41, false);
#line 29 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 87, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders-item col-2\">\n                    ");
            EndContext();
            BeginContext(1416, 646, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53623990d5e894219d4a42dbf2f02d77c37dc0d10688", async() => {
                BeginContext(1495, 60, true);
                WriteLiteral("\n                        <input type=\"hidden\" name=\"orderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1555, "\"", 1580, 1);
#line 32 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
WriteAttributeValue("", 1563, item.OrderNumber, 1563, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1581, 28, true);
                WriteLiteral(" />\n                        ");
                EndContext();
                BeginContext(1609, 425, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53623990d5e894219d4a42dbf2f02d77c37dc0d11609", async() => {
                    BeginContext(1847, 29, true);
                    WriteLiteral("\n                            ");
                    EndContext();
                    BeginContext(1876, 51, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53623990d5e894219d4a42dbf2f02d77c37dc0d12042", async() => {
                        BeginContext(1893, 25, true);
                        WriteLiteral("&nbsp;&nbsp;Select Action");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1927, 29, true);
                    WriteLiteral("\n                            ");
                    EndContext();
                    BeginContext(1956, 44, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53623990d5e894219d4a42dbf2f02d77c37dc0d13642", async() => {
                        BeginContext(1973, 18, true);
                        WriteLiteral("------------------");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2000, 25, true);
                    WriteLiteral("\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 33 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = item.ActionCodeSelectList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "disabled", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 34 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
AddHtmlAttributeValue("", 1715, item.Status != "paid", 1715, 24, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onchange", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1782, "document.getElementById(\'orderForm+", 1782, 35, true);
#line 35 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
AddHtmlAttributeValue("", 1817, item.OrderNumber, 1817, 17, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1834, "\').submit()", 1834, 11, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2034, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1452, "orderForm+", 1452, 10, true);
#line 31 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
AddHtmlAttributeValue("", 1462, item.OrderNumber, 1462, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2062, 51, true);
            WriteLiteral("\n                </section>\n            </article>\n");
            EndContext();
#line 42 "C:\Users\jay.dave\Desktop\Code\eShopOnContainers-dev\src\Web\WebMVC\Views\OrderManagement\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2123, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.eShopOnContainers.WebMVC.ViewModels.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591