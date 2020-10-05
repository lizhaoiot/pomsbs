#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/Views/Report/Peity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a948d2d3442dd0f1ae98158ade2d3c8ac23222ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Report_Peity), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Report/Peity.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 3 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a948d2d3442dd0f1ae98158ade2d3c8ac23222ea", @"/Areas/DemoManage/Views/Report/Peity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    public class Areas_DemoManage_Views_Report_Peity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/Views/Report/Peity.cshtml"
  
    Layout = "~/Views/Shared/_FormGray.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/DemoManage/Views/Report/Peity.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/report/peity/jquery.peity.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-content"">
                    <h2>Peity</h2>
                    <p>
                        <a href=""https://github.com/benpickles/peity"" target=""_blank"">Peity</a> 是一个内嵌数据图形可视化的图表库。
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>饼状图 <small>自定义颜色</small></h5>
                    <div class=""ibox-tools"">
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div>
                    <table class=""table table-bordered white-bg"">
                        <thead>
    ");
            WriteLiteral(@"                        <tr>
                                <th>图表</th>
                                <th>代码</th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr>
                                <td>
                                    <span class=""pie"">1/5</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;1/5&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">226/360</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;226/360&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>");
            WriteLiteral(@"
                                <td>
                                    <span class=""pie"">0.52/1.561</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;0.52/1.561&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">1,4</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;1,4&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">226,134</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&");
            WriteLiteral(@"gt;226,134&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""pie"">0.52,1.041</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""pie""&gt;0.52,1.041&lt;/span&gt;</code>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>线性图</h5>
                    <div class=""ibox-tools"">
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
            WriteLiteral(@"
                </div>
                <div>
                    <table class=""table table-bordered white-bg"">
                        <thead>
                            <tr>
                                <th>图表</th>
                                <th>代码</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <span data-diameter=""40"" class=""updating-chart"">5,3,9,6,5,9,7,3,5,2,5,3,9,6,5,9,7,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""line""&gt;5,3,9,6,5,9,7,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""line"">5,3,9,6,5,9,7,3,5,2</span>
                                ");
            WriteLiteral(@"</td>
                                <td>
                                    <code>&lt;span class=""line""&gt;5,3,9,6,5,9,7,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""line"">5,3,2,-1,-3,-2,2,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""line""&gt;5,3,2,-1,-3,-2,2,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""line"">0,-3,-6,-4,-5,-4,-7,-3,-5,-2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""line""&gt;0,-3,-6,-4,-5,-4,-7,-3,-5,-2&lt;/span&gt;</code>
                   ");
            WriteLiteral(@"             </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""bar"">5,3,9,6,5,9,7,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""bar""&gt;5,3,9,6,5,9,7,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class=""bar"">5,3,2,-1,-3,-2,2,3,5,2</span>
                                </td>
                                <td>
                                    <code>&lt;span class=""bar""&gt;5,3,2,-1,-3,-2,2,3,5,2&lt;/span&gt;</code>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</d");
            WriteLiteral(@"iv>

<script type=""text/javascript"">
    $(function () {
        $(""span.pie"").peity(""pie"", {
            fill: ['#1ab394', '#d7d7d7', '#ffffff']
        })

        $("".line"").peity(""line"", {
            fill: '#1ab394',
            stroke: '#169c81',
        })

        $("".bar"").peity(""bar"", {
            fill: [""#1ab394"", ""#d7d7d7""]
        })

        $("".bar_dashboard"").peity(""bar"", {
            fill: [""#1ab394"", ""#d7d7d7""],
            width: 100
        })

        var updatingChart = $("".updating-chart"").peity(""line"", { fill: '#1ab394', stroke: '#169c81', width: 64 })

        setInterval(function () {
            var random = Math.round(Math.random() * 10)
            var values = updatingChart.text().split("","")
            values.shift()
            values.push(random)

            updatingChart
                .text(values.join("",""))
                .change()
        }, 1000);
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591