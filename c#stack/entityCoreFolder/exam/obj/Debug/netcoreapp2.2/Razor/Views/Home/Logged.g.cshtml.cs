#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915035c7d3cbd83b9e8ff299e0f508a60b5615f6"
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
#line 1 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/_ViewImports.cshtml"
using exam;

#line default
#line hidden
#line 2 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/_ViewImports.cshtml"
using exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915035c7d3cbd83b9e8ff299e0f508a60b5615f6", @"/Views/Home/Logged.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb2a55d59d82a6188c718c6158103bf5dc00b82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Logged : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(55, 32, true);
            WriteLiteral("\n<h1 class=\"display-4\">Welcome, ");
            EndContext();
            BeginContext(88, 15, false);
#line 7 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(103, 31, true);
            WriteLiteral("!</h1>\n\n\n<p class=\"blockquote\">");
            EndContext();
            BeginContext(135, 17, false);
#line 10 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
                 Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(152, 126, true);
            WriteLiteral("</p>\n\n\n<table class=\"table table-bordered col-lg-3\">\n  <thead>\n    <tr>\n      <th>Friends</th>\n    </tr>\n  </thead>\n  <tbody>\n");
            EndContext();
#line 20 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
     foreach(User friend in ViewBag.friends)
    {

#line default
#line hidden
            BeginContext(329, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(351, 16, false);
#line 23 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
       Write(friend.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(367, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(369, 15, false);
#line 23 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
                         Write(friend.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(384, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 25 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
    }

#line default
#line hidden
            BeginContext(406, 171, true);
            WriteLiteral("  </tbody>\n</table>\n\n\n<table class=\"table table-bordered col-lg-3\">\n  <thead>\n    <tr>\n      <th>Friend Requests</th>\n      <th>Action</th>\n    </tr>\n  </thead>\n  <tbody>\n");
            EndContext();
#line 38 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
     foreach(User u in ViewBag.MyInvitationz)
    {

#line default
#line hidden
            BeginContext(629, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(651, 11, false);
#line 41 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
       Write(u.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(662, 20, true);
            WriteLiteral("</td>\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 682, "\"", 706, 2);
            WriteAttributeValue("", 689, "/accept/", 689, 8, true);
#line 42 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
WriteAttributeValue("", 697, u.UserId, 697, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(707, 27, true);
            WriteLiteral(">Accept</a></td>\n    </tr>\n");
            EndContext();
#line 44 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/exam/Views/Home/Logged.cshtml"
    }

#line default
#line hidden
            BeginContext(740, 118, true);
            WriteLiteral("  </tbody>\n</table>\n\n\n\n\n\n\n<button class=\"btn btn-success\"><a style=\"color:white;\" href=\"logout\">LOG OUT</a></button>\n\n");
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
