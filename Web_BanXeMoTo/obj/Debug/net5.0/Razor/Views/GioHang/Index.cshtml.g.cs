#pragma checksum "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f717cf9aa9c0e4e18767f4413d67470d1ef4472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_Index), @"mvc.1.0.view", @"/Views/GioHang/Index.cshtml")]
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
#nullable restore
#line 1 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
using Web_BanXeMoTo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f717cf9aa9c0e4e18767f4413d67470d1ef4472", @"/Views/GioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CartModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
   ViewData["Title"] = "Giỏ hàng";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";
    double ToTalAmount = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Cart view section -->
<section id=""cart-view"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""cart-view-area"">
                    <div class=""cart-view-table"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f717cf9aa9c0e4e18767f4413d67470d1ef44724251", async() => {
                WriteLiteral(@"
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>Hình Ảnh</th>
                                            <th>Sản phẩm</th>
                                            <th>Giá</th>
                                            <th>Số lượng</th>
                                            <th>Tổng tiền</th>
                                            <th></th>
                                        </tr>

                                    </thead>
                                    <tbody>
");
#nullable restore
#line 31 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                         foreach (var item in Model)
                                        {
                                            ToTalAmount += item.ThanhTien;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n\r\n                                <td><a href=\"#\"><img");
                BeginWriteAttribute("src", " src=\"", 1463, "\"", 1479, 1);
#nullable restore
#line 36 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 1469, item.Hinh, 1469, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1480, "\"", 1497, 1);
#nullable restore
#line 36 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 1486, item.Idmau, 1486, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></a></td>\r\n\r\n                                <td><a class=\"aa-cart-title\"");
                BeginWriteAttribute("href", " href=\"", 1572, "\"", 1646, 1);
#nullable restore
#line 38 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 1579, Url.ActionLink("ProductDetails","Customer",new {id = item.Idmau }), 1579, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                                                                                   Write(item.TenXe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                <td> ");
#nullable restore
#line 39 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                Write(string.Format("{0:N0}", ((Int64)item.GiaBan)));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</td>\r\n                                <td>\r\n                                    <button type=\"button\" data-id=\"");
#nullable restore
#line 41 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                              Write(item.Idmau);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"ajax-add fa fa-plus\" style=\"width: auto; color : #ff6666\">  </button>\r\n                                    &nbsp;\r\n                                    <span");
                BeginWriteAttribute("id", " id=\"", 2045, "\"", 2069, 2);
                WriteAttributeValue("", 2050, "soLuong_", 2050, 8, true);
#nullable restore
#line 43 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2058, item.Idmau, 2058, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 43 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                              Write(item.SoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    &nbsp;\r\n                                    <button type=\"button\" data-id=\"");
#nullable restore
#line 45 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                              Write(item.Idmau);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"ajax-minus fa fa-minus\" style=\"width: auto; color : #ff6666\">  </button>\r\n\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 48 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                               Write(string.Format("{0:N0}", ((Int64)item.ThanhTien)));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</td>\r\n                                <td>\r\n");
                WriteLiteral("                                    <p>  <button type=\"button\" data-id=\"");
#nullable restore
#line 51 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                   Write(item.Idmau);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"ajax-delete fa fa-times\" style=\"width: auto; color : #ff6666\">  </button></p>\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 55 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <!-- Cart Total view -->
                        <div class=""cart-view-total"">
                            <h4>Cart Totals</h4>
                            <table class=""aa-totals-table"">
                                <tbody>

                                    <tr>
                                        <th>Tổng tiền</th>
                                        <td>");
#nullable restore
#line 69 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                       Write(string.Format("{0:N0}", ((Int64)ToTalAmount)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                    </tr>\r\n\r\n\r\n\r\n                                </tbody>\r\n                            </table>\r\n                            <a class=\"aa-cart-view-btn\"");
            BeginWriteAttribute("href", " href=\"", 3693, "\"", 3700, 0);
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#checkout-modal\">Thanh toán</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- / Cart view section -->\r\n");
            DefineSection("scriptsdelete", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>
    <script>
        $(document).ready(function () {
            $("".ajax-minus"").click(function () {
                $.ajax({
                    url: ""/GioHang/MinusFromCart"",

                    data: {
                        id: $(this).data(""id""),
                        type: ""ajax""
                    },

                    success: function (data) {
                        
                        $(""#cart_count"").html(data.total);
                        $(""#soLuong_"" + data.id).html(data.soLuong);

                        console.log(data)
                    },
                });
            });
        });
        $(document).ready(function () {
            $("".ajax-delete"").click(function () {
                $.ajax({
                    url: ""/GioHang/RemoveFromCart"",

                    data: {
                        id: $(this).data(""id""),
                        type: ""ajax""
         ");
                WriteLiteral(@"           },

                    success: function (data) {
                        Swal.fire({
                            icon: 'warning',
                            title: 'Xe đã được xóa khỏi giỏ hàng',
                            showConfirmButton: false,
                            timer: 2500
                        });
                        $(""#cart_count"").html(data.soLuong);
                        console.log(data)
                        setTimeout(() => window.location.replace(""/giohang/index""), 2500);

                    },
                });
            });
        });
        $(document).ready(function () {
            $("".ajax-add"").click(function () {
                $.ajax({
                    url: ""/GioHang/AddToCart"",
                    data: {
                        id: $(this).data(""id""),
                        type: ""ajax""
                    },
                    success: function (data) {
                        
                        $(""#cart");
                WriteLiteral("_count\").html(data.total);\r\n                        $(\"#soLuong_\" + data.id).html(data.soLuong);\r\n                        console.log(data)\r\n\r\n                    },\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CartModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
