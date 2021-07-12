namespace NetFramework
{
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Net;
    public class Lifecycle_ChangeGroupQuota : TestBase
    {
        public Lifecycle_ChangeGroupQuota(ApiConfig config) : base(config) { }

        public Guid Run(GroupTeamYammerLifecycleTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetGroupLifecycleService(serviceId);

                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);

                long quota = data.GroupQuotaSize;
                var request = new ChangeGroupQuotaRequest()
                {
                    ServiceId = serviceId,
                    GroupId = new Guid(group.Id),
                    Summary = $"Summary_{DateTime.Now}",
                    GroupObjectType = GroupObjectType.Group,
                    //Department = service.Department,
                    GroupQuotaSize = quota
                    
                };

                var id = this.RequestsApi.SubmitChangeGroupQuotaRequest(request);
                return id;
            }
            catch(ApiException ex)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeGroupQuotaRequest: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }
    }
}
