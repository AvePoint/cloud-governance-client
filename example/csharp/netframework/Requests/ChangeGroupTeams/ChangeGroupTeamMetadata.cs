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
