#pragma checksum "C:\Users\fanny\Documents\7mo Semestre\Programacion Web\Unidad2\Unidad2Actividad2\Unidad2Actividad2\Views\Home\VillancicoInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "280bac9369ca2c32bcd426d27c269c1faf8b5273"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VillancicoInfo), @"mvc.1.0.view", @"/Views/Home/VillancicoInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"280bac9369ca2c32bcd426d27c269c1faf8b5273", @"/Views/Home/VillancicoInfo.cshtml")]
    public class Views_Home_VillancicoInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Unidad2Actividad2.Models.Villancico>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fanny\Documents\7mo Semestre\Programacion Web\Unidad2\Unidad2Actividad2\Unidad2Actividad2\Views\Home\VillancicoInfo.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav>\r\n    <a href=\"javascript:window.history.back();\">Regresar</a>\r\n</nav>\r\n<h2>");
#nullable restore
#line 9 "C:\Users\fanny\Documents\7mo Semestre\Programacion Web\Unidad2\Unidad2Actividad2\Unidad2Actividad2\Views\Home\VillancicoInfo.cshtml"
Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 10 "C:\Users\fanny\Documents\7mo Semestre\Programacion Web\Unidad2\Unidad2Actividad2\Unidad2Actividad2\Views\Home\VillancicoInfo.cshtml"
Write(Model.Compositor);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\fanny\Documents\7mo Semestre\Programacion Web\Unidad2\Unidad2Actividad2\Unidad2Actividad2\Views\Home\VillancicoInfo.cshtml"
                  Write(Model.Anyo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<iframe width=\"560\" height=\"315\"");
            BeginWriteAttribute("src", " src=\"", 254, "\"", 275, 1);
#nullable restore
#line 12 "C:\Users\fanny\Documents\7mo Semestre\Programacion Web\Unidad2\Unidad2Actividad2\Unidad2Actividad2\Views\Home\VillancicoInfo.cshtml"
WriteAttributeValue("", 260, Model.VideoUrl, 260, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n\r\n<article>\r\n ");
#nullable restore
#line 15 "C:\Users\fanny\Documents\7mo Semestre\Programacion Web\Unidad2\Unidad2Actividad2\Unidad2Actividad2\Views\Home\VillancicoInfo.cshtml"
Write(Html.Raw(Model.Letra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</article>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Unidad2Actividad2.Models.Villancico> Html { get; private set; }
    }
}
#pragma warning restore 1591
