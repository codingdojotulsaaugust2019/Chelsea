#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46cb0d6d8d877f07526ef5b525f4fd4b53b0ba90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Product.cshtml", typeof(AspNetCore.Views_Home_Product))]
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/_ViewImports.cshtml"
using catProds;

#line default
#line hidden
#line 2 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/_ViewImports.cshtml"
using catProds.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46cb0d6d8d877f07526ef5b525f4fd4b53b0ba90", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7fea8e6ee4d12ff92f4160f5be77543a9108c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/addcat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(15, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
  
    ViewData["Title"] = "A Product";

#line default
#line hidden
            BeginContext(58, 70, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4 font-weight-bold\">");
            EndContext();
            BeginContext(129, 10, false);
#line 8 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(139, 133, true);
            WriteLiteral("</h1>\n</div>\n\n<div class=\"container\">\n\n    <div class=\"row\">\n\n        <div class=\"col-lg-6\">\n            <p class=\"font-weight-bold\">");
            EndContext();
            BeginContext(273, 10, false);
#line 16 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(283, 26, true);
            WriteLiteral("\'s Current Categories</p>\n");
            EndContext();
#line 17 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
             foreach(var c in ViewBag.cats1)
            {

#line default
#line hidden
            BeginContext(368, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(388, 6, false);
#line 19 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
              Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(394, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 20 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
            }

#line default
#line hidden
            BeginContext(413, 118, true);
            WriteLiteral("        </div>\n\n        <div class=\"col-lg-6\">\n            <p class=\"font-weight-bold\">Add a Category</p>\n            ");
            EndContext();
            BeginContext(531, 499, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46cb0d6d8d877f07526ef5b525f4fd4b53b0ba906295", async() => {
                BeginContext(569, 76, true);
                WriteLiteral("\n                <label></label>\n                <select name=\"CategoryId\">\n");
                EndContext();
#line 28 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
                     foreach(Category c in ViewBag.cats)
                    {

#line default
#line hidden
                BeginContext(724, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(748, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46cb0d6d8d877f07526ef5b525f4fd4b53b0ba907091", async() => {
                    BeginContext(779, 6, false);
#line 30 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
                                                 Write(c.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 30 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
                           WriteLiteral(c.CategoryId);

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
                BeginContext(794, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 31 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
                    }

#line default
#line hidden
                BeginContext(817, 62, true);
                WriteLiteral("                </select>\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 879, "\"", 903, 1);
#line 33 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/catProds/Views/Home/Product.cshtml"
WriteAttributeValue("", 887, Model.ProductId, 887, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(904, 119, true);
                WriteLiteral(" name=\"ProductId\">\n                <button type=\"submit\" class=\"btn btn-primary\">Add to Category!</button>\n            ");
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
            BeginContext(1030, 46, true);
            WriteLiteral("\n        </div>\n\n        \n    </div>\n\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591