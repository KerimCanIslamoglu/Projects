#pragma checksum "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04e537d0ae5950b006031d2b243d6b785913971f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 1 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\_ViewImports.cshtml"
using CourseApp304;

#line default
#line hidden
#line 2 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\_ViewImports.cshtml"
using CourseApp304.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e537d0ae5950b006031d2b243d6b785913971f", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f27b51449b164ae7e254b66b01d61500f1c74a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseApp304.Models.Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(89, 467, true);
            WriteLiteral(@"
<div class=""m-5"">
    <div class=""bg-success text-white p-3"">Request List</div>
    <div class=""table-responsive"">
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Message</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 20 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(621, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(676, 7, false);
#line 23 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(683, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(719, 9, false);
#line 24 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(728, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(764, 10, false);
#line 25 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(774, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(810, 10, false);
#line 26 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(820, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(856, 12, false);
#line 27 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Message);

#line default
#line hidden
            EndContext();
            BeginContext(868, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 29 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                }

#line default
#line hidden
            BeginContext(921, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseApp304.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
