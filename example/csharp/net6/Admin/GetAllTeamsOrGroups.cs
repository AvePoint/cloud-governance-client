
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class GetAllTeamsOrGroups : TestBase
    {
        public GetAllTeamsOrGroups(ApiConfig authData) : base(authData) { }

        public List<WorkspaceGridModel> Run()
        {
            var result = new List<WorkspaceGridModel>();
            try
            {
                var apiInstance = new WorkspacesAdminApi(Configuration.Default);
                String nextToken = null;
                do
                {
                    var pageResult = apiInstance.GetWorkspaces(filter: "type eq 'Group' or type eq 'Teams'", nexttoken: nextToken);
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
                Console.WriteLine("Exception when calling AdminWorkspaceReportAPI.Query: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return result;
        }
    }
}
