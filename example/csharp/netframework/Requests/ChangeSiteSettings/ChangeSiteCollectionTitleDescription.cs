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
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;

    public class ChangeSiteCollectionTitleDescription : TestBase
    {
        public ChangeSiteCollectionTitleDescription(ApiConfig config) : base(config) { }

        public Guid Run(ChangeSiteSettingTestData data)
        {
            try
            {
                
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeSiteSettingService(serviceId);
                var request = service.RequestTemplate;
                var validateResult = this.ServicesApi.ValidateForChangeSiteSettingService(serviceId,
                    new SiteValidationParameter
                    {
                        Uri = data.SiteUrl,
                    });
                request.SiteId = validateResult.SiteId;
                request.SiteUrl = data.SiteUrl;
                request.SiteTitleSetting.ChangeValue = data.NewTitle;
                request.SiteDescriptionSetting.ChangeValue = data.NewDescription;
                request.Summary = $"Api_Sample_ChangeSiteSettings_Request";
                return this.RequestsApi.SubmitChangeSiteSettingRequest(request);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitChangeSiteSettingRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
