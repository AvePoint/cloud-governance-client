
namespace NetFramework
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;

    public class ChangeSiteCollectionContactByUrl : TestBase
    {
        public ChangeSiteCollectionContactByUrl(ApiConfig config) : base(config) { }

        public Guid Run(ChangeSiteAdminTestData data)
        {
            try
            {
                
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var validateResult = this.ServicesApi.ValidateForChangeSiteContactService(serviceId, 
                    new SiteValidationParameter
                    {
                        Uri = data.SiteUrl,                    
                    });
                var service = this.ServicesApi.GetChangeSiteContactService(serviceId);
                var request = service.RequestTemplate;
                request.ChangeByUrlSetting = new List<ChangeContactByUrlSetting>();
                var setting = new ChangeContactByUrlSetting
                {
                    SiteUrl = data.SiteUrl,
                    SiteId = validateResult.SiteId,
                    NewPrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName},
                    NewSecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName },
                    NewPrimaryAdministrator = validateResult.PrimaryAdministrator,
                    NewAdditionalAdministrators = validateResult.AdditionalAdministrators
                };
                request.ChangeByUrlSetting.Add(setting);
                request.Summary = $"Api_Sample_ChangeSCContactByUrl_Request_{DateTime.Now}";
                return this.RequestsApi.SubmitChangeSiteContactRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeSiteContactRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
