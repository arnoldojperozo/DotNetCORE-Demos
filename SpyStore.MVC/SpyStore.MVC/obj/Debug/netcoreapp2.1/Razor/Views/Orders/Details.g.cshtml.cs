#pragma checksum "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659418afd2faabc26d9ffb7d218c78d5174b5116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
#line 1 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC;

#line default
#line hidden
#line 2 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.WebServiceAccess;

#line default
#line hidden
#line 3 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.WebServiceAccess.Base;

#line default
#line hidden
#line 4 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.Entities;

#line default
#line hidden
#line 6 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.ViewModels.Base;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659418afd2faabc26d9ffb7d218c78d5174b5116", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec03bcea3de07d9112f2933877ce90791a284377", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderWithDetailsAndProductInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(83, 14, false);
#line 5 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
Write(ViewBag.Header);

#line default
#line hidden
            EndContext();
            BeginContext(97, 67, true);
            WriteLiteral("</h3>\n<div class=\"row top-row\">\n    <div class=\"col-sm-6\">\n        ");
            EndContext();
            BeginContext(164, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74fd3c101dc484fbdf69070f85ae4d9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 8 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 17, true);
            WriteLiteral("\n        <strong>");
            EndContext();
            BeginContext(217, 41, false);
#line 9 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(258, 56, true);
            WriteLiteral("</strong>\n    </div>\n    <div class=\"col-sm-6\">\n        ");
            EndContext();
            BeginContext(314, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d41470ff30434324adb9035929e8c47c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 12 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ShipDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(348, 17, true);
            WriteLiteral("\n        <strong>");
            EndContext();
            BeginContext(366, 40, false);
#line 13 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(model => model.ShipDate));

#line default
#line hidden
            EndContext();
            BeginContext(406, 994, true);
            WriteLiteral(@"</strong>
    </div>
</div>
<div class=""row"">
    <div class=""col-sm-6"">
        <label>Billing Address:</label>
        <address>
            <strong>John Doe</strong><br>
            123 State Street<br>
            Whatever, UT 55555<br>
            <abbr title=""Phone"">P:</abbr> (123) 456-7890
        </address>
    </div>
    <div class=""col-sm-6"">
        <label>Shipping Address:</label>
        <address>
            <strong>John Doe</strong><br>
            123 State Street<br>
            Whatever, UT 55555<br>
            <abbr title=""Phone"">P:</abbr> (123) 456-7890
        </address>
    </div>
</div>
<div class=""table-responsive"">
    <table class=""table table-bordered product-table"">
        <thead>
            <tr>
                <th style=""width: 70%;"">Product</th>
                <th class=""text-right"">Price</th>
                <th class=""text-right"">Quantity</th>
                <th class=""text-right"">Total</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 47 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
             for (int x=0;x<Model.OrderDetails.Count;x++)
            {
                var item = Model.OrderDetails[x];

#line default
#line hidden
            BeginContext(1522, 136, true);
            WriteLiteral("                <tr>\n                    <td>\n                        <div class=\"product-cell-detail\">\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1658, "\"", 1714, 1);
#line 53 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
WriteAttributeValue("", 1664, Url.Content($"~/images/{item.ProductImageThumb}"), 1664, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1715, 50, true);
            WriteLiteral(" class=\"pull-left\" />\n                            ");
            EndContext();
            BeginContext(1765, 261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693794bf941643739ffa5ca96b4cc98b", async() => {
                BeginContext(1919, 33, true);
                WriteLiteral("\n                                ");
                EndContext();
                BeginContext(1953, 40, false);
#line 57 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
                           Write(Html.DisplayFor(model => item.ModelName));

#line default
#line hidden
                EndContext();
                BeginContext(1993, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
                                 WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2026, 102, true);
            WriteLiteral("\n                            <div class=\"small text-muted hidden-xs\">\n                                ");
            EndContext();
            BeginContext(2129, 42, false);
#line 60 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
                           Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 161, true);
            WriteLiteral("\n                            </div>\n                        </div>\n                    </td>\n                    <td class=\"text-right\">\n                        ");
            EndContext();
            BeginContext(2333, 39, false);
#line 65 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => item.UnitCost));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 95, true);
            WriteLiteral("\n                    </td>\n                    <td class=\"text-right\">\n                        ");
            EndContext();
            BeginContext(2468, 39, false);
#line 68 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2507, 95, true);
            WriteLiteral("\n                    </td>\n                    <td class=\"text-right\">\n                        ");
            EndContext();
            BeginContext(2603, 44, false);
#line 71 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
                   Write(Html.DisplayFor(model => item.LineItemTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2647, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 74 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2710, 206, true);
            WriteLiteral("        </tbody>\n        <tfoot>\n            <tr>\n                <th>&nbsp;</th>\n                <th>&nbsp;</th>\n                <th>&nbsp;</th>\n                <th class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(2917, 42, false);
#line 82 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
               Write(Html.DisplayFor(model => model.OrderTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2959, 108, true);
            WriteLiteral("\n                </th>\n            </tr>\n        </tfoot>\n    </table>\n</div>\n\n<div class=\"pull-right\">\n    ");
            EndContext();
            BeginContext(3067, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2701d813a938417c91007e558acfa175", async() => {
                BeginContext(3154, 21, true);
                WriteLiteral("Back to Order History");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-customerid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Orders\Details.cshtml"
                                    WriteLiteral(Model.CustomerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-customerid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3179, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderWithDetailsAndProductInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
