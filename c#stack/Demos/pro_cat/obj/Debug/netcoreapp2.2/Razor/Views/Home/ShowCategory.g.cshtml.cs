#pragma checksum "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61a021d0693341d330fcc1641aa0fede08d799cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCategory), @"mvc.1.0.view", @"/Views/Home/ShowCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowCategory.cshtml", typeof(AspNetCore.Views_Home_ShowCategory))]
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
#line 1 "/Users/pkrull/Downloads/pro_cat/Views/_ViewImports.cshtml"
using pro_cat;

#line default
#line hidden
#line 2 "/Users/pkrull/Downloads/pro_cat/Views/_ViewImports.cshtml"
using pro_cat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61a021d0693341d330fcc1641aa0fede08d799cd", @"/Views/Home/ShowCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c16fcec3b277a14623556f4fb8a94ddff4f58485", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/add_prod_to_cat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 68, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h3>Category: ");
            EndContext();
            BeginContext(87, 10, false);
#line 5 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(97, 36, true);
            WriteLiteral("</h3>\r\n        <h5>Products(Count): ");
            EndContext();
            BeginContext(134, 33, false);
#line 6 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
                        Write(ViewBag.Associated_Products.Count);

#line default
#line hidden
            EndContext();
            BeginContext(167, 49, true);
            WriteLiteral("</h5>\r\n        <h5>Products:</h5>\r\n        <ul>\r\n");
            EndContext();
#line 9 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
             foreach(var p in ViewBag.Associated_Products){

#line default
#line hidden
            BeginContext(277, 21, true);
            WriteLiteral("                <li> ");
            EndContext();
            BeginContext(299, 6, false);
#line 10 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
                Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(305, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 11 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
            }

#line default
#line hidden
            BeginContext(328, 92, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <h3>Add Products:</h3>\r\n        ");
            EndContext();
            BeginContext(420, 541, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61a021d0693341d330fcc1641aa0fede08d799cd5723", async() => {
                BeginContext(466, 45, true);
                WriteLiteral("\r\n            <input type=hidden name=\"catid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 511, "\"", 531, 1);
#line 17 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
WriteAttributeValue("", 519, Model.CatId, 519, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(532, 170, true);
                WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                <label for=\"Product\">Product</label>\r\n                <Select class=\"form-control\" for=\"Product\" name=\"prodid\">\r\n");
                EndContext();
#line 21 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
                 foreach(var p in ViewBag.Products){

#line default
#line hidden
                BeginContext(756, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(776, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61a021d0693341d330fcc1641aa0fede08d799cd7004", async() => {
                    BeginContext(803, 6, false);
#line 22 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
                                         Write(p.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 22 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
                       WriteLiteral(p.ProdId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(818, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "/Users/pkrull/Downloads/pro_cat/Views/Home/ShowCategory.cshtml"
                }

#line default
#line hidden
                BeginContext(839, 115, true);
                WriteLiteral("            </div>\r\n            <input class=\"btn btn-primary form-control\" value=\"Create\" type=\"submit\">\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(961, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591