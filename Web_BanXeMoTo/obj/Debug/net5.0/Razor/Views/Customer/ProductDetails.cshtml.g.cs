#pragma checksum "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff946dd8a9669e70256e141730a5147e8e348c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ProductDetails), @"mvc.1.0.view", @"/Views/Customer/ProductDetails.cshtml")]
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
#line 1 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff946dd8a9669e70256e141730a5147e8e348c02", @"/Views/Customer/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ef18d2d17df22618c30da944529771f87216aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
   ViewData["Title"] = "Thông tin xe " + Model.MauXe.TenXe;
    Layout = "~/Views/Shared/_CustomerLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- product category -->
<section id=""aa-product-details"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""aa-product-details-area"">
                    <div class=""aa-product-details-content"">
                        <div class=""row"">

                            <!-- Modal view slider -->
                            <div class=""col-md-6 col-sm-6 col-xs-12"">
                                <div class=""aa-product-view-slider"">
                                    <div id=""demo-1"" class=""simpleLens-gallery-container"">
                                        <div class=""simpleLens-container"">
                                            <div class=""simpleLens-big-image-container"">
                                                <a data-lens-image=""");
#nullable restore
#line 21 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                               Write(Model.MauXe.HinhAnh1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"simpleLens-lens-image\">\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 1125, "\"", 1152, 1);
#nullable restore
#line 22 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 1131, Model.MauXe.HinhAnh1, 1131, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""simpleLens-big-image"">
                                                </a>
                                            </div>
                                        </div>
                                        <br />
                                        <div class=""simpleLens-thumbnails-container"">
                                            <a data-big-image=""");
#nullable restore
#line 28 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                          Write(Model.MauXe.HinhAnh1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-lens-image=\"");
#nullable restore
#line 28 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                                                                  Write(Model.MauXe.HinhAnh1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"simpleLens-thumbnail-wrapper\" href=\"#\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 1700, "\"", 1727, 1);
#nullable restore
#line 29 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 1706, Model.MauXe.HinhAnh1, 1706, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"80\" height=\"50\">\r\n                                            </a>\r\n                                            <a data-big-image=\"");
#nullable restore
#line 31 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                          Write(Model.MauXe.HinhAnh2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-lens-image=\"");
#nullable restore
#line 31 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                                                                  Write(Model.MauXe.HinhAnh2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"simpleLens-thumbnail-wrapper\" href=\"#\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 2030, "\"", 2057, 1);
#nullable restore
#line 32 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 2036, Model.MauXe.HinhAnh2, 2036, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"80\" height=\"50\">\r\n                                            </a>\r\n                                            <a data-big-image=\"");
#nullable restore
#line 34 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                          Write(Model.MauXe.HinhAnh3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-lens-image=\"");
#nullable restore
#line 34 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                                                                  Write(Model.MauXe.HinhAnh3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"simpleLens-thumbnail-wrapper\" href=\"#\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 2360, "\"", 2387, 1);
#nullable restore
#line 35 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 2366, Model.MauXe.HinhAnh3, 2366, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""80"" height=""50"">
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- Modal view content -->
");
#nullable restore
#line 42 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                             if (Model.ListXe.Length == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                <div class=\"aa-product-view-content\" style=\"margin-left: 100px\">\r\n                                    <h1>");
#nullable restore
#line 46 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                   Write(Model.MauXe.TenXe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    <br>
                                    <div class=""aa-price-block"">
                                        <span class=""aa-product-view-price"" style=""color: red;"">
                                            ");
#nullable restore
#line 50 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                       Write(string.Format("{0:N0}", ((Int64)Model.MauXe.GiaBan)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ
                                        </span>
                                        <p class=""aa-product-avilability"">
                                            Trạng thái: <span>Hết hàng</span>
                                        </p>
                                    </div>
                                    <div class=""aa-prod-view-bottom"">
                                        <a class=""aa-add-to-cart-btn""><del>Thêm vào giỏ hàng</del></a>
                                    </div>
                                </div>
                            </div> 
");
#nullable restore
#line 61 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                <div class=\"aa-product-view-content\" style=\"margin-left: 100px\">\r\n                                    <h1>");
#nullable restore
#line 66 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                   Write(Model.MauXe.TenXe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                    <br>
                                    <div class=""aa-price-block"">
                                        <span class=""aa-product-view-price"" style=""color: red;"">
                                            ");
