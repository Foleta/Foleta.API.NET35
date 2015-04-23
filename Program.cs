using System.Collections.Generic;

namespace Foleta.API.NET35
{
    /// <summary>
    /// Example application for .NET 3.5.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Settings
            const string apiAddress = "API-ADDRESS";
            const string apiKey = "API-KEY";

            // Init the client
            var client = new FoletaApiClient(apiAddress, apiKey);

            // Execute request
            var departments = client.Get<List<Department>>("department/?schoolId=406&schoolYearId=72");
        }
    }
}
