#pragma checksum "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7b62054ddcdf5e1e72e0e1450429631ae7fc297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pastas_Index), @"mvc.1.0.view", @"/Views/Pastas/Index.cshtml")]
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
#line 1 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/_ViewImports.cshtml"
using PastaClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/_ViewImports.cshtml"
using PastaClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b62054ddcdf5e1e72e0e1450429631ae7fc297", @"/Views/Pastas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b38c769c158ab77bba51fd0e3726c6d984c5a518", @"/Views/_ViewImports.cshtml")]
    public class Views_Pastas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>All Pastas:</h1>\n\n<ol>\n");
#nullable restore
#line 4 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
   foreach (Pasta pasta in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\n      <li>ID: ");
#nullable restore
#line 7 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
         Write(pasta.PastaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n      <li>Name: ");
#nullable restore
#line 8 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
           Write(pasta.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n      <li>Species: ");
#nullable restore
#line 9 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
              Write(pasta.GlutenFree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n      <li>Age: ");
#nullable restore
#line 10 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
          Write(pasta.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n      <li>Gender: ");
#nullable restore
#line 11 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
             Write(pasta.NoodleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    </ul>\n    <a");
            BeginWriteAttribute("href", " href=\"", 274, "\"", 313, 2);
            WriteAttributeValue("", 281, "/pastas/Details/", 281, 16, true);
#nullable restore
#line 13 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
WriteAttributeValue("", 297, pasta.PastaId, 297, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n      <p>View Details</p>\n    </a>\n    <br>\n");
#nullable restore
#line 17 "/Users/jcallahan/Desktop/PastaClient.Solution/PastaClient/Views/Pastas/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>");
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