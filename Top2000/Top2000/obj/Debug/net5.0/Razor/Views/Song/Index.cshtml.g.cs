#pragma checksum "C:\repos\Top2000Opdracht\Top2000\Top2000\Views\Song\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab2cd64b0a5591ffa276155db754c37f03fe259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Song_Index), @"mvc.1.0.view", @"/Views/Song/Index.cshtml")]
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
#line 1 "C:\repos\Top2000Opdracht\Top2000\Top2000\Views\_ViewImports.cshtml"
using Top2000;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\Top2000Opdracht\Top2000\Top2000\Views\_ViewImports.cshtml"
using Top2000.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab2cd64b0a5591ffa276155db754c37f03fe259", @"/Views/Song/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130ea2ce154ec2dc2aea044e3d2cc8b73398e578", @"/Views/_ViewImports.cshtml")]
    public class Views_Song_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Top2000.Models.Song>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\repos\Top2000Opdracht\Top2000\Top2000\Views\Song\Index.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Titel</th>
                <th>Artiest</th>
                <th>Uitgebracht</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 17 "C:\repos\Top2000Opdracht\Top2000\Top2000\Views\Song\Index.cshtml"
               Write(Model.Titel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\repos\Top2000Opdracht\Top2000\Top2000\Views\Song\Index.cshtml"
               Write(Model.Artiestid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\repos\Top2000Opdracht\Top2000\Top2000\Views\Song\Index.cshtml"
               Write(Model.Jaar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Top2000.Models.Song> Html { get; private set; }
    }
}
#pragma warning restore 1591
