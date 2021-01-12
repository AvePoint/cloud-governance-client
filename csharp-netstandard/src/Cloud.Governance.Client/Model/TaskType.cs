

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
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaskType
    {
        [EnumMember(Value = "0")]
        ApprovalTask = 0,

        [EnumMember(Value = "1")]
        ErrorHandlingTask = 1,

        [EnumMember(Value = "2")]
        SCExpired = 2,

        [EnumMember(Value = "3")]
        SCNoAccess = 3,

        [EnumMember(Value = "4")]
        ToDoTask = 4,

        [EnumMember(Value = "5")]
        UserExpired = 5,

        [EnumMember(Value = "6")]
        GroupExpired = 6,

        [EnumMember(Value = "7")]
        GroupInactivityThreshold = 7,

        [EnumMember(Value = "8")]
        AutoImportGroup = 8,

        [EnumMember(Value = "9")]
        AutoImportSite = 9,

        [EnumMember(Value = "10")]
        RenewGroup = 10,

        [EnumMember(Value = "11")]
        RenewSite = 11,

        [EnumMember(Value = "12")]
        RenewGuestUser = 12

    }

}
