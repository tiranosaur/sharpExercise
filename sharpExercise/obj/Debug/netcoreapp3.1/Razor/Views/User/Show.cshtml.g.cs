#pragma checksum "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efff470f641aa952adecaf8b630f1707cfd9ee02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Show), @"mvc.1.0.view", @"/Views/User/Show.cshtml")]
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
#nullable restore
#line 1 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Show.cshtml"
using sharpExercise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efff470f641aa952adecaf8b630f1707cfd9ee02", @"/Views/User/Show.cshtml")]
    public class Views_User_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Show.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";
    User user = ViewBag.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 10 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Show.cshtml"
Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<ul>\n    <li>Id: ");
#nullable restore
#line 12 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Show.cshtml"
       Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Username: ");
#nullable restore
#line 13 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Show.cshtml"
             Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Email: ");
#nullable restore
#line 14 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Show.cshtml"
          Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
