using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNancyApp.Models
{
    /// <summary>
    /// Episode Model for ImportIO Json results
    /// </summary>
    public class Episode
    {
        public string title {get;set;}
        public string created { get; set; }
        public string video { get; set; }
        public string episode_no { get; set; }
    }
}