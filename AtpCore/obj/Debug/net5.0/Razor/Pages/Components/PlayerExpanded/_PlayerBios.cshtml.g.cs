#pragma checksum "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b792b01e684695c7fd816828dc9cb8ff65c0cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AtpCore.Pages.Components.PlayerExpanded.Pages_Components_PlayerExpanded__PlayerBios), @"mvc.1.0.view", @"/Pages/Components/PlayerExpanded/_PlayerBios.cshtml")]
namespace AtpCore.Pages.Components.PlayerExpanded
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
#line 1 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\_ViewImports.cshtml"
using AtpCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b792b01e684695c7fd816828dc9cb8ff65c0cd", @"/Pages/Components/PlayerExpanded/_PlayerBios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa0cd57daed3c850c2954b60d8f65b8b5c45842", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_PlayerExpanded__PlayerBios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlayerBiography>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n\r\n        $(\'#playerTabs a\').click(function (e) {\r\n            e.preventDefault()\r\n            $(this).tab(\'show\')\r\n        })\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!-- Nav tabs -->\r\n<div class=\"panel with-nav-tabs panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <ul class=\"nav nav-tabs\" role=\"tablist\">\r\n            <li role=\"presentation\" class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 653, 2);
            WriteAttributeValue("", 620, "#", 620, 1, true);
#nullable restore
#line 27 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 621, $"about{Model.Data.PlayerId}", 621, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 654, "\"", 702, 1);
#nullable restore
#line 27 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 670, $"about{Model.Data.PlayerId}", 670, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" data-toggle=\"tab\">About ");
#nullable restore
#line 27 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
                                                                                                                                                                              Write(Model.Data.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            <li role=\"presentation\"><a");
            BeginWriteAttribute("href", " href=\"", 809, "\"", 848, 2);
            WriteAttributeValue("", 816, "#", 816, 1, true);
#nullable restore
#line 28 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 817, $"year{Model.Data.PlayerId}", 817, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 849, "\"", 896, 1);
#nullable restore
#line 28 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 865, $"year{Model.Data.PlayerId}", 865, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" data-toggle=\"tab\">Year to Date</a></li>\r\n            <li role=\"presentation\"><a");
            BeginWriteAttribute("href", " href=\"", 988, "\"", 1029, 2);
            WriteAttributeValue("", 995, "#", 995, 1, true);
#nullable restore
#line 29 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 996, $"career{Model.Data.PlayerId}", 996, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1030, "\"", 1079, 1);
#nullable restore
#line 29 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 1046, $"career{Model.Data.PlayerId}", 1046, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" data-toggle=\"tab\">Career Highlights</a></li>\r\n        </ul>\r\n    </div>\r\n    <!-- Tab panes -->\r\n    <div class=\"panel-body\">\r\n        <div class=\"tab-content\">\r\n            <div role=\"tabpanel\" class=\"tab-pane fade in active\"");
            BeginWriteAttribute("id", " id=\"", 1318, "\"", 1355, 1);
#nullable restore
#line 35 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 1323, $"about{Model.Data.PlayerId}", 1323, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"float-right m-3\">\r\n                    <img width=\"70%\"");
            BeginWriteAttribute("src", " src=\"", 1442, "\"", 1528, 2);
            WriteAttributeValue("", 1448, "https://www.atptour.com/", 1448, 24, true);
#nullable restore
#line 37 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 1472, Model.Content.PlayerProfileDetails.PlayerGladiatorUrl, 1472, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1529, "\"", 1577, 2);
#nullable restore
#line 37 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 1535, Model.Data.FirstName, 1535, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue(" ", 1556, Model.Data.LastName, 1557, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"m-3\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
               Write(Html.Raw(@WebUtility.HtmlDecode(Model.Data.BioPersonal)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div role=\"tabpanel\" class=\"tab-pane fade in\"");
            BeginWriteAttribute("id", " id=\"", 1822, "\"", 1858, 1);
#nullable restore
#line 43 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 1827, $"year{Model.Data.PlayerId}", 1827, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"m-3\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
               Write(Html.Raw(@WebUtility.HtmlDecode(Model.Data.BioYearToDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div role=\"tabpanel\" class=\"tab-pane fade in\"");
            BeginWriteAttribute("id", " id=\"", 2079, "\"", 2117, 1);
#nullable restore
#line 48 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
WriteAttributeValue("", 2084, $"career{Model.Data.PlayerId}", 2084, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"m-3\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Components\PlayerExpanded\_PlayerBios.cshtml"
               Write(Html.Raw(@WebUtility.HtmlDecode(Model.Data.BioCareerHighlights)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayerBiography> Html { get; private set; }
    }
}
#pragma warning restore 1591
