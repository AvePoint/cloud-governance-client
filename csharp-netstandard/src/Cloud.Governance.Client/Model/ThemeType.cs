

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
    
    public enum ThemeType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        NavyBlue = 1,

        [EnumMember(Value = "2")]
        LightBlack = 2,

        [EnumMember(Value = "3")]
        LightBlue = 3,

        [EnumMember(Value = "4")]
        Orange = 4,

        [EnumMember(Value = "5")]
        GrassGreen = 5,

        [EnumMember(Value = "6")]
        Pink = 6,

        [EnumMember(Value = "7")]
        EmeraldGreen = 7,

        [EnumMember(Value = "8")]
        Lilac = 8

    }

}
