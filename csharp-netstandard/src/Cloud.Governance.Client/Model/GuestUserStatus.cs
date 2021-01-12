

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
    
    public enum GuestUserStatus
    {
        [EnumMember(Value = "0")]
        Active = 0,

        [EnumMember(Value = "1")]
        RenewalPreparing = 1,

        [EnumMember(Value = "2")]
        RenewalPending = 2,

        [EnumMember(Value = "3")]
        RenewalProcessing = 3,

        [EnumMember(Value = "4")]
        RenewalCompleted = 4,

        [EnumMember(Value = "5")]
        RenewalException = 5,

        [EnumMember(Value = "6")]
        RenewalOverdue = 6,

        [EnumMember(Value = "7")]
        Deleted = 7,

        [EnumMember(Value = "8")]
        Disabled = 8,

        [EnumMember(Value = "9")]
        RenewalDisabled = 9

    }

}
