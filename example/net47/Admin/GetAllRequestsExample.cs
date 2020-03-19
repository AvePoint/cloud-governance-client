namespace Example
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public class GetAllRequestsExample : ExampleBase
    {
        public override void Run()
        {

            try
            {
                var apiInstance = new RequestsDirectoryAdminApi(Configuration.Default);
                var result = new List<AllRequestList>();
                var nl = new NextLink();
                while (nl != null)
                {
                    var pageResult = apiInstance.GetAllRequests(nl.Filter, nl.OrderBy, nl.Search, nl.Top, nl.Skip);
                    nl = null;
                    if (pageResult != null && pageResult.Value != null)
                    {
                        result.AddRange(pageResult.Value);
                        if (!String.IsNullOrEmpty(pageResult.NextLink))
                        {
                            nl = new NextLink(pageResult.NextLink);
                        }
                    }
                }
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
