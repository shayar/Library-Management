#pragma checksum "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b305bbfc56e1d11a1b0dda5366f5c387ad6cd38f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Index), @"mvc.1.0.view", @"/Views/Catalog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Index.cshtml", typeof(AspNetCore.Views_Catalog_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b305bbfc56e1d11a1b0dda5366f5c387ad6cd38f", @"/Views/Catalog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa128db651b520cf778e88daa6f4651ef70eb31d", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryMgmt.Models.Catalog.AssetIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
  
    ViewData["Title"] = "Library Catalog Index";

#line default
#line hidden
            BeginContext(110, 430, true);
            WriteLiteral(@"
<div id=""assets"">
    <h3>Library Catalog</h3>
    <div class=""assetsTable"">
        <table class="" table table-condensed"" id=""catalogIndexTable"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Author / Director</th>
                    <th>Dewey Call Number</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 20 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
                 foreach(var asset in Model.Assets)
                {

#line default
#line hidden
            BeginContext(612, 110, true);
            WriteLiteral("                    <tr class=\"assetRow\">\r\n                        <td class=\"\">\r\n                            ");
            EndContext();
            BeginContext(722, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a2eef0f9b0648898138962c7d8a8bad", async() => {
                BeginContext(795, 38, true);
                WriteLiteral("\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 833, "\"", 854, 1);
#line 25 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
WriteAttributeValue("", 839, asset.ImageUrl, 839, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(855, 51, true);
                WriteLiteral(" class=\"imageCell\" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
                                                                              WriteLiteral(asset.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(910, 100, true);
            WriteLiteral("\r\n                            \r\n                        </td>\r\n                        <td class=\"\">");
            EndContext();
            BeginContext(1011, 11, false);
#line 29 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
                                Write(asset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 44, true);
            WriteLiteral("</td>\r\n                        <td class=\"\">");
            EndContext();
            BeginContext(1067, 22, false);
#line 30 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
                                Write(asset.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 44, true);
            WriteLiteral("</td>\r\n                        <td class=\"\">");
            EndContext();
            BeginContext(1134, 21, false);
#line 31 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
                                Write(asset.DeweyCallNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1155, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Shayar\Documents\Visual Studio 2017\Projects\LibraryMgmt\LibraryMgmt\Views\Catalog\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1208, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryMgmt.Models.Catalog.AssetIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
