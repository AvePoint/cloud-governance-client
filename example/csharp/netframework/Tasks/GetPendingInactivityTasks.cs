using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class GetPendingInactivityTasks : TestBase
    {
        public GetPendingInactivityTasks(ApiConfig authData) : base(authData) { }

        /// <summary>
        /// get pending approval tasks for group/team/site inactivity
        /// </summary>
        /// <param name="assignee">example:someone@example.com</param>
        public void Run(String assignee)
        {
            Configuration.Default.AddApiKey("userPrincipalName", assignee);
            var apiInstance = new TasksApi(Configuration.Default);
            var filter = $"tasktype eq '{TaskType.GroupInactivityThreshold}' or tasktype eq '{TaskType.SCNoAccess}'";
            var orderby = "createdtime desc";
            String nextToken = null;
            var result = new List<TaskList>();
            do
            {
                var pageResult = apiInstance.GetMyTasks(TaskApprovalStatus.PendingConfirm, filter, orderby, nexttoken: nextToken);
                if (pageResult != null && pageResult.Value != null)
                {
                    result.AddRange(pageResult.Value);
                    nextToken = pageResult.NextToken;
                }
            } while (nextToken != null);
        }
    }
}

