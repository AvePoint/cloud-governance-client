

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
    
    public enum SiteLifecycleActionType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        Extend = 1,

        [EnumMember(Value = "2")]
        Delete = 2,

        [EnumMember(Value = "3")]
        Archive = 3,

        [EnumMember(Value = "4")]
        ChangePolicy = 4,

        [EnumMember(Value = "5")]
        Unlock = 5,

        [EnumMember(Value = "7")]
        Lock = 7,

        [EnumMember(Value = "8")]
        ChangeQuota = 8

    }

}
