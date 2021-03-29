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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class CreateSiteTestData
    {
        public String SiteName { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmss");

        public String Department { get; set; }

        public String PolicyName { get; set; }

        public String LanguageName { get; set; }

        public String ServiceName { get; set; }

        public String PrimaryAdminLoginName { get; set; }

        public String AdditionalAdminLoginNames { get; set; }

        public String PrimaryContactLoginName { get; set; }

        public String SecondaryContactLoginName { get; set; }

        public String TimeZoneName { get; set; }

        public String TemplateTitle { get; set; }

        public String GrantedUserLoginName { get; set; }

        public String GrantedUserPermissionLevelNames { get; set; }

        public String SharePointGroupName { get; set; }

        public String SharePointGroupMemberLoginNames { get; set; }

        public String MultiGeoLocatioinName { get; set; }

        public Dictionary<String, String> Metadata { get; set; }

        public String ChoiceMetadataName { get; set; }
        public String ChoiceMetadataValue { get; set; }
        public String SingleLineMetadataName { get; set; }
        public String SingleLineMetadataValue { get; set; }
    }
}
