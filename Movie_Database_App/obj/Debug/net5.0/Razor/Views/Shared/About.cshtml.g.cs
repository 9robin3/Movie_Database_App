#pragma checksum "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Shared\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f714b8e23bb40ec595095cb2ca00b3599cd03d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_About), @"mvc.1.0.view", @"/Views/Shared/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f714b8e23bb40ec595095cb2ca00b3599cd03d3b", @"/Views/Shared/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd64e0b833c6593e3e06444a400894fc535d24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Bibliotek\Dokument\Development\Portfolio\Web Development\Movie_Database_App\Movie_Database_App\Views\Shared\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Movie Database App</h2>
<h3>Created by Robin Andblom - 2021</h3>
<hr />
<p>
    This project was the final project of my course in fullstack web development at Lexicon. 
    The projetc uses ASP.NET MVC, Entity Framework, AJAX JS code, HTML and Razor Pages. Enjoy!
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591