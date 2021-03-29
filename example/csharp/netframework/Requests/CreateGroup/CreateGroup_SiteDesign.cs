
namespace NetFramework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    public class CreateGroup_SiteDesign : TestBase
    {
        public CreateGroup_SiteDesign(ApiConfig config) : base(config) { }

        public Guid Run(CreateGroupTestData data)
        {
            try
            {
                var serviceName = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateGroupService(serviceName);
                var request = service.RequestTemplate;
                request.Summary = $"Summary_{DateTime.Now}";
                request.PrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName };
                request.SecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName };
                request.Owners = data.OwnerList.Split(';').Select(s => new ApiUser() { LoginName = s }).ToList();
                var ticks = DateTime.Now.Ticks;
                request.GroupName = "Api_Sample_Group_" + ticks;
                request.GroupId = "Api_Sample_Group_" + ticks;
                if (service.SiteDesignAssignBy == AssignBy.BusinessUser
                    || service.SiteDesignAssignBy == AssignBy.BusinessUserWithRequired
                    && service.SiteDesigns.Any(d => d.Name.Equals(data.SiteDesignName, StringComparison.CurrentCultureIgnoreCase)))
                {
                    request.AppliedSiteDesignId = service.SiteDesigns.Find(d => d.Name.Equals(data.SiteDesignName, StringComparison.CurrentCultureIgnoreCase)).Id;
                }
                return this.RequestsApi.SubmitCreateGroupRequest(request);

            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateGroupRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}
