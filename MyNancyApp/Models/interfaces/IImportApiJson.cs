using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNancyApp.Models.interfaces
{
    /// <summary>
    /// Interface for the Json from ImportIO
    /// </summary>
    public interface IImportApiJson<T>
    {
        string offset { get; set; }
        IEnumerable<T> results { get; set; }
        List<String> cookies { get; set; }
        string connectorVersionGuid { get; set; }
        string connectorGuid { get; set; }
        string pageUrl { get; set; }
    }
}