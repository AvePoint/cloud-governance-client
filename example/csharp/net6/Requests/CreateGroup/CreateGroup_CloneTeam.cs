using System;
using System.Linq;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace NetFramework
{
    public class CreateGroup_CloneTeam : TestBase
    {
        public CreateGroup_CloneTeam(ApiConfig config) : base(config) { }

        public Guid Run(CreateGroupTestData data)
        {

            try
            {
                var requestApi = new RequestsApi(Configuration.Default);
                var serviceApi = new ServicesApi(Configuration.Default);

                var serviceName = serviceApi.GetServiceId(data.ServiceName);
                var service = serviceApi.GetCreateGroupService(serviceName);
                var request = service.RequestTemplate;


                request.Summary = $"Summary_{DateTime.Now}";

                request.PrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName };
                request.SecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName };
                request.Owners = data.OwnerList.Split(';').Select(s => new ApiUser() { LoginName = s }).ToList();
                var findTargetGroup = service.TemplateSettings.TemplateTeams.FirstOrDefault(t => String.Equals(t.Id.ToString(), data.CloneTeamId, StringComparison.OrdinalIgnoreCase));
                if (findTargetGroup == null)
                {
                    throw new Exception(data.CloneTeamId + "does not find from service");
                }
                request.TemplateSettings = new TeamsTemplateSettings
                {
                    SelectedTemplate = new GuidModel
                    {
                        Id = findTargetGroup.Id,
                        Name = findTargetGroup.Name
                    },
                    EnableCreateTeamFromExistTeam = true,
                    EnableCloneTabs = true
                };
                var ticks = DateTime.Now.Ticks;
                request.GroupName = "Api_Sample_Group_" + ticks;
                request.GroupId = "Api_Sample_Group_" + ticks;
                return requestApi.SubmitCreateGroupRequest(request);

            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}