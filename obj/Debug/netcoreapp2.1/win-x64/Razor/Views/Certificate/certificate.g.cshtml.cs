#pragma checksum "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/Certificate/certificate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4c1eec68f91ecaabf97181f1eb1ca0196191ee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Certificate_certificate), @"mvc.1.0.view", @"/Views/Certificate/certificate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Certificate/certificate.cshtml", typeof(AspNetCore.Views_Certificate_certificate))]
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
#line 1 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/_ViewImports.cshtml"
using CentralDuplicatas;

#line default
#line hidden
#line 2 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/_ViewImports.cshtml"
using CentralDuplicatas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4c1eec68f91ecaabf97181f1eb1ca0196191ee4", @"/Views/Certificate/certificate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f04a559329bab731b14f0328caffd1e364e330", @"/Views/_ViewImports.cshtml")]
    public class Views_Certificate_certificate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/Certificate/certificate.cshtml"
  
      ViewData["Title"] = "Certificado";
    var ClientCertificate = Context?.Request?.HttpContext?.Connection?.ClientCertificate;

    var arrCert = this.Context.Request.Headers["X-ARR-ClientCert"].FirstOrDefault();


#line default
#line hidden
            BeginContext(223, 281, true);
            WriteLiteral(@" <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<div id=""login"">
  <navbarinternal></navbarinternal>
    <div class=""columns"">
      <div class=""column is-three-fifths space"">
          <br>
          <h3><strong>ARR CLIENT CERT:</strong> ");
            EndContext();
            BeginContext(506, 7, false);
#line 14 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/Certificate/certificate.cshtml"
                                            Write(arrCert);

#line default
#line hidden
            EndContext();
            BeginContext(514, 47, true);
            WriteLiteral("</h3>\n        </div>\n      </div>\n     \n      \n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(579, 69, true);
                WriteLiteral("\n\n    <script>\n\n        let token = getToken();\n\n        let cert = \"");
                EndContext();
                BeginContext(649, 7, false);
#line 25 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/Certificate/certificate.cshtml"
               Write(arrCert);

#line default
#line hidden
                EndContext();
                BeginContext(656, 80, true);
                WriteLiteral("\";\n\n        certificate(cert);\n\n        console.log(getToken());\n    </script>\n\n");
                EndContext();
            }
            );
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
