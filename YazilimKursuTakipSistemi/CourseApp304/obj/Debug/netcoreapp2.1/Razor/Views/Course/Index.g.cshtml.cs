#pragma checksum "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c062f2614b85c40d0a4265daeac8be521327d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Index.cshtml", typeof(AspNetCore.Views_Course_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c062f2614b85c40d0a4265daeac8be521327d9", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f27b51449b164ae7e254b66b01d61500f1c74a", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseApp304.Models.Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 173, true);
            WriteLiteral("\r\n<div class=\"m-4\">\r\n    <div class=\"bg-success text-white p-3\">\r\n        Course List\r\n    </div>\r\n    <div class=\"card my-2\">\r\n        <div class=\"card-body\">\r\n            ");
            EndContext();
            BeginContext(262, 983, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c37b6555f1684280aca776b4c2b78ff0", async() => {
                BeginContext(293, 84, true);
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    <input name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 377, "\"", 398, 1);
#line 15 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
WriteAttributeValue("", 385, ViewBag.Name, 385, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(399, 157, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Course Name\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input name=\"price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 556, "\"", 578, 1);
#line 18 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
WriteAttributeValue("", 564, ViewBag.Price, 564, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(579, 160, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Max Price\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input name=\"instructor\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 739, "\"", 766, 1);
#line 21 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
WriteAttributeValue("", 747, ViewBag.instructor, 747, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(767, 189, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Instructor Name\" />\r\n                </div>\r\n                <div class=\"custom-control custom-checkbox mb-2\">\r\n                    <input name=\"isActive\"");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 956, "\"", 983, 1);
#line 24 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
WriteAttributeValue("", 966, ViewBag.isActive, 966, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(984, 254, true);
                WriteLiteral(" class=\"custom-control-input\" id=\"isActive\" type=\"checkbox\" />\r\n                    <label class=\"custom-control-label\" for=\"isActive\">Active</label>\r\n                </div>\r\n\r\n                <button class=\"btn btn-primary\">Filter</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1245, 368, true);
            WriteLiteral(@"
        </div>
    </div>


    <table class=""table table-bordered table-striped table-hover"">
        <thead>
            <tr>
                <th>Course Name</th>
                <th>Price</th>
                <th>Is Active</th>
                <th>Instructor</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 45 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1670, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1709, 15, false);
#line 48 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
               Write(item.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(1724, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1752, 10, false);
#line 49 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1762, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1790, 13, false);
#line 50 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
               Write(item.isActive);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1831, 20, false);
#line 51 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
               Write(item.Instructor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1851, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1900, 334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a95831463c0e45c28700155f761e4f81", async() => {
                BeginContext(1926, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1952, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c52cbf1b63e4d9e8f0c098a9e580173", async() => {
                    BeginContext(2028, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 54 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2036, 56, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2092, "\"", 2108, 1);
#line 55 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
WriteAttributeValue("", 2100, item.Id, 2100, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2109, 118, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2234, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Course\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2293, 36, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            EndContext();
            BeginContext(2329, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a1b1c543a1442daa2a496e26c5b79fe", async() => {
                BeginContext(2376, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2386, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseApp304.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
