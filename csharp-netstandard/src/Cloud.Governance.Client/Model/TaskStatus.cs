

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
    
    public enum TaskStatus
    {
        [EnumMember(Value = "0")]
        Created = 0,

        [EnumMember(Value = "1")]
        WaitingForActivation = 1,

        [EnumMember(Value = "2")]
        WaitingToRun = 2,

        [EnumMember(Value = "3")]
        Running = 3,

        [EnumMember(Value = "4")]
        WaitingForChildrenToComplete = 4,

        [EnumMember(Value = "5")]
        RanToCompletion = 5,

        [EnumMember(Value = "6")]
        Canceled = 6,

        [EnumMember(Value = "7")]
        Faulted = 7

    }

}
