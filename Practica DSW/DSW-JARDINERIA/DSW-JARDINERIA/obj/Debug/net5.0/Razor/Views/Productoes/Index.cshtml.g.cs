#pragma checksum "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productoes_Index), @"mvc.1.0.view", @"/Views/Productoes/Index.cshtml")]
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
#line 1 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\_ViewImports.cshtml"
using DSW_JARDINERIA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\_ViewImports.cshtml"
using DSW_JARDINERIA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a", @"/Views/Productoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d4b1baf5def9450b173b6170bf042aab9f9e81", @"/Views/_ViewImports.cshtml")]
    public class Views_Productoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<DSW_JARDINERIA.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a6363", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<!--Formulario de Busquedas-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a7564", async() => {
                WriteLiteral("\r\n    <div>\r\n        <p>\r\n            Buscar por Nombre: <input type=\"text\" name=\"buscado\"");
                BeginWriteAttribute("value", "\r\n                                      value=\"", 414, "\"", 489, 1);
#nullable restore
#line 21 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
WriteAttributeValue("", 461, ViewData["busqueda_actual"], 461, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Buscar\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a8470", async() => {
                    WriteLiteral("Limpiar b??squeda");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Dimensiones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Proveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().CantidadEnStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().PrecioProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Gama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n      <!-- ORDENACION:\r\n          <tr>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 63 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_nombre"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 68 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_dimensiones"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 69 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Dimensiones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 73 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_proveedor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 74 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Proveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 78 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_descripcion"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 79 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 83 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_cantidadenstock"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 84 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().CantidadEnStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 88 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_precioventa"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 89 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 93 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_precioproveedor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 94 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().PrecioProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\" asp-route-ordenacion=\"");
#nullable restore
#line 98 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                                       Write(ViewData["ordenar_gamanavigation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 99 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().GamaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n      -->\r\n\r\n      \r\n\r\n    <tbody>\r\n");
#nullable restore
#line 109 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 113 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 116 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dimensiones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 119 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Proveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 122 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 125 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CantidadEnStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 128 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 131 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 134 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a24154", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                           WriteLiteral(item.CodigoProducto);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a26384", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                              WriteLiteral(item.CodigoProducto);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf72f9b76c04f42cc5139bd4b34faceb8ebc99a28620", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 139 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
                                             WriteLiteral(item.CodigoProducto);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 142 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 146 "C:\Users\jesus\OneDrive\Escritorio\DSW_Jardineria\Practica DSW\DSW-JARDINERIA\DSW-JARDINERIA\Views\Productoes\Index.cshtml"
Write(Html.PagedListPager(Model
    , nueva_pagina => Url.Action("Index", "Productoes"
        , new { nueva_pagina, buscado = (string)null, busqueda_actual = ViewData["busqueda_actual"],ordenacion = ViewData["ordenacion"] })
    , new PagedListRenderOptions
    {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
    }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<DSW_JARDINERIA.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
