#pragma checksum "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5437dcc49ea6c769981dff89481393dda04b9d38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5437dcc49ea6c769981dff89481393dda04b9d38", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd64e0b833c6593e3e06444a400894fc535d24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie_Database_App.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
  
    //ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <h4>");
#nullable restore
#line 11 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 228, "\"", 276, 1);
#nullable restore
#line 12 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
WriteAttributeValue("", 234, Html.DisplayFor(model => model.PosterUrl), 234, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"250\" height=\"300\" />\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <!--<dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 16 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("        <!--</dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>-->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MovieID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MovieID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <br />\r\n            <br />\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 1395, "\"", 1445, 1);
#nullable restore
#line 45 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1402, Html.DisplayFor(model => model.TrailerUrl), 1402, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trailer</a>\r\n        </dt>\r\n");
            WriteLiteral("        <dd class=\"col-sm-10\">\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatePublished));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatePublished));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<hr />\r\n\r\n\r\n<div>\r\n");
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 1996, "\"", 2064, 1);
#nullable restore
#line 67 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2003, Url.Action("Create", "Reviews", new { id = @Model.MovieID }), 2003, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" role=\"button\">Add Review</a>\r\n\r\n    <script type=\"text/javascript\">\r\n    $(function () {\r\n        //Your Test Data\r\n        var id = ");
#nullable restore
#line 72 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
            Write(Model.MovieID);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n        //Perform your Get\r\n        $.get(\'");
#nullable restore
#line 75 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
          Write(Url.Action("Create","Review"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', { input: id }, function (data) {\r\n            //Populate your \"rData\" element with the results\r\n            $(\"#Reviews\").html(data);\r\n        });\r\n    });\r\n    </script>\r\n\r\n");
            WriteLiteral("</div>\r\n\r\n<hr />\r\n\r\n");
            WriteLiteral("\r\n<table id=\"Reviews\" class=\"table\">\r\n</table>\r\n\r\n\r\n");
#nullable restore
#line 102 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Movies\Details.cshtml"
Write(Html.Partial("~/Views/Movies/ListReviews.cshtml", Model.ReviewsList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5437dcc49ea6c769981dff89481393dda04b9d3811206", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie_Database_App.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
