#pragma checksum "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90d3d383d558d784348767f7f2f828928ad97875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Xe_Index), @"mvc.1.0.view", @"/Views/Xe/Index.cshtml")]
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
#line 1 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90d3d383d558d784348767f7f2f828928ad97875", @"/Views/Xe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ef18d2d17df22618c30da944529771f87216aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Xe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
   ViewData["Title"] = "Danhh sách xe";
    Layout = "~/Views/Shared/_LayoutManager.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""app-main__inner"">
    <div class=""app-page-title"">
        <div class=""page-title-wrapper"">
            <div class=""page-title-heading"">
                <div>
                    <h2 style=""font-weight:500"">Quản lý Xe</h2>
                </div>
            </div>
        </div>
    </div>
    <ul class=""body-tabs body-tabs-layout tabs-animated body-tabs-animated nav"">
        <li class=""nav-item"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d3d383d558d784348767f7f2f828928ad978755843", async() => {
                WriteLiteral("\r\n                <span>Danh sách Xe</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d3d383d558d784348767f7f2f828928ad978757200", async() => {
                WriteLiteral("\r\n                <span>Thêm xe</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"main-card mb-3 card\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 35 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
               Write(Html.ActionLink("Đã bán", "Index", new { trangThai = Web_BanXeMoTo.Models.TrangThaiXe.DaBan}, new { @class = " btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
               Write(Html.ActionLink("Chưa bán", "Index", new { trangThai = Web_BanXeMoTo.Models.TrangThaiXe.ChuaBan }, new {@class = " btn btn-primary" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 38 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                     using (Html.BeginForm("Index", "Xe", FormMethod.Get, new { @style = "float: right; width: 40%" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"text\" id=\"searchString\" name=\"searchString\" placeholder=\"Tìm kiếm...\">\r\n                        <input type=\"submit\" value=\"Tìm kiếm\" class=\"btn btn-outline-info\" style=\"margin-bottom:5px\" />");
#nullable restore
#line 41 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <br /><br />
                    <table class=""table table-hover table-sm"">
                        <thead>
                            <tr>
                                <th>
                                    <label class=""control-label"">");
#nullable restore
#line 47 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                            Write(Html.ActionLink("ID Xe", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                </th>
                                <th>
                                    <label class=""control-label"">Hình</label>
                                </th>
                                <th>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d3d383d558d784348767f7f2f828928ad9787511277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 53 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.mauXe.TenXe);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </th>\r\n\r\n                                <th>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d3d383d558d784348767f7f2f828928ad9787512934", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 57 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.hang.TenHang);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </th>\r\n\r\n                                <th>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d3d383d558d784348767f7f2f828928ad9787514592", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 61 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.mauXe.GiaBan);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"text-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d3d383d558d784348767f7f2f828928ad9787516268", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 64 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.mauXe.BaoHanh);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </th>
                                <th class=""text-center"">
                                    <label class=""control-label"">Khuyến mãi</label>
                                </th>
                                <th class=""text-center"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d3d383d558d784348767f7f2f828928ad9787518126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 70 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Xe.TrangThai);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </th>\r\n");
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 76 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                             foreach (var item in Model.ListXes)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 80 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                   Write(item.Idxe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 83 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                         foreach (var mau in Model.ListMauXe)
                                        {
                                            if (mau.Idmau == item.Idmau)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <img");
            BeginWriteAttribute("src", " src=\"", 4227, "\"", 4246, 1);
#nullable restore
#line 87 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
WriteAttributeValue("", 4233, mau.HinhAnh1, 4233, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"90\" />\r\n");
#nullable restore
#line 88 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                break;
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 93 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                         foreach (var mau in Model.ListMauXe)
                                        {
                                            if (mau.Idmau == item.Idmau)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                           Write(mau.TenXe);

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                          ;
                                                break;
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 103 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                         foreach (var mau in Model.ListMauXe)
                                        {
                                            if (item.Idmau == mau.Idmau)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                 foreach (var hang in Model.ListHang)
                                                {
                                                    if (mau.Idhang == hang.Idhang)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                   Write(hang.TenHang);

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                                     ;
                                                        break;
                                                    }
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                 
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 119 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                         foreach (var mau in Model.ListMauXe)
                                        {
                                            if (mau.Idmau == item.Idmau)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                           Write(mau.GiaBan);

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                           ;
                                                break;
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n");
#nullable restore
#line 129 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                         foreach (var mau in Model.ListMauXe)
                                        {
                                            if (mau.Idmau == item.Idmau)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                           Write(mau.BaoHanh);

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                            ;
                                                break;
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n");
#nullable restore
#line 139 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                         foreach (var mau in Model.ListMauXe)
                                        {
                                            if (item.Idmau == mau.Idmau)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                 foreach (var km in Model.ListKhuyenMai)
                                                {
                                                    if (mau.Idkm == km.Idkm)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                   Write(km.GiaTri);

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                                  ;
                                                        break;
                                                    }
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                                 
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
#nullable restore
#line 155 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                                   Write(Html.DisplayFor(model => item.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 163 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                    ");
#nullable restore
#line 167 "F:\HUFLIT-EDU\năm3\Semester2\DA1-CNPMNC\CNPM\CNPMNC-WEB\Web_BanXeMoTo\Views\Xe\Index.cshtml"
               Write(Html.PagedListPager(Model.ListXes, page => Url.Action("Index",
                                                     new { page, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Controllers.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
