#pragma checksum "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dddd06c873633d35dc47f1500283ac593995cac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
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
#line 1 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Edit.cshtml"
using sharpExercise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dddd06c873633d35dc47f1500283ac593995cac", @"/Views/User/Edit.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Edit.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";
    User user = ViewBag.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Edit User</h2>\n<form action=\"/user/store\" method=\"post\">\n    <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 227, "\"", 243, 1);
#nullable restore
#line 12 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Edit.cshtml"
WriteAttributeValue("", 235, user.Id, 235, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <div>\n        <label for=\"Username\"></label>\n        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 321, "\"", 343, 1);
#nullable restore
#line 15 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Edit.cshtml"
WriteAttributeValue("", 329, user.Username, 329, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Username\" id=\"Username\">\n    </div>\n    <div>\n        <label for=\"Email\"></label>\n        <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 459, "\"", 478, 1);
#nullable restore
#line 19 "/home/tiranosaur/Documents/sharp/sharpExercise/sharpExercise/Views/User/Edit.cshtml"
WriteAttributeValue("", 467, user.Email, 467, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Email\" id=\"Email\">\n    </div>\n    <div>\n        <input type=\"submit\" value=\"Update\">\n    </div>\n</form>\n\n");
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
