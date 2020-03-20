#pragma checksum "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc6fa2bd3e9945e40209a0c5c98543683c93a18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\_ViewImports.cshtml"
using ProjetAspCore.ViewsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\_ViewImports.cshtml"
using ProjetAspCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc6fa2bd3e9945e40209a0c5c98543683c93a18", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f98cf6f636923b32412b3a61c244bc590ef160", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2 class=""mt-4 ml-3""> Votre panier</h2>
<table class="" mt-5 ml-2 table table-bordered table-striped"">

    <thead>

        <tr>
            <th>Nombre</th>
            <th>Livre</th>
            <th class=""text-right"">Prix</th>
            <th class=""text-right"">Total</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml"
         foreach (var item in Model.ShoppingCart.ShoppingCartItems){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
#nullable restore
#line 19 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml"
                               Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
#nullable restore
#line 20 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml"
                             Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 21 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml"
                              Write(item.Book.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml"
        Write((item.Amount * item.Book.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 31 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\ShoppingCart\Index.cshtml"
                              Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591