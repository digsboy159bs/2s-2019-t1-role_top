#pragma checksum "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "132c4ed911f3c18bba34a85b3302d2db702c83ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\_ViewImports.cshtml"
using ROLE_TOP;

#line default
#line hidden
#line 2 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\_ViewImports.cshtml"
using ROLE_TOP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"132c4ed911f3c18bba34a85b3302d2db702c83ac", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfe789f9e3feb9f7d69de2f5ad02533d39f8850", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ROLE_TOP.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Reservas - Role_Top";
    ViewData["H2"] = "Histórico de Reservas";

#line default
#line hidden
            BeginContext(149, 20, true);
            WriteLiteral("\r\n\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(170, 14, false);
#line 9 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(184, 239, true);
            WriteLiteral("\r\n        \r\n    </h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Data</th>\r\n                <th>Evento</th>\r\n                \r\n                <th>Preço</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml"
             foreach( var reserva in Model.Reservas ) {

#line default
#line hidden
            BeginContext(480, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(527, 21, false);
#line 24 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml"
                   Write(reserva.DataDaReserva);

#line default
#line hidden
            EndContext();
            BeginContext(548, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(580, 19, false);
#line 25 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml"
                   Write(reserva.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(599, 53, true);
            WriteLiteral("</td>\r\n                    \r\n                    <td>");
            EndContext();
            BeginContext(653, 18, false);
#line 27 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml"
                   Write(reserva.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(671, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(716, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ROLE_TOP.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
