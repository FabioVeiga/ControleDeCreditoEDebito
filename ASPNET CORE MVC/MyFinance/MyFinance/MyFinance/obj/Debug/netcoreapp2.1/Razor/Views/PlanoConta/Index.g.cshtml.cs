#pragma checksum "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ac9dea569a47087fd8321bb1c94f16b34f28427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlanoConta_Index), @"mvc.1.0.view", @"/Views/PlanoConta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlanoConta/Index.cshtml", typeof(AspNetCore.Views_PlanoConta_Index))]
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
#line 1 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance;

#line default
#line hidden
#line 2 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac9dea569a47087fd8321bb1c94f16b34f28427", @"/Views/PlanoConta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05dd6abef5a8ff60f9a555c67ee727241a6c480", @"/Views/_ViewImports.cshtml")]
    public class Views_PlanoConta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 31, true);
            WriteLiteral("\r\n<h2>Planos de contas</h2>\r\n\r\n");
            EndContext();
            BeginContext(195, 335, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""table-responsive"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Id</th>
                    <th>Descricao</th>
                    <th>Tipo de Despesa</th>
                </tr>
            </thead>

");
            EndContext();
#line 29 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
              
                foreach (var item in (List<PlanoContaModel>)ViewBag.ListaPlanoConta)
                {

#line default
#line hidden
            BeginContext(799, 59, true);
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n");
            EndContext();
            BeginContext(946, 108, true);
            WriteLiteral("                            <th>\r\n                                <button type=\"button\" class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1054, "\"", 1091, 3);
            WriteAttributeValue("", 1064, "Editar(", 1064, 7, true);
#line 36 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 1071, item.Id.ToString(), 1071, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1090, ")", 1090, 1, true);
            EndWriteAttribute();
            BeginContext(1092, 94, true);
            WriteLiteral(">Editar</button>\r\n                                <button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1186, "\"", 1224, 3);
            WriteAttributeValue("", 1196, "Excluir(", 1196, 8, true);
#line 37 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 1204, item.Id.ToString(), 1204, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1223, ")", 1223, 1, true);
            EndWriteAttribute();
            BeginContext(1225, 86, true);
            WriteLiteral(">Excluir</button>\r\n                            </th>\r\n                            <th>");
            EndContext();
            BeginContext(1312, 18, false);
#line 39 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
                           Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1330, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1370, 25, false);
#line 40 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
                           Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1395, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1435, 66, false);
#line 41 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
                           Write(item.Tipo.ToString().Replace("R","Receita").Replace("D","Despesa"));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 68, true);
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </tbody>\r\n");
            EndContext();
#line 44 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1603, 542, true);
            WriteLiteral(@"        </table>
    </div>
</div>
<button type=""button"" class=""btn btn-block btn-primary"" role=""button"" onclick=""CriarPlanoConta()"">Criar Plano de Contas</button>

<script>
    function CriarPlanoConta() {
        window.location.href = ""../PlanoConta/CriarPlanoConta"";
    }

    function Excluir(id_conta) {
        window.location.href = ""../PlanoConta/ExcluirPlanoConta/"" + id_conta;
        }

    function Editar(id_conta) {
        window.location.href = ""../PlanoConta/CriarPlanoConta/"" + id_conta;
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
