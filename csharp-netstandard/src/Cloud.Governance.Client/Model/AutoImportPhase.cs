

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
    
    public enum AutoImportPhase
    {
        [EnumMember(Value = "0")]
        Confirmed = 0,

        [EnumMember(Value = "1")]
        Processing = 1,

        [EnumMember(Value = "2")]
        PendingInition = 2,

        [EnumMember(Value = "3")]
        ApplyInformationException = 3,

        [EnumMember(Value = "4")]
        Overdue = 4,

        [EnumMember(Value = "5")]
        PendingRenewal = 5,

        [EnumMember(Value = "6")]
        RenewalExpired = 6,

        [EnumMember(Value = "7")]
        RenewalProcessing = 7,

        [EnumMember(Value = "8")]
        RenewalException = 8,

        [EnumMember(Value = "9")]
        Locked = 9,

        [EnumMember(Value = "10")]
        RenewalCanceled = 10,

        [EnumMember(Value = "11")]
        RenewalPreparing = 11,

        [EnumMember(Value = "12")]
        Invalid = 12,

        [EnumMember(Value = "13")]
        Archived = 13,

        [EnumMember(Value = "14")]
        Escalation = 14,

        [EnumMember(Value = "15")]
        ITRenewalCanceled = 15

    }

}
