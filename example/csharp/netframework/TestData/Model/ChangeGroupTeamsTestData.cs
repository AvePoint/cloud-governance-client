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
using System;
using System.Collections.Generic;

namespace NetFramework
{
    public class ChangeGroupTeamsTestData
    {
        public String ServiceName { get; set; }

        public String GroupEmail { get; set; }

        public Boolean EnableTeams { get; set; }

        public String GroupName { get; set; }

        public String GroupDescription { get; set; }

        public String Classification { get; set; }

        public String AdminCenterUrl { get; set; }

        public String AssociateHubSiteTitle { get; set; }

        public String PrimaryContact { get; set; }

        public String SecondaryContact { get; set; }

        public Boolean EnabledSubscribe { get; set; }

        public Boolean EnabledOutsideSender { get; set; }

        public String DynamicGroup { get; set; }

        public String NewMembers { get; set; }

        public String NewOwners { get; set; }

        public String RemovedMembers { get; set; }

        public String RemovedOwners { get; set; }
    }
}
