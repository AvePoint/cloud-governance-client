

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
    
    public enum RequestProgressStatus
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        ErrorStart = 1,

        [EnumMember(Value = "2")]
        Error = 2,

        [EnumMember(Value = "3")]
        RequestSubmitted = 3,

        [EnumMember(Value = "4")]
        TaskCreated = 4,

        [EnumMember(Value = "5")]
        AdminContactIssueReview = 5,

        [EnumMember(Value = "6")]
        Cancelled = 6,

        [EnumMember(Value = "7")]
        Rejected = 7,

        [EnumMember(Value = "8")]
        FirstStageApproval = 8,

        [EnumMember(Value = "9")]
        SecondStageApproval = 9,

        [EnumMember(Value = "10")]
        ThirdStageApproval = 10,

        [EnumMember(Value = "11")]
        Completed = 11,

        [EnumMember(Value = "12")]
        AssignContentDatabase = 12,

        [EnumMember(Value = "13")]
        CreateSiteCollection = 13,

        [EnumMember(Value = "14")]
        ApplySecuritySettings = 14,

        [EnumMember(Value = "15")]
        ApplySharePointConfigurations = 15,

        [EnumMember(Value = "16")]
        ApplyCustomMetadata = 16,

        [EnumMember(Value = "17")]
        AddToSiteCollectionDirectory = 17,

        [EnumMember(Value = "18")]
        ApplyDocAveGranularBackupPlan = 18,

        [EnumMember(Value = "19")]
        ApplyDocAveAuditorPlan = 19,

        [EnumMember(Value = "20")]
        ApplyDocAveDeadAccountCleaningPlan = 20,

        [EnumMember(Value = "21")]
        ApplyDocAveScheduledStorageManagerProfile = 21,

        [EnumMember(Value = "22")]
        ApplyDocAveArchiverProfile = 22,

        [EnumMember(Value = "23")]
        ApplyDocAveVaultProfile = 23,

        [EnumMember(Value = "24")]
        ApplyAndRunDPMPlan = 24,

        [EnumMember(Value = "25")]
        ArchiveSiteCollection = 25,

        [EnumMember(Value = "26")]
        UpdateSiteCollectionArchived = 26,

        [EnumMember(Value = "27")]
        ExtendSiteCollection = 27,

        [EnumMember(Value = "28")]
        UpdateCustomMetadata = 28,

        [EnumMember(Value = "29")]
        UpdateSiteDirectory = 29,

        [EnumMember(Value = "30")]
        DeleteSiteCollection = 30,

        [EnumMember(Value = "31")]
        UpdateSiteCollectionDeleted = 31,

        [EnumMember(Value = "32")]
        CreateSubSite = 32,

        [EnumMember(Value = "33")]
        AddToSubSiteDirectory = 33,

        [EnumMember(Value = "34")]
        RetractDocAveGranularBackupPlan = 34,

        [EnumMember(Value = "35")]
        RetractDocAveAuditorPlan = 35,

        [EnumMember(Value = "36")]
        RetractDocAveDeadAccountCleaningPlan = 36,

        [EnumMember(Value = "37")]
        RetractDocAveScheduledStorageManagerProfile = 37,

        [EnumMember(Value = "38")]
        RetrieveDocAveArchiveProfile = 38,

        [EnumMember(Value = "39")]
        RetrieveDocAveVaultProfile = 39,

        [EnumMember(Value = "40")]
        UpdateChangeSCPolicyMetadata = 40,

        [EnumMember(Value = "41")]
        UpdateSiteCollectionPolicyChanged = 41,

        [EnumMember(Value = "42")]
        CreateHiddenList = 42,

        [EnumMember(Value = "43")]
        ChangeSiteCollectionMetadata = 43,

        [EnumMember(Value = "44")]
        UpdateSiteDirectoryForChangeSCMetadata = 44,

        [EnumMember(Value = "45")]
        ChangeSiteCollectionContact = 45,

        [EnumMember(Value = "46")]
        UpdateSiteDirectoryForChangeSCContact = 46,

        [EnumMember(Value = "47")]
        CloneUserPermission = 47,

        [EnumMember(Value = "48")]
        SearchUserPermission = 48,

        [EnumMember(Value = "49")]
        InProgress = 49,

        [EnumMember(Value = "50")]
        CompletedWithException = 50,

        [EnumMember(Value = "51")]
        DeleteSubSite = 51,

        [EnumMember(Value = "52")]
        UpdateDeleteSubSite = 52,

        [EnumMember(Value = "53")]
        ArchiveSubSite = 53,

        [EnumMember(Value = "54")]
        UpdateArchiveSubSite = 54,

        [EnumMember(Value = "55")]
        ChangeSubSiteMetadata = 55,

        [EnumMember(Value = "56")]
        UpdateSiteDirectoryForChangeSSMetadata = 56,

        [EnumMember(Value = "57")]
        FirstTaskCreated = 57,

        [EnumMember(Value = "58")]
        SecondTaskCreated = 58,

        [EnumMember(Value = "59")]
        ThirdTaskCreated = 59,

        [EnumMember(Value = "60")]
        GrantUserPermission = 60,

        [EnumMember(Value = "61")]
        RemoveUserPermission = 61,

        [EnumMember(Value = "62")]
        ChangeSCSettingsTitleDes = 62,

        [EnumMember(Value = "63")]
        CreateMySiteCompleted = 63,

        [EnumMember(Value = "64")]
        CreateCMPlan = 64,

        [EnumMember(Value = "65")]
        RunCMPlan = 65,

        [EnumMember(Value = "67")]
        ApplyArchiverProfile = 67,

        [EnumMember(Value = "68")]
        CreateListCompleted = 68,

        [EnumMember(Value = "69")]
        ChangeListURL = 69,

        [EnumMember(Value = "71")]
        ChangeListSettingsCompleted = 71,

        [EnumMember(Value = "72")]
        RegistSiteCollectionToDcoAveGroup = 72,

        [EnumMember(Value = "73")]
        ApplyPolicyEnforcerProfile = 73,

        [EnumMember(Value = "74")]
        UpdatePolicyEnforcerProfileCompleted = 74,

        [EnumMember(Value = "75")]
        PermissionRecertificationTriggered = 75,

        [EnumMember(Value = "76")]
        ChangingUserPermission = 76,

        [EnumMember(Value = "77")]
        RequesterReportCreated = 77,

        [EnumMember(Value = "78")]
        ApplyDeployAppPart = 78,

        [EnumMember(Value = "79")]
        ApplyAddAppPart = 79,

        [EnumMember(Value = "80")]
        ApplyingDeploymentManagerPlan = 80,

        [EnumMember(Value = "81")]
        ApplyPermissionRecertification = 81,

        [EnumMember(Value = "82")]
        ApplyMetadataRecertification = 82,

        [EnumMember(Value = "83")]
        ApplyOwnershipRecertification = 83,

        [EnumMember(Value = "84")]
        UnlockSiteCollection = 84,

        [EnumMember(Value = "85")]
        UpdateSiteCollectionUnlocked = 85,

        [EnumMember(Value = "86")]
        ChangeSiteCollectionOwner = 86,

        [EnumMember(Value = "87")]
        ChangeSiteCollectionAdditionalAdmin = 87,

        [EnumMember(Value = "88")]
        CreateOrValidYammerGroup = 88,

        [EnumMember(Value = "89")]
        AddYammerGroupFeed = 89,

        [EnumMember(Value = "90")]
        CancelAutoTask = 90,

        [EnumMember(Value = "91")]
        ContinueAccess = 91,

        [EnumMember(Value = "92")]
        ChangeSSSettingsTitleDes = 92,

        [EnumMember(Value = "94")]
        FailedToSubmit = 94,

        [EnumMember(Value = "95")]
        WaitingForSubmission = 95,

        [EnumMember(Value = "96")]
        AllApprovalStageComplete = 96,

        [EnumMember(Value = "97")]
        LockSiteCollection = 97,

        [EnumMember(Value = "98")]
        UpdateSiteCollectionLocked = 98,

        [EnumMember(Value = "99")]
        ChangeSiteCollectionQuota = 99,

        [EnumMember(Value = "100")]
        UpdateSiteCollectionChangedQuota = 100,

        [EnumMember(Value = "101")]
        ApplyAdditionalAdministrators = 101,

        [EnumMember(Value = "400")]
        CallCustomActionBeforeApproval = 400,

        [EnumMember(Value = "401")]
        MaintanceWindow = 401,

        [EnumMember(Value = "500")]
        CreateUser = 500,

        [EnumMember(Value = "501")]
        AssignManager = 501,

        [EnumMember(Value = "502")]
        AssignLicense = 502,

        [EnumMember(Value = "503")]
        AddUserToGroups = 503,

        [EnumMember(Value = "504")]
        RemoveUserFromGroups = 504,

        [EnumMember(Value = "505")]
        AddUserReport = 505,

        [EnumMember(Value = "506")]
        ApplyUserPolicy = 506,

        [EnumMember(Value = "507")]
        ApplyOneDriveSiteProperties = 507,

        [EnumMember(Value = "510")]
        ChangeUser = 510,

        [EnumMember(Value = "511")]
        ChangeUserContact = 511,

        [EnumMember(Value = "512")]
        ChangeUserLicense = 512,

        [EnumMember(Value = "513")]
        ChangeUserManager = 513,

        [EnumMember(Value = "514")]
        ChangeUserGroups = 514,

        [EnumMember(Value = "515")]
        UpdateUserReport = 515,

        [EnumMember(Value = "516")]
        ApplyUserRole = 516,

        [EnumMember(Value = "520")]
        DeleteUser = 520,

        [EnumMember(Value = "521")]
        BlockUser = 521,

        [EnumMember(Value = "522")]
        ResetPassword = 522,

        [EnumMember(Value = "523")]
        ExtendUser = 523,

        [EnumMember(Value = "524")]
        ChangeUserPolicy = 524,

        [EnumMember(Value = "525")]
        UnblockUser = 525,

        [EnumMember(Value = "530")]
        ChangeGroup = 530,

        [EnumMember(Value = "531")]
        UpdateGroupReport = 531,

        [EnumMember(Value = "532")]
        AddOwnersToGroup = 532,

        [EnumMember(Value = "533")]
        AddMembersToGroup = 533,

        [EnumMember(Value = "534")]
        RemoveOwnersFromGroup = 534,

        [EnumMember(Value = "535")]
        RemoveMembersFromGroup = 535,

        [EnumMember(Value = "536")]
        UpdateMetadatasToSite = 536,

        [EnumMember(Value = "537")]
        ChangeDynamicGroupRules = 537,

        [EnumMember(Value = "540")]
        CreateGroup = 540,

        [EnumMember(Value = "541")]
        UpdateGroup = 541,

        [EnumMember(Value = "542")]
        SetGroupOwners = 542,

        [EnumMember(Value = "543")]
        SetGroupMembers = 543,

        [EnumMember(Value = "544")]
        SetGroupQuota = 544,

        [EnumMember(Value = "545")]
        AddGroupReport = 545,

        [EnumMember(Value = "546")]
        ApplyGroupPolicy = 546,

        [EnumMember(Value = "547")]
        EnableTeamCollaboration = 547,

        [EnumMember(Value = "548")]
        ApplySiteDesign = 548,

        [EnumMember(Value = "549")]
        ApplyGroupCustomMetadata = 549,

        [EnumMember(Value = "550")]
        DeleteGroup = 550,

        [EnumMember(Value = "551")]
        ChangeGroupPolicy = 551,

        [EnumMember(Value = "552")]
        ExtendGroup = 552,

        [EnumMember(Value = "553")]
        UpdateGroupStatus = 553,

        [EnumMember(Value = "554")]
        InstallApp = 554,

        [EnumMember(Value = "555")]
        GetGroup = 555,

        [EnumMember(Value = "556")]
        RegisterSiteDocave = 556,

        [EnumMember(Value = "557")]
        GetGroupSite = 557,

        [EnumMember(Value = "558")]
        ChangeGroupQuota = 558,

        [EnumMember(Value = "560")]
        ArchiveTeam = 560,

        [EnumMember(Value = "561")]
        UnArchiveTeam = 561,

        [EnumMember(Value = "600")]
        CreatingSite = 600,

        [EnumMember(Value = "601")]
        ApplyingCustomTemplate = 601,

        [EnumMember(Value = "602")]
        ApplyingSecuritySettings = 602,

        [EnumMember(Value = "603")]
        ApplyingCustomMetadata = 603,

        [EnumMember(Value = "604")]
        ApplyingSitePolicy = 604,

        [EnumMember(Value = "605")]
        ApplyingAdditionalAdministrators = 605,

        [EnumMember(Value = "606")]
        AddingToSiteDirectory = 606,

        [EnumMember(Value = "607")]
        RegistingSiteToDao = 607,

        [EnumMember(Value = "608")]
        ApplyingServiceDpmPlan = 608,

        [EnumMember(Value = "609")]
        ServiceDpmPlanExecuted = 609,

        [EnumMember(Value = "610")]
        ApplyingPolicyDpmPlan = 610,

        [EnumMember(Value = "611")]
        PolicyDpmPlanExecuted = 611,

        [EnumMember(Value = "612")]
        ApplyingPolicyEnforcerProfile = 612,

        [EnumMember(Value = "613")]
        ApplyingArchiverProfile = 613,

        [EnumMember(Value = "614")]
        ApplyingRecertification = 614,

        [EnumMember(Value = "615")]
        InstallingApp = 615,

        [EnumMember(Value = "616")]
        AddingAppParts = 616,

        [EnumMember(Value = "617")]
        CreatingOrValidYammerGroup = 617,

        [EnumMember(Value = "618")]
        AddingYammerGroupFeed = 618,

        [EnumMember(Value = "619")]
        RemovingServiceAccount = 619,

        [EnumMember(Value = "620")]
        CreateGuestUser = 620,

        [EnumMember(Value = "621")]
        UpdateGuestUser = 621,

        [EnumMember(Value = "622")]
        AddGuestUserToGroup = 622,

        [EnumMember(Value = "623")]
        AddGuestUserReport = 623,

        [EnumMember(Value = "624")]
        ApplyGuestUserRenewal = 624,

        [EnumMember(Value = "700")]
        CreatingWeb = 700,

        [EnumMember(Value = "701")]
        ApplyingSecuritySettingsToWeb = 701,

        [EnumMember(Value = "702")]
        ApplyingSharePointConfigurationsToWeb = 702,

        [EnumMember(Value = "703")]
        ApplyingCustomMetadataToWeb = 703,

        [EnumMember(Value = "704")]
        ApplyAndRunDPMPlanInCreatingWeb = 704,

        [EnumMember(Value = "705")]
        AddingWebToDatabase = 705,

        [EnumMember(Value = "706")]
        UpdatingWebInDatabase = 706,

        [EnumMember(Value = "707")]
        DeployingAppPartToWeb = 707,

        [EnumMember(Value = "708")]
        AddingAppPartToWeb = 708,

        [EnumMember(Value = "709")]
        CreatingOrValidingYammerGroupInCreatingWeb = 709,

        [EnumMember(Value = "710")]
        AddingYammerGroupFeedInWeb = 710,

        [EnumMember(Value = "800")]
        DeletingSite = 800,

        [EnumMember(Value = "801")]
        ArchivingSite = 801,

        [EnumMember(Value = "802")]
        ChangingSitePolicy = 802,

        [EnumMember(Value = "803")]
        UnlockingSite = 803,

        [EnumMember(Value = "804")]
        LockingSite = 804,

        [EnumMember(Value = "805")]
        ExtendingSite = 805,

        [EnumMember(Value = "806")]
        ChangingSiteQuota = 806,

        [EnumMember(Value = "830")]
        ChangingSiteTitleAndDescription = 830,

        [EnumMember(Value = "831")]
        ChangingSiteMetadata = 831,

        [EnumMember(Value = "832")]
        UpdatingSiteDirectory = 832,

        [EnumMember(Value = "833")]
        ConvertingToHubSite = 833,

        [EnumMember(Value = "834")]
        ConnectingToHubSite = 834,

        [EnumMember(Value = "835")]
        UnregisteringHubSite = 835,

        [EnumMember(Value = "850")]
        ChangingWebTitleAndDescription = 850,

        [EnumMember(Value = "900")]
        ChangingListSetting = 900,

        [EnumMember(Value = "950")]
        WaitingForGrantPermission = 950,

        [EnumMember(Value = "951")]
        GrantingPermission = 951,

        [EnumMember(Value = "1000")]
        CheckingList = 1000,

        [EnumMember(Value = "1001")]
        UploadingTemplate = 1001,

        [EnumMember(Value = "1002")]
        CreatingList = 1002,

        [EnumMember(Value = "1050")]
        CreatingCMPlan = 1050,

        [EnumMember(Value = "1051")]
        RunningCMPlan = 1051,

        [EnumMember(Value = "1052")]
        SettingGroupSharing = 1052,

        [EnumMember(Value = "1053")]
        SettingOutlookExperience = 1053,

        [EnumMember(Value = "1054")]
        WelcomeEmail = 1054,

        [EnumMember(Value = "1055")]
        FailedWithSubRequestException = 1055,

        [EnumMember(Value = "3000")]
        StartingProcess = 3000

    }

}
