

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    
    public enum MetadataFieldType
    {
        None = 0,

        SingleLineText = 1,

        MultiLineText = 2,

        YesOrNo = 3,

        Choices = 4,

        PeoplePickerValue = 5,

        Terms = 6,

        Hyperlink = 7,

        UserProfileService = 8,

        AzureADProperty = 9,

        SharePointList = 10

    }

}
