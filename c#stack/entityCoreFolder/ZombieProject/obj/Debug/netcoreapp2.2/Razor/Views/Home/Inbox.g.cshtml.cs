#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d18961b26256f55a9048c21ae9580642acaad6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Inbox), @"mvc.1.0.view", @"/Views/Home/Inbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Inbox.cshtml", typeof(AspNetCore.Views_Home_Inbox))]
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/_ViewImports.cshtml"
using ZombieProject;

#line default
#line hidden
#line 2 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/_ViewImports.cshtml"
using ZombieProject.Models;

#line default
#line hidden
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d18961b26256f55a9048c21ae9580642acaad6", @"/Views/Home/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815bf6f9559dc1e54539ae14d45c00a36fe1e715", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Inbox.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = Layout = "~/Views/Shared/_LoggedLayout.cshtml";

#line default
#line hidden
            BeginContext(122, 51, true);
            WriteLiteral("\n<div class=\"container\">\n    <p>Conversations:</p>\n");
            EndContext();
#line 10 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Inbox.cshtml"
     foreach(User u in @Model)
    {

#line default
#line hidden
            BeginContext(210, 31, true);
            WriteLiteral("        <ul>\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 241, "\"", 266, 2);
            WriteAttributeValue("", 248, "messager/", 248, 9, true);
#line 13 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Inbox.cshtml"
WriteAttributeValue("", 257, u.UserId, 257, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(267, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(269, 11, false);
#line 13 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Inbox.cshtml"
                                        Write(u.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(280, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(282, 10, false);
#line 13 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Inbox.cshtml"
                                                     Write(u.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(292, 24, true);
            WriteLiteral("</a></li>\n        </ul>\n");
            EndContext();
#line 15 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Inbox.cshtml"
        
    }

#line default
#line hidden
            BeginContext(331, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
