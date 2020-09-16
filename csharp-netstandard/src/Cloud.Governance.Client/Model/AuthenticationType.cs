

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
    
    public enum AuthenticationType
    {
        [EnumMember(Value = "0")]
        LocalSystem = 0,

        [EnumMember(Value = "1")]
        WindowsIntegration = 1,

        [EnumMember(Value = "2")]
        ADIntegration = 2,

        [EnumMember(Value = "3")]
        ADFSIntegration = 3,

        [EnumMember(Value = "4")]
        Federation = 4,

        [EnumMember(Value = "6")]
        SharePointOnline = 6,

        [EnumMember(Value = "7")]
        SalesForce = 7,

        [EnumMember(Value = "8")]
        Yammer = 8,

        [EnumMember(Value = "9")]
        AzureAD = 9,

        [EnumMember(Value = "10")]
        Sandbox = 10,

        [EnumMember(Value = "11")]
        SharePoint = 11,

        [EnumMember(Value = "12")]
        Exchange = 12

    }

}
