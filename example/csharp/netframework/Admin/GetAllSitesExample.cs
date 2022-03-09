namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public class GetAllSitesExample : TestBase
    {
        public GetAllSitesExample(ApiConfig authData) : base(authData) { }

        public void Run()
        {

            try
            {
                var apiInstance = new WorkspacesAdminApi(Configuration.Default);
                var result = new List<WorkspaceGridModel>();
                String nextToken = null;
                do
                {
                    var pageResult = apiInstance.GetWorkspaces(nexttoken: nextToken);
                    if (pageResult != null && pageResult.Value != null)
                    {
                        result.AddRange(pageResult.Value);
                        nextToken = pageResult.NextToken;
                    }
                } while (nextToken != null);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitLockSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}
