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

    public class ChangeListSettings_Version : TestBase
    {
        public ChangeListSettings_Version(ApiConfig config) : base(config) { }

        public Guid Run(ChangeListSettingsTestData data)
        {
            try
            {
                var result = Guid.Empty;
                var serviceApi = new ServicesApi(Configuration.Default);
                var requestApi = new RequestsApi(Configuration.Default);
                var serviceId = serviceApi.GetServiceId(data.ServiceName);
                var service = serviceApi.GetChangeListSettingService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"{data.Summary}_{DateTime.Now}";

                var validationParameters = new SiteValidationParameter
                {
                    Uri = data.Uri,
                    IgnoreLock = false
                };
                var validationResult = serviceApi.ValidateForChangeListSettingService(serviceId, validationParameters);
                var originalInfo = validationResult.Lists[0];

                request.ObjectInfo.WebUrl = validationResult.WebUrl;
                request.ObjectInfo.SiteUrl = validationResult.SiteUrl;
                request.ObjectInfo.ObjectUrl = originalInfo.Url;

                // not required
                request.ListTitle.ChangeValue = originalInfo.Title;
                request.ListDescription.ChangeValue = originalInfo.Description;

                // not required
                request.NavigationSetting.OriginalValue = request.NavigationSetting.ChangeValue = originalInfo.IsOnQuickLaunch;

                // not required
                request.VersionSetting.OriginalValue = request.VersionSetting.ChangeValue = new ListVersionSettings
                {
                    RequireContentApproval = originalInfo.IsEnableModeration,
                    ListType = originalInfo.IsLibrary ? ListType.Library : ListType.List,
                    EnableMajorAndMinorVersions = originalInfo.IsEnableModeration && originalInfo.IsEnableVersioning && originalInfo.IsEnableMinorVersion,
                    EnableMajorVersionLimit = originalInfo.IsEnableVersioning,
                    EnableMajorVersions = originalInfo.IsEnableVersioning,
                    MajorVersionLimit = originalInfo.MajorVersionLimit,
                    EnableMinorVersionLimit = originalInfo.IsEnableMinorVersion,
                    MinorVersionsLimit = originalInfo.MajorWithMinorVersionsLimit
                };

                request.VersionSetting.ChangeValue = new ListVersionSettings
                {
                    ListType = originalInfo.IsLibrary ? ListType.Library : ListType.List,
                    RequireContentApproval = true,
                    EnableMajorVersions = true,
                    EnableMajorAndMinorVersions = true,
                    EnableMajorVersionLimit = true,
                    MajorVersionLimit = data.MajorVersionLimit + 1,
                    EnableMinorVersionLimit = true,
                    MinorVersionsLimit = data.MinorVersionLimit + 1,
                };

                result = requestApi.SubmitChangeListSettingRequest(request);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine($"An error occurred while changing list settings and calling ");
                Console.WriteLine($"Status code: {e.ErrorCode}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
