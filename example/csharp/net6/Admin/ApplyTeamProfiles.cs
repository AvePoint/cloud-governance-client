namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public class ApplyTeamProfiles : TestBase
    {
        public ApplyTeamProfiles(ApiConfig authData) : base(authData) { }
        public void Run()
        {

            try
            {
                var apiInstance = new WorkspacesAdminApi(Configuration.Default);
                apiInstance.ApplyTeamProfiles(new ApplyTeamProfilesModel
                {
                    ProfileObjectType = ApiProfileObjectType.Team,
                    CancelEmailTemplateId = new Guid(),
                    ElectionProfile = new GuidModel(),
                    EnableElectionProfile = false,
                    EnableExternalSharingProfile = false,
                    EnableModernRenewalProfile = true,
                    EnableQuotaProfile = false,
                    ExternalSharingProfile = new GuidModel(),
                    Filter = "",
                    HandleOngoingType = HandleOngoingType.CancelOngoing,
                    HandleTaskType = HandleTaskType.OnlyRenewal,
                    IsSendCancelEmail = false,
                    ModernRenewalProfile = new GuidModel() { Id = new Guid("fb9f3879-f429-4283-a63f-d53c69260391"), Name = "Apply Team Renewal Sample Profile" },
                    QuotaProfile = new GuidModel(),
                    Search = "",
                    SelectedObjects = new List<String> { "807fc1d0-31ec-4617-bf38-9576ae46ddf0" },
                });
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspacesAdminApi.ApplyTeamProfiles: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}
