#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/lognReg/Views/Home/Logged.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb4d6b2954504804b372e632a409b4f0fb9c69b"
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/lognReg/Views/_ViewImports.cshtml"
using lognReg;

#line default
#line hidden
#line 2 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/lognReg/Views/_ViewImports.cshtml"
using lognReg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb4d6b2954504804b372e632a409b4f0fb9c69b", @"/Views/Home/Logged.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02b7bee982e688481e1985b3bbce9c2dc4c8c4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Logged : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/lognReg/Views/Home/Logged.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 128, true);
            WriteLiteral("\n<h1 class=\"display-4\">Success!</h1>\n\n<button class=\"btn btn-success\"><a style=\"color:white;\" href=\"logout\">LOG OUT</a></button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
