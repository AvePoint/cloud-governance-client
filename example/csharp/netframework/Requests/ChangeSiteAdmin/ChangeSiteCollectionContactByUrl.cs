/********************************************************************
 *
 *  PROPRIETARY and CONFIDENTIAL
 *
 *  This file is licensed from, and is a trade secret of:
 *
 *                   AvePoint, Inc.
 *                   525 Washington Blvd, Suite 1400
 *                   Jersey City, NJ 07310
 *                   United States of America
 *                   Telephone: +1-201-793-1111
 *                   WWW: www.avepoint.com
 *
 *  Refer to your License Agreement for restrictions on use,
 *  duplication, or disclosure.
 *
 *  RESTRICTED RIGHTS LEGEND
 *
 *  Use, duplication, or disclosure by the Government is
 *  subject to restrictions as set forth in subdivision
 *  (c)(1)(ii) of the Rights in Technical Data and Computer
 *  Software clause at DFARS 252.227-7013 (Oct. 1988) and
 *  FAR 52.227-19 (C) (June 1987).
 *
 *  Copyright © 2021 AvePoint® Inc. All Rights Reserved. 
 *
 *  Unpublished - All rights reserved under the copyright laws of the United States.
 */
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
