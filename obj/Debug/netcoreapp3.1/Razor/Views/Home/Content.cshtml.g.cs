#pragma checksum "C:\Users\Asus\source\repos\Back-end practic1\Back-end practic1\Views\Home\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d96ae27e24d094d1086937c6ec70159e3bf702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Content), @"mvc.1.0.view", @"/Views/Home/Content.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d96ae27e24d094d1086937c6ec70159e3bf702", @"/Views/Home/Content.cshtml")]
    #nullable restore
    public class Views_Home_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Ap204</h3>\r\n<span>");
#nullable restore
#line 3 "C:\Users\Asus\source\repos\Back-end practic1\Back-end practic1\Views\Home\Content.cshtml"
 Write(ViewBag.product);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n<span>");
#nullable restore
#line 4 "C:\Users\Asus\source\repos\Back-end practic1\Back-end practic1\Views\Home\Content.cshtml"
 Write(ViewData["count"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n<span> product type:");
#nullable restore
#line 5 "C:\Users\Asus\source\repos\Back-end practic1\Back-end practic1\Views\Home\Content.cshtml"
               Write(TempData["type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
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
