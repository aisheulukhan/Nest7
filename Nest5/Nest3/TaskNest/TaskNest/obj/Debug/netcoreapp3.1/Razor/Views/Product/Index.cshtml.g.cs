#pragma checksum "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2810784638ed0a574c12037bf57d122005b6cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2810784638ed0a574c12037bf57d122005b6cf9", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6bf3f5a72dc5107c9286c90c61434473c6e4ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        .product-img .default-img, .product-img .hover-img {\r\n            width: 190px;\r\n            height: 190px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<div class=\"container mt-30\">\r\n    <div class=\"row flex-row-reverse\">\r\n        <div class=\"col-lg-4-5\">\r\n            <div class=\"row product-grid\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2810784638ed0a574c12037bf57d122005b6cf94327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <!--end product card-->\r\n            </div>\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 540, "\"", 569, 1);
#nullable restore
#line 20 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
WriteAttributeValue("", 548, ViewBag.ProductCount, 548, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"proCount\" />\r\n            <div class=\"d-flex justify-content-center mb-30\">\r\n                <button class=\"btn btn-brand\" id=\"btnLoadMore\">Load more</button>\r\n            </div>\r\n            <!--product grid-->\r\n");
            WriteLiteral(@"            <!--End Deals-->
        </div>
        <div class=""col-lg-1-5 primary-sidebar sticky-sidebar"">
            <div class=""sidebar-widget widget-category-2 mb-30"">
                <h5 class=""section-title style-1 mb-30"">Category</h5>
                <ul>
");
#nullable restore
#line 48 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
                     foreach (Category item in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"category-filter\" data-id=\"");
#nullable restore
#line 50 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <a> <img");
            BeginWriteAttribute("src", " src=\"", 2395, "\"", 2428, 2);
            WriteAttributeValue("", 2401, "assets/imgs/shop/", 2401, 17, true);
#nullable restore
#line 51 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
WriteAttributeValue("", 2418, item.Logo, 2418, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2429, "\"", 2435, 0);
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 51 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span class=\"count\">");
#nullable restore
#line 51 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
                                                                                                             Write(item.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n");
#nullable restore
#line 53 "C:\Users\HP\Desktop\New folder (2)\Nest7\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <!-- Fillter By Price -->
            <div class=""sidebar-widget price_range range mb-30"">
                <h5 class=""section-title style-1 mb-30"">Fill by price</h5>
                <div class=""price-filter"">
                    <div class=""price-filter-inner"">
                        <div id=""slider-range"" class=""mb-20""></div>
                        <div class=""d-flex justify-content-between"">
                            <div class=""caption"">From: <strong id=""slider-range-value1"" class=""text-brand""></strong></div>
                            <div class=""caption"">To: <strong id=""slider-range-value2"" class=""text-brand""></strong></div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Product sidebar Widget -->
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on(""click"", ""#btnLoadMore"", function () {
            let skip = $("".product-grid"").children().length;
            let prodCount = $(""#proCount"").val();
            $.ajax({
                url: ""/Product/LoadMore"",
                method: 'GET',
                data: {
                    skip: skip
                },
                success: function (res) {
                    $("".product-grid"").append(res);
                    if ($("".product-grid"").children().length >= prodCount) {
                        $(""#btnLoadMore"").remove();
                    }
                }
            })
        })
        $(document).on(""click"", "".category-filter"", function () {
            let id = $(this).attr(""data-id"");
            $.ajax({
                url: ""/Product/CategoryFilter"",
                method: 'GET',
                data: {
                    CategoryId: id
                },
                success: function (res) {
                    ");
                WriteLiteral("$(\".product-grid\").html(res);\r\n                    \r\n                }\r\n            })\r\n        })\r\n    </script>\r\n   \r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
