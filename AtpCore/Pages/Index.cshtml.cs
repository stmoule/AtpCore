using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.Mvc;
using HtmlHelper = System.Web.Mvc.HtmlHelper;

namespace AtpCore.Pages
{
    public class IndexModel : PageModel
    {
        public List<PlayerJson> PlayerList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {

            ViewData["players"] = "ATP Tour Top 10";

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://app.atptour.com/");

            // Get data from JSON HttpContent with ReadFromJsonAsync
            var request = new HttpRequestMessage(HttpMethod.Get, "api/gateway/rankings.ranksglrollrange?fromrank=1&torank=10");
            using var response = await httpClient.SendAsync(request);

            List<PlayerJson> playerList = new List<PlayerJson>();

            if (response.IsSuccessStatusCode)
            {
                var profiles = response.Content.ReadFromJsonAsync<PlayerData>();

                foreach (PlayerJson player in profiles.Result.Data.Rankings.Players)
                {
                    playerList.Add(player);
                }
            }

            PlayerList = playerList;

            return Page();
        }

        //public void FavoritePlayersCookie(string favoritePlayers)
        //{



        //    if (checkForExistingCookies("favorite-players"))
        //    {
        //        cookieFavoritePlayers.Expires = DateTime.Now.AddDays(-1);
        //        Response.Cookies.Set(cookieFavoritePlayers);
        //    }

        //    Append("favorite-players", favoritePlayers);

        //    cookieFavoritePlayers.Value = "favorite-players";

        //    cookieFavoritePlayers.Expires = DateTime.Now.AddDays(365);
        //    Response.Cookies.Add(cookieFavoritePlayers);
        //}

        public void WriteCookies(string setting, string settingValue)
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Append(setting, settingValue, options);
        }
    }
}
