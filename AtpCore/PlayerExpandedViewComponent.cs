using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtpCore
{
    public class PlayerExpandedViewComponent : ViewComponent
    {
        public PlayerBiography PlayerBiosFull { get; set; }

        public string PlayerId { get; set; }

        public async Task<IViewComponentResult> InvokeAsync(string PlayerId)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://app.atptour.com/");

            // Get data from JSON HttpContent with ReadFromJsonAsync
            var request = new HttpRequestMessage(HttpMethod.Get, "api/gateway/players.PlayerProfileBio?playerid=" + PlayerId);
            using var response = await httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var profile = response.Content.ReadFromJsonAsync<PlayerBiography>();

                PlayerBiosFull = profile.Result;

                //PlayerData tester = profiles.Result.Data.(p => p.PlayerId == PlayerId));

                //PlayerData testerTwo = profiles.Result.Data.W


                //foreach (PlayerBiosData player in profiles.Result.Data)
                //{



                //}
            }

        //return View<PlayerBiosData>(PlayerBios);
        //return View<PlayerBiosData>("PlayerInfo", PlayerBios);

        return View<PlayerBiography>("_PlayerTest", PlayerBiosFull);

        //InvalidOperationException: The view 'Components/Player/_PlayerTest' was not found. The following locations were searched:

        //InvalidOperationException: The view 'Components/PlayerExpanded/_PlayerTest' was not found.The following locations were searched:
        /// Pages / Components / PlayerExpanded / _PlayerTest.cshtml
        /// Pages / Shared / Components / PlayerExpanded / _PlayerTest.cshtml
        /// Views / Shared / Components / PlayerExpanded / _PlayerTest.cshtml
        //return View<PlayerBiosData>("PlayerBios", PlayerBios);

        }
    }
}
