#pragma checksum "C:\Gimnasio\GimnasioFacil.App\gimnasiofacil.app.presentacion\Pages\ListaNutricion\Listas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af34f6eb39cc5e62b2fd5324b02fd13fd29ff0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GimnasioFacil.App.Presentacion.Pages.ListaNutricion.Pages_ListaNutricion_Listas), @"mvc.1.0.razor-page", @"/Pages/ListaNutricion/Listas.cshtml")]
namespace GimnasioFacil.App.Presentacion.Pages.ListaNutricion
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
#line 1 "C:\Gimnasio\GimnasioFacil.App\gimnasiofacil.app.presentacion\Pages\_ViewImports.cshtml"
using GimnasioFacil.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af34f6eb39cc5e62b2fd5324b02fd13fd29ff0b", @"/Pages/ListaNutricion/Listas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cbd20318e2bf210892210f892887d7f8db7624e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ListaNutricion_Listas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Gimnasio\GimnasioFacil.App\gimnasiofacil.app.presentacion\Pages\ListaNutricion\Listas.cshtml"
  
    ViewData["Title"]="Nutricion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-info\">Lista Nutricion</h2>\r\n\r\n<div class=\"border\">\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>Nombre del estilo de Nutricion</td>\r\n            <td>Descripcion</td>\r\n        </tr>\r\n");
#nullable restore
#line 15 "C:\Gimnasio\GimnasioFacil.App\gimnasiofacil.app.presentacion\Pages\ListaNutricion\Listas.cshtml"
         foreach(var n in Model.listaNutricion)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Gimnasio\GimnasioFacil.App\gimnasiofacil.app.presentacion\Pages\ListaNutricion\Listas.cshtml"
               Write(n.NombreNutricion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Gimnasio\GimnasioFacil.App\gimnasiofacil.app.presentacion\Pages\ListaNutricion\Listas.cshtml"
               Write(n.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Gimnasio\GimnasioFacil.App\gimnasiofacil.app.presentacion\Pages\ListaNutricion\Listas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GimnasioFacil.App.Presentacion.ListasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GimnasioFacil.App.Presentacion.ListasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GimnasioFacil.App.Presentacion.ListasModel>)PageContext?.ViewData;
        public GimnasioFacil.App.Presentacion.ListasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
