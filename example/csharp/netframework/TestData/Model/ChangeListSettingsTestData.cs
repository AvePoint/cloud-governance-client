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
    using System;

    public class ChangeListSettingsTestData
    {
        public String ServiceName { get; set; }

        public String Summary { get; set; }

        public String ListName { get; set; }

        public String Description { get; set; }

        public Int32 MajorVersionLimit { get; set; }

        public Int32 MinorVersionLimit { get; set; }

        public String ListType { get; set; }

        public String Uri { get; set; }

        public String WebUrl { get; set; }

        public String WebId { get; set; }

        public String SiteUrl { get; set; }

        public String SiteId { get; set; }
    }
}
