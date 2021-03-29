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

    public class CreateLibrary_EnableVersion : TestBase
    {
       public CreateLibrary_EnableVersion(ApiConfig config) : base(config) { }

       public Guid Run(CreateListOrLibraryTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetCreateListService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"{data.Summary}_{DateTime.Now}";
                request.ListTitle = $"{data.LibraryTitle}_{DateTime.Now}";
                request.ListType = (ListType)Enum.Parse(typeof(ListType), data.Library);
                request.ListName = $"{data.LibraryName}_{DateTime.Now}";
                request.ParentObject.ParentUrl = data.WebUrl;
                request.ParentObject.SiteUrl = data.SiteUrl;
                request.ListTemplate = data.LibraryTemplate;

                request.VersionSettings.RequireContentApproval = false;
                request.VersionSettings.EnableMajorAndMinorVersions = true;
                request.VersionSettings.EnableMajorVersionLimit = true;
                request.VersionSettings.MajorVersionLimit = data.MajorVersionLimit;
                request.VersionSettings.EnableMinorVersionLimit = true;
                request.VersionSettings.MinorVersionsLimit = data.MinorVersionLimit;

                var result = this.RequestsApi.SubmitCreateListRequest(request);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine($"An error occurred while creating library with version and calling RequestsApi.SubmitCreateListRequest: {e}");
                Console.WriteLine($"Status code: {e.ErrorCode}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
