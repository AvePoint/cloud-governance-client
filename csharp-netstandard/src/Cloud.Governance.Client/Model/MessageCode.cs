

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
    
    public enum MessageCode
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        NoServicePermission = 1,

        [EnumMember(Value = "300")]
        SiteNotInScope = 300,

        [EnumMember(Value = "301")]
        SiteUnlock = 301,

        [EnumMember(Value = "302")]
        SiteNotInGADB = 302,

        [EnumMember(Value = "303")]
        SiteInvalid = 303,

        [EnumMember(Value = "304")]
        SiteLifecycleLock = 304,

        [EnumMember(Value = "305")]
        SiteAutoLifecycleLock = 305,

        [EnumMember(Value = "306")]
        SiteHasPendingRenewal = 306,

        [EnumMember(Value = "307")]
        SiteHasRecertification = 307,

        [EnumMember(Value = "308")]
        SitePolicyInvalid = 308,

        [EnumMember(Value = "309")]
        SiteExtendTimeError = 309,

        [EnumMember(Value = "310")]
        SiteLocked = 310,

        [EnumMember(Value = "400")]
        GroupArchived = 400,

        [EnumMember(Value = "401")]
        GroupNotInGADB = 401,

        [EnumMember(Value = "402")]
        TeamArchiveAvaliable = 402,

        [EnumMember(Value = "403")]
        TeamRestoreAvaliable = 403,

        [EnumMember(Value = "404")]
        TeamArchivedNotRestore = 404,

        [EnumMember(Value = "405")]
        GroupNotInScope = 405,

        [EnumMember(Value = "406")]
        TeamNotInScope = 406,

        [EnumMember(Value = "407")]
        GroupDisableDelete = 407,

        [EnumMember(Value = "408")]
        GroupDisableExtend = 408,

        [EnumMember(Value = "409")]
        GroupDisableChangePolicy = 409,

        [EnumMember(Value = "410")]
        GroupDisableChangeQuota = 410,

        [EnumMember(Value = "411")]
        GroupDisableArchive = 411,

        [EnumMember(Value = "412")]
        GroupDisableUnArchive = 412,

        [EnumMember(Value = "413")]
        GroupNotInServiceScope = 413,

        [EnumMember(Value = "414")]
        GroupNotAllowAddGuestUser = 414,

        [EnumMember(Value = "415")]
        YammerNotInScope = 415

    }

}
