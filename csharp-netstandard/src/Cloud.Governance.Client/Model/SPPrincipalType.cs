

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
    
    public enum SPPrincipalType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        User = 1,

        [EnumMember(Value = "2")]
        DistributionList = 2,

        [EnumMember(Value = "4")]
        SecurityGroup = 4,

        [EnumMember(Value = "8")]
        SharePointGroup = 8,

        [EnumMember(Value = "15")]
        All = 15

    }

}
