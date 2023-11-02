namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class SubmitAutoLifecyceTask : TestBase
    {
        public SubmitAutoLifecyceTask(ApiConfig authData) : base(authData)
        {
        }

        public Boolean Run(TaskList task)
        {
            try
            {
                var apiInstance = new TasksApi(Configuration.Default);
                var comments = new CommentsParam("Test");
                apiInstance.SubmitContinueAccessSiteAutoTaskAsync(task.Id, comments).GetAwaiter().GetResult();
                return true;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TasksApi.SubmitContinueAccessSiteAutoTaskAsync: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
    }
}