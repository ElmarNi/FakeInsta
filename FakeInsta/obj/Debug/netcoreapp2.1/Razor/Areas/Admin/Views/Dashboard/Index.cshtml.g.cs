#pragma checksum "C:\Users\User\Desktop\FakeInsta\FakeInsta\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0639ca391ec9167b21c680be0d004f446e519485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0639ca391ec9167b21c680be0d004f446e519485", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FakeInsta.Models.LoginInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 454, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
      integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

<table class=""table table-hover w-100"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Username</th>
            <th scope=""col"">Password</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 14 "C:\Users\User\Desktop\FakeInsta\FakeInsta\Areas\Admin\Views\Dashboard\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(551, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"col\">");
            EndContext();
            BeginContext(602, 7, false);
#line 17 "C:\Users\User\Desktop\FakeInsta\FakeInsta\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(609, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"col\">");
            EndContext();
            BeginContext(649, 13, false);
#line 18 "C:\Users\User\Desktop\FakeInsta\FakeInsta\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(item.username);

#line default
#line hidden
            EndContext();
            BeginContext(662, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"col\">");
            EndContext();
            BeginContext(702, 13, false);
#line 19 "C:\Users\User\Desktop\FakeInsta\FakeInsta\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(item.password);

#line default
#line hidden
            EndContext();
            BeginContext(715, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 21 "C:\Users\User\Desktop\FakeInsta\FakeInsta\Areas\Admin\Views\Dashboard\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(752, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FakeInsta.Models.LoginInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591