#pragma checksum "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90a223179d0cb237603e553e82181051dc5be60a"
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
#line 1 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
using Web_BanXeMoTo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90a223179d0cb237603e553e82181051dc5be60a", @"/Views/GioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ef18d2d17df22618c30da944529771f87216aa", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CartModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("aa-cart-view-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThanhToan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#checkout-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Background/paypal_checkout.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaypalCheckout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a223179d0cb237603e553e82181051dc5be60a6835", async() => {
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
#line 31 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                         foreach (var item in Model)
                                        {
                                            ToTalAmount += item.ThanhTien;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n\r\n                                                <td><a href=\"#\"><img");
                BeginWriteAttribute("src", " src=\"", 1495, "\"", 1511, 1);
#nullable restore
#line 36 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 1501, item.Hinh, 1501, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1512, "\"", 1529, 1);
#nullable restore
#line 36 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 1518, item.Idmau, 1518, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></a></td>\r\n\r\n                                                <td><a class=\"aa-cart-title\"");
                BeginWriteAttribute("href", " href=\"", 1620, "\"", 1694, 1);
#nullable restore
#line 38 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 1627, Url.ActionLink("ProductDetails","Customer",new {id = item.Idmau }), 1627, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                                                                                                   Write(item.TenXe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                <td> ");
#nullable restore
#line 39 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                Write(string.Format("{0:N0}", ((Int64)item.GiaBan)));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</td>\r\n                                                <td>\r\n                                                    <button type=\"button\" data-id=\"");
#nullable restore
#line 41 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                              Write(item.Idmau);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"ajax-add fa fa-plus\" style=\"width: auto; color : #ff6666\">  </button>\r\n                                                    &nbsp;\r\n                                                    <span");
                BeginWriteAttribute("id", " id=\"", 2173, "\"", 2197, 2);
                WriteAttributeValue("", 2178, "soLuong_", 2178, 8, true);
#nullable restore
#line 43 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2186, item.Idmau, 2186, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 43 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                              Write(item.SoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                    &nbsp;\r\n                                                    <button type=\"button\" data-id=\"");
#nullable restore
#line 45 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                              Write(item.Idmau);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"ajax-minus fa fa-minus\" style=\"width: auto; color : #ff6666\">  </button>\r\n\r\n                                                </td>\r\n                                                <td>\r\n                                                    <span");
                BeginWriteAttribute("id", " id=\"", 2626, "\"", 2652, 2);
                WriteAttributeValue("", 2631, "thanhTien_", 2631, 10, true);
#nullable restore
#line 49 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2641, item.Idmau, 2641, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 49 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                                Write(string.Format("{0:N0}", ((Int64)item.ThanhTien)));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span> VNĐ\r\n                                                </td>\r\n                                                <td>\r\n");
                WriteLiteral("                                                    <p>  <button type=\"button\" data-id=\"");
#nullable restore
#line 53 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                                                   Write(item.Idmau);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"ajax-delete fa fa-times\" style=\"width: auto; color : #ff6666\">  </button></p>\r\n\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 57 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
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
                                        <td><span id=""tongTien"">");
#nullable restore
#line 71 "D:\lap trinh\năm 3\Semester 2\CNPMNC-WEB\Web_BanXeMoTo\Views\GioHang\Index.cshtml"
                                                           Write(string.Format("{0:N0}", ((Int64)ToTalAmount)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> VNĐ</td>\r\n                                    </tr>\r\n\r\n\r\n\r\n                                </tbody>\r\n                            </table>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a223179d0cb237603e553e82181051dc5be60a16350", async() => {
                WriteLiteral("Thanh toán");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a223179d0cb237603e553e82181051dc5be60a17910", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90a223179d0cb237603e553e82181051dc5be60a18198", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- / Cart view section -->\r\n");
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
                        $(""#thanhTien_"" + data.id).html(new Intl.NumberFormat().format(data.thanhTien));
                        $(""#tongTien"").html(new Intl.NumberFormat().format(data.tongTien));

                        console.log(data)
                    },
                });
            });
        });
        $(document).ready(function () {
            $("".ajax-delete"").click(function () {
                $.ajax({
     ");
                WriteLiteral(@"               url: ""/GioHang/RemoveFromCart"",

                    data: {
                        id: $(this).data(""id""),
                        type: ""ajax""
                    },

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
                        id: $(this).data(""");
                WriteLiteral(@"id""),
                        type: ""ajax""
                    },
                    success: function (data) {

                        $(""#cart_count"").html(data.total);
                        $(""#soLuong_"" + data.id).html(data.soLuong);
                        $(""#thanhTien_"" + data.id).html(new Intl.NumberFormat().format(data.thanhTien));
                        $(""#tongTien"").html(new Intl.NumberFormat().format(data.tongTien));
                        console.log(data)

                    },
                    error: function () {
                        Swal.fire({
                            icon: 'error',
                            title: 'Thêm giỏ hàng thất bại',
                            text: 'Số lượng sản phẩm đã hết',
                            showConfirmButton: false,
                            timer: 2500
                        });
                    }
                });
            });
        });

    </script>
");
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
