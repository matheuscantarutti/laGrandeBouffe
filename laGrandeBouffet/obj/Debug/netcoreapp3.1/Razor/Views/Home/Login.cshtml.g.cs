#pragma checksum "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1795f94d80b7db34f828561a0270ba8652a681a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\_ViewImports.cshtml"
using La_Grande_Bouffe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\_ViewImports.cshtml"
using La_Grande_Bouffe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1795f94d80b7db34f828561a0270ba8652a681a9", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09d21c3b896129ad9ed072fc3866b3792507c59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<laGrandeBouffet.ViewModels.Home.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecuperaAcesso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" w-100 btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Acesso dos colaboradores";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid d-flex justify-content-center\">\r\n\r\n    <div class=\"card m-3\" style=\"width: 18rem;\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title text-center\">");
#nullable restore
#line 10 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 11 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
             if (Model.ErroLogin != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-danger font-weight-bold text-center\">");
#nullable restore
#line 13 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                                                               Write(Model.ErroLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1795f94d80b7db34f828561a0270ba8652a681a97873", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""email-login"">Email</label>
                    <input type=""email"" class=""form-control"" id=""email-login"" name=""emailLogin"" aria-describedby=""loginHelp"" placeholder=""Digite seu email"">
");
#nullable restore
#line 20 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                     if (Model.ErroEmail != null) 
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <small id=\"loginHelp\" class=\"form-text text-danger\">");
#nullable restore
#line 22 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                                                                       Write(Model.ErroEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n");
#nullable restore
#line 23 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
                <div class=""form-group"">
                    <label for=""senha-acesso"">Senha</label>
                    <input type=""password"" class=""form-control"" id=""senha-acesso"" name=""senhaLogin"" aria-describedby=""senhaHelp"" placeholder=""Senha"">
");
#nullable restore
#line 28 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                     if (Model.ErroSenha != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <small id=\"senhaHelp\" class=\"form-text text-danger\">");
#nullable restore
#line 30 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                                                                       Write(Model.ErroSenha);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n");
#nullable restore
#line 31 "C:\Users\mathe\OneDrive\Documentos\ADS\3ºsemestre\prwa\bim1\projetos\laGrandeBouffet\laGrandeBouffet\Views\Home\Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>


                <div class=""d-flex justify-content-center mb-2"">
                    <button type=""submit"" class=""btn btn-success w-100"" >Entrar</button>
                </div>

                <div class=""text-center mb-2"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1795f94d80b7db34f828561a0270ba8652a681a911005", async() => {
                    WriteLiteral("Esqueceu sua senha?");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n\r\n                <div class=\"text-center\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1795f94d80b7db34f828561a0270ba8652a681a912848", async() => {
                    WriteLiteral("Cadastrar-se");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<laGrandeBouffet.ViewModels.Home.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
