#pragma checksum "/Users/jackal/Projects/Crr/Views/Term/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1efdf1855c430ac517bd6dc124694121de3e965c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Term_Index), @"mvc.1.0.view", @"/Views/Term/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Term/Index.cshtml", typeof(AspNetCore.Views_Term_Index))]
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
#line 1 "/Users/jackal/Projects/Crr/Views/_ViewImports.cshtml"
using Crr;

#line default
#line hidden
#line 2 "/Users/jackal/Projects/Crr/Views/_ViewImports.cshtml"
using Crr.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efdf1855c430ac517bd6dc124694121de3e965c", @"/Views/Term/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e664fd116dd9f54333715e1f929afc4fd9eb1915", @"/Views/_ViewImports.cshtml")]
    public class Views_Term_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crr.Models.Term.TermIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 75, true);
            WriteLiteral("\n<h1>Blockchain Terms!</h1>\n\n<table class=\"table table-hover\">\n    <tbody>\n");
            EndContext();
#line 7 "/Users/jackal/Projects/Crr/Views/Term/Index.cshtml"
         foreach(var term in Model.TermList)
        {

#line default
#line hidden
            BeginContext(168, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(227, 13, false);
#line 11 "/Users/jackal/Projects/Crr/Views/Term/Index.cshtml"
               Write(term.LinkName);

#line default
#line hidden
            EndContext();
            BeginContext(240, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(305, 9, false);
#line 14 "/Users/jackal/Projects/Crr/Views/Term/Index.cshtml"
               Write(term.Name);

#line default
#line hidden
            EndContext();
            BeginContext(314, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(379, 16, false);
#line 17 "/Users/jackal/Projects/Crr/Views/Term/Index.cshtml"
               Write(term.Description);

#line default
#line hidden
            EndContext();
            BeginContext(395, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 20 "/Users/jackal/Projects/Crr/Views/Term/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(446, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crr.Models.Term.TermIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
