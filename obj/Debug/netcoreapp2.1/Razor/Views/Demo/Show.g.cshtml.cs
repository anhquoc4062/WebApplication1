#pragma checksum "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc58d93206687233b56102ec66280f2100542d40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Show), @"mvc.1.0.view", @"/Views/Demo/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demo/Show.cshtml", typeof(AspNetCore.Views_Demo_Show))]
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
#line 1 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc58d93206687233b56102ec66280f2100542d40", @"/Views/Demo/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 30, true);
            WriteLiteral("\r\n\r\n<h2>Show</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(83, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d9860411ab34807a37a971d3c49c81d", async() => {
                BeginContext(106, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(120, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(213, 57, false);
#line 13 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
           Write(Html.DisplayNameFor(model => model.category_id.Increment));

#line default
#line hidden
            EndContext();
            BeginContext(270, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(326, 49, false);
#line 16 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
           Write(Html.DisplayNameFor(model => model.category_name));

#line default
#line hidden
            EndContext();
            BeginContext(375, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 21 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(470, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(519, 56, false);
#line 24 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
           Write(Html.DisplayFor(modelItem => item.category_id.Increment));

#line default
#line hidden
            EndContext();
            BeginContext(575, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(631, 48, false);
#line 27 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
           Write(Html.DisplayFor(modelItem => item.category_name));

#line default
#line hidden
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(735, 40, false);
#line 30 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(798, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(819, 47, false);
#line 31 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  }));

#line default
#line hidden
            EndContext();
            BeginContext(889, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(910, 45, false);
#line 32 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  }));

#line default
#line hidden
            EndContext();
            BeginContext(978, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "D:\Learning\MongoDB\WebApplication1\WebApplication1\Views\Demo\Show.cshtml"
}

#line default
#line hidden
            BeginContext(1017, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
