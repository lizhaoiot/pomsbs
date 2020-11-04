#pragma checksum "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f555f94b6c2324e4494fbc883a43beb8787b990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_DataDict_DataDictIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml")]
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
#line 2 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f555f94b6c2324e4494fbc883a43beb8787b990", @"/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_DataDict_DataDictIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml"
  
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
                        字典类型：<input id=""dictType"" col=""DictType"" type=""text"" />
                    </li>
                    <li>
                        字典描述：<input id=""remark"" col=""Remark"" type=""text"" />
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
            <a id=""btnDelete"" class=""btn bt");
            WriteLiteral(@"n-danger disabled"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
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
#line 39 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml"
                   Write(Url.Content("~/SystemManage/DataDict/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            sortName: 'DictSort',
            sortOrder: 'Asc',
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'DictType', title: '字典类型' },
                { field: 'Remark', title: '字典描述' },
                { field: 'DictSort', title: '字典排序' },
                {
                    field: 'BaseModifyTime', title: '创建时间', formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                },
                {
                    title: '操作',
                    align: 'center',
                    formatter: function (value, row, index) {
                        var actions = [];
                        actions.push('<a class=""btn btn-info btn-xs"" href=""#"" onclick=""showDataDictDetailForm(\'' + row.DictType + '\')""><i class=""fa ");
            WriteLiteral(@"fa-list-ul""></i>字典值</a>');
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
            title: id > 0 ? ""编辑字典"" : ""添加字典"",
            content: '");
#nullable restore
#line 91 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml"
                 Write(Url.Content("~/SystemManage/DataDict/DataDictForm"));

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
#line 105 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml"
                     Write(Url.Content("~/SystemManage/DataDict/DeleteFormJson"));

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

    function showDataDictDetailForm(dictType) {
        var url = '");
#nullable restore
#line 122 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/DataDict/DataDictIndex.cshtml"
              Write(Url.Content("~/SystemManage/DataDictDetail/DataDictDetailIndex"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'?dictType=\' + dictType;\r\n        createMenuItem(url, \"字典数据\");\r\n    }\r\n</script>\r\n");
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
