#pragma checksum "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969037d957fcd71cc9707a9de300aa36ea969320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pastas_Details), @"mvc.1.0.view", @"/Views/Pastas/Details.cshtml")]
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
#line 1 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/_ViewImports.cshtml"
using PastaClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/_ViewImports.cshtml"
using PastaClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969037d957fcd71cc9707a9de300aa36ea969320", @"/Views/Pastas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b38c769c158ab77bba51fd0e3726c6d984c5a518", @"/Views/_ViewImports.cshtml")]
    public class Views_Pastas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
   
  ViewData["Title"] = "Details";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<h1>Pasta Info:</h1>\n<ul>\n  <li>ID: ");
#nullable restore
#line 9 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
     Write(Model.PastaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li>Name: ");
#nullable restore
#line 10 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li>Gluten Free: ");
#nullable restore
#line 11 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
              Write(Model.GlutenFree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li>Place of Origin: ");
#nullable restore
#line 12 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
                  Write(Model.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li>Noodle Type: ");
#nullable restore
#line 13 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
              Write(Model.NoodleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>\n<br>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 269, "\"", 305, 2);
            WriteAttributeValue("", 276, "/Pastas/Edit/", 276, 13, true);
#nullable restore
#line 17 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
WriteAttributeValue("", 289, Model.PastaId, 289, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n  <p>Edit</p>\n</a>\n<br>\n\n<a href=\"/Pastas\">\n  <p>Return</p>\n</a>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 376, "\"", 414, 2);
            WriteAttributeValue("", 383, "/Pastas/Delete/", 383, 15, true);
#nullable restore
#line 26 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Details.cshtml"
WriteAttributeValue("", 398, Model.PastaId, 398, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n  <p>DELETE PASTA</p>\n</a>");
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
