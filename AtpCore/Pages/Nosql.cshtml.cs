using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
//using Microsoft.Azure.Documents.Client;

namespace AtpCore.Pages
{
    public class NosqlModel : PageModel
    {

        private static string endpointUrl = "https://atp-assessment.documents.azure.com:443/";
        private static string authorizationKey = "xBe1N1J70dbq84gKoerzNpPZKAkmWLLdGdRlKMAAVn3zi0clkbx1qtHxlv4wae6QhbbY4bfT9O177FW4uviwDQ==";
        static DocumentClient client = new DocumentClient(new Uri(endpointUrl), authorizationKey);
        static Database database = client.CreateDatabaseQuery().Where(x => x.Id == "atpdb").AsEnumerable().FirstOrDefault();
        DocumentCollection collection = client.CreateDocumentCollectionQuery(database.SelfLink).Where(c => c.Id == "atpdata").ToArray().FirstOrDefault();
        // Set some common query options
        FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true };

        public List<NoSqlClass> FavoriteColor { get; set; } = new List<NoSqlClass>();

        public async Task<IActionResult> OnGetAsync()
        {
            List<NoSqlClass> colorsList = new List<NoSqlClass>();

            var docs = client.CreateDocumentQuery<NoSqlClass>(collection.SelfLink, queryOptions).AsEnumerable();

            foreach (var item in docs)
            {
                colorsList.Add(item);
            }

            FavoriteColor = colorsList;
            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                NoSqlClass colorData = new NoSqlClass
                {
                    Name = Request.Form["txtboxName"],
                    Color = Request.Form["colorFavoriteColor"],
                    Time = DateTime.Now.ToString(),
                    id = Guid.NewGuid().ToString(),
                };

                await client.CreateDocumentAsync(collection.SelfLink, colorData);
            }
            catch (Exception)
            {
                throw;
            }

            if (!this.ModelState.IsValid)
            {
                // Something failed. Redisplay the form.
                return await this.OnGetAsync();
            }

            return this.RedirectToPage("/Nosql");

        }

        public async Task<IActionResult> OnPostDelete(string id, string Name)
        {
            try
            {

                await client.DeleteDocumentAsync(
                    UriFactory.CreateDocumentUri("atpdb", "atpdata", id),
                    new RequestOptions { PartitionKey = new PartitionKey(Name) });

            }
            catch (Exception)
            {
                throw;
            }

            if (!this.ModelState.IsValid)
            {
                // Something failed. Redisplay the form.
                return await this.OnGetAsync();
            }

            return this.RedirectToPage("/Nosql");

        }
    }
}
