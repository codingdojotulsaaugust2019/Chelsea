#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3b115074454a5cd25893d46a08c89b92fd5922"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3b115074454a5cd25893d46a08c89b92fd5922", @"/Views/Home/Logged.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815bf6f9559dc1e54539ae14d45c00a36fe1e715", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Logged : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = Layout = "~/Views/Shared/_LoggedLayout.cshtml";

#line default
#line hidden
            BeginContext(122, 56, true);
            WriteLiteral("\n<div class=\"container\">\n\n    <p>Available Zombies:</p>\n");
            EndContext();
#line 11 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
     foreach (User u in @Model)
    {


#line default
#line hidden
            BeginContext(217, 142, true);
            WriteLiteral("    <div class=\"card d-inline-block m-1 col-lg-4 bg-danger text-white\">\n        <img style=\"width:280px;height:230px\" class=\"card-img-top m-1\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 359, "\"", 376, 1);
#line 15 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
WriteAttributeValue("", 365, u.ImageURL, 365, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(377, 69, true);
            WriteLiteral(">\n        <div class=\"card-body\">\n            <h4 class=\"card-title\">");
            EndContext();
            BeginContext(447, 11, false);
#line 17 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
                              Write(u.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(458, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(460, 10, false);
#line 17 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
                                           Write(u.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(470, 52, true);
            WriteLiteral("</h4>\n            <p class=\"card-text\">\n            ");
            EndContext();
            BeginContext(523, 9, false);
#line 19 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
       Write(u.Tagline);

#line default
#line hidden
            EndContext();
            BeginContext(532, 32, true);
            WriteLiteral("\n            </p>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 564, "\"", 588, 2);
            WriteAttributeValue("", 571, "profile/", 571, 8, true);
#line 21 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
WriteAttributeValue("", 579, u.UserId, 579, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(589, 56, true);
            WriteLiteral(" class=\"btn btn-primary\">View Profile</a>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 645, "\"", 670, 2);
            WriteAttributeValue("", 652, "messager/", 652, 9, true);
#line 22 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"
WriteAttributeValue("", 661, u.UserId, 661, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(671, 63, true);
            WriteLiteral(" class=\"btn btn-primary\">Message</a>\n        </div>\n    </div>\n");
            EndContext();
#line 25 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Logged.cshtml"

    }

#line default
#line hidden
            BeginContext(741, 8, true);
            WriteLiteral("\n</div>\n");
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
