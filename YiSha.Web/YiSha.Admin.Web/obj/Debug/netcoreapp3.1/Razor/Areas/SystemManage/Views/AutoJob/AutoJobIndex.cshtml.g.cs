#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05fde9123d3b575cc85ffdaf8264e2f1074b8086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_AutoJob_AutoJobIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fde9123d3b575cc85ffdaf8264e2f1074b8086", @"/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_AutoJob_AutoJobIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
  
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
                        任务名称：<input id=""jobName"" col=""JobName"" type=""text"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""btn-group-sm"" id=""toolbar"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary disabled"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
            <a id=""btnDelete"" class=""btn btn-info"" on");
            WriteLiteral(@"click=""showAutoJobLogForm()""><i class=""fa fa-list""></i> 日志</a>
        </div>

        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        initGrid();
    });

    function initGrid() {
        var queryUrl = '");
#nullable restore
#line 37 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
                   Write(Url.Content("~/SystemManage/AutoJob/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'JobGroupName', title: '任务组' },
                { field: 'JobName', title: '任务名称' },
                { field: 'CronExpression', title: 'Cron表达式' },
                {
                    field: 'JobStatus', title: '状态', formatter: function (value, row, index) {
                        if (row.JobStatus == """);
#nullable restore
#line 48 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
                                         Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""") {
                            return '<span class=""badge badge-primary"">' + ""运行中"" + '</span>';
                        } else {
                            return '<span class=""badge badge-danger"">' + ""停止"" + '</span>';
                        }
                    }
                },
                { field: 'StartTime', title: '开始时间' },

                { field: 'EndTime', title: '结束时间' },
                { field: 'NextStartTime', title: '下次运行时间' },
                {
                    title: '操作',
                    align: 'center',
                    formatter: function (value, row, index) {
                        var actions = [];
                        if (row.JobStatus == """);
#nullable restore
#line 64 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
                                         Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            actions.push(\'<a class=\"btn btn-primary btn-xs\" href=\"#\" onclick=\"ChangeJobStatus(\\\'\' + row.Id + \'\\\',");
#nullable restore
#line 65 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
                                                                                                                            Write(StatusEnum.No.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(")\"><i class=\"fa fa-pause-circle-o\"></i>暂停</a> \');\r\n                        } else {\r\n                            actions.push(\'<a class=\"btn btn-primary btn-xs\" href=\"#\" onclick=\"ChangeJobStatus(\\\'\' + row.Id + \'\\\',");
#nullable restore
#line 67 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
                                                                                                                            Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(@")""><i class=""fa fa-play-circle-o""></i>执行</a> ');
                        }
                        return actions.join('');
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function showSaveForm(bAdd) {
        var id = 0;
        if (!bAdd) {
            var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            else {
                id = selectedRow[0].Id;
            }
        }
        ys.openDialog({
            title: id > 0 ? ""编辑"" : ""添加"",
            content: '");
#nullable restore
#line 99 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
                 Write(Url.Content("~/SystemManage/AutoJob/AutoJobForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function deleteForm() {
        var selectedRow = $(""#gridTable"").bootstrapTable(""getSelections"");
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm(""确认要删除选中的"" + selectedRow.length + ""条数据吗？"", function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 113 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
                     Write(Url.Content("~/SystemManage/AutoJob/DeleteFormJson"));

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

    function ChangeJobStatus(id, jobStatus) {
        var postData = {};
        postData.Id = id;
        postData.JobStatus = jobStatus;
        ys.ajax({
            url: '");
#nullable restore
#line 134 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
             Write(Url.Content("~/SystemManage/AutoJob/ChangeJobStatusJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""post"",
            data: postData,
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
    }

    function showAutoJobLogForm() {
        var url = '");
#nullable restore
#line 150 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/AutoJob/AutoJobIndex.cshtml"
              Write(Url.Content("~/SystemManage/AutoJobLog/AutoJobLogIndex"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        createMenuItem(url, \"任务日志\");\r\n    }\r\n</script>\r\n");
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
