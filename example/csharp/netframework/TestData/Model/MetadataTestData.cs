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
    public class MetadataTestData
    {
        #region Name
        public String ChoiceMetadataName { get; set; }
        public String SingleLineMetadataName { get; set; }
        public String MultiLineMetadataName { get; set; }
        public String UpsMetadataName { get; set; }
        public String AzureAdMetadataName { get; set; }
        public String UserMetadataName { get; set; }
        public String YesNoMetadataName { get; set; }
        public String TermsMetadataName { get; set; }
        public String HyperlinkMetadataName { get; set; }
        #endregion Name


        #region Value
        public String AzureAdMetadataLookupUser { get; set; }
        public String UpsMetadataLookupUser { get; set; }
        public String LinkMetadataValue { get; set; }
        public String TermsMetadataValue { get; set; }
        public String UserMetadataValue { get; set; }
        public String ChoiceMetadataValue { get; set; }
        public String YesNoMetadataValue { get; set; }
        public String MultiLineMetadataValue { get; set; }
        public String SingleLineMetadataValue { get; set; }
        #endregion Value
    }
}
