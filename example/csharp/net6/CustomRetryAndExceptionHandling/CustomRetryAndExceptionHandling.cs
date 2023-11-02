using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class CustomRetryAndExceptionHandling : TestBase
    {
        public CustomRetryAndExceptionHandling(ApiConfig authData) : base(authData)
        {
            //RetryConfiguration.RetryPolicy = Polly.Policy<RestSharp.IRestResponse>.HandleResult(response => response.StatusCode != HttpStatusCode.OK).WaitAndRetry(new[]
            //    {
            //        TimeSpan.FromSeconds(1)
            //    });
        }

        /// <summary>
        /// get pending approval tasks for group/team/site inactivity
        /// </summary>
        /// <param name="assignee">example:someone@example.com</param>
        public List<TaskList> Run(String assignee)
        {
            Configuration.Default.AddApiKey("userPrincipalName", assignee);
            var apiInstance = new TasksApi(Configuration.Default);
            //apiInstance.ExceptionFactory = (method, resp) => HandleException(method, resp);
            var filter = $"tasktype1 eq '{TaskType.GroupInactivityThreshold}' or tasktype eq '{TaskType.SCNoAccess}'";
            var orderby = "createdtime desc";
            String nextToken = null;
            var result = new List<TaskList>();
            try
            {
                do
                {
                    var pageResult = apiInstance.GetMyTasks(TaskApprovalStatus.PendingConfirm, filter, orderby, nexttoken: nextToken);
                    if (pageResult != null && pageResult.Value != null)
                    {
                        result.AddRange(pageResult.Value);
                        nextToken = pageResult.NextToken;
                    }
                } while (nextToken != null);
            }catch(Exception e)
            {

            }
            return result;
        }

        private Exception HandleException(String method, IApiResponse response)
        {
            return new Exception($"Your custom exception handler for {method}, error message:{response?.ErrorText}");
        }
    }
}