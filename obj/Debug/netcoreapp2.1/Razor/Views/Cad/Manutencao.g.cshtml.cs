#pragma checksum "C:\Users\Thallis\Desktop\CentralDuplicatas-master\Views\Cad\Manutencao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8898a4ffbf72ac8b06b7669523f8674b555fc7f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cad_Manutencao), @"mvc.1.0.view", @"/Views/Cad/Manutencao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cad/Manutencao.cshtml", typeof(AspNetCore.Views_Cad_Manutencao))]
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
#line 1 "C:\Users\Thallis\Desktop\CentralDuplicatas-master\Views\_ViewImports.cshtml"
using CentralDuplicatas;

#line default
#line hidden
#line 2 "C:\Users\Thallis\Desktop\CentralDuplicatas-master\Views\_ViewImports.cshtml"
using CentralDuplicatas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8898a4ffbf72ac8b06b7669523f8674b555fc7f5", @"/Views/Cad/Manutencao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f04a559329bab731b14f0328caffd1e364e330", @"/Views/_ViewImports.cshtml")]
    public class Views_Cad_Manutencao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal mt3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Thallis\Desktop\CentralDuplicatas-master\Views\Cad\Manutencao.cshtml"
  
    ViewData["Title"] = "Meus dados";

#line default
#line hidden
            BeginContext(48, 1244, true);
            WriteLiteral(@"<link rel=""stylesheet ""href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<script src=""https://unpkg.com/vue""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/axios/0.18.0/axios.min.js""></script>

<section class=""hero infoc blue"">
    <div class=""hero-body mt5"">
        <div class=""container has-text-centered"">
            <titulocadastro id=""tabscadastrotitle""  class=""title"">Meus Dados<br></titulocadastro>
        </div>
    </div>

    <div class=""hero-foot"">
        <nav class=""tabs is-boxed is-fullwidth is-default"">
            <div class=""container"">
                <ul>
                    <li class=""tab is-active"" onclick=""openTab(event,'WebDev')"">
                        <a>Dados da Empresa</a></li>
                    <li class=""tab"" onclick=""openTab(event,'cadastroadministrador')""><a>Dados do Administrador</a></li>
                    <li class=""tab"" onclick=""openTab(event,'cadastrousuarios')""><a>Dados do Usuário</a></li>
            ");
            WriteLiteral("    </ul>\r\n            </div>\r\n        </nav>\r\n    </div>\r\n</section>\r\n\r\n<div id=\"navbarcad\">\r\n    <navbarinternal></navbarinternal>\r\n</div>\r\n\r\n<div id=\"WebDev\" class=\"content-tab\">\r\n    <div class=\"\" id=\"cad\">\r\n        ");
            EndContext();
            BeginContext(1292, 6613, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2c211f81f76496db7cca1025cfed53d", async() => {
                BeginContext(1298, 1331, true);
                WriteLiteral(@"
            <div v-if=""step === 1"">
                <div class=""mt5"">
                    <div id=""cadastro"" class=""columns is-desktop"">
                        <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                            <div class=""mt4"">
                                        <label class=""label mt3"">CNPJ</label>
                                        <input class=""input"" id=""cnpj"" type=""text"" name=""cnpj"" data-validate=""cnpj"" placeholder=""00.000.000/0000-00"" v-model=""dados.entity.cnpj"">
                                        <label class=""label mt3"">Razão Social</label>
                                        <input class=""input"" data-validate=""text"" v-model=""dados.entity.fullname"">
                                        <label class=""label mt3"">Nome Fantasia</label>
                                        <input class=""input"" data-validate=""text"" style=""margin-bottom: 0.75rem"" v-model=""dados.entity.aliasname"">
                             ");
                WriteLiteral(@"           <label class=""label mt1"">Atividade</label>
                                        <div class=""control"">
                                            <div class=""select is-fullwidth"">
                                                <select>
                                                    ");
                EndContext();
                BeginContext(2629, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a4ad30882334c89a3a2e4e8b85f148c", async() => {
                    BeginContext(2637, 21, true);
                    WriteLiteral("Selecione a atividade");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2667, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(2721, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06ccf170db9d4662bc7e189e2c7032cb", async() => {
                    BeginContext(2729, 12, true);
                    WriteLiteral("With options");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2750, 2510, true);
                WriteLiteral(@"
                                                </select>
                                            </div>
                                        </div>
                                    <div>
                                        <label class=""label mt1"">Email</label>
                                        <input class=""input"" v-model=""dados.emails.address"" label=""Email"">
                                        <div class=""columns"" v-for=""(telephones, index) in dados.telephones"">
                                            <div class=""column is-2"">
                                                <label class=""label mt1"">DDD</label>
                                                <input class=""input"" v-model=""telephones.ddd"">
                                            </div>
                                            <div class=""column is-6"">
                                                <label class=""label mt1"">Telefone</label>
                                                <input");
                WriteLiteral(@" type=""text"" data-validate=""brPhone"" class=""input"" v-model=""telephones.number"">
                                            </div>
                                            <div class=""column is-4"">
                                            <label class=""label mt1"">Adicionar campo</label>
                                            <i class=""fa fa-trash fa-2x"" aria-hidden=""true"" v-on:click.prevent=""deleteUser(index)"" style=""padding-right: 1cm""></i>
                                            <i class=""fa fa-plus fa-2x"" aria-hidden=""true""v-on:click.prevent=""addUser""></i>
                                            </div>
                                        </div>

                                    </div>

                                    <div class=""mt4 mb5 column is-paddingless is-10-touch is-4-desktop flexd"">
                                        <button v-on:click.prevent=""next()"" class=""button is-info"">Próximo</button>
                                    </div>
                ");
                WriteLiteral(@"                </div>
                        </div>
                         <infocadastro></infocadastro>
                    </div>
                </div>
            </div>
            <div v-if=""step === 2"">
                <div class=""mt5"">
                    <div id=""cadastro1"" class=""columns is-desktop"">
                        <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                            ");
                EndContext();
                BeginContext(5260, 1672, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab22deaa1c154dc4aed74388db27bc24", async() => {
                    BeginContext(5294, 1631, true);
                    WriteLiteral(@"
                                    <div class=""control"">
                                        <label class=""label mt1"">CEP</label>
                                        <input type=""text"" class=""input"" v-model=""cep"" v-on:keyup=""searchCep()"" placeholder=""digite o cep aqui (sem hífen)"">
                                        <span v-if=""message"" class=""help is-danger"">CEP não encontrado.</span>
                                        <label class=""label mt1"">Cidade</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.city"">
                                        <label class=""label mt1"">UF</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.state"">
                                        <label class=""label mt1"">Endereço</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.thoroughfare"">
                                        <label ");
                    WriteLiteral(@"class=""label mt1"">Numero</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.number"">
                                        <label class=""label mt1"">Bairro</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.neighborhood"">
                                        <label class=""label mt1"">Complemento</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.complement"">
                                    </div>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6932, 966, true);
                WriteLiteral(@"
                            <div class=""container mt3"">
                            <div class=""columns"">
                             <div class=""column is-2"">
                        <p>Download do termo de adesão</p>
                        </div>
                         <div class=""column is-10""> <i class=""fa fa-file-text-o fa-2x"" v-on:click=""modal = !modal"" aria-hidden=""true""></i>
                         </div>
                         </div>
                         </div>
                            <div class=""mt5 mb5 column is-paddingless is-10-touch is-4-desktop flexd"">
                                <button v-on:click.prevent=""prev()"" class=""button is-light"">Anterior</button>
                                <button v-on:click.prevent=""submit()"" class=""button is-info"">Salvar</button>
                            </div>
                        </div>
                    </div>
                </div>
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
            BeginContext(7905, 101, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div id=\"cadastroadministrador\" class=\"content-tab\" style=\"display:none\">\r\n    ");
            EndContext();
            BeginContext(8006, 7935, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b04c13eed28d4c21b6fc04d30fd908b6", async() => {
                BeginContext(8012, 4961, true);
                WriteLiteral(@"
        <div v-if=""step === 1"">
            <div class=""mt5"">
                <div id=""cadastro"" class=""columns is-desktop"">
                    <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                            <div class=""mt4"">
                                <div>
                                    <label class=""label mt3"">CPF</label>
                                    <input class=""input"" id=""cpf"" type=""text"" name=""cpf"" data-validate=""cpf"" placeholder=""000.000.000-00"" maxlength=""14"" v-model=""dados.document"">
                                    <label class=""label mt3"">Nome Completo</label>
                                    <input class=""input"" data-validate=""text"" v-model=""dados.fullName"">
                                    <label class=""label mt3"">Data de nascimento</label>
                                    <input class=""input"" data-validate=""date"" style=""margin-bottom: 0.75rem"" v-model=""dados.birthDate"">
                                </");
                WriteLiteral(@"div>
                                <div>
                                    <label class=""label mt1"">Email</label>
                                    <input class=""input"" v-model=""dados.emails.address"" label=""Email"">
                                    <label class=""label mt2"">Confirmação Email</label>
                                    <input class=""input"" v-model=""dados.emails.address"" label=""Email"">
                                    <div class=""columns"">
                                        <div class=""column is-4"">
                                            <div class=""checkradio100 mt1"">
                                                <input class=""is-checkradio is-info"" id=""checkboxEmail"" type=""checkbox"" name=""checkboxEmail"">
                                                <label for=""checkboxEmail"">Receber notificações por e-mail</label></div>
                                        </div>
                                        <div class=""column is-6"">
                        ");
                WriteLiteral(@"                    <div class=""checkradio100 mt1"">
                                                <input class=""is-checkradio is-info"" id=""checkboxNews"" type=""checkbox"" name=""checkboxNews"">
                                                <label for=""checkboxNews"">Receber Newsletter</label></div>
                                        </div>
                                    </div>
                                    <div class=""columns"" v-for=""(telephones, index) in dados.telephones"">
                                        <div class=""column is-2"">
                                            <label class=""label mt1"">DDD</label>
                                            <input class=""input"" v-model=""telephones.ddd"">
                                        </div>

                                        <div class=""column is-6"">
                                            <label class=""label mt1"">Telefone</label>
                                            <input type=""text"" data-validate=""");
                WriteLiteral(@"brPhone"" class=""input"" v-model=""telephones.number"">
                                        </div>
                                        <div class=""column is-4"">
                                            <label class=""label mt1"">Adicionar campo</label>
                                            <i class=""fa fa-trash fa-2x"" aria-hidden=""true"" v-on:click.prevent=""deleteUser(index)"" style=""padding-right: 1cm""></i>
                                            <i class=""fa fa-plus fa-2x"" aria-hidden=""true""v-on:click.prevent=""addUser""></i>
                                            
                                        </div>
                                    </div>
                                    <div class=""control"">

                                        <div class=""checkradio100 mt1"">
                                            <input class=""is-checkradio is-info"" id=""checkboxSms"" type=""checkbox"" name=""checkboxSms"">
                                            <label for=""checkboxSm");
                WriteLiteral(@"s"">Receber notificações por SMS</label>
                                        </div>
                                    </div>
                                </div>

                                <div class=""mt4 mb5 column is-paddingless is-10-touch is-4-desktop flexd"">
                                    <button v-on:click.prevent=""next()"" class=""button is-info"">Próximo</button>
                                </div>
                        </div>
                    </div>
                    <infocadastro></infocadastro>
                </div>
            </div>
        </div>
        <div v-if=""step === 2"">
            <div class=""mt5"">
                <div id=""cadastro1"" class=""columns is-desktop"">
                    <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                        ");
                EndContext();
                BeginContext(12973, 1600, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a81e674c00964172a3133f02d4f90f15", async() => {
                    BeginContext(13007, 1559, true);
                    WriteLiteral(@"
                                <div class=""control"">
                                    <label class=""label mt1"">CEP</label>
                                    <input type=""text"" class=""input"" v-model=""cep"" v-on:keyup=""searchCep()"" placeholder=""digite o cep aqui (sem hífen)"">
                                    <span v-if=""message"" class=""help is-danger"">CEP não encontrado.</span>
                                    <label class=""label mt1"">Cidade</label>
                                    <input class=""input"" v-model=""dados.userInfoModel.address.city"">
                                    <label class=""label mt1"">UF</label>
                                    <input class=""input"" v-model=""dados.userInfoModel.address.state"">
                                    <label class=""label mt1"">Endereço</label>
                                    <input class=""input"" v-model=""dados.userInfoModel.address.thoroughfare"">
                                    <label class=""label mt1"">Numero</label>
          ");
                    WriteLiteral(@"                          <input class=""input"" v-model=""dados.userInfoModel.address.number"">
                                    <label class=""label mt1"">Bairro</label>
                                    <input class=""input"" v-model=""dados.userInfoModel.address.neighborhood"">
                                    <label class=""label mt1"">Complemento</label>
                                    <input class=""input"" v-model=""dados.userInfoModel.address.complement"">
                                </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14573, 1361, true);
                WriteLiteral(@"
                        <div class=""control"">
                            <div class=""checkradio100 mt1"">
                                <input class=""is-checkradio is-info"" id=""exampleCheckbox19"" type=""checkbox"" name=""exampleCheckbox"">
                                <label for=""exampleCheckbox19"">Concordo em receber notificações por e-mail</label>
                            </div>
                        </div>
                        <div class=""container mt3"">
                            <div class=""columns"">
                             <div class=""column is-2"">
                        <p>Download do termo de adesão</p>
                        </div>
                         <div class=""column is-10""> <i class=""fa fa-file-text-o fa-2x"" v-on:click=""modal = !modal"" aria-hidden=""true""></i>
                         </div>
                         </div>
                         </div>

                        <div class=""mt5 mb5 column is-paddingless is-10-touch is-offset-1-touch is-4-des");
                WriteLiteral(@"ktop flexd"">

                            <button v-on:click.prevent=""prev()"" class=""button is-light"">Anterior</button>
                            <button v-on:click.prevent=""submit()"" class=""button is-info"">Salvar</button>
                        </div>
                    </div>
                </div>
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
            BeginContext(15941, 106, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n<div id=\"cadastrousuarios\" class=\"content-tab\" style=\"display:none\">\r\n    ");
            EndContext();
            BeginContext(16047, 2692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da61e66cff3546c881a273b1840bc513", async() => {
                BeginContext(16053, 2679, true);
                WriteLiteral(@"
        <section class=""container"">
            <div class=""hero-body"">
                <div style=""text-align: left""> 
                <div class=""container"">
                    <h4 class=""title"">
                    Usuários cadastrados
                    </h4>
                </div>
            </div>
        </section>
        <div class=""container mt5"">
            <div class=""columns is-desktop"">
                    <div class=""column is-8-desktop is-offset-2-desktop is-10-touch is-offset-1-touch"">
                        <div class=""mt4"">
                        <div v-for=""(user, index) in users"">
                            <div class=""columns"">
                            <div class=""column is-3"">
                            <label class=""label mt3"">CPF</label>
                            <input class=""input"" data-validate=""cpf"" placeholder=""000.000.000-00"" v-model=""user.cpf""><br>
                            </div>
                            <div class=""column is-5"">
      ");
                WriteLiteral(@"                      <label class=""label mt3"">Nome completo</label>
                            <input class=""input"" data-validate=""text"" v-model=""user.nome"">
                            </div>
                            <div class=""column is-1"">
                                <label v-for=""ativar"" class=""label mt3"">Ativar</label>
                                <div class=""checkradio100 mt1"">
                             <input class=""checkradio is-info"" id=""ativar"" type=""checkbox"" name=""ativar"" checked=""checked"" style=""border-color:#fff"">
                             </div>
                             </div>
                          <div class=""column is-1"">
                                            <label class=""label mt3"">Editar</label>
                                            <i class=""fa fa-pencil-square-o fa-2x"" aria-hidden=""true""></i>
                                            </div>
                         <div class=""column is-1"">
                                           ");
                WriteLiteral(@"<label class=""label mt3"">Excluir</label>
                                            <i class=""fa fa-times fa-2x"" aria-hidden=""true""></i>
                                            </div>
                            <div class=""column is-1"">
                                            <label class=""label mt3"">Autorização</label>
                                            <i class=""fa fa-plus-circle fa-2x"" aria-hidden=""true""></i>
                                            </div>
                                        </div>
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
            BeginContext(18739, 323, true);
            WriteLiteral(@"
        </div>
    </div>
    </div>

    </div>
    <div class=""container mt5"">
    <div class=""mb4"" style=""text-align: center"">
    <div style=""text-align: center""> 
        <button class=""button is-info"" v-on:click.prevent=""enviar"">Salvar</button>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
