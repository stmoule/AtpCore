using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace AtpCore.Pages
{
    public class NosqlModel : PageModel
    {

        private static string endpointUrl = "https://hla.documents.azure.com:443/";
        private static string authorizationKey = "e8cl4Gz9KPZsVA2FYopbdfQaoBleqwjE4yxiwBeCp2wTeyAP4zbqTs9V6dBg2JgI4YONMVXt2yfJuHqUFt0dVA==";
        static DocumentClient client = new DocumentClient(new Uri(endpointUrl), authorizationKey);
        static Database database = client.CreateDatabaseQuery().Where(x => x.Id == "hladb").AsEnumerable().FirstOrDefault();
        DocumentCollection collection = client.CreateDocumentCollectionQuery(database.SelfLink).Where(c => c.Id == "atpTour").ToArray().FirstOrDefault();
        // Set some common query options
        FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true };

        public void OnGet()
        {
            PlayerJson docs = client.CreateDocumentQuery<PlayerJson>(collection.SelfLink, queryOptions)
            .Where(r => r.PlayerId == playerId)
            .AsEnumerable()
            .SingleOrDefault();
        }
    }
}
