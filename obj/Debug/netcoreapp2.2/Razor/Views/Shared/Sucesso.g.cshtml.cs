#pragma checksum "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Shared\Sucesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c3757960a9c19e4dd9e067524e87d66396af83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Sucesso), @"mvc.1.0.view", @"/Views/Shared/Sucesso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Sucesso.cshtml", typeof(AspNetCore.Views_Shared_Sucesso))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c3757960a9c19e4dd9e067524e87d66396af83", @"/Views/Shared/Sucesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfe789f9e3feb9f7d69de2f5ad02533d39f8850", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Sucesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ROLE_TOP.ViewModels.RespostaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 19, true);
            WriteLiteral("<main>\r\n    <h2>\r\n ");
            EndContext();
            BeginContext(66, 14, false);
#line 4 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Shared\Sucesso.cshtml"
Write(Model.NomeView);

#line default
#line hidden
            EndContext();
            BeginContext(80, 33, true);
            WriteLiteral(" deu bom!\r\n    </h2>\r\n    <p>\r\n  ");
            EndContext();
            BeginContext(114, 14, false);
#line 7 "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Shared\Sucesso.cshtml"
Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(128, 19, true);
            WriteLiteral("\r\n    </p>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ROLE_TOP.ViewModels.RespostaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
