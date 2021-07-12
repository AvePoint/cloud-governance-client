
using Cloud.Governance.Client.Model;
using System;
using System.Collections.Generic;

namespace NetFramework
{
    public class CustomTestData
    {
        public String ServiceName { get; set; }
        public List<RequestMetadata> Metadata { get; set; }
        

        #region Metadata Name
        public String ChoiceMetadataName { get; set; }
        public String SingleLineMetadataName { get; set; }
        public String MultiLineMetadataName { get; set; }
        public String UpsMetadataName { get; set; }
        public String AzureAdMetadataName { get; set; }
        public String UserMetadataName { get; set; }
        public String YesNoMetadataName { get; set; }
        public String TermsMetadataName { get; set; }
        public String HyperlinkMetadataName { get; set; }
        public String LookupMetadataName { get; set; }
        #endregion Name


        #region Metadata Value
        public String AzureAdMetadataLookupUser { get; set; }
        public String UpsMetadataLookupUser { get; set; }
        public String LinkMetadataValue { get; set; }
        public String TermsMetadataValue { get; set; }
        public String UserMetadataValue { get; set; }
        public String ChoiceMetadataValue { get; set; }
        public String YesNoMetadataValue { get; set; }
        public String MultiLineMetadataValue { get; set; }
        public String SingleLineMetadataValue { get; set; }
        public String LookupMetadataValue { get; set; }
        #endregion Value
    }
}
