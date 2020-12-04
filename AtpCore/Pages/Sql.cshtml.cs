using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace AtpCore.Pages
{
    public class SqlModel : PageModel
    {

        public List<SqlClass> FavoriteMovie { get; set; } = new List<SqlClass>();

        public async Task<IActionResult> OnGetAsync()
        {
            List<SqlClass> movieList = new List<SqlClass>();

            var connectionString = "Server=atpassessmentserver.database.windows.net,1433;Database=AtpTour;";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.AccessToken = await (new Microsoft.Azure.Services.AppAuthentication.AzureServiceTokenProvider()).GetAccessTokenAsync("https://database.windows.net/");
                await conn.OpenAsync();
                var sql = "SELECT  * FROM [dbo].[FavoriteMovie]";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            SqlClass favoriteMovie = new SqlClass();
                            favoriteMovie.Name = Request.Form["txtboxName"];
                            favoriteMovie.FavoriteMovie = "Tester";
                            favoriteMovie.DateCreated = DateTime.Now.ToString();
                            movieList.Add(favoriteMovie);
                        }
                    }
                }
            }

            FavoriteMovie = movieList;
            return Page();

        }
    }
}
