#pragma checksum "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d273c6c0c7895c2fad76386cd59f598b53c24a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5d273c6c0c7895c2fad76386cd59f598b53c24a", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815bf6f9559dc1e54539ae14d45c00a36fe1e715", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(55, 124, true);
            WriteLiteral("\n<div class=\"container\">\n\n    <div class=\"row\">\n        <img style=\"width:380px;height:330px\" class=\"img-thumbnail col-lg-4\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 179, "\"", 200, 1);
#line 10 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
WriteAttributeValue("", 185, Model.ImageURL, 185, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(201, 89, true);
            WriteLiteral(" alt=\"Thumbnail image\">\n        <div class=\"col-lg-6\">\n            <h1 class=\"display-4\">");
            EndContext();
            BeginContext(291, 15, false);
#line 12 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
                             Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(306, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(308, 14, false);
#line 12 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
                                              Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(322, 36, true);
            WriteLiteral("</h1>\n            <p>Interested In: ");
            EndContext();
            BeginContext(359, 18, false);
#line 13 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
                         Write(Model.InterestedIn);

#line default
#line hidden
            EndContext();
            BeginContext(377, 30, true);
            WriteLiteral("</p>\n            <p>Location: ");
            EndContext();
            BeginContext(408, 10, false);
#line 14 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
                    Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(418, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(421, 11, false);
#line 14 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
                                 Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(432, 28, true);
            WriteLiteral("</p>\n            <p>My Bio: ");
            EndContext();
            BeginContext(461, 17, false);
#line 15 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
                  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(478, 32, true);
            WriteLiteral("</p>\n            <p>My Hobbies: ");
            EndContext();
            BeginContext(511, 13, false);
#line 16 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
                      Write(Model.Hobbies);

#line default
#line hidden
            EndContext();
            BeginContext(524, 65, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n\n    <div class=\"row\">\n        <p>");
            EndContext();
            BeginContext(590, 13, false);
#line 21 "/Users/chelseareynolds/GitRepo/c#stack/entityCoreFolder/ZombieProject/Views/Home/Profile.cshtml"
      Write(Model.Tagline);

#line default
#line hidden
            EndContext();
            BeginContext(603, 24, true);
            WriteLiteral("</p>\n    </div>\n\n\n</div>");
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
