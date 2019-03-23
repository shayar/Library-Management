#pragma checksum "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c346063bbcf4ab71e1264d44d69faf41aa6df818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patron/Detail.cshtml", typeof(AspNetCore.Views_Patron_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c346063bbcf4ab71e1264d44d69faf41aa6df818", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa128db651b520cf778e88daa6f4651ef70eb31d", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryMgmt.Models.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(94, 283, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
            EndContext();
            BeginContext(378, 14, false);
#line 14 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(392, 117, true);
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
            EndContext();
            BeginContext(510, 19, false);
#line 16 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(529, 65, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
            EndContext();
            BeginContext(595, 13, false);
#line 17 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(608, 63, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
            EndContext();
            BeginContext(672, 15, false);
#line 18 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(687, 67, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
            EndContext();
            BeginContext(755, 17, false);
#line 19 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(772, 70, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
            EndContext();
            BeginContext(843, 23, false);
#line 20 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibraryBranch);

#line default
#line hidden
            EndContext();
            BeginContext(866, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 21 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
            BeginContext(955, 71, true);
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
            EndContext();
            BeginContext(1027, 17, false);
#line 23 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 24 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1136, 81, true);
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
            EndContext();
#line 28 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
            BeginContext(1246, 163, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
            EndContext();
#line 35 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
            BeginContext(1481, 75, true);
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
            EndContext();
#line 39 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
            BeginContext(1667, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(1742, 27, false);
#line 42 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1769, 22, true);
            WriteLiteral(" - (Library Asset ID: ");
            EndContext();
            BeginContext(1792, 24, false);
#line 42 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 142, true);
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
            EndContext();
            BeginContext(1959, 14, false);
#line 45 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
            EndContext();
            BeginContext(1973, 144, true);
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
            EndContext();
            BeginContext(2118, 14, false);
#line 48 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
            EndContext();
            BeginContext(2132, 131, true);
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
            EndContext();
#line 52 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(2294, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 55 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2413, 64, true);
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
            EndContext();
#line 59 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
            BeginContext(2498, 109, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
            EndContext();
#line 65 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
            BeginContext(2668, 74, true);
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
            EndContext();
#line 69 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
            BeginContext(2838, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(2875, 23, false);
#line 71 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2898, 10, true);
            WriteLiteral(" - Placed ");
            EndContext();
            BeginContext(2909, 44, false);
#line 71 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2953, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 72 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(2991, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 75 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3110, 50, true);
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
            EndContext();
#line 79 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(3179, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryMgmt.Models.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
