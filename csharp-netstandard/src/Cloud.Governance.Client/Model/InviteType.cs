

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
    
    public enum InviteType
    {
        [EnumMember(Value = "0")]
        User = 0,

        [EnumMember(Value = "1")]
        Group = 1,

        [EnumMember(Value = "2")]
        UserInGroup = 2,

        [EnumMember(Value = "3")]
        PortalSupport = 3,

        [EnumMember(Value = "4")]
        ProductSupport = 4

    }

}
