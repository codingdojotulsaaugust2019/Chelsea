#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08db00cddfae1afa992a012572c0d2e8a2248af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
using chefNdish.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08db00cddfae1afa992a012572c0d2e8a2248af4", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a108710d68d036f1cf3468b341dd7c83cd1bfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
  
    ViewData["Title"] = "Dishes";

#line default
#line hidden
            BeginContext(91, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(96, 17, false);
#line 8 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(113, 276, true);
            WriteLiteral(@"</h1>


<table class=""table"">
        <thead>
            <tr>
            <th>Name</th>
            <th>Tastiness</th>
            <th>Calories</th>
            <th>Chef</th>
            <th>Description</th>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 23 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
         foreach (Dish d in @Model)
        {

#line default
#line hidden
            BeginContext(437, 34, true);
            WriteLiteral("            <tr>\r\n            <td>");
            EndContext();
            BeginContext(472, 6, false);
#line 26 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
           Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(478, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(502, 11, false);
#line 27 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
           Write(d.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(513, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(537, 10, false);
#line 28 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
           Write(d.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(547, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(571, 19, false);
#line 29 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
           Write(d.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(590, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(614, 13, false);
#line 30 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
           Write(d.Description);

#line default
#line hidden
            EndContext();
            BeginContext(627, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/chefNdish/Views/Home/Dishes.cshtml"
        }

#line default
#line hidden
            BeginContext(664, 52, true);
            WriteLiteral("    </table>\r\n\r\n<a href=\"/newdish\">Add A Dish!</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591