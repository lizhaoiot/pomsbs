#pragma checksum "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuChoose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54aef110fccac0d13807a557f9925a97e96be72f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SystemManage_Views_Menu_MenuChoose), @"mvc.1.0.view", @"/Areas/SystemManage/Views/Menu/MenuChoose.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54aef110fccac0d13807a557f9925a97e96be72f", @"/Areas/SystemManage/Views/Menu/MenuChoose.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fff452d81302d3bae40575f5c9db46ed73b4e31f", @"/Areas/SystemManage/_ViewImports.cshtml")]
    public class Areas_SystemManage_Views_Menu_MenuChoose : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuChoose.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"wrapper\">\r\n");
            WriteLiteral("    <input id=\"treeId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 875, "\"", 883, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input id=\"treeName\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 927, "\"", 935, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div id=\"menuTree\" class=\"ztree treeselect\"></div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    $(function () {\r\n        $(\'#menuTree\').ysTree({\r\n            id: \"menuTree\",\r\n            url: \'");
#nullable restore
#line 34 "/Users/lizhao/projects/pomsbs/YiSha.Web/YiSha.Admin.Web/Areas/SystemManage/Views/Menu/MenuChoose.cshtml"
             Write(Url.Content("~/SystemManage/Menu/GetMenuTreeListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            check: { enable: false },
            expandLevel: 0,
            callback: { onClick: saveChoose }
        });
    });

    function saveChoose(event, treeId, treeNode) {
        $(""#treeId"").val(treeNode.id);
        $(""#treeName"").val(treeNode.name);
    }
</script>");
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
