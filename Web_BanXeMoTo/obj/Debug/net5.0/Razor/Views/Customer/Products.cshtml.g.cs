#pragma checksum "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae213709282d6000d710e8dce69ef2380c41174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Products), @"mvc.1.0.view", @"/Views/Customer/Products.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae213709282d6000d710e8dce69ef2380c41174", @"/Views/Customer/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.CustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("aa-sort-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
  
    ViewData["Title"] = "Danh sách sản phẩm";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- product category -->
<section id=""aa-product-category"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 col-md-9 col-sm-8 col-md-push-3"">
                <div class=""aa-product-catg-content"">
                    <div class=""aa-product-catg-head"">
                        <div class=""aa-product-catg-head-left"">
                            <h1 style=""font-weight:bold"">HONDA</h1>
                            <hr style=""border-top: 1px solid #b98e8e;"" />
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae213709282d6000d710e8dce69ef2380c411745139", async() => {
                WriteLiteral("\n                                <label");
                BeginWriteAttribute("for", " for=\"", 821, "\"", 827, 0);
                EndWriteAttribute();
                WriteLiteral(">Sắp xếp theo : </label>\n                                <div class=\"aa-prod-view-bottom\">\n                                    ");
#nullable restore
#line 23 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
                               Write(Html.ActionLink("Giá tăng dần", "Products", new { sortOrder = "" }, new { @class = "aa-add-to-cart-btn", @style = "width: 150px; padding: 5px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
#nullable restore
#line 24 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
                               Write(Html.ActionLink("Giá giảm dần", "Products", new { sortOrder = "name_desc" }, new { @class = "aa-add-to-cart-btn", @style = "width: 150px; padding: 5px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </div>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <div style=\"float:right;margin-left: 160px;margin-top: 22px;\">\n\n");
#nullable restore
#line 29 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
                                 using (Html.BeginForm("Products", "Customer", FormMethod.Get, new { }))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""aa-prod-view-bottom"">
                                        <input type=""text"" id=""searchString"" name=""searchString"" placeholder=""Tìm kiếm"">
                                        <input type=""submit"" value=""Search"" class=""aa-add-to-cart-btn"" style=""width: 100px; padding: 5px;"" />
                                    </div>
");
#nullable restore
#line 35 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>


                    </div>
                    <div class=""aa-product-catg-body"">
                        <ul class=""aa-product-catg"">
                            <!-- start single product item -->
");
#nullable restore
#line 45 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
                             foreach (var mauXe in Model.ListMauXes)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li style=\"height:300px\">\n                                    <figure>\n                                        <a class=\"aa-product-img\"");
            BeginWriteAttribute("href", " href=\"", 2546, "\"", 2622, 1);
#nullable restore
#line 49 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
WriteAttributeValue("", 2553, Url.ActionLink("ProductDetails","Customer", new {id = mauXe.Idmau }), 2553, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2628, "\"", 2649, 1);
#nullable restore
#line 49 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
WriteAttributeValue("", 2634, mauXe.HinhAnh1, 2634, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"260\" height=\"180\"></a>\n                                        <a class=\"aa-add-card-btn\"");
            BeginWriteAttribute("href", " href=\"", 2747, "\"", 2824, 1);
#nullable restore
#line 50 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
WriteAttributeValue("", 2754, Url.ActionLink("ProductDetails","Customer", new {id =  mauXe.Idmau }), 2754, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"padding: 8px 0px;\"><span class=\"fa fa-shopping-cart\"></span>Mua ngay</a>\n                                        <figcaption>\n                                            <h4 class=\"aa-product-title\"><a");
            BeginWriteAttribute("href", " href=\"", 3034, "\"", 3111, 1);
#nullable restore
#line 52 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
WriteAttributeValue("", 3041, Url.ActionLink("ProductDetails","Customer", new {id =  mauXe.Idmau }), 3041, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(model => mauXe.TenXe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\n                                            <span class=\"aa-product-price\">");
#nullable restore
#line 53 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
                                                                      Write(string.Format("{0:N0}", ((Int64)mauXe.GiaBan)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n");
            WriteLiteral("                                        </figcaption>\n                                    </figure>\n                                    <!-- product badge -->\n");
            WriteLiteral("                                </li>\n");
#nullable restore
#line 60 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!-- start single product item -->
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-4 col-md-pull-9"">
                <aside class=""aa-sidebar"">
                    <!-- Honda -->
                    <div class=""aa-sidebar-widget"">
                        <h3>Honda</h3>
                        <ul class=""aa-catg-nav"">
                            <li><a href=""#"">Sport</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4270, "\"", 4277, 0);
            EndWriteAttribute();
            WriteLiteral(">SprotTouring</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4335, "\"", 4342, 0);
            EndWriteAttribute();
            WriteLiteral(">Classic</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4395, "\"", 4402, 0);
            EndWriteAttribute();
            WriteLiteral(@">Naked</a></li>
                        </ul>
                    </div>
                    <!-- Yamaha -->
                    <div class=""aa-sidebar-widget"">
                        <h3>Yamaha</h3>
                        <ul class=""aa-catg-nav"">
                            <li><a href=""#"">HyperNaked</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4751, "\"", 4758, 0);
            EndWriteAttribute();
            WriteLiteral(">SuperSport</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4814, "\"", 4821, 0);
            EndWriteAttribute();
            WriteLiteral(@">XSR</a></li>
                        </ul>
                    </div>
                    <!-- Kawasaki -->
                    <div class=""aa-sidebar-widget"">
                        <h3>Kawasaki</h3>
                        <ul class=""aa-catg-nav"">
                            <li><a href=""#"">Ninja</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 5167, "\"", 5174, 0);
            EndWriteAttribute();
            WriteLiteral(">Versys</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 5226, "\"", 5233, 0);
            EndWriteAttribute();
            WriteLiteral(@">Naked</a></li>
                        </ul>
                    </div>
                    <!-- Suzuki -->
                    <div class=""aa-sidebar-widget"">
                        <h3>Suzuki</h3>
                        <ul class=""aa-catg-nav"">
                            <li><a href=""#"">Naked</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 5577, "\"", 5584, 0);
            EndWriteAttribute();
            WriteLiteral(">Sport</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 5635, "\"", 5642, 0);
            EndWriteAttribute();
            WriteLiteral(@">ADV</a></li>
                        </ul>
                    </div>
                    <!-- Ducati -->
                    <div class=""aa-sidebar-widget"">
                        <h3>Ducati</h3>
                        <ul class=""aa-catg-nav"">
                            <li><a href=""#"">Naked Ducati</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 5991, "\"", 5998, 0);
            EndWriteAttribute();
            WriteLiteral(">Sport</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 6049, "\"", 6056, 0);
            EndWriteAttribute();
            WriteLiteral(@">Multitrada</a></li>
                        </ul>
                    </div>
                    <!-- BMW -->
                    <div class=""aa-sidebar-widget"">
                        <h3>BMW</h3>
                        <ul class=""aa-catg-nav"">
                            <li><a href=""#"">ADV</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 6397, "\"", 6404, 0);
            EndWriteAttribute();
            WriteLiteral(">Cafe racer</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 6460, "\"", 6467, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sport</a></li>
                        </ul>
                    </div>
                    <!-- KTM -->
                    <div class=""aa-sidebar-widget"">
                        <h3>KTM</h3>
                        <ul class=""aa-catg-nav"">
                            <li><a href=""#"">Naked</a></li>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 6805, "\"", 6812, 0);
            EndWriteAttribute();
            WriteLiteral(">ADV</a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 6861, "\"", 6868, 0);
            EndWriteAttribute();
            WriteLiteral(">Sport</a></li>\n                        </ul>\n                    </div>\n                </aside>\n            </div>\n        </div>\n    </div>\n    <div style=\"text-align:center; margin-left:300px\">\n        ");
#nullable restore
#line 137 "C:\Users\HP\Desktop\ĐỒ ÁN BÁO CÁO\CNPMNC-WEB-master\CNPMNC-WEB-master\Web_BanXeMoTo\Views\Customer\Products.cshtml"
   Write(Html.PagedListPager(Model.ListMauXes, page => Url.Action("Products",
                                          new { page, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</section>\n<!-- / product category -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Controllers.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
