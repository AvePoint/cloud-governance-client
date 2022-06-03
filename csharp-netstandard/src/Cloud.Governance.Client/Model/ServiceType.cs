

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
    
    public enum ServiceType
    {
        None = 0,

        ProvisionSiteCollection = 1,

        CreateSubSite = 2,

        SiteCollectionLifecycleMgmt = 3,

        ArchiveSiteCollection = 4,

        DeleteSiteCollection = 5,

        ExtendSiteCollection = 6,

        ChangeSiteCollectionPolicy = 7,

        ChangeSiteCollectionMetadata = 8,

        ChangeSiteCollectionContact = 9,

        TransferUserPermission = 10,

        ManualArchiveSiteCollectionContent = 11,

        CloneUserPermissions = 12,

        SiteLifecycleManagement = 13,

        GrantUserPermissions = 14,

        RemoveUserPermissions = 15,

        ChangeSubSitePolicy = 16,

        ChangeSubSiteMetadata = 17,

        ChangeSubSiteContact = 18,

        CleanDeadAccounts = 19,

        BackupAndRestore = 20,

        ArchiveUserContent = 21,

        MoveListItem = 22,

        MoveList = 23,

        MoveSite = 24,

        SiteTemplateDeployment = 25,

        SiteThemeDeployment = 26,

        SandboxSolutionDeployment = 27,

        FarmSolutionDeployment = 28,

        SiteOwnerReporting = 29,

        SiteCollectionOwnerReporting = 30,

        SiteRequestReporting = 31,

        ContentManager = 32,

        ProvisionSiteCollectionExternal = 33,

        MySite = 40,

        CreateList = 41,

        ChangeList = 42,

        AutoSiteCollectionLifecycleMgmt = 43,

        QuestionaireMgmt = 44,

        PermRecertify = 46,

        MetadataRecertify = 47,

        OwnershipRecertification = 48,

        Election = 49,

        Unlock = 50,

        AutoLocking = 51,

        SCInactivityThreshold = 52,

        SCLeasePeriod = 53,

        Blank = 54,

        LockSC = 55,

        ChangeSCQuota = 56,

        ApplySiteInformation = 57,

        ImportSite = 58,

        ApplySitePolicy = 59,

        ImportWeb = 60,

        RenewSite = 61,

        RenewGroup = 62,

        ExportReport = 63,

        RequestValidation = 64,

        SyncSiteMetadata = 65,

        PermissionManagement = 66,

        BulkUpdate = 67,

        CreateGuestUser = 68,

        BulkUpdateGroupTeam = 69,

        RenewGuestUser = 70,

        UpdateSiteLockStatus = 72,

        ApplySitePolicyPartSetting = 73,

        ApplyGroupPolicyPartSetting = 74,

        ApplyGroupExternalSharingProfilePartSetting = 75,

        ApplyGroupQuotaProfilePartSetting = 76,

        CreateUser = 110,

        ChangeUser = 111,

        UserLifecycle = 112,

        OffBoardingUser = 113,

        ExtendUser = 114,

        ChangeUserPolicy = 115,

        UnblockUser = 116,

        ChangeUserLoginName = 117,

        CreateGroup = 120,

        ChangeGroup = 121,

        GroupLifecycle = 122,

        DeleteGroup = 123,

        ExtendGroup = 124,

        ChangeGroupPolicy = 125,

        ChangeGroupQuota = 128,

        ContinueAccess = 130,

        ApplyGroupInformation = 131,

        ApplyGroupPolicy = 132,

        ImportAzureGroup = 133,

        ImportAzureUser = 134,

        PostCreateGroup = 135,

        ImportAzureGuestUser = 136,

        ImportYammer = 137,

        ArchiveTeam = 140,

        UnArchiveTeam = 141,

        GroupMembershipRecertification = 200,

        GroupPermissionRecertification = 201,

        SyncSite = 501,

        UpgradeSiteLifecycleSetting = 502,

        AutoElection = 503,

        ManualArchiveTimer = 504,

        SyncWeb = 505,

        QuotaThresholdTimerJob = 506,

        SyncUserForDynamicRule = 507,

        SyncGroup = 508,

        AutoImportSiteCustomService = 509,

        AutoImportSite = 510,

        AutoImportGroup = 511,

        TemporaryPermissionStart = 512,

        TemporaryPermissionEnd = 513,

        TemporaryPermissionExpiringNotificationJob = 514,

        RenewTeams = 515,

        AutoExportReport = 516,

        SyncUserInformation = 517,

        SyncUpsMetadata = 518,

        GroupAutoElection = 520,

        SyncGuestUser = 521,

        RenewYammer = 522,

        SpecifyContacts = 530,

        UpdateGroupStieLockStatus = 531,

        BulkDeleteWorkspace = 532,

        BulkManageWorkspaceLockState = 533,

        BulkArchiveSite = 534,

        BulkArchiveTeams = 535,

        BulkRestoreTeams = 536,

        RemoveSite = 540,

        RemoveGroup = 541,

        RemoveWeb = 542,

        AutoImportGroupEscalation = 543,

        AutoImportSiteEscalation = 544,

        BulkAutoCompleteRenewal = 545,

        BulkRestartRenewal = 546,

        AutoImportGuestUser = 547,

        MPWelcomeEmailTemplate = 548,

        AutoImportYammerCommunity = 549,

        BulkApplyGuestRenewal = 550,

        BulkSpecifyGuestContact = 551,

        BulkRestartGuestRenewal = 552,

        BulkSpecifyGuestOneTimeRenewal = 553,

        RemoveGuestUser = 554,

        RemoveWorkspace = 555,

        CreatePrivateChannel = 556,

        BulkApplyGroupExtensions = 557,

        BulkReassignRenewalTask = 558,

        BulkReassignAutoImportTask = 559,

        GuestAutoElection = 560,

        BulkApplyGuestElection = 561,

        ChangePrivateChannel = 562,

        RequestReportAction = 563,

        ApplyTeamProfiles = 564,

        ApplyGroupProfiles = 565,

        ApplyYammerProfiles = 566,

        ApplySiteProfiles = 567,

        UpdateModernRenewalProfile = 568

    }

}
