#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d07bec7d5e2bb6755658b9e58c4eabda30b68561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/_ViewImports.cshtml"
using YiSha.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/_ViewImports.cshtml"
using YiSha.Entity.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/_ViewImports.cshtml"
using YiSha.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/_ViewImports.cshtml"
using YiSha.Admin.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07bec7d5e2bb6755658b9e58c4eabda30b68561", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10467f6850395725752005e8267616b06b0df080", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fixed-sidebar full-height-layout gray-bg login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--登录页和首页模板-->\r\n");
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d07bec7d5e2bb6755658b9e58c4eabda30b685614571", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""renderer"" content=""webkit|ie-comp|ie-stand"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"" />
    <meta http-equiv=""Cache-Control"" content=""no-siteapp"" />

    <meta name=""keywords"" content=""中粮包装运营管理平台"">
    <meta name=""description"" content=""中粮包装运营管理平台"""">

    <link rel=""bookmark"" href='");
#nullable restore
#line 15 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
                          Write(Url.Content("~/faviconcpmc.ico"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' />\r\n    <link rel=\"shortcut icon\" href=\"");
#nullable restore
#line 16 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
                               Write(Url.Content("~/faviconcpmc.ico"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" type=\"image/x-icon\" />\r\n\r\n    ");
#nullable restore
#line 18 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap/3.3.7/css/bootstrap.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 19 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fontawesome/4.7.0/css/fontawesome.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 20 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/jquery/2.1.4/jquery.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 22 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap/3.3.7/js/bootstrap.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/layer/3.1.1/layer.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 25 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/css/style.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 26 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/js/yisha.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!--首页需要用到的js开始-->\r\n    ");
#nullable restore
#line 29 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/js/yisha-index.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\'", 1722, "\'", 1792, 1);
#nullable restore
#line 30 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 1728, Url.Content("~/lib/jquery.metisMenu/1.1.3/jquery.metisMenu.js"), 1728, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\'", 1839, "\'", 1915, 1);
#nullable restore
#line 31 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 1845, Url.Content("~/lib/jquery.slimscroll/1.3.8/jquery.slimscroll.min.js"), 1845, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!--首页需要用到的js结束-->\r\n    ");
#nullable restore
#line 33 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(RenderSection("header", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <title>中粮包装运营管理平台</title>\r\n    <style type=\"text/css\">\r\n        .nav > li:hover .dropdown-menu {\r\n            display: block;\r\n        }\r\n    </style>\r\n    <script type=\"text/javascript\">\r\n        var ctx = \'");
#nullable restore
#line 41 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
              Write(Url.Content("~/"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d07bec7d5e2bb6755658b9e58c4eabda30b6856110970", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 45 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 46 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(RenderSection("footer", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 48 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/css/yisha.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 49 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Layout.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/js/yisha-init.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
