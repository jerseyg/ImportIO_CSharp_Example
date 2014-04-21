using Nancy;
using MyNancyApp.Handlers;
using Newtonsoft.Json;
using MyNancyApp.Models;
using Nancy.ViewEngines.Razor;
using MyNancyApp.Models.interfaces;
namespace MyNancy.Modules
{
    //using System.IO;

    public class IndexModule : NancyModule
    {
        /// <summary>
        /// Routing module to index
        /// </summary>
        public IndexModule()
        {
            Get["/"] = Index;
        }
        private dynamic Index(dynamic parameters)
        {
            IDeserializeJsonFromImportIO<Episode> episodes = new SortEpisodeJson();
            var episodeModel = episodes.getSortedJson();
            return View["Index",episodeModel];
        }
  
    }
}