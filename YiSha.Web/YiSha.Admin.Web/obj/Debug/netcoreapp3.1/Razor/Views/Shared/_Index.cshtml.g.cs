#pragma checksum "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6498d8dd8af1aafe5947e641b5ba425546ffedb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Index), @"mvc.1.0.view", @"/Views/Shared/_Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6498d8dd8af1aafe5947e641b5ba425546ffedb", @"/Views/Shared/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10467f6850395725752005e8267616b06b0df080", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("gray-bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" <!--Areas文件夹下列表页面模板-->\r\n");
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6498d8dd8af1aafe5947e641b5ba425546ffedb4535", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""renderer"" content=""webkit|ie-comp|ie-stand"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"" />
    <meta http-equiv=""Cache-Control"" content=""no-siteapp"" />
    ");
#nullable restore
#line 11 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap/3.3.7/css/bootstrap.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fontawesome/4.7.0/css/fontawesome.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/jquery/2.1.4/jquery.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 15 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap/3.3.7/js/bootstrap.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 16 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/layer/3.1.1/layer.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 17 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/laydate/5.0.9/laydate.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 19 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.table/1.12.0/bootstrap-table.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 20 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/bootstrap.table/1.12.0/bootstrap-table.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 22 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/css/style.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/js/yisha.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 25 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/select2/4.0.6/css/select2.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 26 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/select2/4.0.6/js/select2.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 28 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(RenderSection("header", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        var ctx = \'");
#nullable restore
#line 30 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6498d8dd8af1aafe5947e641b5ba425546ffedb10322", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 34 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 35 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(RenderSection("footer", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 37 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/css/yisha.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 38 "/Users/lizhao/projects/YiShaAdmin/YiSha.Web/YiSha.Admin.Web/Views/Shared/_Index.cshtml"
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
            WriteLiteral("\r\n</html>");
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
