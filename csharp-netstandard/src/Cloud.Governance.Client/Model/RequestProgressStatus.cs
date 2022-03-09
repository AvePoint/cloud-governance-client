

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
    
    public enum RequestProgressStatus
    {
        None = 0,

        ErrorStart = 1,

        Error = 2,

        RequestSubmitted = 3,

        TaskCreated = 4,

        AdminContactIssueReview = 5,

        Cancelled = 6,

        Rejected = 7,

        FirstStageApproval = 8,

        SecondStageApproval = 9,

        ThirdStageApproval = 10,

        Completed = 11,

        AssignContentDatabase = 12,

        CreateSiteCollection = 13,

        ApplySecuritySettings = 14,

        ApplySharePointConfigurations = 15,

        ApplyCustomMetadata = 16,

        AddToSiteCollectionDirectory = 17,

        ApplyDocAveGranularBackupPlan = 18,

        ApplyDocAveAuditorPlan = 19,

        ApplyDocAveDeadAccountCleaningPlan = 20,

        ApplyDocAveScheduledStorageManagerProfile = 21,

        ApplyDocAveArchiverProfile = 22,

        ApplyDocAveVaultProfile = 23,

        ApplyAndRunDPMPlan = 24,

        ArchiveSiteCollection = 25,

        UpdateSiteCollectionArchived = 26,

        ExtendSiteCollection = 27,

        UpdateCustomMetadata = 28,

        UpdateSiteDirectory = 29,

        DeleteSiteCollection = 30,

        UpdateSiteCollectionDeleted = 31,

        CreateSubSite = 32,

        AddToSubSiteDirectory = 33,

        RetractDocAveGranularBackupPlan = 34,

        RetractDocAveAuditorPlan = 35,

        RetractDocAveDeadAccountCleaningPlan = 36,

        RetractDocAveScheduledStorageManagerProfile = 37,

        RetrieveDocAveArchiveProfile = 38,

        RetrieveDocAveVaultProfile = 39,

        UpdateChangeSCPolicyMetadata = 40,

        UpdateSiteCollectionPolicyChanged = 41,

        CreateHiddenList = 42,

        ChangeSiteCollectionMetadata = 43,

        UpdateSiteDirectoryForChangeSCMetadata = 44,

        ChangeSiteCollectionContact = 45,

        UpdateSiteDirectoryForChangeSCContact = 46,

        CloneUserPermission = 47,

        SearchUserPermission = 48,

        InProgress = 49,

        CompletedWithException = 50,

        DeleteSubSite = 51,

        UpdateDeleteSubSite = 52,

        ArchiveSubSite = 53,

        UpdateArchiveSubSite = 54,

        ChangeSubSiteMetadata = 55,

        UpdateSiteDirectoryForChangeSSMetadata = 56,

        FirstTaskCreated = 57,

        SecondTaskCreated = 58,

        ThirdTaskCreated = 59,

        GrantUserPermission = 60,

        RemoveUserPermission = 61,

        ChangeSCSettingsTitleDes = 62,

        CreateMySiteCompleted = 63,

        CreateCMPlan = 64,

        RunCMPlan = 65,

        ApplyArchiverProfile = 67,

        CreateListCompleted = 68,

        ChangeListURL = 69,

        ChangeListSettingsCompleted = 71,

        RegistSiteCollectionToDcoAveGroup = 72,

        ApplyPolicyEnforcerProfile = 73,

        UpdatePolicyEnforcerProfileCompleted = 74,

        PermissionRecertificationTriggered = 75,

        ChangingUserPermission = 76,

        RequesterReportCreated = 77,

        ApplyDeployAppPart = 78,

        ApplyAddAppPart = 79,

        ApplyingDeploymentManagerPlan = 80,

        ApplyPermissionRecertification = 81,

        ApplyMetadataRecertification = 82,

        ApplyOwnershipRecertification = 83,

        UnlockSiteCollection = 84,

        UpdateSiteCollectionUnlocked = 85,

        ChangeSiteCollectionOwner = 86,

        ChangeSiteCollectionAdditionalAdmin = 87,

        CreateOrValidYammerGroup = 88,

        AddYammerGroupFeed = 89,

        CancelAutoTask = 90,

        ContinueAccess = 91,

        ChangeSSSettingsTitleDes = 92,

        FailedToSubmit = 94,

        WaitingForSubmission = 95,

        AllApprovalStageComplete = 96,

        LockSiteCollection = 97,

        UpdateSiteCollectionLocked = 98,

        ChangeSiteCollectionQuota = 99,

        UpdateSiteCollectionChangedQuota = 100,

        ApplyAdditionalAdministrators = 101,

        CallCustomActionBeforeApproval = 400,

        MaintanceWindow = 401,

        CreateUser = 500,

        AssignManager = 501,

        AssignLicense = 502,

        AddUserToGroups = 503,

        RemoveUserFromGroups = 504,

        AddUserReport = 505,

        ApplyUserPolicy = 506,

        ApplyOneDriveSiteProperties = 507,

        ChangeUser = 510,

        ChangeUserContact = 511,

        ChangeUserLicense = 512,

        ChangeUserManager = 513,

        ChangeUserGroups = 514,

        UpdateUserReport = 515,

        ApplyUserRole = 516,

        DeleteUser = 520,

        BlockUser = 521,

        ResetPassword = 522,

        ExtendUser = 523,

        ChangeUserPolicy = 524,

        UnblockUser = 525,

        ChangeGroup = 530,

        UpdateGroupReport = 531,

        AddOwnersToGroup = 532,

        AddMembersToGroup = 533,

        RemoveOwnersFromGroup = 534,

        RemoveMembersFromGroup = 535,

        UpdateMetadatasToSite = 536,

        ChangeDynamicGroupRules = 537,

        CreateGroup = 540,

        UpdateGroup = 541,

        SetGroupOwners = 542,

        SetGroupMembers = 543,

        SetGroupQuota = 544,

        AddGroupReport = 545,

        ApplyGroupPolicy = 546,

        EnableTeamCollaboration = 547,

        ApplySiteDesign = 548,

        ApplyGroupCustomMetadata = 549,

        DeleteGroup = 550,

        ChangeGroupPolicy = 551,

        ExtendGroup = 552,

        UpdateGroupStatus = 553,

        InstallApp = 554,

        GetGroup = 555,

        RegisterSiteDocave = 556,

        GetGroupSite = 557,

        ChangeGroupQuota = 558,

        SetGeoLocation = 559,

        ArchiveTeam = 560,

        UnArchiveTeam = 561,

        ApplyGroupExtension = 562,

        ChangeTeamPrivateChannelSiteQuota = 563,

        CreatingSite = 600,

        ApplyingCustomTemplate = 601,

        ApplyingSecuritySettings = 602,

        ApplyingCustomMetadata = 603,

        ApplyingSitePolicy = 604,

        ApplyingAdditionalAdministrators = 605,

        AddingToSiteDirectory = 606,

        RegistingSiteToDao = 607,

        ApplyingServiceDpmPlan = 608,

        ServiceDpmPlanExecuted = 609,

        ApplyingPolicyDpmPlan = 610,

        PolicyDpmPlanExecuted = 611,

        ApplyingPolicyEnforcerProfile = 612,

        ApplyingArchiverProfile = 613,

        ApplyingRecertification = 614,

        InstallingApp = 615,

        AddingAppParts = 616,

        CreatingOrValidYammerGroup = 617,

        AddingYammerGroupFeed = 618,

        RemovingServiceAccount = 619,

        CreateGuestUser = 620,

        UpdateGuestUser = 621,

        AddGuestUserToGroup = 622,

        AddGuestUserReport = 623,

        ApplyGuestUserRenewal = 624,

        ApplyGuestUserElection = 625,

        CreatingWeb = 700,

        ApplyingSecuritySettingsToWeb = 701,

        ApplyingSharePointConfigurationsToWeb = 702,

        ApplyingCustomMetadataToWeb = 703,

        ApplyAndRunDPMPlanInCreatingWeb = 704,

        AddingWebToDatabase = 705,

        UpdatingWebInDatabase = 706,

        DeployingAppPartToWeb = 707,

        AddingAppPartToWeb = 708,

        CreatingOrValidingYammerGroupInCreatingWeb = 709,

        AddingYammerGroupFeedInWeb = 710,

        DeletingSite = 800,

        ArchivingSite = 801,

        ChangingSitePolicy = 802,

        UnlockingSite = 803,

        LockingSite = 804,

        ExtendingSite = 805,

        ChangingSiteQuota = 806,

        ChangingSiteTitleAndDescription = 830,

        ChangingSiteMetadata = 831,

        UpdatingSiteDirectory = 832,

        ConvertingToHubSite = 833,

        ConnectingToHubSite = 834,

        UnregisteringHubSite = 835,

        ChangingSensitivity = 836,

        ChangingWebTitleAndDescription = 850,

        ChangingListSetting = 900,

        WaitingForGrantPermission = 950,

        GrantingPermission = 951,

        CheckingList = 1000,

        UploadingTemplate = 1001,

        CreatingList = 1002,

        CreatingCMPlan = 1050,

        RunningCMPlan = 1051,

        SettingGroupSharing = 1052,

        SettingOutlookExperience = 1053,

        WelcomeEmail = 1054,

        FailedWithSubRequestException = 1055,

        ValidatePrivateChannel = 1100,

        CreatePrivateChannel = 1101,

        AddUserToChannel = 1102,

        AddChannelToDB = 1103,

        ApplyPolicyToChannel = 1104,

        ChangeChannelName = 1200,

        ChangeChannelDescription = 1201,

        ChangeChannelMembers = 1202,

        ChangeChannelOwners = 1203,

        ChangeChannelToDB = 1204,

        RegistingSiteToAos = 2000,

        RegistingGroupToAos = 2001,

        StartingProcess = 3000

    }

}
