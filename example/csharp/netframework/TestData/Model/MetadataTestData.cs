
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
