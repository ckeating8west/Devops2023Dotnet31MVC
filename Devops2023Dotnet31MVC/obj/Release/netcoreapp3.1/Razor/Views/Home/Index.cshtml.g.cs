#pragma checksum "D:\Users\ckeating\source\repos\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25ddb4eab36ba1d97abbf70fee4ea71238ee2e3b"
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
#line 1 "D:\Users\ckeating\source\repos\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\Views\_ViewImports.cshtml"
using Devops2023Dotnet31MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\ckeating\source\repos\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\Views\_ViewImports.cshtml"
using Devops2023Dotnet31MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ddb4eab36ba1d97abbf70fee4ea71238ee2e3b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a68065ae46e82a23ce7f759cd1153583ad5323", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\ckeating\source\repos\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <summary>\r\n        Password:\r\n        <details>");
#nullable restore
#line 9 "D:\Users\ckeating\source\repos\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\Views\Home\Index.cshtml"
            Write(ViewBag.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</details>\r\n        <details>");
#nullable restore
#line 10 "D:\Users\ckeating\source\repos\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\Views\Home\Index.cshtml"
            Write(ViewBag.MySecret);

#line default
#line hidden
#nullable disable
            WriteLiteral("</details>\r\n    </summary>\r\n</div>\r\n");
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
