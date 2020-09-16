

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
    
    public enum TreeNodeType
    {
        [EnumMember(Value = "0")]
        Root = 0,

        [EnumMember(Value = "2")]
        WebApplication = 2,

        [EnumMember(Value = "3")]
        Tenant = 3,

        [EnumMember(Value = "4")]
        Container = 4,

        [EnumMember(Value = "10")]
        ManagedPath = 10,

        [EnumMember(Value = "100")]
        SiteCollection = 100,

        [EnumMember(Value = "200")]
        Site = 200,

        [EnumMember(Value = "201")]
        Sites = 201,

        [EnumMember(Value = "202")]
        Lists = 202,

        [EnumMember(Value = "300")]
        List = 300,

        [EnumMember(Value = "310")]
        DocumentLibrary = 310,

        [EnumMember(Value = "400")]
        Folder = 400,

        [EnumMember(Value = "401")]
        Folders = 401,

        [EnumMember(Value = "402")]
        Items = 402,

        [EnumMember(Value = "500")]
        Item = 500,

        [EnumMember(Value = "501")]
        File = 501,

        [EnumMember(Value = "600")]
        Group = 600,

        [EnumMember(Value = "1000")]
        All = 1000,

        [EnumMember(Value = "-5")]
        WebApplication_D = -5,

        [EnumMember(Value = "-4")]
        BPOSDCA = -4,

        [EnumMember(Value = "-3")]
        SelectAll = -3,

        [EnumMember(Value = "-2")]
        None = -2,

        [EnumMember(Value = "-1")]
        Farm = -1

    }

}
