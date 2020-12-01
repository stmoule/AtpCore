#pragma checksum "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49011ffdc74c3ea6f0d0ec63dae35ede85f611dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AtpCore.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AtpCore.Pages
{
    #line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\_ViewImports.cshtml"
using AtpCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using AtpCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49011ffdc74c3ea6f0d0ec63dae35ede85f611dd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa0cd57daed3c850c2954b60d8f65b8b5c45842", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
  
    ViewData["Title"] = "Top Ten";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

        let checkboxValues = JSON.parse(getCookieValue('favorite-players')) || {};

        //Add favorites to cookie
        function TestMethod(sender, args) {

            const $checkboxes = $('input[type=""checkbox""]');
            const expireDate = new Date(new Date().setFullYear(new Date().getFullYear() + 1));

            $checkboxes.on(""change"", function () {
                $checkboxes.each(function () {
                    checkboxValues[this.value] = this.checked;
                });
                document.cookie = `favorite-players=${JSON.stringify(checkboxValues)}; expires=${expireDate}; path=/`;
            });
        }

        function getCookieValue(name) {
            let nameString = name + ""="";
            const value = document.cookie.split("";"").filter(item => {
                return item.includes(nameString);
            })
            if (value != """") {
                console.log(value[0].substring(nameString.length,");
                WriteLiteral(@" value[0].length));
                return value[0].substring(nameString.length, value[0].length);
            }
            return false;
        }

        //Check favorites on page load
        $.each(checkboxValues, function (key, value) {
            $('input[type=""checkbox""][value=""' + key + '""]').prop('checked', value);
        });

        function togglePlayerInfo(element) {
            $(element).toggleClass(""additional-row-td"");
        }


    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\" id=\"content\">\r\n    <h1>");
#nullable restore
#line 123 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
   Write(ViewData["players"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-secondary text-center\">\r\n            <th>\r\n                ");
#nullable restore
#line 128 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PlayerList[0].Rank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Player\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 134 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PlayerList[0].Points));

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
#line 150 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
         foreach (var item in Model.PlayerList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td class=\"player-rank\">\r\n                    ");
#nullable restore
#line 154 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rank));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <a class=\"player-bio\" style=\"font-size: 0.35em\" role=\"button\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 4688, "\"", 4726, 2);
            WriteAttributeValue("", 4695, "#", 4695, 1, true);
#nullable restore
#line 155 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 4696, $"{item.PlayerId}Accordian", 4696, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4727, "\"", 4782, 3);
            WriteAttributeValue("", 4737, "togglePlayerInfo(\'", 4737, 18, true);
#nullable restore
#line 155 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 4755, $"#{item.PlayerId}Row", 4755, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4780, "\')", 4780, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 4783, "\"", 4829, 1);
#nullable restore
#line 155 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 4799, $"{item.PlayerId}Accordian", 4799, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">Info</a>\r\n                </td>\r\n                <td class=\"player-name\">\r\n                    <img width=\"30%\"");
            BeginWriteAttribute("src", " src=\"", 4964, "\"", 5027, 2);
            WriteAttributeValue("", 4970, "https://www.atptour.com/", 4970, 24, true);
#nullable restore
#line 158 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 4994, item.PlayerHeadshotImageCmsUrl, 4994, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5028, "\"", 5064, 2);
#nullable restore
#line 158 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 5034, item.FirstName, 5034, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue(" ", 5049, item.LastName, 5050, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br />\r\n                    ");
#nullable restore
#line 159 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 159 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 162 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 165 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrevRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 168 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AgeAtRankDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 171 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <input type=\"checkbox\" onclick=\"TestMethod()\"");
            BeginWriteAttribute("value", " value=\"", 6059, "\"", 6096, 2);
#nullable restore
#line 176 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 6067, item.FirstName, 6067, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 6082, item.LastName, 6082, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"favorite\" />\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n            <tr>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 6417, "\"", 6446, 1);
#nullable restore
#line 183 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 6422, $"{item.PlayerId}Row", 6422, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"additional-row-td\" colspan=\"7\">\r\n");
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 6650, "\"", 6685, 1);
#nullable restore
#line 185 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 6655, $"{item.PlayerId}Accordian", 6655, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\">\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                        ");
#nullable restore
#line 197 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
                   Write(await Component.InvokeAsync("PlayerInfo", new { PlayerId = @item.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 202 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
            

    //private List<string> FavoritePlayers = new List<string>();

    //public IActionResult WriteCookie(string player)
    //{
    //    //string player = e.ToString();
    //    //if (FavoritePlayers is null)

    //    if (!FavoritePlayers.Contains(player))
    //    {
    //        FavoritePlayers.Add(player);
    //    }
    //    else
    //    {
    //        FavoritePlayers.Remove(player);
    //    }

    //    CookieOptions options = new CookieOptions();
    //    options.Expires = DateTime.Now.AddDays(365);
    //    Response.Cookies.Append("favorite-players", JsonConvert.SerializeObject(FavoritePlayers), options);

    //}

    public List<PlayerBiography> PlayerBiography { get; set; }
    public string PlayerId { get; set; }

    private async Task<IActionResult> PlayerContent(string PlayerId)
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://app.atptour.com/");

        // Get data from JSON HttpContent with ReadFromJsonAsync
        var request = new HttpRequestMessage(HttpMethod.Get, "api/gateway/players.PlayerProfileBio?playerid=D643");
        using var response = await httpClient.SendAsync(request);

        List<PlayerBiography> playerContent = new List<PlayerBiography>();

        if (response.IsSuccessStatusCode)
        {
            var profiles = response.Content.ReadFromJsonAsync<PlayerBiography>();

            //foreach (PlayerBiography player in (profiles.).Where(p => p.PlayerId == PlayerId))
            //{
            //    playerContent.Add(player);
            //}
        }

        PlayerBiography = playerContent;

        return Page();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
