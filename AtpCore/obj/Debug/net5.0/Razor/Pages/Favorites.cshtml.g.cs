#pragma checksum "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c8be45ac55c403cfb2b9656861e85b9daa766da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AtpCore.Pages.Pages_Favorites), @"mvc.1.0.razor-page", @"/Pages/Favorites.cshtml")]
namespace AtpCore.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c8be45ac55c403cfb2b9656861e85b9daa766da", @"/Pages/Favorites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa0cd57daed3c850c2954b60d8f65b8b5c45842", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Favorites : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\" id=\"content\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
   Write(ViewData["players"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-secondary text-center\">\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
           Write(Html.DisplayNameFor(m => m.FavoritePlayerList[0].Rank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Player\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
           Write(Html.DisplayNameFor(m => m.FavoritePlayerList[0].Points));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Previous Rank
            </th>
            <th>
                Age
            </th>
            <th>
                Country
            </th>
            <th>
                Add to Favorites
            </th>
        </tr>

");
#nullable restore
#line 34 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
         foreach (var item in Model.FavoritePlayerList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td class=\"player-rank\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rank));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    <img width=\"30%\"");
            BeginWriteAttribute("src", " src=\"", 1076, "\"", 1139, 2);
            WriteAttributeValue("", 1082, "https://www.atptour.com/", 1082, 24, true);
#nullable restore
#line 41 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
WriteAttributeValue("", 1106, item.PlayerHeadshotImageCmsUrl, 1106, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1140, "\"", 1176, 2);
#nullable restore
#line 41 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
WriteAttributeValue("", 1146, item.FirstName, 1146, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
WriteAttributeValue(" ", 1161, item.LastName, 1162, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br />\r\n                    ");
#nullable restore
#line 42 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
               Write(Html.DisplayFor(modelItem => item.Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrevRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
               Write(Html.DisplayFor(modelItem => item.AgeAtRankDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
               Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    <input type=\"checkbox\" onclick=\"TestMethod()\"");
            BeginWriteAttribute("value", " value=\"", 1890, "\"", 1927, 2);
#nullable restore
#line 57 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
WriteAttributeValue("", 1898, item.FirstName, 1898, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
WriteAttributeValue("", 1913, item.LastName, 1913, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"favorite\" /><br />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Favorites.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AtpCore.Pages.FavoritesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AtpCore.Pages.FavoritesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AtpCore.Pages.FavoritesModel>)PageContext?.ViewData;
        public AtpCore.Pages.FavoritesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