#nullable restore
#line 70 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                       Write(string.Format("{0:N0}", ((Int64)Model.MauXe.GiaBan)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ
                                        </span>
                                        <p class=""aa-product-avilability"">
                                            Trạng thái: <span>Còn hàng</span>
                                        </p>
                                    </div>
                                    <div class=""aa-prod-view-bottom"">
                                        <p> <button type=""button"" data-id=""");
#nullable restore
#line 77 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                                      Write(Model.MauXe.Idmau);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"ajax-add aa-add-to-cart-btn\"> Thêm vào giỏ hàng </button></p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 81 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n                    <div class=\"aa-product-details-bottom\">\r\n                        <h3><b>Thông tin sản phẩm</b></h3>\r\n                        ");
#nullable restore
#line 89 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                   Write(Model.MauXe.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral(@"                    <!-- Related product -->
                    <div class=""aa-product-related-item"">
                        <h3>Các sản phẩm nổi bật khác</h3>
                        <ul class=""aa-product-catg "">
                            <!-- start single product item -->

");
#nullable restore
#line 109 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                              
                                Random rnd = new Random();
                                HashSet<int> numbers = new HashSet<int>();
                                while (numbers.Count < 4)
                                {
                                    numbers.Add(rnd.Next(0, Model.ListMauXe.Length));
                                }
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                 foreach (var i in numbers)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li style=\"height:250px\">\r\n                                        <figure>\r\n                                            <a class=\"aa-product-img\"");
            BeginWriteAttribute("href", " href=\"", 8243, "\"", 8332, 1);
#nullable restore
#line 120 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 8250, Url.ActionLink("ProductDetails","Customer", new {id = Model.ListMauXe[i].Idmau }), 8250, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 8338, "\"", 8372, 1);
#nullable restore
#line 120 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 8344, Model.ListMauXe[i].HinhAnh1, 8344, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"242\" height=\"170\"></a>\r\n                                            <a class=\"aa-add-card-btn\"");
            BeginWriteAttribute("href", " href=\"", 8475, "\"", 8565, 1);
#nullable restore
#line 121 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 8482, Url.ActionLink("ProductDetails","Customer", new {id =  Model.ListMauXe[i].Idmau }), 8482, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fa fa-shopping-cart\"></span>Mua ngay</a>\r\n                                            <figcaption>\r\n                                                <h4 class=\"aa-product-title\"><a");
            BeginWriteAttribute("href", " href=\"", 8759, "\"", 8849, 1);
#nullable restore
#line 123 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
WriteAttributeValue("", 8766, Url.ActionLink("ProductDetails","Customer", new {id =  Model.ListMauXe[i].Idmau }), 8766, 83, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 123 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                                                                                                                                      Write(Html.DisplayFor(model => Model.ListMauXe[i].TenXe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                                <span class=\"aa-product-price\">");
#nullable restore
#line 124 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                                                          Write(string.Format("{0:N0}", ((Int64)Model.ListMauXe[i].GiaBan)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n");
            WriteLiteral("                                            </figcaption>\r\n                                        </figure>\r\n                                        <!-- product badge -->\r\n");
            WriteLiteral("                                    </li>\r\n");
#nullable restore
#line 131 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Customer\ProductDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- / product category -->\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>
    <script>
        $(document).ready(function () {
            $("".ajax-add"").click(function () {
                $.ajax({
                    url: ""/GioHang/AddToCart"",
                    data: {
                        id: $(this).data(""id""),
                        type: ""ajax""
                    },
                    success: function (data) {
                        Swal.fire({
                            icon: 'success',
                            title: 'Thêm giỏ hàng thành công',
                            showConfirmButton: false,
                            timer: 2500
                        });
                        $(""#cart_count"").html(data.total);
                    },
                    error: function () {
                        Swal.fire({
                            icon: 'error',
                            title: 'Thêm giỏ hàng thất bại',
                            text: 'Vui lòng");
                WriteLiteral(" thử lại\',\r\n                            showConfirmButton: false,\r\n                            timer: 2500\r\n                        });\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
