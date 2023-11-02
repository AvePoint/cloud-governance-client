
namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    
    using System;
    using Cloud.Governance.Client.Model;
    using System.Linq;
    using System.Collections.Generic;

    public class ChangeGroupTeamMetadata : TestBase
    {
        public ChangeGroupTeamMetadata(ApiConfig authData) : base(authData) { }

        public Guid Run(ChangeGroupTeamsTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeGroupSettingService(serviceId);
                if (service.EnableAddOrDeleteMetadata)
                {
                    var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);
                    var request = service.RequestTemplate;
                    var metadataLists = service.MetadataList;
                    request.Summary = $"Summary_ChangeTeamMetadata_{DateTime.Now}";
                    request.GroupEmail = data.GroupEmail;
                    request.GroupId = new Guid(group.Id);
                    request.OriginalGroupName = group.DisplayName;
                    request.ChangedDynamicGroupType = AddGroupMemberType.Manually;
                    request.GroupMetadatas = new List<RequestMetadata>();
                    metadataLists.ForEach(meta =>
                    {
                        var requestMetadata = new RequestMetadata()
                        {
                            Action = MetadataActionType.Add,
                            Type = meta.Type,
                            Id = meta.Id,
                            Name = meta.Name,
                            SingleLineOrMultipleLineValue = "Test"
                        };
                        request.GroupMetadatas.Add(requestMetadata);
                    });

                    var result = this.RequestsApi.SubmitChangeGroupSettingRequest(request);
                    return result;
                }
                return Guid.Empty;
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
