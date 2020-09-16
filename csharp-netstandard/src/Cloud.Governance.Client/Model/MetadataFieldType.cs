

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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MetadataFieldType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        SingleLineText = 1,

        [EnumMember(Value = "2")]
        MultiLineText = 2,

        [EnumMember(Value = "3")]
        YesOrNo = 3,

        [EnumMember(Value = "4")]
        Choices = 4,

        [EnumMember(Value = "5")]
        PeoplePickerValue = 5,

        [EnumMember(Value = "6")]
        Terms = 6,

        [EnumMember(Value = "7")]
        Hyperlink = 7,

        [EnumMember(Value = "8")]
        UserProfileService = 8,

        [EnumMember(Value = "9")]
        AzureADProperty = 9,

        [EnumMember(Value = "10")]
        SharePointList = 10

    }

}
