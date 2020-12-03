using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AtpCore.Pages
{
    public class SqlModel : PageModel
    {

        public List<SqlClass> FavoriteMovie { get; set; } = new List<SqlClass>();

        public async Task<IActionResult> OnGetAsync()
        {
            List<NoSqlClass> movieList = new List<NoSqlClass>();

            var docs = client.CreateDocumentQuery<NoSqlClass>(collection.SelfLink, queryOptions).AsEnumerable();

            foreach (var item in docs)
            {
                colorsList.Add(item);
            }

            FavoriteMovie = movieList;
            return Page();

        }
    }
}
