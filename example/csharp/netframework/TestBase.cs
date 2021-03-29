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
    using System.Net;

    public class TestBase
    {

        public ServicesApi ServicesApi { get; set; }
        public RequestsApi RequestsApi { get; set; }
        public UsersApi UsersApi { get; set; }
        public SettingsApi SettingsApi { get; set; }

        public TestBase(ApiConfig config)
        {
            Configuration.Default.BasePath = config.ApiEndPoint;

            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", config.Secret);

            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", config.UserPrincipalName);

            this.ServicesApi = new ServicesApi(Configuration.Default);
            this.RequestsApi = new RequestsApi(Configuration.Default);
            this.UsersApi = new UsersApi(Configuration.Default);
            this.SettingsApi = new SettingsApi(Configuration.Default);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public ApiUser ResolveUser(String upn,
            ApiUserType apiUserType = ApiUserType.UserAndGroup,
            UserSource userSource = UserSource.Azure,
            ExternalSharingOptions sharingOptions = ExternalSharingOptions.Disabled)
        {
            return this.UsersApi.ResolveUsers(upn, apiUserType, userSource, sharingOptions).FirstOrDefault();
        }

        public List<ApiUser> ResolveUsers(String upn,
            ApiUserType apiUserType = ApiUserType.UserAndGroup,
            UserSource userSource = UserSource.Azure,
            ExternalSharingOptions sharingOptions = ExternalSharingOptions.Disabled)
        {
            return this.UsersApi.ResolveUsers(upn, apiUserType, userSource, sharingOptions);
        }

        public Guid GetServiceId(String serviceName)
        {
            return this.ServicesApi.GetServiceId(serviceName);
        }

        public void CancelRequest(Guid requestId)
        {
            this.RequestsApi.CancelRequest(requestId);
        }

        public List<RequestMetadata> GetMetadatas(Dictionary<String, String> metadata)
        {
            var result = new List<RequestMetadata>();
            if (metadata != null)
            {
                foreach (var kvp in metadata)
                {
                    result.Add(new RequestMetadata(name: kvp.Key, value: kvp.Value));
                }
            }
            return result;
        }
    }
}
