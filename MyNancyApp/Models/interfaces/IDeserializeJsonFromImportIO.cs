using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNancyApp.Models.interfaces
{
    public interface IDeserializeJsonFromImportIO<T>
    {
        /// <summary>
        /// General method for deseriavlizing Json from import.io
        /// </summary>
        /// <returns>the model of the Json in a generic list</returns>
        IEnumerable<T> getSortedJson();
    }
}