#pragma checksum "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f203706aff828771844bf4993f57f275b47a4502"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f203706aff828771844bf4993f57f275b47a4502", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetAspCore.ViewsModels.BookListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row text-center\">\r\n    <img style=\"margin-left:3%\" src=\"https://cdn.pixabay.com/photo/2016/02/19/11/53/book-1210030_960_720.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 192, "\"", 198, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"1100\" height=\"500\"/>\r\n</div>\r\n");
#nullable restore
#line 5 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\Home\Index.cshtml"
 foreach (var book in Model.Books)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 7 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\Home\Index.cshtml"
   Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 309, "\"", 329, 1);
#nullable restore
#line 8 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 315, book.ImageUrl, 315, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <h2>");
#nullable restore
#line 9 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\Home\Index.cshtml"
   Write(book.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3>");
#nullable restore
#line 10 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\Home\Index.cshtml"
   Write(book.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 11 "C:\Users\Utilisateur\Documents\Asp.net\ProjetAspCore\Views\Home\Index.cshtml"
   
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetAspCore.ViewsModels.BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
