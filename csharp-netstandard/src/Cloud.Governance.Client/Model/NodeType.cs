

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
    
    public enum NodeType
    {
        [EnumMember(Value = "2")]
        Container = 2,

        [EnumMember(Value = "100")]
        Site = 100,

        [EnumMember(Value = "200")]
        Web = 200,

        [EnumMember(Value = "300")]
        List = 300,

        [EnumMember(Value = "310")]
        DocumentLibrary = 310,

        [EnumMember(Value = "400")]
        Folder = 400,

        [EnumMember(Value = "500")]
        Item = 500,

        [EnumMember(Value = "501")]
        File = 501,

        [EnumMember(Value = "-2")]
        None = -2

    }

}
