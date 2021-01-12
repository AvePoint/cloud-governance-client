

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
    
    public enum SiteLockType
    {
        [EnumMember(Value = "0")]
        NoAccess = 0,

        [EnumMember(Value = "1")]
        ReadOnly = 1,

        [EnumMember(Value = "2")]
        NoAccessAndReadOnly = 2,

        [EnumMember(Value = "3")]
        Unlock = 3

    }

}
