#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/Home/ShowPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3aa045fc735c7d41cb42e8759930d17e65f40eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowPerson), @"mvc.1.0.view", @"/Views/Home/ShowPerson.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowPerson.cshtml", typeof(AspNetCore.Views_Home_ShowPerson))]
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/_ViewImports.cshtml"
using exam2;

#line default
#line hidden
#line 2 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/_ViewImports.cshtml"
using exam2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3aa045fc735c7d41cb42e8759930d17e65f40eb", @"/Views/Home/ShowPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63234ee2f9ee5bcbf3339dd16307bda54c2333a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/Home/ShowPerson.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(55, 35, true);
            WriteLiteral("\n<div class=\"container\">\n\n<p>Name: ");
            EndContext();
            BeginContext(91, 10, false);
#line 9 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/Home/ShowPerson.cshtml"
    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(101, 15, true);
            WriteLiteral("</p>\n<p>Alias: ");
            EndContext();
            BeginContext(117, 11, false);
#line 10 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/Home/ShowPerson.cshtml"
     Write(Model.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(128, 15, true);
            WriteLiteral("</p>\n<p>Email: ");
            EndContext();
            BeginContext(144, 11, false);
#line 11 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/Home/ShowPerson.cshtml"
     Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(155, 20, true);
            WriteLiteral("</p>\n\n<p>I\'ve liked ");
            EndContext();
            BeginContext(176, 17, false);
#line 13 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/Home/ShowPerson.cshtml"
         Write(Model.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(193, 27, true);
            WriteLiteral(" Ideas.</p>\n<p>I\'ve posted ");
            EndContext();
            BeginContext(221, 17, false);
#line 14 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam2/Views/Home/ShowPerson.cshtml"
          Write(Model.Ideas.Count);

#line default
#line hidden
            EndContext();
            BeginContext(238, 19, true);
            WriteLiteral(" Ideas.</p>\n\n</div>");
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
