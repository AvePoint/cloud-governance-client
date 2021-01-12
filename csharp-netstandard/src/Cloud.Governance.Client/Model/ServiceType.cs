

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
    
    public enum ServiceType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        ProvisionSiteCollection = 1,

        [EnumMember(Value = "2")]
        CreateSubSite = 2,

        [EnumMember(Value = "3")]
        SiteCollectionLifecycleMgmt = 3,

        [EnumMember(Value = "4")]
        ArchiveSiteCollection = 4,

        [EnumMember(Value = "5")]
        DeleteSiteCollection = 5,

        [EnumMember(Value = "6")]
        ExtendSiteCollection = 6,

        [EnumMember(Value = "7")]
        ChangeSiteCollectionPolicy = 7,

        [EnumMember(Value = "8")]
        ChangeSiteCollectionMetadata = 8,

        [EnumMember(Value = "9")]
        ChangeSiteCollectionContact = 9,

        [EnumMember(Value = "10")]
        TransferUserPermission = 10,

        [EnumMember(Value = "11")]
        ManualArchiveSiteCollectionContent = 11,

        [EnumMember(Value = "12")]
        CloneUserPermissions = 12,

        [EnumMember(Value = "13")]
        SiteLifecycleManagement = 13,

        [EnumMember(Value = "14")]
        GrantUserPermissions = 14,

        [EnumMember(Value = "15")]
        RemoveUserPermissions = 15,

        [EnumMember(Value = "16")]
        ChangeSubSitePolicy = 16,

        [EnumMember(Value = "17")]
        ChangeSubSiteMetadata = 17,

        [EnumMember(Value = "18")]
        ChangeSubSiteContact = 18,

        [EnumMember(Value = "19")]
        CleanDeadAccounts = 19,

        [EnumMember(Value = "20")]
        BackupAndRestore = 20,

        [EnumMember(Value = "21")]
        ArchiveUserContent = 21,

        [EnumMember(Value = "22")]
        MoveListItem = 22,

        [EnumMember(Value = "23")]
        MoveList = 23,

        [EnumMember(Value = "24")]
        MoveSite = 24,

        [EnumMember(Value = "25")]
        SiteTemplateDeployment = 25,

        [EnumMember(Value = "26")]
        SiteThemeDeployment = 26,

        [EnumMember(Value = "27")]
        SandboxSolutionDeployment = 27,

        [EnumMember(Value = "28")]
        FarmSolutionDeployment = 28,

        [EnumMember(Value = "29")]
        SiteOwnerReporting = 29,

        [EnumMember(Value = "30")]
        SiteCollectionOwnerReporting = 30,

        [EnumMember(Value = "31")]
        SiteRequestReporting = 31,

        [EnumMember(Value = "32")]
        ContentManager = 32,

        [EnumMember(Value = "33")]
        ProvisionSiteCollectionExternal = 33,

        [EnumMember(Value = "40")]
        MySite = 40,

        [EnumMember(Value = "41")]
        CreateList = 41,

        [EnumMember(Value = "42")]
        ChangeList = 42,

        [EnumMember(Value = "43")]
        AutoSiteCollectionLifecycleMgmt = 43,

        [EnumMember(Value = "44")]
        QuestionaireMgmt = 44,

        [EnumMember(Value = "46")]
        PermRecertify = 46,

        [EnumMember(Value = "47")]
        MetadataRecertify = 47,

        [EnumMember(Value = "48")]
        OwnershipRecertification = 48,

        [EnumMember(Value = "49")]
        Election = 49,

        [EnumMember(Value = "50")]
        Unlock = 50,

        [EnumMember(Value = "51")]
        AutoLocking = 51,

        [EnumMember(Value = "52")]
        SCInactivityThreshold = 52,

        [EnumMember(Value = "53")]
        SCLeasePeriod = 53,

        [EnumMember(Value = "54")]
        Blank = 54,

        [EnumMember(Value = "55")]
        LockSC = 55,

        [EnumMember(Value = "56")]
        ChangeSCQuota = 56,

        [EnumMember(Value = "57")]
        ApplySiteInformation = 57,

        [EnumMember(Value = "58")]
        ImportSite = 58,

        [EnumMember(Value = "59")]
        ApplySitePolicy = 59,

        [EnumMember(Value = "60")]
        ImportWeb = 60,

        [EnumMember(Value = "61")]
        RenewSite = 61,

        [EnumMember(Value = "62")]
        RenewGroup = 62,

        [EnumMember(Value = "63")]
        ExportReport = 63,

        [EnumMember(Value = "64")]
        RequestValidation = 64,

        [EnumMember(Value = "65")]
        SyncSiteMetadata = 65,

        [EnumMember(Value = "66")]
        PermissionManagement = 66,

        [EnumMember(Value = "67")]
        BulkUpdate = 67,

        [EnumMember(Value = "68")]
        CreateGuestUser = 68,

        [EnumMember(Value = "69")]
        BulkUpdateGroupTeam = 69,

        [EnumMember(Value = "70")]
        RenewGuestUser = 70,

        [EnumMember(Value = "72")]
        UpdateSiteLockStatus = 72,

        [EnumMember(Value = "73")]
        ApplySitePolicyPartSetting = 73,

        [EnumMember(Value = "74")]
        ApplyGroupPolicyPartSetting = 74,

        [EnumMember(Value = "110")]
        CreateUser = 110,

        [EnumMember(Value = "111")]
        ChangeUser = 111,

        [EnumMember(Value = "112")]
        UserLifecycle = 112,

        [EnumMember(Value = "113")]
        OffBoardingUser = 113,

        [EnumMember(Value = "114")]
        ExtendUser = 114,

        [EnumMember(Value = "115")]
        ChangeUserPolicy = 115,

        [EnumMember(Value = "116")]
        UnblockUser = 116,

        [EnumMember(Value = "117")]
        ChangeUserLoginName = 117,

        [EnumMember(Value = "120")]
        CreateGroup = 120,

        [EnumMember(Value = "121")]
        ChangeGroup = 121,

        [EnumMember(Value = "122")]
        GroupLifecycle = 122,

        [EnumMember(Value = "123")]
        DeleteGroup = 123,

        [EnumMember(Value = "124")]
        ExtendGroup = 124,

        [EnumMember(Value = "125")]
        ChangeGroupPolicy = 125,

        [EnumMember(Value = "128")]
        ChangeGroupQuota = 128,

        [EnumMember(Value = "130")]
        ContinueAccess = 130,

        [EnumMember(Value = "131")]
        ApplyGroupInformation = 131,

        [EnumMember(Value = "132")]
        ApplyGroupPolicy = 132,

        [EnumMember(Value = "133")]
        ImportAzureGroup = 133,

        [EnumMember(Value = "134")]
        ImportAzureUser = 134,

        [EnumMember(Value = "135")]
        PostCreateGroup = 135,

        [EnumMember(Value = "136")]
        ImportAzureGuestUser = 136,

        [EnumMember(Value = "137")]
        ImportYammer = 137,

        [EnumMember(Value = "140")]
        ArchiveTeam = 140,

        [EnumMember(Value = "141")]
        UnArchiveTeam = 141,

        [EnumMember(Value = "200")]
        GroupMembershipRecertification = 200,

        [EnumMember(Value = "201")]
        GroupPermissionRecertification = 201,

        [EnumMember(Value = "501")]
        SyncSite = 501,

        [EnumMember(Value = "502")]
        UpgradeSiteLifecycleSetting = 502,

        [EnumMember(Value = "503")]
        AutoElection = 503,

        [EnumMember(Value = "504")]
        ManualArchiveTimer = 504,

        [EnumMember(Value = "505")]
        SyncWeb = 505,

        [EnumMember(Value = "506")]
        QuotaThresholdTimerJob = 506,

        [EnumMember(Value = "507")]
        SyncUserForDynamicRule = 507,

        [EnumMember(Value = "508")]
        SyncGroup = 508,

        [EnumMember(Value = "509")]
        AutoImportSiteCustomService = 509,

        [EnumMember(Value = "510")]
        AutoImportSite = 510,

        [EnumMember(Value = "511")]
        AutoImportGroup = 511,

        [EnumMember(Value = "512")]
        TemporaryPermissionStart = 512,

        [EnumMember(Value = "513")]
        TemporaryPermissionEnd = 513,

        [EnumMember(Value = "514")]
        TemporaryPermissionExpiringNotificationJob = 514,

        [EnumMember(Value = "515")]
        RenewTeams = 515,

        [EnumMember(Value = "516")]
        AutoExportReport = 516,

        [EnumMember(Value = "517")]
        SyncUserInformation = 517,

        [EnumMember(Value = "518")]
        SyncUpsMetadata = 518,

        [EnumMember(Value = "520")]
        GroupAutoElection = 520,

        [EnumMember(Value = "521")]
        SyncGuestUser = 521,

        [EnumMember(Value = "522")]
        RenewYammer = 522,

        [EnumMember(Value = "530")]
        SpecifyContacts = 530,

        [EnumMember(Value = "531")]
        UpdateGroupStieLockStatus = 531,

        [EnumMember(Value = "532")]
        BulkDeleteWorkspace = 532,

        [EnumMember(Value = "533")]
        BulkManageWorkspaceLockState = 533,

        [EnumMember(Value = "534")]
        BulkArchiveSite = 534,

        [EnumMember(Value = "535")]
        BulkArchiveTeams = 535,

        [EnumMember(Value = "536")]
        BulkRestoreTeams = 536,

        [EnumMember(Value = "540")]
        RemoveSite = 540,

        [EnumMember(Value = "541")]
        RemoveGroup = 541,

        [EnumMember(Value = "542")]
        RemoveWeb = 542,

        [EnumMember(Value = "543")]
        AutoImportGroupEscalation = 543,

        [EnumMember(Value = "544")]
        AutoImportSiteEscalation = 544

    }

}
