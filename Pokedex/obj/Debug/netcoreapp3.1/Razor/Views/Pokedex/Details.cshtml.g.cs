#pragma checksum "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2b1afb4c43a98d52af6c3fea79bea2f471ca0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokedex_Details), @"mvc.1.0.view", @"/Views/Pokedex/Details.cshtml")]
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
#line 2 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\_ViewImports.cshtml"
using Pokedex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2b1afb4c43a98d52af6c3fea79bea2f471ca0a", @"/Views/Pokedex/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3058cc3b178afd3ce6edf04e57f5326960b5d40", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokedex_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pokemon>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <td>Image</td>\r\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee2b1afb4c43a98d52af6c3fea79bea2f471ca0a3203", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 95, "~/images/pokemon/", 95, 17, true);
#nullable restore
#line 5 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
AddHtmlAttributeValue("", 112, Model.Id, 112, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 123, ".png", 123, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Name</td>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
       Write(Model.Name.English);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Type</td>\r\n        <td>\r\n            <ul>\r\n");
#nullable restore
#line 15 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
                 foreach (var type in Model.Type)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 17 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
                   Write(type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>HP</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
       Write(Model.Base.Hp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Attack</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
       Write(Model.Base.Attack);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    \r\n    <tr>\r\n        <td>Defense</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
       Write(Model.Base.Defense);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Special Attack</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
       Write(Model.Base.SpAttack);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Special Defense</td>\r\n        <td>");
#nullable restore
#line 41 "C:\Users\Narwa Eshai Du\source\repos\Pokedex\Pokedex\Views\Pokedex\Details.cshtml"
       Write(Model.Base.SpDefense);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pokemon> Html { get; private set; }
    }
}
#pragma warning restore 1591
