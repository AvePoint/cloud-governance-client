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
    using System.Collections.Generic;

    public class Site_AddSharepointGroup_AddOwnerAndMember : TestBase
    {
        public Site_AddSharepointGroup_AddOwnerAndMember(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {


                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_AddGroup_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                request.Department = data.Department;
                request.PermissionManagement = new PermissionManagementModel()
                {
                    IsUniquePermission = true,
                    PermissionItems = new List<ObjectPermissionManagementModel>()
                };
                var groupMemberLoginNames = data.SpGroupMemberIdentityName.Split(';');
                //var groupMemberDisplayNames = data.SpGroupMemberDisplayName.Split(';');
                var spGroup = new SPGroupManagementModel
                {
                    Name = new StringChangedProperty()
                    {
                        OriginalValue = data.SpGroupNameOriginalValue,
                        ChangeValue = data.SpGroupNameChangeValue
                    },
                    Description = data.SpGroupDescription,
                    Owner = new ApiUser()
                    {
                        LoginName = data.SpGroupOwnerLoginName,
                    },
                    Members = new List<SPUserManagementModel>(),
                    Action = ManagePermissionAction.Added
                };
                for (int i = 0; i < groupMemberLoginNames.Length; i++)
                {
                    spGroup.Members.Add(new SPUserManagementModel()
                    {
                        IdentityName = groupMemberLoginNames[i],
                        //DisplayName = groupMemberDisplayNames[i],
                        Action = ManagePermissionAction.Added
                    });
                }
                request.SpGroupManagement.Add(spGroup);
                var id = this.RequestsApi.SubmitManagePermissionRequest(request);
                return id;
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RequestsApi.SubmitCreateSiteRequest: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
                throw e;
            }
        }
    }
}
