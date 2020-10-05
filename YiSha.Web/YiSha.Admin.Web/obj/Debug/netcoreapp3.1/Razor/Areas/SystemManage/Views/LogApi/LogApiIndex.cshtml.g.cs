#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e7345a2a7c430577f894d1cd384f6167190351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_LogApi_LogApiIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml")]
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
#line 2 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e7345a2a7c430577f894d1cd384f6167190351", @"/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_LogApi_LogApiIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        登录名称：<input id=""userName"" col=""UserName"" type=""text"" />
                    </li>
                    <li>
                        请求方法：<input id=""executeUrl"" col=""ExecuteUrl"" type=""text"" />
                    </li>
                    <li>
                        执行状态：<span id=""logStatus"" col=""LogStatus""></span>
                    </li>
                    <li class=""select-time"">
                        <label>请求时间： </label>
                        <input id=""startTime"" col=""StartTime"" type=""text"" class=""time-input"" placeholder=""开始时间"" />
                        <span>-</span>
                        <input id=""endTime"" col=""EndTime"" type=""text"" class=""time-input"" placeholder=""结束时间"" />
                    </li>
                    <li>
                        <a id=""bt");
            WriteLiteral(@"nSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm"" id=""toolbar"">
            <a id=""btnDelete"" class=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
            <a id=""btnDelete"" class=""btn btn-danger"" onclick=""removeAllForm()""><i class=""fa fa-trash""></i> 清空</a>
        </div>
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        initGrid();
        $(""#logStatus"").ysComboBox({ data: ys.getJson(");
#nullable restore
#line 43 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                                                 Write(Html.Raw(typeof(OperateStatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n\r\n        laydate.render({ elem: \'#startTime\', format: \'yyyy-MM-dd\' });\r\n        laydate.render({ elem: \'#endTime\', format: \'yyyy-MM-dd\' });\r\n    });\r\n\r\n    function initGrid() {\r\n        var queryUrl = \'");
#nullable restore
#line 50 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                   Write(Url.Content("~/SystemManage/LogApi/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'UserName', title: '登录名称' },
                { field: 'DepartmentName', title: '部门名称' },
                { field: 'ExecuteUrl', title: 'Url' },
                { field: 'ExecuteTime', title: '耗时（ms）' },
                {
                    field: 'LogStatus', title: '执行状态', align: 'center',
                    formatter: function (value, row, index) {
                        if (value == """);
#nullable restore
#line 63 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                                 Write(OperateStatusEnum.Success.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"badge badge-primary\">\' + \"");
#nullable restore
#line 64 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                                                                      Write(OperateStatusEnum.Success.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \'</span>\';\r\n                        } else {\r\n                            return \'<span class=\"badge badge-warning\">\' + \"");
#nullable restore
#line 66 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                                                                      Write(OperateStatusEnum.Fail.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + '</span>';
                        }
                    }
                },
                {
                    field: 'BaseCreateTime', title: '请求时间', formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
                {
                    title: '操作',
                    align: 'center',
                    formatter: function (value, row, index) {
                        var actions = [];
                        actions.push('<a class=""btn btn-warning btn-xs"" href=""#"" onclick=""showDetailForm(\'' + row.Id + '\')""><i class=""fa fa-search""></i>详细</a>');
                        return actions.join('');
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                r");
            WriteLiteral(@"eturn queryString;
            }
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function deleteForm() {
        var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm(""确认要删除选中的"" + selectedRow.length + ""条数据吗？"", function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 104 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                     Write(Url.Content("~/SystemManage/LogApi/DeleteFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?ids=' + ids,
                    type: ""post"",
                    success: function (obj) {
                        if (obj.Tag == 1) {
                            ys.msgSuccess(obj.Message);
                            searchGrid();
                        }
                        else {
                            ys.msgError(obj.Message);
                        }
                    }
                });
            });
        }
    }

    function removeAllForm() {
        ys.confirm(""确认要清空表吗？"", function () {
            ys.ajax({
                url: '");
#nullable restore
#line 123 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                 Write(Url.Content("~/SystemManage/LogApi/RemoveAllFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""post"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        searchGrid();
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        });
    }

    function showDetailForm(id) {
        ys.openDialog({
            title: ""Api日志详细"",
            content: '");
#nullable restore
#line 141 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/LogApi/LogApiIndex.cshtml"
                 Write(Url.Content("~/SystemManage/LogApi/LogApiDetail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'?id=\' + id\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
