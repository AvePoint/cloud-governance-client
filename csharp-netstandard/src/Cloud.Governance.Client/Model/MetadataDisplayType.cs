

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
    
    public enum MetadataDisplayType
    {
        [EnumMember(Value = "1")]
        DoNotDisplayInReport = 1,

        [EnumMember(Value = "2")]
        DisplayInPublicSCDirectoryReport = 2,

        [EnumMember(Value = "3")]
        DisplayInAdministrationReport = 3

    }

}
