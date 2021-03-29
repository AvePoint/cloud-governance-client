using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetFramework
{
    public class Lifecycle_ArchiveTeam :TestBase
    {
        public Lifecycle_ArchiveTeam(ApiConfig config) : base(config) { }

        public Guid Run(GroupTeamYammerLifecycleTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetGroupLifecycleService(serviceId);

                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);

                var request = new ArchiveGroupRequest()
                {
                    ServiceId = serviceId,
                    GroupId = new Guid(group.Id),
                    Summary = $"Summary_{DateTime.Now}",
                    GroupObjectType = GroupObjectType.Team,
                    Department = service.Department
                };

                var id = this.RequestsApi.SubmitArchiveGroupRequest(request);
                return id;
            }
            catch(ApiException ex)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitArchiveGroupRequest: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }
    }
}
