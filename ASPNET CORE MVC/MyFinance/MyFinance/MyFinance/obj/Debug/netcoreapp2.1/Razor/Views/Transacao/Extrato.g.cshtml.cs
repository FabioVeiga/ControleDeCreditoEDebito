#pragma checksum "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f069dfd4d9ccdb7c3eea1068465a45be7265855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacao_Extrato), @"mvc.1.0.view", @"/Views/Transacao/Extrato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transacao/Extrato.cshtml", typeof(AspNetCore.Views_Transacao_Extrato))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f069dfd4d9ccdb7c3eea1068465a45be7265855", @"/Views/Transacao/Extrato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05dd6abef5a8ff60f9a555c67ee727241a6c480", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacao_Extrato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TransacaoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "R", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "D", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Extrato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 57, true);
            WriteLiteral("\r\n\r\n<h2>Meu Extrato</h2>\r\n\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(80, 1382, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b1d8cc6f4614819b572f29f450a2b25", async() => {
                BeginContext(134, 101, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Data transacao (inicio):</label>\r\n            ");
                EndContext();
                BeginContext(235, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d23d23c651d042d19e67d7c63ace7976", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 10 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Data);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(290, 116, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Data transacao (fim):</label>\r\n            ");
                EndContext();
                BeginContext(406, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a916d2f70114b9d9b2b71125aa06959", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 15 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DataFinal);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(466, 97, true);
                WriteLiteral("\r\n        </div>\r\n        <label>Tipo: </label>\r\n        <div class=\"radio\">\r\n            <label>");
                EndContext();
                BeginContext(563, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f74f582bda84257aa20a8f456e543fe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 19 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("checked", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(616, 93, true);
                WriteLiteral("Receitas e Despesas</label>\r\n        </div>\r\n        <div class=\"radio\">\r\n            <label>");
                EndContext();
                BeginContext(709, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a46f7ced92c48f5b1c095c61276411d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 22 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(754, 82, true);
                WriteLiteral("Receitas</label>\r\n        </div>\r\n        <div class=\"radio\">\r\n            <label>");
                EndContext();
                BeginContext(836, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1119d67b9684ee4b2f4734bc8e5c31c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 25 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(881, 115, true);
                WriteLiteral("Despesas</label>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Conta:</label>\r\n            ");
                EndContext();
                BeginContext(996, 329, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e3d2b657b5b4367b593a71a7a39c606", async() => {
                    BeginContext(1044, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 30 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                  
                    foreach (var item in (List<ContaModel>)ViewBag.ListaContas)
                    {

#line default
#line hidden
                    BeginContext(1170, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(1194, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fe23864490c44b482dd702afda8f2d4", async() => {
                        BeginContext(1231, 20, false);
#line 33 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                                                       Write(item.Nome.ToString());

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           WriteLiteral(item.Id.ToString());

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1260, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 34 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                    }
                

#line default
#line hidden
                    BeginContext(1304, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 29 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Conta_Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1325, 130, true);
                WriteLiteral("\r\n            <br />\r\n            <button type=\"submit\" class=\"btn btn-success btn-block\">Consultar</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1462, 492, true);
            WriteLiteral(@"
</div>
<br />

<div class=""container"">
    <div class=""table-responsive"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Id</th>
                    <th>Data</th>
                    <th>Tipo</th>
                    <th>Valor</th>
                    <th>Historico</th>
                    <th>Conta</th>
                    <th>Plano de conta</th>
                </tr>
            </thead>
");
            EndContext();
#line 63 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
              
                var totalReceitas = 0.0;
                var totalDespesas = 0.0;
                var total = 0.0;
                foreach (var item in (List<TransacaoModel>)ViewBag.ListaTransacao)
                {

#line default
#line hidden
            BeginContext(2339, 59, true);
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n");
            EndContext();
            BeginContext(2486, 108, true);
            WriteLiteral("                            <th>\r\n                                <button type=\"button\" class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2594, "\"", 2631, 3);
            WriteAttributeValue("", 2604, "Editar(", 2604, 7, true);
#line 73 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
WriteAttributeValue("", 2611, item.Id.ToString(), 2611, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2630, ")", 2630, 1, true);
            EndWriteAttribute();
            BeginContext(2632, 85, true);
            WriteLiteral(">Editar</button>\r\n                            </th>\r\n                            <th>");
            EndContext();
            BeginContext(2718, 18, false);
#line 75 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2736, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(2776, 20, false);
#line 76 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           Write(item.Data.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2796, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(2836, 68, false);
#line 77 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           Write(item.Tipo.ToString().Replace("R", "Receita").Replace("D", "Despesa"));

#line default
#line hidden
            EndContext();
            BeginContext(2904, 42, true);
            WriteLiteral("</th>\r\n                            <th>R$ ");
            EndContext();
            BeginContext(2947, 21, false);
#line 78 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                              Write(item.Valor.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2968, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(3008, 25, false);
#line 79 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(3033, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(3073, 26, false);
#line 80 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           Write(item.Nome_Conta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(3099, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(3139, 32, false);
#line 81 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           Write(item.Nome_Plano_Conta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(3171, 38, true);
            WriteLiteral("</th>\r\n                        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                           
                            if(item.Tipo == "R")
                            {
                                totalReceitas += double.Parse(item.Valor.ToString());
                            }
                            else
                            {
                                totalDespesas += double.Parse(item.Valor.ToString());
                            }
                            total = totalReceitas - totalDespesas;
                        

#line default
#line hidden
            BeginContext(3715, 30, true);
            WriteLiteral("                    </tbody>\r\n");
            EndContext();
#line 95 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                }
            

#line default
#line hidden
            BeginContext(3779, 69, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n<h3><strong>Saldo: </strong>R$ ");
            EndContext();
            BeginContext(3849, 5, false);
#line 100 "C:\Users\Fabinho\Documents\Udemy\ASPNET CORE MVC\MyFinance\MyFinance\MyFinance\Views\Transacao\Extrato.cshtml"
                          Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(3854, 327, true);
            WriteLiteral(@"
</h3>

<script>
    function Criar() {
        window.location.href = ""../Transacao/Registrar"";
    }

    function Excluir(id) {
        window.location.href = ""../Transacao/ExcluirTransacao/"" + id;
    }

    function Editar(id) {
        window.location.href = ""../Transacao/Registrar/"" + id;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TransacaoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591