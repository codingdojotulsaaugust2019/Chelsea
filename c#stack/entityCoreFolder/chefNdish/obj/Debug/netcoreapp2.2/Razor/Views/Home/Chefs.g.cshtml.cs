#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deed1b38ebc6ce6694ac54efbc3db8cf85bdc3f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chefs), @"mvc.1.0.view", @"/Views/Home/Chefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Chefs.cshtml", typeof(AspNetCore.Views_Home_Chefs))]
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/_ViewImports.cshtml"
using chefNdish;

#line default
#line hidden
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
using chefNdish.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deed1b38ebc6ce6694ac54efbc3db8cf85bdc3f1", @"/Views/Home/Chefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a108710d68d036f1cf3468b341dd7c83cd1bfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
  
    ViewData["Title"] = "Chefs";

#line default
#line hidden
            BeginContext(88, 31, true);
            WriteLiteral("<div class=\"container\">\r\n\r\n<h1>");
            EndContext();
            BeginContext(120, 17, false);
#line 9 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(137, 219, true);
            WriteLiteral("</h1>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n            <th>Birthday</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 19 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
         foreach (Chef c in @Model)
        {

#line default
#line hidden
            BeginContext(404, 34, true);
            WriteLiteral("            <tr>\r\n            <td>");
            EndContext();
            BeginContext(439, 11, false);
#line 22 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
           Write(c.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(450, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(474, 10, false);
#line 23 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
           Write(c.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(484, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(508, 10, false);
#line 24 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
           Write(c.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(518, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Chefs.cshtml"
        }

#line default
#line hidden
            BeginContext(555, 52, true);
            WriteLiteral("    </table>\r\n</div>\r\n<a href=\"/new\">Add A Chef!</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
