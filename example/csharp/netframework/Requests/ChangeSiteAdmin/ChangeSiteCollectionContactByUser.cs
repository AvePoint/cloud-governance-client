
namespace NetFramework
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;

    public class ChangeSiteCollectionContactByUser : TestBase
    {
        public ChangeSiteCollectionContactByUser(ApiConfig config) : base(config) { }

        public Guid Run(ChangeSiteAdminTestData data)
        {
            try
            {
                
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeSiteContactService(serviceId);
                var request = service.RequestTemplate;
                request.ChangeByUserSetting = new ChangeContactByUserSetting
                {
                    CurrentUser = new ApiUser { LoginName = data.CurrentUser },
                    NewUser = new ApiUser { LoginName = data.NewUser },
                    AlternativeUser = new ApiUser { LoginName = data.AlternateUser }
                };                
                request.Summary = $"Api_Sample_ChangeSCContactAdminByUser_Request_{DateTime.Now}";
                return this.RequestsApi.SubmitChangeSiteContactRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeSiteContactRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return Guid.Empty;
        }
    }
}
