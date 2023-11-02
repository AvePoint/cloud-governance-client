
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;

    public class AutoCompleteRenew : TestBase
    {
        public AutoCompleteRenew(ApiConfig authData) : base(authData) { }

        public Boolean Run(WorkspaceActionTestData data)
        {
            var result = true;
            var workspace = new WorkspaceIdTypeModel
            {
                ObjectId = data.ObjectId,
                WorkspaceType = data.WorkspaceType
            };
            try
            {
                var markAsCancel = true;

                var apiInstance = new WorkspacesAdminApi(Configuration.Default);
                apiInstance.CompleteWorkspaceRenewalTask(autoCompleteRenewalTaskParameter: new AutoCompleteRenewalTaskParameter
                {
                    IsMarkAsCanceled = markAsCancel,
                    Workspace = new List<WorkspaceIdTypeModel> { workspace }
                });
            }
            catch (ApiException e)
            {
                result = false;
                Console.WriteLine("Exception when calling AdminWorkspaceReportAPI.Query: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return result;
        }
    }
}
