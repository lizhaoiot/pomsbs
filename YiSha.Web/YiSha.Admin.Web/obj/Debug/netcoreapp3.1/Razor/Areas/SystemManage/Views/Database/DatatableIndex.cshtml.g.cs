#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Database/DatatableIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "161c9f41f4c74bbc79e9dadc9bc9ef4e2d6df228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Database_DatatableIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Database/DatatableIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"161c9f41f4c74bbc79e9dadc9bc9ef4e2d6df228", @"/Areas/SystemManage/Views/Database/DatatableIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Database_DatatableIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Database/DatatableIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("header", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        表名称：<input id=""tableName"" col=""TableName"" type=""text"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>

        <div class=""btn-group-sm"" id=""toolbar"">
            <a id=""btnSync"" class=""btn btn-primary"" onclick=""syncDatabase()""><i class=""fa fa-edit""></i> 同步</a>
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

    function initGrid");
            WriteLiteral("() {\r\n        var queryUrl = \'");
#nullable restore
#line 39 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Database/DatatableIndex.cshtml"
                   Write(Url.Content("~/SystemManage/Database/GetTablePageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            detailView: true,
            sortName: 'TableName',
            sortOrder: ""Asc"",
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'TableName', title: '表名称', sortable: true },
                { field: 'TableKeyName', title: '主键名称' },
                { field: 'TableKey', title: '主键字段' },
                { field: 'TableCount', title: '记录数' },
                { field: 'Remark', title: '备注' }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $(""#searchDiv"").getWebControls(pagination);
                return queryString;
            },
            onExpandRow: function (index, row, $detail) {
                initChildGrid(index, row, $detail);
            }
        });
    }

  ");
            WriteLiteral("  function initChildGrid(index, row, $detail) {\r\n        var queryUrl = \'");
#nullable restore
#line 66 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Database/DatatableIndex.cshtml"
                   Write(Url.Content("~/SystemManage/Database/GetTableFieldListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?tableName=' + row.TableName;
        var cur_table = $detail.html('<div style=""border:1px solid #666666""><table></table></div>').find('table');
        $detail.css(""padding-left"", ""28px"");
        $(cur_table).ysTable({
            url: queryUrl,
            toolbar: '',
            pagination: false,
            showColumns: false,
            showRefresh: false,
            showToggle: false,
            showToolbar: false,
            columns: [
                { field: 'TableColumn', title: '列名', width: 180 },
                { field: 'Datatype', title: '数据类型', width: 180 },
                { field: 'FieldLength', title: '长度', width: 180 },
                { field: 'Remark', title: '说明' }
            ]
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable('search');
        resetToolbarStatus();
    }

    function syncDatabase() {
        ys.ajax({
            url: '");
#nullable restore
#line 93 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Database/DatatableIndex.cshtml"
             Write(Url.Content("~/SystemManage/Database/SyncDatabaseJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""post"",
            success: function (obj) {
                if (obj.Tag == 1) {
                    ys.msgSuccess('同步完成');
                }
                else {
                    ys.msgError(obj.Message);
                }
            }
        });
    }
</script>
");
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