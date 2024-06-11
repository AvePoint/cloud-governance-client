namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ManualImportTeamExample : TestBase
    {
        public ManualImportTeamExample(ApiConfig authData) : base(authData) { }

        public void Run()
        {
            try
            {
                ManualImportTeam(Configuration.Default).GetAwaiter().GetResult();
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.ManualImportTeam: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }

        public static async Task ManualImportTeam(Configuration config)
        {
            var unmanagedDirectoryAdminApi = new UnmanagedDirectoryAdminApi(config);
            await unmanagedDirectoryAdminApi.ImportUnmanagedTeamsAsync(new ManualImportTeamJobModel
            {
                ObjectType = ImportObjectType.Team,
                InactiveJobTimeBaseType = LifecycleJobTimeBaseType.ImportedTime,
                IsIncludeArchivedTeams = true,
                Name = "Test Name",
                Description = "Test Description",
                Workspaces = new List<ImportTeamModel>
                {
                    new ImportTeamModel
                    {
                        TeamName = "Team Name",
                        EmailAddress = "EmailAddress@xxx.com",
                        IsKeepSiteQuota = true,
                        AppSetting = AppSettingType.None,
                        PrimaryContact = "user1@xxx.com",
                        SecondaryContact = "user2@xxx.com",
                        ExternalSharingProfile = "External Sharing Profile Name",
                        StorageManagementProfile = "Storage Management Profile Name",
                        ContactElectionProfile = "Contact Election Profile Name",
                        RenewalProfile = "Renewal Profile Name",
                        Metadatas = new List<ImportMetadataModel>
                        {
                            new ImportMetadataModel
                            {
                                Name = "Metadata Name",
                                Value = "Metadata Value",
                            }
                        }
                    }
                }
            });
        }
    }
}
