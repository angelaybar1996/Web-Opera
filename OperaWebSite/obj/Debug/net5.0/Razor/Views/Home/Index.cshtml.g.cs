#pragma checksum "C:\Users\RYZEN 20\Desktop\Programacion .NET\7_Asp .net Core\Proyectos\TeatroSolucion\OperaWebSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599e9a31c3fd0fbdbcf5f3f65681065e4c045766"
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
#line 1 "C:\Users\RYZEN 20\Desktop\Programacion .NET\7_Asp .net Core\Proyectos\TeatroSolucion\OperaWebSite\Views\_ViewImports.cshtml"
using OperaWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RYZEN 20\Desktop\Programacion .NET\7_Asp .net Core\Proyectos\TeatroSolucion\OperaWebSite\Views\_ViewImports.cshtml"
using OperaWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599e9a31c3fd0fbdbcf5f3f65681065e4c045766", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2d4aeaa5d00198a0d236baf52e4a3c023d6316", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\RYZEN 20\Desktop\Programacion .NET\7_Asp .net Core\Proyectos\TeatroSolucion\OperaWebSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 6 "C:\Users\RYZEN 20\Desktop\Programacion .NET\7_Asp .net Core\Proyectos\TeatroSolucion\OperaWebSite\Views\Home\Index.cshtml"
Write(ViewBag.Saludo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("          \r\n    ");
#nullable restore
#line 10 "C:\Users\RYZEN 20\Desktop\Programacion .NET\7_Asp .net Core\Proyectos\TeatroSolucion\OperaWebSite\Views\Home\Index.cshtml"
Write(Html.ActionLink("About","About","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
