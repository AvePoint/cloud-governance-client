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

    public class Site_GrantGroupPermission : TestBase
    {
        public Site_GrantGroupPermission(ApiConfig authData) : base(authData) { }

        public Guid Run(ManagePermissionTestData data)
        {
            try
            {
                

                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetManagePermissionService(serviceId);
                var request = service.RequestTemplate;

                request.Summary = $"Api_Sample_ManagePermission_GrantGroupPermission_Request_{DateTime.Now}";
                request.ObjectUrl = data.ObjectUrl;
                request.Department = data.Department;
                request.SpGroupManagement = new List<SPGroupManagementModel>();
                request.PermissionManagement = new PermissionManagementModel()
                {
                    IsUniquePermission = true,
                    PermissionItems = new List<ObjectPermissionManagementModel>()
                };
                var groupPermissionInfo = new ObjectPermissionManagementModel()
                {
                    Action = ManagePermissionAction.Added,
                    ObjectType = SPPrincipalType.SecurityGroup,
                    ObjectInfo = new ApiUser()
                    {
                        LoginName = data.ObjectInfoLoginName,
                        IsGroup = true
                    },
                    GrantPermissionSetting = new GrantPermissionModel()
                    {
                        PermissionDurationSettings = new TemporaryPermissionRequestSetting()
                        {
                            IsGrantTemporaryPermission = false,
                            StartTime = DateTime.UtcNow
                        },
                        WelcomeEmailSettings = new WelcomeEmailSettings()
                        {
                            Enabled = false
                        }
                    },
                    Permissions = new List<string>(data.PermissionLevels.Split(';')),
                };
                request.PermissionManagement.PermissionItems.Add(groupPermissionInfo);
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
