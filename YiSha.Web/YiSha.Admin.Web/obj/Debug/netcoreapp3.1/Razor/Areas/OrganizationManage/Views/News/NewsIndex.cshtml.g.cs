#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/News/NewsIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c837755425dec49be89c00324eca5efba3383a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_News_NewsIndex), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/News/NewsIndex.cshtml")]
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
#line 3 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c837755425dec49be89c00324eca5efba3383a", @"/Areas/OrganizationManage/Views/News/NewsIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_News_NewsIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/News/NewsIndex.cshtml"
  
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
                        文章标题：<input id=""newsTitle"" col=""NewsTitle"" type=""text"" />
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
        </div>
        <div class=""col-sm-12 sel");
            WriteLiteral(@"ect-table table-striped"">
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
#line 35 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/News/NewsIndex.cshtml"
                   Write(Url.Content("~/OrganizationManage/News/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            sortName: 'NewsSort',
            sortOrder: 'Desc',
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: 'Id', visible: false },
                { field: 'NewsTitle', title: '文章标题' },
                {
                    field: 'NewsType', title: '文章类型', formatter: function (value, row, index) {
                        return top.getDataDictValue('NewsType', value);
                    }
                },
                { field: 'NewsAuthor', title: '作者' },
                { field: 'NewsSort', title: '排序' },
                { field: 'NewsDate', title: '发布时间' },
                { field: 'ViewTimes', title: '阅读量' },
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                retu");
            WriteLiteral(@"rn queryString;
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
            title: id > 0 ? ""编辑文章"" : ""添加文章"",
            content: '");
#nullable restore
#line 80 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/News/NewsIndex.cshtml"
                 Write(Url.Content("~/OrganizationManage/News/NewsForm"));

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
#line 94 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/News/NewsIndex.cshtml"
                     Write(Url.Content("~/OrganizationManage/News/DeleteFormJson"));

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
