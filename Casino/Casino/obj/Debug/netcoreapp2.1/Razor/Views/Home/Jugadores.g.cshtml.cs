#pragma checksum "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "912aec0123d054740d6947a3676f3f88f8172a89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Jugadores), @"mvc.1.0.view", @"/Views/Home/Jugadores.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Jugadores.cshtml", typeof(AspNetCore.Views_Home_Jugadores))]
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
#line 1 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\_ViewImports.cshtml"
using Casino;

#line default
#line hidden
#line 2 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\_ViewImports.cshtml"
using Casino.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"912aec0123d054740d6947a3676f3f88f8172a89", @"/Views/Home/Jugadores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231b5e586ba348a413b5d46c33241c944434d4b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Jugadores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Casino.Models.RegistroModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Jugadores.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
  
    ViewData["Title"] = "Manejo de Jugadores";

#line default
#line hidden
            BeginContext(93, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(98, 17, false);
#line 6 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(115, 33, true);
            WriteLiteral("</h2>\r\n\r\n<!--Seccion Scripts-->\r\n");
            EndContext();
            BeginContext(148, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1a28f61af0a4114a290eccaf1c3fcd5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(212, 517, true);
            WriteLiteral(@"

<!--Contenido-->
<button type=""button"" class=""btn btn-success"" onclick=""AbrirModalJugadores();"">Agregar Jugador</button>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Edad</th>
            <th scope=""col"">Sexo</th>
            <th scope=""col"">Estado</th>
            <th scope=""col"">Disponible ($)</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
         foreach (var item in Model.lstJugadores)
        {

#line default
#line hidden
            BeginContext(791, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(822, 11, false);
#line 29 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
           Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(833, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(857, 9, false);
#line 30 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
           Write(item.Edad);

#line default
#line hidden
            EndContext();
            BeginContext(866, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
             if (item.Sexo == "1")
            {

#line default
#line hidden
            BeginContext(924, 36, true);
            WriteLiteral("                <td>Masculino</td>\r\n");
            EndContext();
#line 34 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1008, 35, true);
            WriteLiteral("                <td>Femenino</td>\r\n");
            EndContext();
#line 38 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
            }

#line default
#line hidden
            BeginContext(1058, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
             if (item.Estado == "A")
            {

#line default
#line hidden
            BeginContext(1113, 33, true);
            WriteLiteral("                <td>Activo</td>\r\n");
            EndContext();
#line 43 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1194, 35, true);
            WriteLiteral("                <td>Inactivo</td>\r\n");
            EndContext();
#line 47 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
            }

#line default
#line hidden
            BeginContext(1244, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(1261, 15, false);
#line 48 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
           Write(item.Disponible);

#line default
#line hidden
            EndContext();
            BeginContext(1276, 68, true);
            WriteLiteral("</td>\r\n            <td><button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1344, "\"", 1416, 5);
            WriteAttributeValue("", 1354, "EditarJugador(", 1354, 14, true);
#line 49 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
WriteAttributeValue("", 1368, item.TipoIdentificacion, 1368, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 1392, ",", 1392, 1, true);
#line 49 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
WriteAttributeValue(" ", 1393, item.Identificacion, 1394, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1414, ");", 1414, 2, true);
            EndWriteAttribute();
            BeginContext(1417, 83, true);
            WriteLiteral(">Editar</button></td>\r\n            <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1500, "\"", 1574, 5);
            WriteAttributeValue("", 1510, "EliminarJugador(", 1510, 16, true);
#line 50 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
WriteAttributeValue("", 1526, item.TipoIdentificacion, 1526, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 1550, ",", 1550, 1, true);
#line 50 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
WriteAttributeValue(" ", 1551, item.Identificacion, 1552, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1572, ");", 1572, 2, true);
            EndWriteAttribute();
            BeginContext(1575, 40, true);
            WriteLiteral(">Eliminar</button></td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Proyectos\MonitoreoCasino\Casino\Casino\Views\Home\Jugadores.cshtml"
        }

#line default
#line hidden
            BeginContext(1626, 695, true);
            WriteLiteral(@"    </tbody>
</table>
<input type=""hidden"" id=""tipoIdeEliminar"" />
<input type=""hidden"" id=""ideEliminar"" />

<!--Modal para agregar jugadores-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""agregarJugador"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h5 class=""modal-title"">Por favor ingresar la información del Jugador</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(2321, 2256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2288fb0e29fa456cabf4a98f6e197211", async() => {
                BeginContext(2327, 272, true);
                WriteLiteral(@"
                    <div class=""form-group required"">
                        <label class=""col-form-label control-label"">Tipo de Identificación:</label>
                        <select class=""form-control"" id=""agregarTipoIdentificacion"">
                            ");
                EndContext();
                BeginContext(2599, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1241d43f0cf845c2b8d33593ff1d8f21", async() => {
                    BeginContext(2617, 13, true);
                    WriteLiteral("Seleccione...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2639, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2669, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5a77ed9c784e2fae4e20aa4f459c14", async() => {
                    BeginContext(2687, 20, true);
                    WriteLiteral("Cédula de Ciudadanía");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2716, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2746, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da926d935b794b10b620db92ccdcebac", async() => {
                    BeginContext(2764, 21, true);
                    WriteLiteral("Cédula de Extranjería");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2794, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2824, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b2d23ba76fd48cba04f146b610c4214", async() => {
                    BeginContext(2842, 3, true);
                    WriteLiteral("Nit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2854, 1186, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group required"">
                        <label class=""col-form-label control-label"">Número de Identificación:</label>
                        <input type=""text"" class=""form-control"" id=""agregarNumeroIdentificacion"" onkeypress=""return SoloNumeros(event)"">
                    </div>
                    <div class=""form-group required"">
                        <label class=""col-form-label control-label"">Nombre Completo:</label>
                        <input type=""text"" class=""form-control"" id=""agregarNombreCompleto"">
                    </div>
                    <div class=""form-group required"">
                        <label class=""col-form-label control-label"">Edad:</label>
                        <input type=""text"" class=""form-control"" id=""agregarEdad""  onkeypress=""return SoloNumeros(event)"">
                    </div>
                    <div class=""form-group required"">
                     ");
                WriteLiteral("   <label class=\"col-form-label control-label\">Sexo:</label>\r\n                        <select class=\"form-control\" id=\"agregarSexo\">\r\n                            ");
                EndContext();
                BeginContext(4040, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be7024505c9146c589211b2967b01dd2", async() => {
                    BeginContext(4058, 13, true);
                    WriteLiteral("Seleccione...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4080, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4110, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a259e050b7244a939099b186f2d7c4b3", async() => {
                    BeginContext(4128, 9, true);
                    WriteLiteral("Masculino");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4146, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4176, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d89210b2004c35a0c1204f95eae716", async() => {
                    BeginContext(4194, 8, true);
                    WriteLiteral("Femenino");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4211, 359, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group required"">
                        <label class=""col-form-label control-label"">Dinero Disponible ($):</label>
                        <input type=""text"" class=""form-control"" id=""agregarDineroDisponible"">
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4577, 1329, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <input type=""hidden"" id=""operacion""/>
                <button type=""button"" class=""btn btn-primary"" onclick=""GuardarJugador();"">Guardar</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
            </div>
        </div>
    </div>
</div>

<!--Modal confirmacion de eliminacion-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""eliminarJugador"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Eliminar Jugador</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Está seguro de eliminar el jugador?.</p>
            </div>
            <div");
            WriteLiteral(@" class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""ConfirmarEliminarJugador();"">Eliminar</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Casino.Models.RegistroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
