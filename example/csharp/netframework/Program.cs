using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;

namespace NetFramework
{
    internal class Program
    {
        private static Dictionary<String, JObject> jObjects = new Dictionary<String, JObject>();

        private static void Main(string[] args)
        {
            InitJsonFiles();

            var apiConfig = GetData<ApiConfig>("ApiConfig");

            var pendingInactivityTasks = new GetPendingInactivityTasks(apiConfig).Run(apiConfig.UserPrincipalName);

            if (pendingInactivityTasks.Count > 0)
            {
                var test1 = new SubmitAutoLifecyceTask(apiConfig);
                test1.Run(pendingInactivityTasks.First());
            }
        }

        private static T GetData<T>(String fileName)
        {
            return jObjects[fileName].ToObject<T>();
        }

        private static void InitJsonFiles()
        {
            var files = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "TestData"), "*.json", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var name = Path.GetFileNameWithoutExtension(file);
                var fileData = File.ReadAllText(file);

                var objData = JObject.Parse(fileData);
                jObjects[name] = objData;
            }
        }
    }
}