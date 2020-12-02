using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Net;

namespace AtpCore.Pages
{
    public class FavoritesModel : PageModel
    {
        public List<PlayerJson> FavoritePlayerList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {

            ViewData["title"] = "Favorite Players";

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://app.atptour.com/");

            // Get data from JSON HttpContent with ReadFromJsonAsync
            var request = new HttpRequestMessage(HttpMethod.Get, "api/gateway/rankings.ranksglrollrange?fromrank=1&torank=10");
            using var response = await httpClient.SendAsync(request);

            List<PlayerJson> playerList = new List<PlayerJson>();

            string cookieObjFavorites = Request.Cookies["favorite-players"];
            string cookieObjFavoritesTest = Request.Cookies["favorite-players-test"];
            //if (cookieObjFavorites != null)
            //{
            //    favoritePlayers = cookieObjFavorites["favorite-players"].Value;
            //}

            if (response.IsSuccessStatusCode && !String.IsNullOrEmpty(cookieObjFavorites))
            {
                var profiles = response.Content.ReadFromJsonAsync<PlayerData>();

                foreach (PlayerJson player in profiles.Result.Data.Rankings.Players)
                {
                    if (cookieObjFavorites.Contains(player.FirstName + player.LastName))
                    {
                        playerList.Add(player);
                    }
                    
                }
            }

            FavoritePlayerList = playerList;

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(365);
            options.Path = "/";
            Response.Cookies.Append("favorite-players-test", "FavoritePlayersTest", options);

            return Page();
        }
    }
}
