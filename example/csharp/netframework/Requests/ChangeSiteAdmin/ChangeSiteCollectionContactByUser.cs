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
