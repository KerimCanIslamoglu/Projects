#pragma checksum "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5cb7f40924210f3e31d110524cd2b2d50f5e88a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_InstructorEdit), @"mvc.1.0.view", @"/Views/Instructor/InstructorEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructor/InstructorEdit.cshtml", typeof(AspNetCore.Views_Instructor_InstructorEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5cb7f40924210f3e31d110524cd2b2d50f5e88a", @"/Views/Instructor/InstructorEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f27b51449b164ae7e254b66b01d61500f1c74a", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_InstructorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseApp304.Models.Instructor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
   int counter = 0;

#line default
#line hidden
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 1173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3381855605474babff296acbe6ec42", async() => {
                BeginContext(103, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(109, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a4a008a01e69448289c1b13c91bbef30", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(145, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(151, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d1f02f851ad4946955049d7789f3436", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(189, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
     foreach (var course in Model.Courses)
    {

#line default
#line hidden
                BeginContext(242, 64, true);
                WriteLiteral("        <div class=\"row my-2\">\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 306, "\"", 324, 1);
#line 11 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 314, course.Id, 314, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 325, "\"", 352, 3);
                WriteAttributeValue("", 332, "Courses[", 332, 8, true);
#line 11 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 340, counter, 340, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 348, "].Id", 348, 4, true);
                EndWriteAttribute();
                BeginContext(353, 37, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 390, "\"", 417, 1);
#line 12 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 398, course.Description, 398, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 418, "\"", 454, 3);
                WriteAttributeValue("", 425, "Courses[", 425, 8, true);
#line 12 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 433, counter, 433, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 441, "].Description", 441, 13, true);
                EndWriteAttribute();
                BeginContext(455, 37, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 492, "\"", 525, 3);
                WriteAttributeValue("", 499, "Courses[", 499, 8, true);
#line 13 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 507, counter, 507, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 515, "].isActive", 515, 10, true);
                EndWriteAttribute();
                BeginContext(526, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(529, 64, false);
#line 13 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
                                                               Write(Html.Raw(course.isActive ? "value=\"true\"" : "value=\"false\""));

#line default
#line hidden
                EndContext();
                BeginContext(594, 70, true);
                WriteLiteral(" />\r\n            <div class=\"col\">\r\n                <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 664, "\"", 699, 3);
                WriteAttributeValue("", 671, "Courses[", 671, 8, true);
#line 15 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 679, counter, 679, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 687, "].CourseName", 687, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 700, "\"", 726, 1);
#line 15 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 708, course.CourseName, 708, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(727, 111, true);
                WriteLiteral(" class=\"form-control\" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 838, "\"", 868, 3);
                WriteAttributeValue("", 845, "Courses[", 845, 8, true);
#line 18 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 853, counter, 853, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 861, "].Price", 861, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 869, "\"", 890, 1);
#line 18 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 877, course.Price, 877, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(891, 62, true);
                WriteLiteral(" class=\"form-control\" />\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 21 "C:\Users\section1\source\repos\CourseApp304\CourseApp304\Views\Instructor\InstructorEdit.cshtml"
        { counter++; }     
    }

#line default
#line hidden
                BeginContext(989, 154, true);
                WriteLiteral("    <div class=\"row mt-2\">\r\n        <div class=\"col text-center\">\r\n            <button class=\"btn btn-success\" type=\"submit\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(1143, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24fd436817634848be52d3eb66af4fa9", async() => {
                    BeginContext(1189, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1199, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1238, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseApp304.Models.Instructor> Html { get; private set; }
    }
}
#pragma warning restore 1591
