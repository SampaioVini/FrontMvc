#pragma checksum "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716bebd860adc687c2769a82cddb25c608542cc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disputas_IndexHabilidades), @"mvc.1.0.view", @"/Views/Disputas/IndexHabilidades.cshtml")]
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
#line 1 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716bebd860adc687c2769a82cddb25c608542cc4", @"/Views/Disputas/IndexHabilidades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Disputas_IndexHabilidades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.DisputaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
 if (@TempData["Mensagem"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-suceess\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 8 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
 if (@TempData["MensagemErro"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 11 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2> Ataque com Habilidade </h2>\r\n");
#nullable restore
#line 14 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(Html.DisplayName("Habilidade"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 22 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(Html.DropDownListFor(model => model.HabilidadeId, new SelectList(@ViewBag.ListaHabilidades, "Id", "Nome"),
                    "---Selecione---", new  { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(Html.DisplayName("Oponente"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 29 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
   Write(Html.DropDownListFor(model => model.OponenteId, new SelectList(@ViewBag.ListaOponentes, "Id", "Nome"),
                    "---Selecione---", new  { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-6"">
                <input type=""submit"" value=""Atacar com Arma!!!"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 39 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 41 "C:\Users\vinic\Downloads\trabalhos\RpgMvc\Views\Disputas\IndexHabilidades.cshtml"
Write(Html.ActionLink("Retornar", "Index", "Personagens"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.DisputaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
