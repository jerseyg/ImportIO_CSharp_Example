using MinimalCometLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MyNancyApp.Handlers
{
    public class ImportIOJson
    {
        private static CountdownEvent countdownLatch;
        /// <summary>
        /// Stores the Json from query.import.io
        /// </summary>
        public string Json { get; set; }
      
        /// <summary>
        /// Retrieves the Json results from query.import.io
        /// </summary>
        /// <param name="UserGuid">Guid of import.io user</param>
        /// <param name="ApiKey">Api of import.io user</param>
        /// <param name="ExtractorGuid">Guid of the extractor</param>
        /// <param name="WebpageUrl">Website linked to the extractor</param>
        /// <returns></returns>
        public string getJson(string UserGuid, string ApiKey, string ExtractorGuid, string WebpageUrl)
        {
            ImportIO io = new ImportIO("https://query.import.io", Guid.Parse(UserGuid), ApiKey);
            io.Connect();

            countdownLatch = new CountdownEvent(1);

            // Query for tile Latest Episode
            Dictionary<String, Object> query1 = new Dictionary<String, Object>();
            query1.Add("connectorGuids", new List<String>() { ExtractorGuid });
            query1.Add("input", new Dictionary<String, String>() { {"webpage/url", WebpageUrl } });
            query1.Add("asObjects", "true");
            io.DoQuery(query1, HandleQuery);

            countdownLatch.Wait();

            io.Disconnect();
            return Json;
        }

        private void HandleQuery(Query query, Dictionary<String, Object> message)
        {
            if (message["type"].Equals("MESSAGE"))
            {
                Json = JsonConvert.SerializeObject(message["data"]);
            }

            if (query.isFinished) countdownLatch.Signal();

        }
    }
}