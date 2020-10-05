#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "482323645606ee9031403e8ff5ca667552df54bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_Department_DepartmentIndex), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"482323645606ee9031403e8ff5ca667552df54bf", @"/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    public class Areas_OrganizationManage_Views_Department_DepartmentIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.treetable/1.0/bootstrap-treetable.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.treetable/1.0/bootstrap-treetable.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>
                    <li>
                        部门名称：<input id=""departmentName"" col=""DepartmentName"" type=""text"" />
                    </li>
                    <li>
                        <a id=""btnSearch"" class=""btn btn-primary btn-sm"" onclick=""searchTreeGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a>
                    </li>
                </ul>
            </div>
        </div>

        <div class=""btn-group-sm"" id=""toolbar"" role=""group"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
            <a id=""btnExpandAll"" cla");
            WriteLiteral(@"ss=""btn btn-info""><i class=""fa fa-exchange""></i> 展开/折叠</a>
        </div>
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    var id = 0;
    $(function () {
        initTreeGrid();
    });

    function initTreeGrid() {
        var options = {
            code: ""Id"",
            parentCode: ""ParentId"",
            uniqueId: ""Id"",
            expandAll: false,
            expandFirst: true,
            toolbar: '#toolbar',
            expandColumn: '1',
            url: '");
#nullable restore
#line 53 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml"
             Write(Url.Content("~/OrganizationManage/Department/GetListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            modalName: ""部门"",
            columns: [
                { field: 'selectItem', radio: true },
                { field: 'DepartmentName', title: '部门名称', width: '20%' },
                { field: 'DepartmentSort', title: '显示顺序', width: '10%', align: ""left"" },
                { field: 'PrincipalName', title: '负责人', width: '10%', align: ""left"" },
                {
                    field: 'BaseModifyTime', title: '创建时间', width: '60%', align: ""left"",
                    formatter: function (value, row, index) {
                        return ys.formatDate(value, ""yyyy-MM-dd HH:mm:ss"");
                    }
                }
            ],
            onLoadSuccess: function () {
                if (id != 0) {
                    $('#gridTable').ysTreeTable('expandRowById', id);
                }
            }
        };
        $('#gridTable').ysTreeTable(options);
    }

    function searchTreeGrid(callBackId) {
        var param = $(""#searchDiv"").getWebControls();
      ");
            WriteLiteral(@"  $('#gridTable').ysTreeTable('search', param);
         if (callBackId) {
            id = callBackId;
        }
    }

    function showSaveForm(bAdd) {
        var id = 0;
        if (!bAdd) {
            var selectedRow = $(""#gridTable"").bootstrapTreeTable(""getSelections"");
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            else {
                id = selectedRow[0].Id;
            }
        }
        ys.openDialog({
            title: id > 0 ? ""编辑部门"" : ""添加部门"",
            content: '");
#nullable restore
#line 97 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml"
                 Write(Url.Content("~/OrganizationManage/Department/DepartmentForm"));

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
        var selectedRow = $(""#gridTable"").bootstrapTreeTable(""getSelections"");
        if (ys.checkRowDelete(selectedRow)) {
            ys.confirm(""确认要删除选中的"" + selectedRow.length + ""条数据吗？"", function () {
                var ids = ys.getIds(selectedRow);
                ys.ajax({
                    url: '");
#nullable restore
#line 111 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/OrganizationManage/Views/Department/DepartmentIndex.cshtml"
                     Write(Url.Content("~/OrganizationManage/Department/DeleteFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?ids=' + ids,
                    type: ""post"",
                    error: ys.ajaxError,
                    success: function (obj) {
                        if (obj.Tag == 1) {
                            ys.msgSuccess(obj.Message);
                            searchTreeGrid();
                        }
                        else {
                            ys.msgError(obj.Message);
                        }
                    }
                });
            });
        }
    }
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
