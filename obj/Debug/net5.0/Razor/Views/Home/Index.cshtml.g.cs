#pragma checksum "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd89148b66462ec136860e463a2563fc420155cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Workm\Desktop\E-Shop\Views\_ViewImports.cshtml"
using eshop_srytr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Workm\Desktop\E-Shop\Views\_ViewImports.cshtml"
using eshop_srytr.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Workm\Desktop\E-Shop\Views\_ViewImports.cshtml"
using eshop_srytr.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Workm\Desktop\E-Shop\Views\_ViewImports.cshtml"
using eshop_srytr.Models.Database.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Workm\Desktop\E-Shop\Views\_ViewImports.cshtml"
using eshop_srytr.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Workm\Desktop\E-Shop\Views\_ViewImports.cshtml"
using eshop_srytr.Models.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd89148b66462ec136860e463a2563fc420155cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4564162b3ad89dadbd09df421135a4f9f4025cb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/homepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark mt-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd89148b66462ec136860e463a2563fc420155cc5832", async() => {
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
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<div class=\"container mt-4\">\n\n");
#nullable restore
#line 13 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
      
        if (Model != null && Model.CarouselItems != null && Model.CarouselItems.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"carousel\" class=\"carousel custom-carousel slide\" data-ride=\"carousel\">\n                <ol class=\"carousel-indicators\">\n");
#nullable restore
#line 18 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                      
                        for (int i = 0; i < Model.CarouselItems.Count; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-target=\"#carousel\" data-slide-to=\"");
#nullable restore
#line 23 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\n");
#nullable restore
#line 24 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-target=\"#carousel\" data-slide-to=\"");
#nullable restore
#line 27 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\n");
#nullable restore
#line 28 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ol>\n                <div class=\"carousel-inner\">\n");
#nullable restore
#line 33 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                      
                        for (int i = 0; i < Model.CarouselItems.Count; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item active\">\n                                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1364, "\"", 1405, 1);
#nullable restore
#line 39 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1370, Model.CarouselItems[i].ImageSource, 1370, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1406, "\"", 1444, 1);
#nullable restore
#line 39 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1412, Model.CarouselItems[i].ImageAlt, 1412, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n");
#nullable restore
#line 41 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\n                                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1701, "\"", 1742, 1);
#nullable restore
#line 45 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1707, Model.CarouselItems[i].ImageSource, 1707, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1743, "\"", 1781, 1);
#nullable restore
#line 45 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1749, Model.CarouselItems[i].ImageAlt, 1749, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n");
#nullable restore
#line 47 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carousel"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carousel"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
");
#nullable restore
#line 60 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n<!-- Section-->\n<section class=\"py-5\">\n    <div class=\"container px-4 px-lg-5 mt-5\">\n        <div class=\"row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-start\">\n");
#nullable restore
#line 69 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
              
                if (Model != null && Model.ProductItems != null && Model.ProductItems.Count > 0) {
                    for (int i = 0; i < Model.ProductItems.Count; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col mb-5\">\n                            <div class=\"card h-100\">\n                                <!-- Product image-->\n                                <img class=\"card-img-top p-4\"");
            BeginWriteAttribute("src", " src=\"", 3083, "\"", 3123, 1);
#nullable restore
#line 75 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 3089, Model.ProductItems[i].ImageSource, 3089, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""..."" />
                                <!-- Product details-->
                                <div class=""card-body p-4"">
                                    <div class=""text-center"">
                                        <!-- Product name-->
                                        <h5 class=""fw-bolder"">");
#nullable restore
#line 80 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                                                         Write(Model.ProductItems[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                        <!-- Product price-->\n                                        ");
#nullable restore
#line 82 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                                   Write(Model.ProductItems[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" K??


                                        <div class=""rating"" style=""margin: 0 auto;"">
                                            <div class=""rating__inputs"">
                                                <input name=""rated_product"" type=""radio"" value=""1"">
                                                <input name=""rated_product"" type=""radio"" value=""2"">
                                                <input name=""rated_product"" type=""radio"" value=""3"">
                                                <input name=""rated_product"" type=""radio"" value=""4"">
                                                <input name=""rated_product"" type=""radio"" value=""5"">
                                            </div>

                                            <div class=""rating__stars"">
                                                <meter class=""rating__score""");
            BeginWriteAttribute("value", " value=\"", 4466, "\"", 4510, 1);
#nullable restore
#line 95 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
WriteAttributeValue("", 4474, Model.ProductItems[i].ProductRating, 4474, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" min=""0"" max=""5""></meter>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                                <!-- Product actions-->
                                <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                                    <div class=""text-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd89148b66462ec136860e463a2563fc420155cc16269", async() => {
                WriteLiteral("P??ej??t na detail produktu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                                                                                                                                                   WriteLiteral(Model.ProductItems[i].ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 107 "C:\Users\Workm\Desktop\E-Shop\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
