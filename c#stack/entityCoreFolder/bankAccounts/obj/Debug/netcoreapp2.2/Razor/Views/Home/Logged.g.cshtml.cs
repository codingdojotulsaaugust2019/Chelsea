#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c6354312e959c5e8843dd7981a2fc2874dcdf67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Logged), @"mvc.1.0.view", @"/Views/Home/Logged.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Logged.cshtml", typeof(AspNetCore.Views_Home_Logged))]
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/_ViewImports.cshtml"
using bankAccounts;

#line default
#line hidden
#line 2 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/_ViewImports.cshtml"
using bankAccounts.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6354312e959c5e8843dd7981a2fc2874dcdf67", @"/Views/Home/Logged.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d894afe0b39049437e56f498fe8ce3be86ce174", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Logged : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("transaction"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(55, 62, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome, ");
            EndContext();
            BeginContext(118, 15, false);
#line 8 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
                              Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(133, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(135, 14, false);
#line 8 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
                                               Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(149, 30, true);
            WriteLiteral("</h1>\n    <p>Current Balance: ");
            EndContext();
            BeginContext(180, 13, false);
#line 9 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
                   Write(Model.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(193, 66, true);
            WriteLiteral("</p>\n</div>\n\n<div class=\"container\">\n\n<div class=\"container\">\n    ");
            EndContext();
            BeginContext(259, 661, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6354312e959c5e8843dd7981a2fc2874dcdf676526", async() => {
                BeginContext(300, 292, true);
                WriteLiteral(@"

        <div class=""form-group col-lg-4"">
            <label for=""Amount"">Amount</label>
            <input name=""Amount"" type=""number"" step="".01"" class=""form-control"">
        </div>

        <div class=""form-group"">
        <select name=""Deposit"" class=""form-group col-lg-4"">
            ");
                EndContext();
                BeginContext(592, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6354312e959c5e8843dd7981a2fc2874dcdf677211", async() => {
                    BeginContext(635, 15, true);
                    WriteLiteral("Withdraw Amount");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(659, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(672, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6354312e959c5e8843dd7981a2fc2874dcdf678757", async() => {
                    BeginContext(714, 14, true);
                    WriteLiteral("Deposit Amount");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(737, 77, true);
                WriteLiteral("\n        </select>\n        </div>\n\n        <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 814, "\"", 835, 1);
#line 29 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
WriteAttributeValue("", 822, Model.UserId, 822, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(836, 77, true);
                WriteLiteral(">\n\n        <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(920, 217, true);
            WriteLiteral("\n</div>\n\n<div class=\"container\">\n    <table class=\"table table-bordered col-lg-6\">\n    <thead>\n        <tr>\n        <th>Amount</th>\n        <th>Date</th>\n        <th>Action</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 45 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
         foreach(Transaction trans in ViewBag.Transactions)
        {

#line default
#line hidden
            BeginContext(1207, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(1237, 12, false);
#line 48 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
           Write(trans.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1249, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1272, 19, false);
#line 49 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
           Write(trans.TransactionAt);

#line default
#line hidden
            EndContext();
            BeginContext(1291, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 50 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
                 if(@trans.Deposit == false)
                {

#line default
#line hidden
            BeginContext(1360, 39, true);
            WriteLiteral("                    <td>Withdrawl</td>\n");
            EndContext();
#line 53 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1456, 37, true);
            WriteLiteral("                    <td>Deposit</td>\n");
            EndContext();
#line 57 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
                }

#line default
#line hidden
            BeginContext(1511, 14, true);
            WriteLiteral("        </tr>\n");
            EndContext();
#line 59 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/bankAccounts/Views/Home/Logged.cshtml"
        }

#line default
#line hidden
            BeginContext(1535, 42, true);
            WriteLiteral("    </tbody>\n    </table>\n</div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591