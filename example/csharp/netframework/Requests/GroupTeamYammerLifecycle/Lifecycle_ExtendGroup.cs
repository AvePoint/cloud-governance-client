namespace NetFramework
{
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Net;
    public class Lifecycle_ExtendGroup : TestBase
    {
        public Lifecycle_ExtendGroup(ApiConfig config) : base(config) { }

        public Guid Run(GroupTeamYammerLifecycleTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetGroupLifecycleService(serviceId);

                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);
                var request = new ExtendGroupRequest()
                {
                    ServiceId = serviceId,
                    GroupId = new Guid(group.Id),
                    Summary = $"Summary_{DateTime.Now}",
                    GroupObjectType = GroupObjectType.Group,
                    //Department = service.Department,
                    ExtendDuration = 1,
                    ExtendDurationType = ApiDurationType.Week
                };
                var id = this.RequestsApi.SubmitExtendGroupRequest(request);
                return id;
            }
            catch(ApiException ex)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitExtendGroupRequest: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
            
        }
    }
}
