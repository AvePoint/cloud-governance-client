using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace NetFramework
{
    class Program
    {
        /// <summary>
        /// please modify the json file  under TestData/Files accordingly
        /// </summary>
        const String ApiConfig_Path = "TestData/Files/ApiConfig.json";
        const String CreateSite_Basic_Path = "TestData/Files/Requests/CreateSite/Basic.json";

        static void Main(string[] args)
        {
            try
            {
                var apiConfig = GetData<ApiConfig>(ApiConfig_Path);

                var createSiteRequestData = GetData<CreateSiteTestData>(CreateSite_Basic_Path);

                var requestId = new CreateSite_Basic(apiConfig).Run(createSiteRequestData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static T GetData<T>(String filePath)
        {

            var dataFilePath = Path.Combine(Directory.GetCurrentDirectory(), filePath);
            if (!File.Exists(dataFilePath))
            {
                throw new ArgumentException($"Could not find file at path: {dataFilePath}");
            }

            // Load the file
            var fileData = File.ReadAllText(dataFilePath);

            return JObject.Parse(fileData).ToObject<T>();
            
        }
    }
}
