

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
    
    public enum ApiRequestProgressStatus
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        RequestSubmitted = 1,

        [EnumMember(Value = "2")]
        WaitingForApproval = 2,

        [EnumMember(Value = "3")]
        WaitingForSubmission = 3,

        [EnumMember(Value = "4")]
        Cancelled = 4,

        [EnumMember(Value = "5")]
        Rejected = 5,

        [EnumMember(Value = "6")]
        Completed = 6,

        [EnumMember(Value = "7")]
        CompletedWithException = 7,

        [EnumMember(Value = "8")]
        EncounterError = 8,

        [EnumMember(Value = "9")]
        InProgress = 9,

        [EnumMember(Value = "10")]
        FailedWithSubRequestException = 10

    }

}
