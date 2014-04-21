using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyNancyApp.Models;
using Newtonsoft.Json;
using MyNancyApp.Models.interfaces;
namespace MyNancyApp.Handlers
{
    public class SortEpisodeJson : IDeserializeJsonFromImportIO<Episode>
    {
        public IEnumerable<Episode> getSortedJson()
        {
            string UserGuid = "c1819f5b-4dff-498f-93ee-850bd91f2d7e";
            string ApiKey = "f/oCir2D8KJtkUNmuhmKsVyyLH/oevGll9m3wDUSYnfMHbkCCa892sV08+l1xmPCLNDgZv6vvh/08VwmYJ3qOw==";
            string ExtractorGuid = "11f4b692-28bb-4ab6-8d24-de66d4d35c90";
            string WebpageUrl = "http://anilinkz.com/";
            ImportIOJson import = new ImportIOJson();
            var importedIOJson = import.getJson(UserGuid,ApiKey,ExtractorGuid,WebpageUrl);
            var deserializedJson = JsonConvert.DeserializeObject<ImportApiEpisodeResults>(importedIOJson);
            return deserializedJson.results;
        }
    }
}