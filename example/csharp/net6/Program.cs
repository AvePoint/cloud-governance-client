using Newtonsoft.Json.Linq;

namespace NetFramework
{
    internal class Program
    {
        private static Dictionary<String, JObject> jObjects = new Dictionary<String, JObject>();

        private static void Main(string[] args)
        {
            InitJsonFiles();

            var apiConfig = GetData<ApiConfig>("ApiConfig");

            var createSiteRequestData = GetData<CreateSiteTestData>("Basic");

            var requestId = new CreateSite_Basic(apiConfig).Run(createSiteRequestData);
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