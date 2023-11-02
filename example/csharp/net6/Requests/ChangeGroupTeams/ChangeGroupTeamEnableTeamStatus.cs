
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    
    using System;
    using Cloud.Governance.Client.Model;
    using System.Linq;

    public class ChangeGroupTeamEnableTeamStatus : TestBase
    {
        public ChangeGroupTeamEnableTeamStatus(ApiConfig authData) : base(authData) { }

        public Guid Run(ChangeGroupTeamsTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeGroupSettingService(serviceId);
                
                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);

                var request = service.RequestTemplate;
                request.Summary = $"Summary_EnableTeam_{DateTime.Now}";
                request.GroupEmail = data.GroupEmail;
                request.EnableTeams = data.EnableTeams;
                request.GroupId = new Guid(group.Id);
                request.OriginalGroupName = group.DisplayName;
                var result = this.RequestsApi.SubmitChangeGroupSettingRequest(request);

                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeGroupSettingRequest for EnableTeam, exception: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
