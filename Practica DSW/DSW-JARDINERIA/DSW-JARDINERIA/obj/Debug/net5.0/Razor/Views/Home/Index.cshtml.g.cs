#pragma checksum "C:\Users\2dawaa\Documents\GitHub\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a71d0003c10f1cc3956407808f78eff15cf9845a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\2dawaa\Documents\GitHub\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\_ViewImports.cshtml"
using DSW_JARDINERIA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\2dawaa\Documents\GitHub\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\_ViewImports.cshtml"
using DSW_JARDINERIA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\2dawaa\Documents\GitHub\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a71d0003c10f1cc3956407808f78eff15cf9845a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d4b1baf5def9450b173b6170bf042aab9f9e81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\2dawaa\Documents\GitHub\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\2dawaa\Documents\GitHub\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Home\Index.cshtml"
                     Write(localizador["bienvenido"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\2dawaa\Documents\GitHub\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Home\Index.cshtml"
   Write(ViewData["bienvenido"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizador { get; private set; }
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
