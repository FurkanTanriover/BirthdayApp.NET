#pragma checksum "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\Home\InvitationForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b6d3922f98f3a671f1fe31bd994e963e5425886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InvitationForm), @"mvc.1.0.view", @"/Views/Home/InvitationForm.cshtml")]
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
#line 1 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\_ViewImports.cshtml"
using BirthdayApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\_ViewImports.cshtml"
using BirthdayApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b6d3922f98f3a671f1fe31bd994e963e5425886", @"/Views/Home/InvitationForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302b1a199cb68fcd595e294761e791dd9899342e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InvitationForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<global::BirthdayApp.Models.InvitationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\Home\InvitationForm.cshtml"
  
    ViewData["Title"] = "InvitationForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"panel panel-success\">\r\n    <div class=\"panel-head\"><h4>Sen de davetlisin</h4></div>\r\n    <div class=\"panel-body\">\r\n");
#nullable restore
#line 10 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\Home\InvitationForm.cshtml"
         using (Html.BeginForm()) // begin form varsay??lan olarak post metoduna gider(e??er bir parametre belirtmezsek home controller alt??ndaki ??nvitationform a gidecek)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label>Name   :</label>\r\n                ");
#nullable restore
#line 14 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\Home\InvitationForm.cshtml"
           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Posta   :</label>\r\n                ");
#nullable restore
#line 18 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\Home\InvitationForm.cshtml"
           Write(Html.TextBoxFor(x => x.Posta, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Kat??lacak m??s??n?</label>\r\n                ");
#nullable restore
#line 22 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\Home\InvitationForm.cshtml"
           Write(Html.DropDownListFor(x => x.ParticipationStatus, new[]
           {
               new SelectListItem() {Text="Evet, Geliyorum",
               Value=bool.TrueString },
               new SelectListItem(){Text="Hay??r, Gelmiyorum",
               Value=bool.FalseString}
                     }, "Geliyor musun?",new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"text-center\">\r\n            <input class=\"btn btn-success\" type=\"submit\" value=\"G??nder\"/>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\Furkan\source\repos\WebApplicationStudy\BirthdayApp\Views\Home\InvitationForm.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<global::BirthdayApp.Models.InvitationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
