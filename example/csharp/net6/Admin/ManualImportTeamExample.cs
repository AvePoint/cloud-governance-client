namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ManualImportTeamExample : TestBase
    {
        public ManualImportTeamExample(ApiConfig authData) : base(authData) { }

        public void Run()
        {
            try
            {
                var localFilePath = "c:\\import.xlsx";
                ManualImportTeam(localFilePath, Configuration.Default).GetAwaiter().GetResult();
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.ManualImportTeam: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }

        public static async Task ManualImportTeam(String localFilePath, Configuration config)
        {
            var office365AdminApi = new Office365AdminApi(config);
            var sasUriModel = await office365AdminApi.GetUploadFileUrLAsync(ApiUploadFileType.ManualImport, $"import_{DateTime.Now}.xlsx");

            var client = new HttpClient();
            var content = new StreamContent(new MemoryStream(File.ReadAllBytes(localFilePath)));
            content.Headers.Add("x-ms-blob-type", "BlockBlob");
            content.Headers.Add("Content-Type", "text/plain");
            using (var response = await client.PutAsync(sasUriModel.Uri, content))
            {
                Console.WriteLine(response.StatusCode);
            }

            var unmanagedDirectoryAdminApi = new UnmanagedDirectoryAdminApi(config);
            await unmanagedDirectoryAdminApi.ImportUnmanagedTeamsAsync(new ManualImportTeamJobModel
            {
                ObjectType = ImportObjectType.Team,
                InactiveJobTimeBaseType = LifecycleJobTimeBaseType.ImportedTime,
                Name = "Test Name",
                Description = "Test Description",
                FileName = sasUriModel.FileName,
            });
        }
    }
}
