#pragma checksum "C:\Users\34436810852\Documents\exercicios\ROLE TOP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e0d197cd6fdf020fe9e486bce2adcc1097804b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e0d197cd6fdf020fe9e486bce2adcc1097804b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfe789f9e3feb9f7d69de2f5ad02533d39f8850", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6294, true);
            WriteLiteral(@" <main>

        <section id=""logo-area"">

            <img src=""../img/logo role top.png"">

        </section>
    </header>

    <div class=""objetivo-background"">

        <section id=""objetivo"">
            <div class=""section-container"">

                <br>
                <h2>Alugue já</h2>
                <p>Alugue nosso espaço para eventos.
                </p>

        </section>
        </div>

        <div class=""historia-background"">

            <section id=""quemsomos"">
                <div class=""section-container"">

                    <br>
                    <br>
                    <h2>quem somos</h2>
                    <p>somos proprietarios de um belo espaço, para alugar eventos,essa ideia surgiu a partir de 2 homen que tinham um espaço sobrando e nao queriam disperdiçar.
                    </p>

            </section>

            </div>
            <section id=""galeria"">
                <br>
                <br>

                <h2 style=""text-");
            WriteLiteral(@"align:center"">galeria</h2>
                <br>
                <br>
            </section>
            <section id=""meio"">
                <div class=""container"">
                    <div class=""mySlides"">
                        <div class=""numbertext"">1 / 6</div>
                        <img src=""../img/show2.png"" height=""500px"" width=""700px"">
                    </div>

                    <div class=""mySlides"">
                        <div class=""numbertext"">2 / 6</div>
                        <img src=""../img/formaturas.png"" height=""500px"" width=""700px"">
                    </div>

                    <div class=""mySlides"">
                        <div class=""numbertext"">3 / 6</div>
                        <img src=""../img/exposiçoes1.png"" height=""500px"" width=""700px"">
                    </div>

                    <div class=""mySlides"">
                        <div class=""numbertext"">4 / 6</div>
                        <img src=""../img/casamento.png"" height=""500px"" width=""700px""");
            WriteLiteral(@">
                    </div>

                    <div class=""mySlides"">
                        <div class=""numbertext"">5 / 6</div>
                        <img src=""../img/universitarias 2.png"" height=""500px"" width=""700px"">
                    </div>

                    <div class=""mySlides"">
                        <div class=""numbertext"">6 / 6</div>
                        <img src=""../img/aniversarios.png"" height=""500px"" width=""700px"">
                    </div>
            </section>

            <a class=""prev"" onclick=""plusSlides(-1)"">❮</a>
            <a class=""next"" onclick=""plusSlides(1)"">❯</a>

            <div class=""caption-container"">
                <p id=""caption""></p>
            </div>

            <div class=""row"">
                <div class=""column"">
                    <img class=""demo cursor"" src=""../img/show2.png"" height=""250px"" width=""250px"" style=""width:100%"" onclick=""currentSlide(1)"" alt=""shows"">
                </div>
                <div class=""column"">
");
            WriteLiteral(@"                    <img class=""demo cursor"" src=""../img/formaturas.png"" height=""250px"" width=""250px"" style=""width:100%"" onclick=""currentSlide(2)"" alt=""formaturas"">
                </div>
                <div class=""column"">
                    <img class=""demo cursor"" src=""../img/exposiçoes1.png"" height=""250px"" width=""250px"" style=""width:100%"" onclick=""currentSlide(3)"" alt=""exposiçoes"">
                </div>
                <div class=""column"">
                    <img class=""demo cursor"" src=""../img/casamento.png"" height=""250px"" width=""250px"" style=""width:100%"" onclick=""currentSlide(4)"" alt=""casamentos"">
                </div>
                <div class=""column"">
                    <img class=""demo cursor"" src=""../img/universitarias 2.png"" height=""250px"" width=""250px"" style=""width:100%"" onclick=""currentSlide(5)"" alt=""universitarias"">
                </div>
                <div class=""column"">
                    <img class=""demo cursor"" src=""../img/aniversarios.png"" style=""width:100%"" height=""");
            WriteLiteral(@"250px"" width=""250px"" onclick=""currentSlide(6)"" alt=""aniversarios"">
                </div>
            </div>
            </div>
            <br>
            <br>

            <script>
                var slideIndex = 1;
                showSlides(slideIndex);

                function plusSlides(n) {
                    showSlides(slideIndex += n);
                }

                function currentSlide(n) {
                    showSlides(slideIndex = n);
                }

                function showSlides(n) {
                    var i;
                    var slides = document.getElementsByClassName(""mySlides"");
                    var dots = document.getElementsByClassName(""demo"");
                    var captionText = document.getElementById(""caption"");
                    if (n > slides.length) {
                        slideIndex = 1
                    }
                    if (n < 1) {
                        slideIndex = slides.length
                    }
          ");
            WriteLiteral(@"          for (i = 0; i < slides.length; i++) {
                        slides[i].style.display = ""none"";
                    }
                    for (i = 0; i < dots.length; i++) {
                        dots[i].className = dots[i].className.replace("" active"", """");
                    }
                    slides[slideIndex - 1].style.display = ""block"";
                    dots[slideIndex - 1].className += "" active"";
                    captionText.innerHTML = dots[slideIndex - 1].alt;
                }
                
            </script>
            <section id=""local"">
                <div class=""section-container"">
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410"" width=");
            WriteLiteral("\"100%\" height=\"100%\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>\r\n                </div>\r\n            </section>\r\n            </main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
