#pragma checksum "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\Account\Manage\WatchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98dfdce5d37c28b62387282ea056c2be2856e09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_WatchList), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/WatchList.cshtml")]
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
#line 1 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\_ViewImports.cshtml"
using Movie_Database_App.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\_ViewImports.cshtml"
using Movie_Database_App.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Movie_Database_App.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Movie_Database_App.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\Account\Manage\WatchList.cshtml"
using Movie_Database_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98dfdce5d37c28b62387282ea056c2be2856e09", @"/Areas/Identity/Pages/Account/Manage/WatchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6fbe7ae09ab1ad2b2e65a68b963a49b041e692a", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf04405efd017eb6e7519eab36b124f789ccf99", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a44705167ee6ecb8ba35fbc0fa8796cc16ba708", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_WatchList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\Account\Manage\WatchList.cshtml"
  
    ViewData["Title"] = "Watchlist";
    ViewData["ActivePage"] = ManageNavPages.WatchList;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>");
#nullable restore
#line 8 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\Account\Manage\WatchList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <p>A collection of your saved movies to watch.</p>\r\n\r\n        <div>\r\n            <th>\r\n                <p>Username: </p>\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Areas\Identity\Pages\Account\Manage\WatchList.cshtml"
           Write(Html.DisplayFor(model => model.UserObj.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </div>\r\n        <div>\r\n");
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<div>\r\n    <table class=\"table\">\r\n");
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e98dfdce5d37c28b62387282ea056c2be2856e096776", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WatchListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WatchListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WatchListModel>)PageContext?.ViewData;
        public WatchListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
