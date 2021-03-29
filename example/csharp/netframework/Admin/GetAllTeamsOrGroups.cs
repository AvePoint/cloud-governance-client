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
    using System.Diagnostics;

    public class GetAllTeamsOrGroups : TestBase
    {
        public GetAllTeamsOrGroups(ApiConfig authData) : base(authData) { }

        public List<WorkspaceGridModel> Run()
        {
            var result = new List<WorkspaceGridModel>();
            try
            {
                var apiInstance = new WorkspacesAdminApi(Configuration.Default);
                String nextToken = null;
                do
                {
                    var pageResult = apiInstance.GetWorkspaces(filter: "type eq 'Group' or type eq 'Teams'", nexttoken: nextToken);
                    if (pageResult != null && pageResult.Value != null)
                    {
                        result.AddRange(pageResult.Value);
                        nextToken = pageResult.NextToken;
                    }
                } while (nextToken != null);
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AdminWorkspaceReportAPI.Query: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
            return result;
        }
    }
}
