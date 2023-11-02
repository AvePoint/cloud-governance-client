
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    
    using System;
    using Cloud.Governance.Client.Model;
    using System.Linq;

    public class ChangeGroupTeamHubsite : TestBase
    {
        public ChangeGroupTeamHubsite(ApiConfig authData) : base(authData) { }

        public Guid Run(ChangeGroupTeamsTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeGroupSettingService(serviceId);
                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);

                var request = service.RequestTemplate;
                request.Summary = $"Summary_ChangeTeamHubsite_{DateTime.Now}";
                request.GroupEmail = data.GroupEmail;
                request.HubSiteActionType = ChangeHubsiteActionType.AssociateToHubSite;
                request.GroupId = new Guid(group.Id);
                request.OriginalGroupName = group.DisplayName;
                if (request.HubSiteActionType == ChangeHubsiteActionType.AssociateToHubSite || request.HubSiteActionType == ChangeHubsiteActionType.UnRegisterAndAssociateToHubSite)
                {
                    var office365Api = new Office365Api(Configuration.Default);
                    var allHubSites = office365Api.GetHubSitesByUrl(data.AdminCenterUrl);
                    var hubSite = allHubSites.FirstOrDefault(site => site.Name.Equals(data.AssociateHubSiteTitle));
                    if (hubSite != null)
                    {
                        request.AssociateHubSiteTitle = hubSite.Name;
                        request.AssociateHubSiteId = hubSite.Id;
                    }
                }
                var result = this.RequestsApi.SubmitChangeGroupSettingRequest(request);

                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeGroupSettingRequest for ChangeTeamHubsite, exception: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
