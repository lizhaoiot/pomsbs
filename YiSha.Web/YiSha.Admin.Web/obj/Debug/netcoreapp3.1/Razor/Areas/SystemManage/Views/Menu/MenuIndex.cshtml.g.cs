#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33903e4d14f5c3a4df9520edd8f338f45799efc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Menu_MenuIndex), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Menu/MenuIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33903e4d14f5c3a4df9520edd8f338f45799efc", @"/Areas/SystemManage/Views/Menu/MenuIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Menu_MenuIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.treetable/1.0/bootstrap-treetable.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.treetable/1.0/bootstrap-treetable.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"container-div\">\r\n    <div class=\"row\">\r\n        <div id=\"searchDiv\" class=\"col-sm-12 search-collapse\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e33903e4d14f5c3a4df9520edd8f338f45799efc5543", async() => {
                WriteLiteral(@"
                <div class=""select-list"">
                    <ul>
                        <li>
                            菜单名称：<input id=""menuName"" col=""MenuName"" type=""text"" />
                        </li>
                        <li>
                            菜单状态：<span id=""menuStatus"" col=""MenuStatus""></span>
                        </li>
                        <li><a class=""btn btn-primary btn-sm"" onclick=""searchTreeGrid()""><i class=""fa fa-search""></i>&nbsp;搜索</a></li>
                    </ul>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""btn-group-sm"" id=""toolbar"" role=""group"">
            <a id=""btnAdd"" class=""btn btn-success"" onclick=""showSaveForm(true)""><i class=""fa fa-plus""></i> 新增</a>
            <a id=""btnEdit"" class=""btn btn-primary"" onclick=""showSaveForm(false)""><i class=""fa fa-edit""></i> 修改</a>
            <a id=""btnDelete"" class=""btn btn-danger"" onclick=""deleteForm()""><i class=""fa fa-remove""></i> 删除</a>
            <a id=""btnExpandAll"" class=""btn btn-info""><i class=""fa fa-exchange""></i> 展开/折叠</a>
        </div>
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    var parentId = 0;
    var id = 0;
    $(function () {
        initTreeGrid();

        $(""#menuStatus"").ysComboBox({ data: ys.getJson(");
#nullable restore
#line 47 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });
    });

    function initTreeGrid() {
        var options = {
            code: ""Id"",
            parentCode: ""ParentId"",
            expandAll: false,
            expandFirst: false,
            toolbar: '#toolbar',
            expandColumn: '1',
            url: '");
#nullable restore
#line 58 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
             Write(Url.Content("~/SystemManage/Menu/GetListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            modalName: ""菜单"",
            columns: [
                { field: 'selectItem', radio: true },
                {
                    field: 'MenuName', title: '菜单名称', width: '20%', formatter: function (value, row, index) {
                        if (ys.isNullOrEmpty(row.MenuIcon)) {
                            return row.MenuName;
                        } else {
                            return '<i class=""' + row.MenuIcon + '""></i> <span class=""nav-label"">' + row.MenuName + '</span>';
                        }
                    }
                },
                {
                    field: 'MenuType', title: '类型', width: '10%', align: ""left"",
                    formatter: function (value, item, index) {
                        if (item.MenuType == """);
#nullable restore
#line 74 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                         Write(MenuTypeEnum.Directory.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"label label-success\">");
#nullable restore
#line 75 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                                                 Write(MenuTypeEnum.Directory.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\';\r\n                        }\r\n                        else if (item.MenuType == \"");
#nullable restore
#line 77 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                              Write(MenuTypeEnum.Menu.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"label label-primary\">");
#nullable restore
#line 78 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                                                 Write(MenuTypeEnum.Menu.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\';\r\n                        }\r\n                        else if (item.MenuType == \"");
#nullable restore
#line 80 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                              Write(MenuTypeEnum.Button.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"label label-warning\">");
#nullable restore
#line 81 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                                                 Write(MenuTypeEnum.Button.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>';
                        }
                    }
                },
                { field: 'MenuSort', title: '显示顺序', width: '10%', align: ""left"" },
                { field: 'MenuUrl', title: '请求地址', width: '35%', align: ""left"" },
                { field: 'Authorize', title: '权限标识', width: '15%', align: ""left"" },
                {
                    field: 'MenuStatus', title: '状态', width: '10%', align: ""left"",
                    formatter: function (value, row, index) {
                        if (row.MenuStatus == """);
#nullable restore
#line 91 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                          Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral("\") {\r\n                            return \'<span class=\"badge badge-primary\">\' + \"");
#nullable restore
#line 92 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                                                      Write(StatusEnum.Yes.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("\" + \'</span>\';\r\n                        } else {\r\n                            return \'<span class=\"badge badge-warning\">\' + \"");
#nullable restore
#line 94 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                                                                      Write(StatusEnum.No.GetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + '</span>';
                        }
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
        $('#gridTable').ysTreeTable('search', param);
        if (callBackId) {
            id = callBackId;
        }
    }

    function showSaveForm(bAdd) {
        var id = 0;
        var parentName = '';

        var selectedRow = $(""#gridTable"").bootstrapTreeTable(""getSelections"");
        if (!bAdd) {
            if (!ys.checkRowEdit(selectedRow)) {
                return;
            }
            id = selectedRow[0].Id;
        }
        if (selectedRow.length > 0) {
            parentId = selectedRow[0].ParentId;
            var row = $('#grid");
            WriteLiteral("Table\').ysTreeTable(\'getRowById\', parentId);\r\n            if (row) {\r\n                parentName = row.MenuName;\r\n            }\r\n        }\r\n\r\n        ys.openDialog({\r\n            title: id > 0 ? \"编辑菜单\" : \"添加菜单\",\r\n            content: \'");
#nullable restore
#line 137 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                 Write(Url.Content("~/SystemManage/Menu/MenuForm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id + '&parentId=' + parentId + '&parentName=' + encodeURIComponent(parentName),
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
#line 151 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuIndex.cshtml"
                     Write(Url.Content("~/SystemManage/Menu/DeleteFormJson"));

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
