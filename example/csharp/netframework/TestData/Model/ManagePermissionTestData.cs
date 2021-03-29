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
using Cloud.Governance.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class ManagePermissionTestData
    {
        public String ServiceName { get; set; }

        public String ObjectUrl { get; set; }

        public String GrantUserLoginName { get; set; }

        public String PermissionLevels { get; set; }

        public String SpGroupNameChangeValue { get; set; }

        public String SpGroupNameOriginalValue { get; set; }

        public String SpGroupDescription { get; set; }

        public String SpGroupOwnerLoginName { get; set; }

        public String SpGroupMemberIdentityName { get; set; }

        public String SpGroupMemberDisplayName { get; set; }

        public String ObjectInfoLoginName { get; set; }

        public String Department { get; set; }

        public String UserLoginName { get; set; }

        public String UserDisplayName { get; set; }
    }
}
