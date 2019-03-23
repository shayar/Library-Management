#pragma checksum "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c936632de383ca5dd4bb482f5c2ca91b5fe8574e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Detail), @"mvc.1.0.view", @"/Views/Branch/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Branch/Detail.cshtml", typeof(AspNetCore.Views_Branch_Detail))]
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
#line 1 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\_ViewImports.cshtml"
using LibraryMgmt;

#line default
#line hidden
#line 2 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\_ViewImports.cshtml"
using LibraryMgmt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c936632de383ca5dd4bb482f5c2ca91b5fe8574e", @"/Views/Branch/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa128db651b520cf778e88daa6f4651ef70eb31d", @"/Views/_ViewImports.cshtml")]
    public class Views_Branch_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryMgmt.Models.Branch.BranchDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
  
    ViewData["Title"] = Model.Name + " Branch";

#line default
#line hidden
            BeginContext(108, 216, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"header clearfix detailHeading\">\r\n        <h2 class=\"text-muted\">Branch Information</h2>\r\n    </div>\r\n    <div class=\"jumbotron\">\r\n        <div class=\"row\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 324, "\"", 345, 1);
#line 12 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
WriteAttributeValue("", 330, Model.ImageUrl, 330, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(346, 142, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"row branchInfo\">\r\n            <div class=\"col-md-8\">\r\n                <div>\r\n                    <h2>");
            EndContext();
            BeginContext(489, 10, false);
#line 17 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(499, 113, true);
            WriteLiteral("</h2>\r\n                    <div class=\"branchContact\">\r\n                        <div id=\"branchAddress\">Address: ");
            EndContext();
            BeginContext(613, 13, false);
#line 19 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(626, 63, true);
            WriteLiteral("</div>\r\n                        <div id=\"branchTel\">Telephone: ");
            EndContext();
            BeginContext(690, 15, false);
#line 20 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(705, 129, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div id=\"branchDescription\">\r\n                        <p class=\"caption\">");
            EndContext();
            BeginContext(835, 17, false);
#line 23 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(852, 110, true);
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div id=\"branchHours\">\r\n                        <ul>\r\n");
            EndContext();
#line 28 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                             foreach (var day in @Model.HoursOpen)
                            {

#line default
#line hidden
            BeginContext(1061, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(1098, 3, false);
#line 30 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                               Write(day);

#line default
#line hidden
            EndContext();
            BeginContext(1101, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 31 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(1139, 313, true);
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 detailInfo"">
                <table>
                    <tr>
                        <td class=""itemLabel"">Date Opened: </td>
                        <td class=""itemValue"">");
            EndContext();
            BeginContext(1453, 14, false);
#line 40 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                                         Write(Model.OpenDate);

#line default
#line hidden
            EndContext();
            BeginContext(1467, 178, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Number Of Patrons: </td>\r\n                        <td class=\"itemValue\">");
            EndContext();
            BeginContext(1646, 21, false);
#line 44 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                                         Write(Model.NumberOfPatrons);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 177, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Number of Assets: </td>\r\n                        <td class=\"itemValue\">");
            EndContext();
            BeginContext(1845, 20, false);
#line 48 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                                         Write(Model.NumberOfAssets);

#line default
#line hidden
            EndContext();
            BeginContext(1865, 177, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Value of Assets: </td>\r\n                        <td class=\"itemValue\">$");
            EndContext();
            BeginContext(2043, 21, false);
#line 52 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Branch\Detail.cshtml"
                                          Write(Model.TotalAssetValue);

#line default
#line hidden
            EndContext();
            BeginContext(2064, 116, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryMgmt.Models.Branch.BranchDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591