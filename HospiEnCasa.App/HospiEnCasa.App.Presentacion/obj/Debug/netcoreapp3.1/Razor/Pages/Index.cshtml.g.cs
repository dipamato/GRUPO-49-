#pragma checksum "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5137ca6dedeea3d17228ffe1d455ac0c1eddbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.Presentacion.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(HospiEnCasa.App.Presentacion.Pages.Pages_Index), null)]
namespace HospiEnCasa.App.Presentacion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Presentacion;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5137ca6dedeea3d17228ffe1d455ac0c1eddbc", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"194bd1ebe49182ec885d20e65a87b3d718284680", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 29, true);
            WriteLiteral("<p>CLAIMS DEL USUARIO</p>\r\n\r\n");
            EndContext();
#line 8 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(140, 27, true);
            WriteLiteral("    <table class=\"table\">\r\n");
            EndContext();
#line 11 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml"
         foreach(var x in User.Claims)
        {

#line default
#line hidden
            BeginContext(218, 34, true);
            WriteLiteral("            <tr>\r\n            <td>");
            EndContext();
            BeginContext(253, 6, false);
#line 14 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml"
           Write(x.Type);

#line default
#line hidden
            EndContext();
            BeginContext(259, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(283, 7, false);
#line 15 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml"
           Write(x.Value);

#line default
#line hidden
            EndContext();
            BeginContext(290, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 17 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(323, 26, true);
            WriteLiteral("        \r\n\r\n    </table>\r\n");
            EndContext();
#line 21 "D:\MISION TIC 2022\CICLO 3\Grupo 49\Hospitalizacion\hospiencasa.app\hospiencasa.app.presentacion\Pages\Index.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
