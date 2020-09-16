

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
    
    public enum TaskDynamicActions
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        Extend = 1,

        [EnumMember(Value = "2")]
        Archive = 2,

        [EnumMember(Value = "3")]
        ChangePolicy = 3,

        [EnumMember(Value = "4")]
        OffBoarding = 4,

        [EnumMember(Value = "5")]
        Delete = 5,

        [EnumMember(Value = "6")]
        ContinueAccess = 6,

        [EnumMember(Value = "7")]
        Claim = 7,

        [EnumMember(Value = "8")]
        Decline = 8,

        [EnumMember(Value = "9")]
        SpecifyContacts = 9,

        [EnumMember(Value = "10")]
        SpecifySecondaryContact = 10

    }

}
