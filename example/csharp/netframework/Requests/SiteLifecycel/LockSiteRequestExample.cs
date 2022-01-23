namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public class LockSiteRequestExample : ExampleBase
    {
        public LockSiteRequestExample(ApiConfig authData) : base(authData) { }

        public void Run()
        {

            try
            {
                var siteUrl = "https://xxxx.sharepoint.com/sites/CreateSiteCollectionaaa";
                var apiInstance = new RequestsApi(Configuration.Default);
                var lockSiteRequest = new LockSiteRequest
                {
                    Summary = "lock site",
                    ServiceId = new Guid("906d41ea-b79d-4541-97b7-df107a2dba7b"),
                    Action = SiteLifecycleActionType.Lock,
                    SiteUrl = siteUrl,
                    SiteId = new Guid("c3c8d93d-10d7-4a0b-98b1-37fd604711a9"),
                    LockType = SiteLockType.ReadOnly,
                    Metadatas = this.GetMetadatas(null)
                };

                // submit lock site request
                Guid result = apiInstance.SubmitLockSiteRequest(lockSiteRequest);
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
