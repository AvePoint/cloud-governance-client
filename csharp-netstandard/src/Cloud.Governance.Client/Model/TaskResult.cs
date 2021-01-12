

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
    
    public enum TaskResult
    {
        [EnumMember(Value = "0")]
        Running = 0,

        [EnumMember(Value = "1")]
        Approved = 1,

        [EnumMember(Value = "2")]
        Rejected = 2,

        [EnumMember(Value = "3")]
        Canceled = 3,

        [EnumMember(Value = "4")]
        TimeOut = 4,

        [EnumMember(Value = "5")]
        Completed = 5,

        [EnumMember(Value = "6")]
        AutoActionApproved = 6,

        [EnumMember(Value = "7")]
        Retried = 7,

        [EnumMember(Value = "8")]
        Skipped = 8,

        [EnumMember(Value = "9")]
        Submited = 9,

        [EnumMember(Value = "10")]
        WaitingForSubmission = 10,

        [EnumMember(Value = "11")]
        AllStagesTimeOut = 11,

        [EnumMember(Value = "12")]
        Declined = 12,

        [EnumMember(Value = "13")]
        WaitingForClaim = 13,

        [EnumMember(Value = "14")]
        ElectionTaskTimeOut = 14,

        [EnumMember(Value = "15")]
        Claimed = 15,

        [EnumMember(Value = "16")]
        AutoComplete = 16,

        [EnumMember(Value = "17")]
        WaitingForSpecify = 17,

        [EnumMember(Value = "19")]
        PendingConfirm = 19,

        [EnumMember(Value = "20")]
        ConfirmOverdue = 20,

        [EnumMember(Value = "21")]
        PendingRenewal = 21,

        [EnumMember(Value = "22")]
        RenewalExpired = 22,

        [EnumMember(Value = "23")]
        ConfirmException = 23,

        [EnumMember(Value = "24")]
        RenewalException = 24,

        [EnumMember(Value = "25")]
        WaitingForSpecifyBothContacts = 25

    }

}
