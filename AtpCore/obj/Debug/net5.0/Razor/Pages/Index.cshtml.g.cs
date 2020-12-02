#pragma checksum "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e04ff4e13c92129d0807f982414b55752bbb2e"
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
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e04ff4e13c92129d0807f982414b55752bbb2e", @"/Pages/Index.cshtml")]
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

        //Makes a favorites cookie
        function TestMethod(sender, args) {
            const $checkboxes = $('input.favorite-player[type=""checkbox""]');
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
                console.log(value[0].substring(nam");
                WriteLiteral(@"eString.length, value[0].length));
                return value[0].substring(nameString.length, value[0].length);
            }
            return false;
        }

        //Check favorites on page load
        $.each(checkboxValues, function (key, value) {
            $('input.favorite-player[type=""checkbox""][value=""' + key + '""]').prop('checked', value);
        });

        function togglePlayerInfo(element) {
            $(element).toggleClass(""additional-row-td"");
        }

        function favoritesToggle() {
            if ($('input.switch-input[type=""checkbox""]').is(':checked')) {
                $.each(checkboxValues, function (key, value) {
                    if (!value) {
                        $('tr.' + key).addClass(""hidden"");
                    }
                });
            } else {
                $('tr.hidden').removeClass(""hidden"");
            }
        }

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\" id=\"content\">\r\n    <div class=\"col-xs-6\">\r\n        <h1>");
#nullable restore
#line 128 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
       Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    </div>
    <div class=""col-xs-6"">
        <div class=""float-right title-margin"">
            Only Show Favorite Players
            <div class=""switch"">
                <input id=""switch-1"" type=""checkbox"" class=""switch-input"" onclick=""favoritesToggle()"" />
                <label for=""switch-1"" class=""switch-label"">Search</label>
            </div>
        </div>
    </div>

    <table class=""table table-striped border"">
        <tr class=""table-secondary"">
            <th class=""text-center"">
                ");
#nullable restore
#line 143 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PlayerList[0].Rank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-center\">\r\n                Player\r\n            </th>\r\n            <th class=\"text-center\">\r\n                ");
#nullable restore
#line 149 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PlayerList[0].Points));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th class=""text-center"">
                Previous Rank
            </th>
            <th class=""text-center"">
                Age
            </th>
            <th class=""text-center"">
                Country
            </th>
            <th class=""text-center"">
                Add to Favorites
            </th>
        </tr>

");
#nullable restore
#line 165 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
         foreach (var item in Model.PlayerList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 5354, "\"", 5403, 3);
            WriteAttributeValue("", 5362, "text-center", 5362, 11, true);
#nullable restore
#line 167 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue(" ", 5373, item.FirstName, 5374, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 5389, item.LastName, 5389, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td class=\"player-rank\">\r\n                    ");
#nullable restore
#line 169 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rank));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <a class=\"player-bio\" style=\"font-size: 0.35em\" role=\"button\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 5621, "\"", 5659, 2);
            WriteAttributeValue("", 5628, "#", 5628, 1, true);
#nullable restore
#line 170 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 5629, $"{item.PlayerId}Accordian", 5629, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 5660, "\"", 5715, 3);
            WriteAttributeValue("", 5670, "togglePlayerInfo(\'", 5670, 18, true);
#nullable restore
#line 170 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 5688, $"#{item.PlayerId}Row", 5688, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5713, "\')", 5713, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 5716, "\"", 5762, 1);
#nullable restore
#line 170 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 5732, $"{item.PlayerId}Accordian", 5732, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"false\">Info</a>\r\n                </td>\r\n                <td class=\"player-name\">\r\n                    <img width=\"30%\"");
            BeginWriteAttribute("src", " src=\"", 5897, "\"", 5960, 2);
            WriteAttributeValue("", 5903, "https://www.atptour.com/", 5903, 24, true);
#nullable restore
#line 173 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 5927, item.PlayerHeadshotImageCmsUrl, 5927, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5961, "\"", 5997, 2);
#nullable restore
#line 173 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 5967, item.FirstName, 5967, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue(" ", 5982, item.LastName, 5983, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br />\r\n                    ");
#nullable restore
#line 174 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 174 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 177 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Points));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 180 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrevRank));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 183 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AgeAtRankDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 186 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CountryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <input type=\"checkbox\" class=\"favorite-player\" onclick=\"TestMethod()\"");
            BeginWriteAttribute("value", " value=\"", 7016, "\"", 7053, 2);
#nullable restore
#line 191 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 7024, item.FirstName, 7024, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 7039, item.LastName, 7039, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"favorite\" />\r\n                </td>\r\n            </tr>\r\n            <tr");
            BeginWriteAttribute("class", " class=\"", 7132, "\"", 7169, 2);
#nullable restore
#line 194 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 7140, item.FirstName, 7140, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 7155, item.LastName, 7155, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 7192, "\"", 7221, 1);
#nullable restore
#line 195 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 7197, $"{item.PlayerId}Row", 7197, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" colspan=\"7\">\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 7261, "\"", 7296, 1);
#nullable restore
#line 196 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
WriteAttributeValue("", 7266, $"{item.PlayerId}Accordian", 7266, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\">\r\n                        ");
#nullable restore
#line 197 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
                   Write(await Component.InvokeAsync("PlayerExpanded", new { PlayerId = @item.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 201 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\stmou\OneDrive\Documents\GitHub\AtpCore\AtpCore\Pages\Index.cshtml"
            

    private List<string> FavoritePlayers = new List<string>();

    //public void WriteCookie(UIMouseEventArgs e)
    //{
    //    //string player = e.ToString();
    //    //if (FavoritePlayers is null)

    //    //if (!FavoritePlayers.Contains(player))
    //    //{
    //    //    FavoritePlayers.Add(player);
    //    //}
    //    //else
    //    //{
    //    //    FavoritePlayers.Remove(player);
    //    //}

    //    CookieOptions options = new CookieOptions();
    //    options.Expires = DateTime.Now.AddDays(365);
    //    Response.Cookies.Append("favorite-players", JsonConvert.SerializeObject(FavoritePlayers), options);

    //}

    //public List<PlayerBiography> PlayerBiography { get; set; }
    //public string PlayerId { get; set; }

    //private async Task<IActionResult> PlayerContent(string PlayerId)
    //{
    //    var httpClient = new HttpClient();
    //    httpClient.BaseAddress = new Uri("https://app.atptour.com/");

    //    // Get data from JSON HttpContent with ReadFromJsonAsync
    //    var request = new HttpRequestMessage(HttpMethod.Get, "api/gateway/players.PlayerProfileBio?playerid=D643");
    //    using var response = await httpClient.SendAsync(request);

    //    List<PlayerBiography> playerContent = new List<PlayerBiography>();

    //    if (response.IsSuccessStatusCode)
    //    {
    //        var profiles = response.Content.ReadFromJsonAsync<PlayerBiography>();

    //        //foreach (PlayerBiography player in (profiles.).Where(p => p.PlayerId == PlayerId))
    //        //{
    //        //    playerContent.Add(player);
    //        //}
    //    }

    //    PlayerBiography = playerContent;

    //    return Page();
    //}

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
