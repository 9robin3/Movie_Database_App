#pragma checksum "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3965ded58a15b24b6ec02f3cb38acc7f858df4b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_ListWatchList), @"mvc.1.0.view", @"/Views/Movies/ListWatchList.cshtml")]
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
#line 1 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\_ViewImports.cshtml"
using Movie_Database_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\_ViewImports.cshtml"
using Movie_Database_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3965ded58a15b24b6ec02f3cb38acc7f858df4b7", @"/Views/Movies/ListWatchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd64e0b833c6593e3e06444a400894fc535d24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_ListWatchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie_Database_App.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight:bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
  
    ViewData["Title"] = "Watch List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3>Your saved movies</h3>
<hr />


<!--<form asp-controller=""Movies"" asp-action=""Search"">
    <p>
        <table>
            <thead>
                Search for:
                <input id=""MovieSearch"" type=""text"" name=""search"" onkeyup=""SearchMovie"" />-->
");
            WriteLiteral("<!--</thead>\r\n        </table>\r\n    </p>\r\n</form>-->\r\n");
            WriteLiteral("\r\n<table id=\"AllMovies\" asp-controller=\"Movies\" asp-action=\"Index\">\r\n    <!--<thead>\r\n    <tr>\r\n        <th>\r\n\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
       Write(Html.DisplayNameFor(model => model.RunningTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>-->\r\n");
            WriteLiteral("    <!--<th></th>\r\n        </tr>\r\n    </thead>-->\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 45 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            <div>\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3965ded58a15b24b6ec02f3cb38acc7f858df4b76033", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 1334, "\"", 1355, 1);
#nullable restore
#line 50 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
WriteAttributeValue("", 1340, item.PosterUrl, 1340, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"150\" height=\"200\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
                                          WriteLiteral(item.MovieID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
            WriteLiteral("                <div>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3965ded58a15b24b6ec02f3cb38acc7f858df4b78807", async() => {
#nullable restore
#line 60 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
                                                                       WriteLiteral(item.MovieID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 64 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
               Write(Html.DisplayFor(modelItem => item.RunningTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    ");
#nullable restore
#line 67 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
               Write(Html.DisplayFor(modelItem => item.MovieID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2226, "\"", 2305, 1);
#nullable restore
#line 70 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
WriteAttributeValue("", 2233, Url.Action("RemoveFromWatchList", "Movies", new { id = @item.MovieID }), 2233, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" role=\"button\">Remove</a>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        </td>\r\n");
#nullable restore
#line 83 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\ListWatchList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie_Database_App.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
