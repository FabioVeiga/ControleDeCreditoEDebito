#pragma checksum "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\FirstProject\aspnetCoreMCV\aspnetCoreMCV\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9b7ffad00fbc2e17b5e047e0beb3b418f306f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\FirstProject\aspnetCoreMCV\aspnetCoreMCV\Views\_ViewImports.cshtml"
using aspnetCoreMCV.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9b7ffad00fbc2e17b5e047e0beb3b418f306f3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894c5d9f3844ac7a2ad69de2034a40ef188088da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 139, true);
            WriteLiteral("\r\n<h2>Meu primeiro projeto ASP net CORE MCV</h2>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <td>Id</td>\r\n        <td>Nome</td>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\FirstProject\aspnetCoreMCV\aspnetCoreMCV\Views\Home\Index.cshtml"
      
        foreach(var item in (List<HomeModel>)ViewBag.Lista)
        {

#line default
#line hidden
            BeginContext(237, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(268, 18, false);
#line 15 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\FirstProject\aspnetCoreMCV\aspnetCoreMCV\Views\Home\Index.cshtml"
           Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(286, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(310, 20, false);
#line 16 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\FirstProject\aspnetCoreMCV\aspnetCoreMCV\Views\Home\Index.cshtml"
           Write(item.Nome.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(330, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 18 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\FirstProject\aspnetCoreMCV\aspnetCoreMCV\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(370, 216, true);
            WriteLiteral("</table>\r\n\r\n<form asp-controler=\"Home\" asp-action=\"Index\" action=\"post\">\r\n    <input type=\"text\" asp-for=\"Id\" /><br />\r\n    <input type=\"text\" asp-for=\"Nome\" /><br />\r\n    <input type=\"submit\" value=\"OK\" /> \r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
