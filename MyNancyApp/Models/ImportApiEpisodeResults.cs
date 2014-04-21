using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using MyNancyApp.Models.interfaces;
namespace MyNancyApp.Models
{
    /// <summary>
    /// Model for ImportIO Json with Episode Model argument
    /// </summary>
    public class ImportApiEpisodeResults: IImportApiJson<Episode>
    {
        public string offset {get; set;}
        public IEnumerable<Episode>results{ get; set;}
        public List<String> cookies { get; set; }
        public string connectorVersionGuid {get; set;}
        public string connectorGuid{ get; set; }
        public string pageUrl { get; set; }
    }
}