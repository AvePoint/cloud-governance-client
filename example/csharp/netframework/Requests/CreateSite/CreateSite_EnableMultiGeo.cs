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
    using System.Linq;
    using System.Collections.Generic;

    public class CreateSite_EnableMultiGeo : TestBase
    {
        public CreateSite_EnableMultiGeo(ApiConfig config) : base(config) { }

        public void Run(CreateSiteTestData data)
        {

            try
            {
                

                var serviceName = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateSiteService(serviceName);
                var request = service.RequestTemplate;

                request.SiteUrl.Name = $"Api_{DateTime.Now}";
                request.Summary = $"Summary_{DateTime.Now}";
                request.SiteTitle = $"Title_{DateTime.Now}";
                request.PrimaryContact = new ApiUser { LoginName = data.PrimaryContactLoginName };
                request.SecondaryContact = new ApiUser { LoginName = data.SecondaryContactLoginName };

                var allLocations = service.MultiGeoSetting.AllLocations;
                var location= allLocations.First(l => l.DisplayName.Equals(data.MultiGeoLocatioinName, StringComparison.CurrentCultureIgnoreCase));
                request.MultiGeoLocation = new GeoLocationBase(name: location.Name);

                var result = this.RequestsApi.SubmitCreateSiteRequest(request);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
