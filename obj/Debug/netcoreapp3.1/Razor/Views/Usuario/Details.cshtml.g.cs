#pragma checksum "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aac483f6ab1408307cd4c4e3f3838766295d33d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Details), @"mvc.1.0.view", @"/Views/Usuario/Details.cshtml")]
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
#line 1 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\_ViewImports.cshtml"
using controleFinanceiro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\_ViewImports.cshtml"
using controleFinanceiro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac483f6ab1408307cd4c4e3f3838766295d33d5", @"/Views/Usuario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2681afc8cd9762e514b74ce17a30eac052f0aac", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<controleFinanceiro.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex align-items-center justify-content-between\">\r\n    <h1>\r\n        ");
#nullable restore
#line 9 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
   Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n");
#nullable restore
#line 11 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
      
        var idUsu = Model.UsuarioId;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"btn-group btn-group-toggle\">\r\n        <div class=\"btn btn-light\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
       Write(Html.ActionLink("Nova transa????o", "Create", "Financa", new { id = @idUsu}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aac483f6ab1408307cd4c4e3f3838766295d33d55486", async() => {
                WriteLiteral("Editar Usu??rio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
                                                                  WriteLiteral(Model.UsuarioId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aac483f6ab1408307cd4c4e3f3838766295d33d57792", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Valor
            </th>
            <th>
                Data da Finan??a
            </th>
            <th>
                Modalidade
            </th>
            <th>
                Categoria
            </th>
            <th>
                Tipo
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 45 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
         foreach (var item in Model.Financas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
               Write(string.Format("{0:C}", item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
               Write(item.DataFinanca.ToString("dd/MM/yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Modalidade.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Categoria.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tipo.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"btn-group btn-group-toggle\">\r\n                    <div class=\"btn btn-light btn-sm\">\r\n                        ");
#nullable restore
#line 65 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
                   Write(Html.ActionLink("Editar", "Edit", "Financa", new { id = @item.FinancaId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"btn btn-light btn-sm\">\r\n                        ");
#nullable restore
#line 68 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
                   Write(Html.ActionLink("Detalhes", "Details", "Financa", new { id = @item.FinancaId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"btn btn-light btn-sm\">\r\n                        ");
#nullable restore
#line 71 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
                   Write(Html.ActionLink("Deletar", "Delete", "Financa", new { id = @item.FinancaId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Liz\Documents\DESENVOLVIMENTO DE SISTEMAS II\Controle_Financeiro\Views\Usuario\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<controleFinanceiro.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
