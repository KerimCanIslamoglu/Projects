#pragma checksum "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbd85d76e45b42a2291a99a4c854783abdfbd33f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\_ViewImports.cshtml"
using GotCoreApp;

#line default
#line hidden
#line 2 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\_ViewImports.cshtml"
using GotCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd85d76e45b42a2291a99a4c854783abdfbd33f", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bca419cc78598a5d1f8fe129b5d8ec42f13f067c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GotCoreApp.Models.Bolumlers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 231, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card mb-3\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row no-gutter\">\r\n                    <div class=\"col-md-4\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 310, "\"", 329, 1);
#line 13 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
WriteAttributeValue("", 316, Model.Poster, 316, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 330, "\"", 348, 1);
#line 13 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
WriteAttributeValue("", 336, Model.Title, 336, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(349, 151, true);
            WriteLiteral(" class=\"card-img\" /></div>\r\n                    <div class=\"col-md-8\">\r\n                        <h5 class=\"card-title\">\r\n                              ");
            EndContext();
            BeginContext(501, 11, false);
#line 16 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(512, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(634, 91, true);
            WriteLiteral("                        </h5>\r\n                        <p class=\"card-text\"> <b>Year :</b> ");
            EndContext();
            BeginContext(726, 10, false);
#line 19 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                       Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(736, 67, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Rated :</b> ");
            EndContext();
            BeginContext(804, 11, false);
#line 20 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                        Write(Model.Rated);

#line default
#line hidden
            EndContext();
            BeginContext(815, 75, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Released Date :</b> ");
            EndContext();
            BeginContext(891, 14, false);
#line 21 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                                Write(Model.Released);

#line default
#line hidden
            EndContext();
            BeginContext(905, 67, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Season:</b> ");
            EndContext();
            BeginContext(973, 12, false);
#line 22 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                        Write(Model.Season);

#line default
#line hidden
            EndContext();
            BeginContext(985, 70, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Episode  :</b> ");
            EndContext();
            BeginContext(1056, 13, false);
#line 23 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                           Write(Model.Episode);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 73, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Description :</b> ");
            EndContext();
            BeginContext(1143, 10, false);
#line 24 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                              Write(Model.Plot);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 69, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Runtime :</b> ");
            EndContext();
            BeginContext(1223, 13, false);
#line 25 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                          Write(Model.Runtime);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 67, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Genre :</b> ");
            EndContext();
            BeginContext(1304, 11, false);
#line 26 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                        Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 69, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Director:</b> ");
            EndContext();
            BeginContext(1385, 14, false);
#line 27 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                          Write(Model.Director);

#line default
#line hidden
            EndContext();
            BeginContext(1399, 72, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Written by :</b> ");
            EndContext();
            BeginContext(1472, 12, false);
#line 28 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                             Write(Model.Writer);

#line default
#line hidden
            EndContext();
            BeginContext(1484, 68, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Actors :</b> ");
            EndContext();
            BeginContext(1553, 12, false);
#line 29 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                         Write(Model.Actors);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 70, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Language :</b> ");
            EndContext();
            BeginContext(1636, 14, false);
#line 30 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                           Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 69, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Country :</b> ");
            EndContext();
            BeginContext(1720, 13, false);
#line 31 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                          Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1733, 68, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Awards :</b> ");
            EndContext();
            BeginContext(1802, 12, false);
#line 32 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                         Write(Model.Awards);

#line default
#line hidden
            EndContext();
            BeginContext(1814, 70, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Metascore:</b> ");
            EndContext();
            BeginContext(1885, 15, false);
#line 33 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                           Write(Model.Metascore);

#line default
#line hidden
            EndContext();
            BeginContext(1900, 66, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Type :</b> ");
            EndContext();
            BeginContext(1967, 10, false);
#line 34 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                       Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1977, 69, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Imdb Id :</b> ");
            EndContext();
            BeginContext(2047, 12, false);
#line 35 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                          Write(Model.ImdbId);

#line default
#line hidden
            EndContext();
            BeginContext(2059, 72, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Imdb Votes :</b> ");
            EndContext();
            BeginContext(2132, 15, false);
#line 36 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                             Write(Model.ImdbVotes);

#line default
#line hidden
            EndContext();
            BeginContext(2147, 74, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Imdb Ratings :</b> ");
            EndContext();
            BeginContext(2222, 16, false);
#line 37 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                               Write(Model.ImdbRating);

#line default
#line hidden
            EndContext();
            BeginContext(2238, 70, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Serie Id :</b> ");
            EndContext();
            BeginContext(2309, 14, false);
#line 38 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                           Write(Model.SeriesId);

#line default
#line hidden
            EndContext();
            BeginContext(2323, 70, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"> <b>Response :</b> ");
            EndContext();
            BeginContext(2394, 14, false);
#line 39 "C:\Users\kerim\source\repos\GotCoreApp\GotCoreApp\Views\Home\Details.cshtml"
                                                           Write(Model.Response);

#line default
#line hidden
            EndContext();
            BeginContext(2408, 165, true);
            WriteLiteral("</p>\r\n                      \r\n                       \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GotCoreApp.Models.Bolumlers> Html { get; private set; }
    }
}
#pragma warning restore 1591
