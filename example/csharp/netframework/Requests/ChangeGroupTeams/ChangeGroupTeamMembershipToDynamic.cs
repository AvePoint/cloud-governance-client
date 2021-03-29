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

    public class ChangeGroupTeamMembershipToDynamic : TestBase
    {
        public ChangeGroupTeamMembershipToDynamic(ApiConfig authData) : base(authData) { }

        public Guid Run(ChangeGroupTeamsTestData data)
        {
            try
            {
                var serviceId = this.ServicesApi.GetServiceId(data.ServiceName);
                var service = this.ServicesApi.GetChangeGroupSettingService(serviceId);
                var group = this.ResolveUser(data.GroupEmail, ApiUserType.Group);
                var dynamicGroup = this.ResolveUser(data.DynamicGroup, ApiUserType.Group);
                var request = service.RequestTemplate;
                request.Summary = $"Summary_ChangeTeamMembershipToDynamic_{DateTime.Now}";
                request.GroupEmail = data.GroupEmail;
                request.GroupId = new Guid(group.Id);
                request.OriginalGroupName = group.DisplayName;
                request.ChangedDynamicGroupType = AddGroupMemberType.Dynamically;
                if (service.EnableChangeDynamicMembershipRules)
                {
                    var rules = this.SettingsApi.GetDynamicMembershipRuleItems(service.TenantId);
                    var currentRule = rules.Organization.Where(rule => rule.Name.Equals("Group Assignment")).FirstOrDefault();
                    request.DynamicMembershipRules = new List<DynamicGroupRuleInfo>
                    {
                        new DynamicGroupRuleInfo
                        {
                            Category = CategoryType.Organization,
                            Condition = DynamicRuleCondition.In,
                            Id = currentRule.Id,
                            MetadataId = currentRule.Id,
                            MetadataName = currentRule.Name,
                            MetadataValue = dynamicGroup.Id,
                            MetadataDisplayValue = dynamicGroup.DisplayName
                        }
                    };
                }
                var result = this.RequestsApi.SubmitChangeGroupSettingRequest(request);

                return result;
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
