#pragma checksum "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe956103e2fee767ae95763e1cc78334c36ef20c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seferler_BiletAl), @"mvc.1.0.view", @"/Views/Seferler/BiletAl.cshtml")]
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
#line 1 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe956103e2fee767ae95763e1cc78334c36ef20c", @"/Views/Seferler/BiletAl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Seferler_BiletAl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UI.Models.TicketAdd>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
  
    ViewData["Title"] = "Bilet AL";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .cs-select ul {\r\n        height: 400px;\r\n        max-height: 400px;\r\n        overflow-x: hidden;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 14 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" id=\"btn\" class=\"btn btn-primary hidden\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n        Launch demo modal\r\n    </button>\r\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel""></h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    İşleminize nasıl devam etmek istiyorsunuz?
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Üye Olmadan Devam Et</button>
                    <a href=""/Account/Login"" class=""btn btn-primary"">Üye Girişi Yap</a>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 39 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 43 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
         using (Html.BeginForm("BiletAl", "Seferler", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"sex\" class=\"form-group col-md-6\" style=\"margin:50px 0\">\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.Label("Yolcu Adı Soyadı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 48 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.TextBoxFor(x => x.Passenger.PassengerName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.Label("Tc No"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 52 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.TextBoxFor(x => x.Passenger.PassengerTc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.Label("Telefon"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 56 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.TextBoxFor(x => x.Passenger.PassengerTel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <style>\r\n                </style>\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.Label("Koltuk Seçimi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 62 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
               Write(Html.DropDownListFor(x => x.Reservation.Seat.SeatNo, (List<SelectListItem>)ViewBag.sv, new { id = "dropbox", @class = "cs-select cs-skin-border" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe956103e2fee767ae95763e1cc78334c36ef20c9086", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 67 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reservation.BusServiceId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
                                                                                    WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <button class=\"btn btn-primary\" style=\"margin-top:10px\">Bilet AL</button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 71 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <label style=\"margin-top:50px;display:block;\">Durak Bilgileri</label>\r\n");
            WriteLiteral("\r\n            ");
#nullable restore
#line 79 "C:\Users\MK\Desktop\Yeni Klasör\MkTurizm\MkTurizm\UI\Views\Seferler\BiletAl.cshtml"
       Write(await Component.InvokeAsync("Seat"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
    </div>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
<script>
    $(document).ready(function () {
        $(""#btn"").click()

    });
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UI.Models.TicketAdd> Html { get; private set; }
    }
}
#pragma warning restore 1591
