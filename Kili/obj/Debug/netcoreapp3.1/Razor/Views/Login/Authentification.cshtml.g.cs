#pragma checksum "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4badb51e27983566866269d03668d90b66fd4f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Authentification), @"mvc.1.0.view", @"/Views/Login/Authentification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4badb51e27983566866269d03668d90b66fd4f3", @"/Views/Login/Authentification.cshtml")]
    #nullable restore
    public class Views_Login_Authentification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kili.ViewModels.UserAccountViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Authentification";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
 if (Model.Authentifie)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>\r\n        Vous êtes déjà authentifié avec le login :\r\n        ");
#nullable restore
#line 11 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
   Write(Model.UserAccount.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n");
#nullable restore
#line 13 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
Write(Html.ActionLink("Voulez-vous vous déconnecter ?", "Deconnexion"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
                                                                     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Veuillez vous authentifier :\r\n    </p>\r\n");
#nullable restore
#line 20 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Connexion : </legend>\r\n        ");
#nullable restore
#line 24 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
   Write(Html.LabelFor(m => m.UserAccount.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
   Write(Html.TextBoxFor(m => m.UserAccount.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
   Write(Html.ValidationMessageFor(m => m.UserAccount.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 28 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
   Write(Html.LabelFor(m => m.UserAccount.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
   Write(Html.PasswordFor(m => m.UserAccount.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 30 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
   Write(Html.ValidationMessageFor(m => m.UserAccount.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <input type=\"submit\" value=\"Se Connecter...\" />\r\n    </fieldset>\r\n");
#nullable restore
#line 34 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\tolot\source\KILI_REPOS\Kili\Views\Login\Authentification.cshtml"
 
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kili.ViewModels.UserAccountViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
