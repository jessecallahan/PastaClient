#pragma checksum "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db907091d864d9b67bc304a6dec1d50be978738f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pastas_Edit), @"mvc.1.0.view", @"/Views/Pastas/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db907091d864d9b67bc304a6dec1d50be978738f", @"/Views/Pastas/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b38c769c158ab77bba51fd0e3726c6d984c5a518", @"/Views/_ViewImports.cshtml")]
    public class Views_Pastas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Edit Info:</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db907091d864d9b67bc304a6dec1d50be978738f3465", async() => {
                WriteLiteral("\n  <label for=\"name\">Pasta\'s Name</label>\n  <input id=\"name\" name=\"name\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 166, "\"", 187, 1);
#nullable restore
#line 4 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Edit.cshtml"
WriteAttributeValue("", 174, Model.Name, 174, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n  <!-- <label for=\"noodle-type\">Pasta\'s Noodle Type</label>\n  <input id=\"noodle-type\" name=\"noodle-type\" type=\"text\" value=\"");
#nullable restore
#line 6 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Edit.cshtml"
                                                            Write(Model.NoodleType);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\n  <label for=\"origin\">Pasta\'s Origin</label>\n  <input id=\"origin\" name=\"origin\" type=\"text\" value=\"");
#nullable restore
#line 8 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Edit.cshtml"
                                                  Write(Model.Origin);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\n  <label for=\"url\">Pasta\'s Url</label>\n  <input id=\"url\" name=\"url\" type=\"text\" value=\"");
#nullable restore
#line 10 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Edit.cshtml"
                                            Write(Model.Url);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"> -->\n  <button type=\"submit\">Go!</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 34, "/Pastas/Details/", 34, 16, true);
#nullable restore
#line 2 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Edit.cshtml"
AddHtmlAttributeValue("", 50, Model.PastaId, 50, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<a");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 646, 2);
            WriteAttributeValue("", 614, "/Pastas/Details/", 614, 16, true);
#nullable restore
#line 14 "/Users/lauriewaller/Desktop/PastaClient/PastaClient/Views/Pastas/Edit.cshtml"
WriteAttributeValue("", 630, Model.PastaId, 630, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n  <p>Return to Details</p>\n</a>");
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
