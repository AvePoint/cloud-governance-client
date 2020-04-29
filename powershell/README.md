# Cloud.Governance.Client - the PowerShell module for the Cloud Governance Api

<a name="frameworks-supported"></a>
## Frameworks supported
- PowerShell 3.0 or later

<a name="installation"></a>
## Installation

```powershell
Install-Module -Name Cloud.Governance.Client
```

## Documentation for API Endpoints

All URIs are relative to *https://API_BASE_URL*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AosAdminApi* | [**Get-ActiveLicenses**](docs/AosAdminApi.md#Get-ActiveLicenses) | **GET** /admin/aos/licenses | get active licences
*AosAdminApi* | [**Get-AdminCenterUrls**](docs/AosAdminApi.md#Get-AdminCenterUrls) | **GET** /admin/aos/admincenters | 
*AosAdminApi* | [**Get-ArchiveProfiles**](docs/AosAdminApi.md#Get-ArchiveProfiles) | **GET** /admin/aos/cloudmanagement/profiles/archive/{level} | get archive profiles
*AosAdminApi* | [**Get-AzureADProfiles**](docs/AosAdminApi.md#Get-AzureADProfiles) | **GET** /admin/aos/profiles/azuread | 
*AosAdminApi* | [**Get-DpmPlans**](docs/AosAdminApi.md#Get-DpmPlans) | **GET** /admin/aos/cloudmanagement/profiles/dpm | get dpm plans
*AosAdminApi* | [**Get-EnforcerProfiles**](docs/AosAdminApi.md#Get-EnforcerProfiles) | **GET** /admin/aos/cloudmanagement/profiles/enforcer | get enforcer profiles
*ApprovalprocessesAdminApi* | [**Invoke-CreateApprovalProcess**](docs/ApprovalprocessesAdminApi.md#Invoke-CreateApprovalProcess) | **POST** /admin/approvalprocesses | create approval process
*ApprovalprocessesAdminApi* | [**Invoke-DeleteSelectedApprovalProcesses**](docs/ApprovalprocessesAdminApi.md#Invoke-DeleteSelectedApprovalProcesses) | **DELETE** /admin/approvalprocesses | remove selected approval processes
*ApprovalprocessesAdminApi* | [**Get-ApprovalProcessFilters**](docs/ApprovalprocessesAdminApi.md#Get-ApprovalProcessFilters) | **GET** /admin/approvalprocesses/filters | get filters of approval process
*ApprovalprocessesAdminApi* | [**Get-ApprovalProcessSetting**](docs/ApprovalprocessesAdminApi.md#Get-ApprovalProcessSetting) | **GET** /admin/approvalprocesses/{id} | get edit approval process setting
*ApprovalprocessesAdminApi* | [**Get-ApprovalProcesses**](docs/ApprovalprocessesAdminApi.md#Get-ApprovalProcesses) | **GET** /admin/approvalprocesses | get all approval processes
*ApprovalprocessesAdminApi* | [**Update-ApprovalProcess**](docs/ApprovalprocessesAdminApi.md#Update-ApprovalProcess) | **PUT** /admin/approvalprocesses | update approval process
*ApprovalprocessesAdminApi* | [**Update-SelectedApprovalProcessesStatus**](docs/ApprovalprocessesAdminApi.md#Update-SelectedApprovalProcessesStatus) | **PATCH** /admin/approvalprocesses/status/{status} | update the status of selected approval processes
*AuditDirectoryAdminApi* | [**Get-RequestActivities**](docs/AuditDirectoryAdminApi.md#Get-RequestActivities) | **GET** /admin/directory/audit/requests | get request activites
*AuditDirectoryAdminApi* | [**Get-RequestActivityFilters**](docs/AuditDirectoryAdminApi.md#Get-RequestActivityFilters) | **GET** /admin/directory/audit/requests/filters | get request activity filters
*AuditDirectoryAdminApi* | [**Get-UserActivities**](docs/AuditDirectoryAdminApi.md#Get-UserActivities) | **GET** /admin/directory/audit/users | get user activities
*AuditDirectoryAdminApi* | [**Get-UserActivityFilters**](docs/AuditDirectoryAdminApi.md#Get-UserActivityFilters) | **GET** /admin/directory/audit/users/filters | get user activity filters
*AuditDirectoryAdminApi* | [**Get-WorkspaceActivities**](docs/AuditDirectoryAdminApi.md#Get-WorkspaceActivities) | **GET** /admin/directory/audit/workspace | get office365 workspace activites
*AuditDirectoryAdminApi* | [**Get-WorkspaceActivityFilters**](docs/AuditDirectoryAdminApi.md#Get-WorkspaceActivityFilters) | **GET** /admin/directory/audit/workspace/filters | get office365 workspace activity filters
*AuthApi* | [**Get-DelegateAccessToken**](docs/AuthApi.md#Get-DelegateAccessToken) | **POST** /auth/token/delegate | get delegate access token by client id and client secret which created in cloud governance Api Authentication Management
*AuthApi* | [**Get-TokenUsage**](docs/AuthApi.md#Get-TokenUsage) | **GET** /auth/token/usage | 
*AuthApi* | [**Get-UserTokenUrl**](docs/AuthApi.md#Get-UserTokenUrl) | **GET** /auth/token/user/url | get the url which used to get user access token
*AuthApi* | [**Invoke-RefreshUserAccessToken**](docs/AuthApi.md#Invoke-RefreshUserAccessToken) | **POST** /auth/token/user/refresh | refresh user access token
*DashboardAdminApi* | [**Invoke-CreateLineOrColumnReport**](docs/DashboardAdminApi.md#Invoke-CreateLineOrColumnReport) | **POST** /admin/dashboard/charts/lineorcolumn | create line or column report
*DashboardAdminApi* | [**Invoke-CreatePieReport**](docs/DashboardAdminApi.md#Invoke-CreatePieReport) | **POST** /admin/dashboard/charts/pie | create pie report
*DashboardAdminApi* | [**Invoke-DeleteReport**](docs/DashboardAdminApi.md#Invoke-DeleteReport) | **DELETE** /admin/dashboard/charts/{id} | delete report
*DashboardAdminApi* | [**Get-AllReportsIndex**](docs/DashboardAdminApi.md#Get-AllReportsIndex) | **GET** /admin/dashboard/charts/all | load all report index
*DashboardAdminApi* | [**Get-LastLastModifiedTime**](docs/DashboardAdminApi.md#Get-LastLastModifiedTime) | **GET** /admin/dashboard/charts/timerange | get default time range
*DashboardAdminApi* | [**Get-ReportSettings**](docs/DashboardAdminApi.md#Get-ReportSettings) | **GET** /admin/dashboard/charts/{id}/settings | get report info for edit
*DashboardAdminApi* | [**Invoke-LoadChartStatistics**](docs/DashboardAdminApi.md#Invoke-LoadChartStatistics) | **GET** /admin/dashboard/charts/statistics/{source} | load chart statistic data by source type
*DashboardAdminApi* | [**Invoke-LoadLegendEntries**](docs/DashboardAdminApi.md#Invoke-LoadLegendEntries) | **GET** /admin/dashboard/charts/legendentries/{source}/{legendsource} | load legend entries
*DashboardAdminApi* | [**Update-LineOrColumnReport**](docs/DashboardAdminApi.md#Update-LineOrColumnReport) | **PUT** /admin/dashboard/charts/lineorcolumn | update line or column report
*DashboardAdminApi* | [**Update-PieReport**](docs/DashboardAdminApi.md#Update-PieReport) | **PUT** /admin/dashboard/charts/pie | update pie report
*DirectoryAdminApi* | [**Invoke-ApplyGroupsPolicy**](docs/DirectoryAdminApi.md#Invoke-ApplyGroupsPolicy) | **POST** /admin/directory/groups/policy | apply groups policy
*DirectoryAdminApi* | [**Invoke-ApplySitesPolicy**](docs/DirectoryAdminApi.md#Invoke-ApplySitesPolicy) | **POST** /admin/directory/sites/policy | apply sites policy
*DirectoryAdminApi* | [**Invoke-ApplyTeamsPolicy**](docs/DirectoryAdminApi.md#Invoke-ApplyTeamsPolicy) | **POST** /admin/directory/teams/policy | apply teams policy
*DirectoryAdminApi* | [**Invoke-ElectContact**](docs/DirectoryAdminApi.md#Invoke-ElectContact) | **POST** /admin/directory/sites/contact/election | elect sites contact
*DirectoryAdminApi* | [**Export-ManagedGroups**](docs/DirectoryAdminApi.md#Export-ManagedGroups) | **GET** /admin/directory/groups/export | export all managed groups
*DirectoryAdminApi* | [**Export-ManagedSites**](docs/DirectoryAdminApi.md#Export-ManagedSites) | **GET** /admin/directory/sites/export | export all managed sites
*DirectoryAdminApi* | [**Export-ManagedTeams**](docs/DirectoryAdminApi.md#Export-ManagedTeams) | **GET** /admin/directory/teams/export | export all managed teams
*DirectoryAdminApi* | [**Get-AllMailContacts**](docs/DirectoryAdminApi.md#Get-AllMailContacts) | **GET** /admin/directory/sites/contact/mail | get all sites contacts
*DirectoryAdminApi* | [**Get-ManagedGroupFilters**](docs/DirectoryAdminApi.md#Get-ManagedGroupFilters) | **GET** /admin/directory/groups/filters | get managed groups filters
*DirectoryAdminApi* | [**Get-ManagedGroups**](docs/DirectoryAdminApi.md#Get-ManagedGroups) | **GET** /admin/directory/groups | get all managed groups
*DirectoryAdminApi* | [**Get-ManagedSites**](docs/DirectoryAdminApi.md#Get-ManagedSites) | **GET** /admin/directory/sites | get all managed sites
*DirectoryAdminApi* | [**Get-ManagedSitesFilters**](docs/DirectoryAdminApi.md#Get-ManagedSitesFilters) | **GET** /admin/directory/sites/filters | get managed sites filters
*DirectoryAdminApi* | [**Get-ManagedTeamFilters**](docs/DirectoryAdminApi.md#Get-ManagedTeamFilters) | **GET** /admin/directory/teams/filters | get managed teams filters
*DirectoryAdminApi* | [**Get-ManagedTeams**](docs/DirectoryAdminApi.md#Get-ManagedTeams) | **GET** /admin/directory/teams | get all managed teams
*DirectoryAdminApi* | [**Get-ManagedWebs**](docs/DirectoryAdminApi.md#Get-ManagedWebs) | **GET** /admin/directory/webs | get all managed webs
*DirectoryAdminApi* | [**Get-ManagedWebsFilters**](docs/DirectoryAdminApi.md#Get-ManagedWebsFilters) | **GET** /admin/directory/webs/filters | get managed webs filters
*DirectoryAdminApi* | [**Invoke-SpecifyContact**](docs/DirectoryAdminApi.md#Invoke-SpecifyContact) | **POST** /admin/directory/sites/contact/specification | specify selected sites contact
*EmailsApi* | [**Get-EmailTemplate**](docs/EmailsApi.md#Get-EmailTemplate) | **GET** /emails/{type} | get email templates by email template type
*LifecycleSettingsAdminApi* | [**Add-Reminder**](docs/LifecycleSettingsAdminApi.md#Add-Reminder) | **POST** /admin/settings/lifecycle/reminders | create reminder
*LifecycleSettingsAdminApi* | [**Invoke-DeleteReminder**](docs/LifecycleSettingsAdminApi.md#Invoke-DeleteReminder) | **DELETE** /admin/settings/lifecycle/reminders/{id} | delete reminder
*LifecycleSettingsAdminApi* | [**Invoke-DeleteReminders**](docs/LifecycleSettingsAdminApi.md#Invoke-DeleteReminders) | **DELETE** /admin/settings/lifecycle/reminders | delete reminders
*LifecycleSettingsAdminApi* | [**Edit-Reminder**](docs/LifecycleSettingsAdminApi.md#Edit-Reminder) | **PUT** /admin/settings/lifecycle/reminders | Edit reminder
*LifecycleSettingsAdminApi* | [**Invoke-GerminderById**](docs/LifecycleSettingsAdminApi.md#Invoke-GerminderById) | **GET** /admin/settings/lifecycle/reminders/{id} | get reminder
*LifecycleSettingsAdminApi* | [**Get-ElectionProcessSettings**](docs/LifecycleSettingsAdminApi.md#Get-ElectionProcessSettings) | **GET** /admin/settings/lifecycle/election | get election process settings
*LifecycleSettingsAdminApi* | [**Get-RecertificationProfiles**](docs/LifecycleSettingsAdminApi.md#Get-RecertificationProfiles) | **GET** /admin/settings/lifecycle/recertification | get recertification profiles
*LifecycleSettingsAdminApi* | [**Get-Reminders**](docs/LifecycleSettingsAdminApi.md#Get-Reminders) | **GET** /admin/settings/lifecycle/reminders | get reminder list
*LifecycleSettingsAdminApi* | [**Save-ElectionProcessSettings**](docs/LifecycleSettingsAdminApi.md#Save-ElectionProcessSettings) | **POST** /admin/settings/lifecycle/election | 
*MetadataApi* | [**Get-Metadata**](docs/MetadataApi.md#Get-Metadata) | **GET** /metadata | get metadata
*MetadataApi* | [**Get-MetadataById**](docs/MetadataApi.md#Get-MetadataById) | **GET** /metadata/{id} | get metadata by id
*MetadataAdminApi* | [**Invoke-CreateMetadata**](docs/MetadataAdminApi.md#Invoke-CreateMetadata) | **POST** /admin/metadata | Create metadata
*MetadataAdminApi* | [**Invoke-DeleteMetadata**](docs/MetadataAdminApi.md#Invoke-DeleteMetadata) | **DELETE** /admin/metadata/{id} | delete metadata
*MetadataAdminApi* | [**Get-AllMetadata**](docs/MetadataAdminApi.md#Get-AllMetadata) | **GET** /admin/metadata | get all metadata
*MetadataAdminApi* | [**Get-MetadataFilters**](docs/MetadataAdminApi.md#Get-MetadataFilters) | **GET** /admin/metadata/filters | get metadata filters
*MetadataAdminApi* | [**Get-SingleMetadataById**](docs/MetadataAdminApi.md#Get-SingleMetadataById) | **GET** /admin/metadata/{id} | Get metadata by id
*MetadataAdminApi* | [**Update-Metadata**](docs/MetadataAdminApi.md#Update-Metadata) | **PUT** /admin/metadata | Update metadata
*NotificationSettingsAdminApi* | [**Add-Emailtemplate**](docs/NotificationSettingsAdminApi.md#Add-Emailtemplate) | **POST** /admin/settings/notification/emailtemplates | add a new email template
*NotificationSettingsAdminApi* | [**Invoke-DeleteEmailTemplate**](docs/NotificationSettingsAdminApi.md#Invoke-DeleteEmailTemplate) | **DELETE** /admin/settings/notification/emailtemplates/{id} | delete email template
*NotificationSettingsAdminApi* | [**Invoke-DeleteEmailTemplates**](docs/NotificationSettingsAdminApi.md#Invoke-DeleteEmailTemplates) | **DELETE** /admin/settings/notification/emailtemplates | delete email templates
*NotificationSettingsAdminApi* | [**Edit-eEmailTemplate**](docs/NotificationSettingsAdminApi.md#Edit-eEmailTemplate) | **PUT** /admin/settings/notification/emailtemplates | edit email template
*NotificationSettingsAdminApi* | [**Get-AdministratorNotification**](docs/NotificationSettingsAdminApi.md#Get-AdministratorNotification) | **GET** /admin/settings/notification/contacts | get administrator notification settings
*NotificationSettingsAdminApi* | [**Get-DelayNotificationSettings**](docs/NotificationSettingsAdminApi.md#Get-DelayNotificationSettings) | **GET** /admin/settings/notification/delay | get delay notification configurations
*NotificationSettingsAdminApi* | [**Get-EmailTemplateById**](docs/NotificationSettingsAdminApi.md#Get-EmailTemplateById) | **GET** /admin/settings/notification/emailtemplates/{id} | get email template with id
*NotificationSettingsAdminApi* | [**Get-EmailTemplateFilters**](docs/NotificationSettingsAdminApi.md#Get-EmailTemplateFilters) | **GET** /admin/settings/notification/emailtemplates/filters | get filters of email templates
*NotificationSettingsAdminApi* | [**Get-EmailTemplateTypes**](docs/NotificationSettingsAdminApi.md#Get-EmailTemplateTypes) | **GET** /admin/settings/notification/emailtemplates/types | get email template types
*NotificationSettingsAdminApi* | [**Get-EmailTemplates**](docs/NotificationSettingsAdminApi.md#Get-EmailTemplates) | **GET** /admin/settings/notification/emailtemplates | get email templates
*NotificationSettingsAdminApi* | [**Get-ReferencesForBody**](docs/NotificationSettingsAdminApi.md#Get-ReferencesForBody) | **GET** /admin/settings/notification/emailtemplates/{type}/body/references/{languageid} | get email template references for body
*NotificationSettingsAdminApi* | [**Get-ReferencesForSubject**](docs/NotificationSettingsAdminApi.md#Get-ReferencesForSubject) | **GET** /admin/settings/notification/emailtemplates/{type}/subject/references/{languageid} | get email template references for subject
*NotificationSettingsAdminApi* | [**Save-AdministratorNotification**](docs/NotificationSettingsAdminApi.md#Save-AdministratorNotification) | **POST** /admin/settings/notification/contacts | save administrator notification settings
*NotificationSettingsAdminApi* | [**Save-DelayNotificationSettings**](docs/NotificationSettingsAdminApi.md#Save-DelayNotificationSettings) | **POST** /admin/settings/notification/delay | save delay notification configurations
*Office365Api* | [**Get-GroupInfo**](docs/Office365Api.md#Get-GroupInfo) | **GET** /office365/groups/{tenantid}/{id} | get group information
*Office365Api* | [**Get-GroupMembers**](docs/Office365Api.md#Get-GroupMembers) | **GET** /office365/groups/{email}/members | get group members by group email
*Office365Api* | [**Get-GroupMembersByGroupName**](docs/Office365Api.md#Get-GroupMembersByGroupName) | **GET** /office365/groups/members | get group members by group name
*Office365Api* | [**Get-GroupOwners**](docs/Office365Api.md#Get-GroupOwners) | **GET** /office365/groups/{email}/owners | get group owners by group email
*Office365Api* | [**Get-HubSites**](docs/Office365Api.md#Get-HubSites) | **GET** /office365/hubsites/{tenantid} | get all hubsites from a specific tenant
*Office365Api* | [**Get-HubSitesFromTenantOfSite**](docs/Office365Api.md#Get-HubSitesFromTenantOfSite) | **GET** /office365/hubsites | get all hubsites from site's tenant
*Office365Api* | [**Get-OwnedTeams**](docs/Office365Api.md#Get-OwnedTeams) | **GET** /office365/teams/my | get all teams that owner is curernt user
*Office365Api* | [**Get-Permissions**](docs/Office365Api.md#Get-Permissions) | **GET** /office365/permissions | get web permissions for creating list request by web url
*Office365Api* | [**Get-RoleAssignment**](docs/Office365Api.md#Get-RoleAssignment) | **GET** /office365/roleassignment | get site permimssion role assignment
*Office365Api* | [**Get-SiteDesigns**](docs/Office365Api.md#Get-SiteDesigns) | **GET** /office365/sitedesigns | get site designs by site url
*Office365Api* | [**Get-SiteInfo**](docs/Office365Api.md#Get-SiteInfo) | **GET** /office365/sites | get site collection information with url
*Office365Api* | [**Get-SitePermissionLevels**](docs/Office365Api.md#Get-SitePermissionLevels) | **GET** /office365/sites/permissionlevels | get site permission levels
*Office365Api* | [**Get-SiteSharePointGroups**](docs/Office365Api.md#Get-SiteSharePointGroups) | **GET** /office365/sites/sharepointgroups | get site sharePoint groups
*Office365Api* | [**Get-SiteTemplates**](docs/Office365Api.md#Get-SiteTemplates) | **GET** /office365/sites/templates/{languageid} | get site templates with language code identifier
*Office365Api* | [**Get-YammerGroup**](docs/Office365Api.md#Get-YammerGroup) | **GET** /office365/yammergroup/{networkid}/{name} | get yammer group
*Office365Api* | [**Invoke-LoadContainers**](docs/Office365Api.md#Invoke-LoadContainers) | **GET** /office365/containers/{serviceid} | load the containers from cloud management
*Office365Api* | [**Invoke-LoadFolders**](docs/Office365Api.md#Invoke-LoadFolders) | **GET** /office365/folders/{listid} | load sharepoint folders
*Office365Api* | [**Invoke-LoadItems**](docs/Office365Api.md#Invoke-LoadItems) | **GET** /office365/items/{listid} | load sharepoint items
*Office365Api* | [**Invoke-LoadLists**](docs/Office365Api.md#Invoke-LoadLists) | **GET** /office365/lists | load sharepoint lists
*Office365Api* | [**Invoke-LoadManagedMetadata**](docs/Office365Api.md#Invoke-LoadManagedMetadata) | **GET** /office365/managedmetadata/{termStoreid}/{groupid}/{termsetid}/{parentid} | load managed metadata terms
*Office365Api* | [**Invoke-LoadManagedSites**](docs/Office365Api.md#Invoke-LoadManagedSites) | **GET** /office365/managedsites/{serviceid}/{containerid}/{isselected} | load sharepoint sites
*Office365Api* | [**Invoke-LoadWebs**](docs/Office365Api.md#Invoke-LoadWebs) | **GET** /office365/webs/{serviceid}/{siteorwebid}/{isselected}/{issite} | load sharepoint webs
*Office365AdminApi* | [**Get-AzureAdBuiltInPropertyNames**](docs/Office365AdminApi.md#Get-AzureAdBuiltInPropertyNames) | **GET** /admin/office365/azuread/property/names/builtin | get azure ad custom property names
*Office365AdminApi* | [**Get-AzureAdCustomPropertyNames**](docs/Office365AdminApi.md#Get-AzureAdCustomPropertyNames) | **GET** /admin/office365/azuread/{tenantId}/property/names/custom | get azure ad custom property names
*Office365AdminApi* | [**Get-UpsPropertyNames**](docs/Office365AdminApi.md#Get-UpsPropertyNames) | **GET** /admin/office365/userprofile/property/names | get user profile property names
*Office365SettingsAdminApi* | [**Add-ImpersonationAccount**](docs/Office365SettingsAdminApi.md#Add-ImpersonationAccount) | **POST** /admin/settings/office365/accounts | add impersonation account
*Office365SettingsAdminApi* | [**Invoke-DeleteImpersonationAccount**](docs/Office365SettingsAdminApi.md#Invoke-DeleteImpersonationAccount) | **DELETE** /admin/settings/office365/accounts/{id} | delete impersonationn account by id
*Office365SettingsAdminApi* | [**Invoke-DeleteImpersonationAccounts**](docs/Office365SettingsAdminApi.md#Invoke-DeleteImpersonationAccounts) | **DELETE** /admin/settings/office365/accounts | delete impersonation accounts
*Office365SettingsAdminApi* | [**Invoke-Deletepermissionlevel**](docs/Office365SettingsAdminApi.md#Invoke-Deletepermissionlevel) | **DELETE** /admin/settings/office365/permissionlevels/{id} | delete permission level
*Office365SettingsAdminApi* | [**Invoke-Deletepermissionlevels**](docs/Office365SettingsAdminApi.md#Invoke-Deletepermissionlevels) | **DELETE** /admin/settings/office365/permissionlevels | delete permission levels
*Office365SettingsAdminApi* | [**Edit-ImpersonationAccount**](docs/Office365SettingsAdminApi.md#Edit-ImpersonationAccount) | **PUT** /admin/settings/office365/accounts | edit impersonation account
*Office365SettingsAdminApi* | [**Edit-PermissionLevel**](docs/Office365SettingsAdminApi.md#Edit-PermissionLevel) | **PUT** /admin/settings/office365/permissionlevels | edit permission level
*Office365SettingsAdminApi* | [**Get-AppBrandingSettings**](docs/Office365SettingsAdminApi.md#Get-AppBrandingSettings) | **GET** /admin/settings/office365/branding | get app branding settings
*Office365SettingsAdminApi* | [**Get-DefaultDomain**](docs/Office365SettingsAdminApi.md#Get-DefaultDomain) | **GET** /admin/settings/office365/tenants/{id}/domain | get tenants default domain
*Office365SettingsAdminApi* | [**Get-ImpersonationAccount**](docs/Office365SettingsAdminApi.md#Get-ImpersonationAccount) | **GET** /admin/settings/office365/accounts/{id} | get impersonation account
*Office365SettingsAdminApi* | [**Get-ImpersonationAccountList**](docs/Office365SettingsAdminApi.md#Get-ImpersonationAccountList) | **GET** /admin/settings/office365/accounts | get impersonation account list
*Office365SettingsAdminApi* | [**Get-ImpersonationAccountListFilters**](docs/Office365SettingsAdminApi.md#Get-ImpersonationAccountListFilters) | **GET** /admin/settings/office365/accounts/filters | get impersonation account list filters
*Office365SettingsAdminApi* | [**Get-PermissionLevel**](docs/Office365SettingsAdminApi.md#Get-PermissionLevel) | **GET** /admin/settings/office365/permissionlevels/{id} | get permission level by id
*Office365SettingsAdminApi* | [**Get-PermissionLevels**](docs/Office365SettingsAdminApi.md#Get-PermissionLevels) | **GET** /admin/settings/office365/permissionlevels | get permission levels
*Office365SettingsAdminApi* | [**Get-ReferencedServices**](docs/Office365SettingsAdminApi.md#Get-ReferencedServices) | **GET** /admin/settings/office365/permissionlevels/{id}/services | get services that referneced these permission level
*Office365SettingsAdminApi* | [**Get-Tenants**](docs/Office365SettingsAdminApi.md#Get-Tenants) | **GET** /admin/settings/office365/tenants | get office365 tenants
*Office365SettingsAdminApi* | [**Get-UploadUrl**](docs/Office365SettingsAdminApi.md#Get-UploadUrl) | **GET** /admin/settings/office365/branding/url | get upload app branding URL
*Office365SettingsAdminApi* | [**Save-AppBrandingSettings**](docs/Office365SettingsAdminApi.md#Save-AppBrandingSettings) | **POST** /admin/settings/office365/branding | save app branding settings
*Office365SettingsAdminApi* | [**Save-PermissionLevel**](docs/Office365SettingsAdminApi.md#Save-PermissionLevel) | **POST** /admin/settings/office365/permissionlevels | create permission level
*PoliciesAdminApi* | [**Invoke-CreateGroupPolicy**](docs/PoliciesAdminApi.md#Invoke-CreateGroupPolicy) | **POST** /admin/policies/group | create group policy
*PoliciesAdminApi* | [**Invoke-CreateSitePolicy**](docs/PoliciesAdminApi.md#Invoke-CreateSitePolicy) | **POST** /admin/policies/site | create site collection policy
*PoliciesAdminApi* | [**Invoke-DeleteSelectedPolicies**](docs/PoliciesAdminApi.md#Invoke-DeleteSelectedPolicies) | **DELETE** /admin/policies | remove selected approval processes
*PoliciesAdminApi* | [**Get-ActivePolicies**](docs/PoliciesAdminApi.md#Get-ActivePolicies) | **GET** /admin/policies/active/{type} | get active policies
*PoliciesAdminApi* | [**Get-ChangePolicyScope**](docs/PoliciesAdminApi.md#Get-ChangePolicyScope) | **GET** /admin/policies/scope/{type} | get change policy scope
*PoliciesAdminApi* | [**Get-GroupPolicySettings**](docs/PoliciesAdminApi.md#Get-GroupPolicySettings) | **GET** /admin/policies/group/{id} | get edit group policy setting
*PoliciesAdminApi* | [**Get-Policies**](docs/PoliciesAdminApi.md#Get-Policies) | **GET** /admin/policies | get all policies
*PoliciesAdminApi* | [**Get-PolicyFilters**](docs/PoliciesAdminApi.md#Get-PolicyFilters) | **GET** /admin/policies/filters | get filters of policy
*PoliciesAdminApi* | [**Get-SitePolicySettings**](docs/PoliciesAdminApi.md#Get-SitePolicySettings) | **GET** /admin/policies/site/{id} | get edit site collection policy setting
*PoliciesAdminApi* | [**Update-GroupPolicy**](docs/PoliciesAdminApi.md#Update-GroupPolicy) | **PUT** /admin/policies/group | update group policy
*PoliciesAdminApi* | [**Update-SelectedPoliciesStatus**](docs/PoliciesAdminApi.md#Update-SelectedPoliciesStatus) | **PATCH** /admin/policies/status/{status} | update the status of selected approval processes
*PoliciesAdminApi* | [**Update-SitePolicy**](docs/PoliciesAdminApi.md#Update-SitePolicy) | **PUT** /admin/policies/site | update site collection policy
*QuestionnairesApi* | [**Get-QuestionnaireById**](docs/QuestionnairesApi.md#Get-QuestionnaireById) | **GET** /questionnaires/{id} | get questionnaire by id
*QuestionnairesApi* | [**Submit-Questionnaire**](docs/QuestionnairesApi.md#Submit-Questionnaire) | **POST** /questionnaires | submit questionnaire
*QuestionnairesApi* | [**Submit-QuestionnaireInWorkspace**](docs/QuestionnairesApi.md#Submit-QuestionnaireInWorkspace) | **POST** /questionnaires/workspace/{objecttype}/{objectid} | submit questionnaire in workspace
*QuestionnairesAdminApi* | [**Invoke-DeleteSelectedQuestionnaires**](docs/QuestionnairesAdminApi.md#Invoke-DeleteSelectedQuestionnaires) | **DELETE** /admin/questionnaires | remove selected questionnaires
*QuestionnairesAdminApi* | [**Get-QuestionMetadataList**](docs/QuestionnairesAdminApi.md#Get-QuestionMetadataList) | **GET** /admin/questionnaires/question/metadata | get question metadata list
*QuestionnairesAdminApi* | [**Get-QuestionServiceList**](docs/QuestionnairesAdminApi.md#Get-QuestionServiceList) | **GET** /admin/questionnaires/service | get questionnaire service list
*QuestionnairesAdminApi* | [**Get-QuestionnaireFilters**](docs/QuestionnairesAdminApi.md#Get-QuestionnaireFilters) | **GET** /admin/questionnaires/filters | get filters of questionnaires
*QuestionnairesAdminApi* | [**Get-QuestionnaireSetting**](docs/QuestionnairesAdminApi.md#Get-QuestionnaireSetting) | **GET** /admin/questionnaires/{id} | get questionnaire setting
*QuestionnairesAdminApi* | [**Get-Questionnaires**](docs/QuestionnairesAdminApi.md#Get-Questionnaires) | **GET** /admin/questionnaires | get all questionnaires
*QuestionnairesAdminApi* | [**Update-SelectedQuestionnairesStatus**](docs/QuestionnairesAdminApi.md#Update-SelectedQuestionnairesStatus) | **PATCH** /admin/questionnaires/status/{status} | update the status of selected questionnaires
*RequestsApi* | [**Invoke-CancelRequest**](docs/RequestsApi.md#Invoke-CancelRequest) | **GET** /requests/{id}/cancel | cancel request
*RequestsApi* | [**Get-ArchiveGroupRequest**](docs/RequestsApi.md#Get-ArchiveGroupRequest) | **GET** /requests/archivegroup/{id} | get archive group request
*RequestsApi* | [**Get-ArchiveSiteRequest**](docs/RequestsApi.md#Get-ArchiveSiteRequest) | **GET** /requests/archivesite/{id} | get archive site request
*RequestsApi* | [**Get-ArchiveWebRequest**](docs/RequestsApi.md#Get-ArchiveWebRequest) | **GET** /requests/archiveweb/{id} | get archive web request
*RequestsApi* | [**Get-ChagneGroupPolicyRequest**](docs/RequestsApi.md#Get-ChagneGroupPolicyRequest) | **GET** /requests/changegrouppolicy/{id} | get change group policy request
*RequestsApi* | [**Get-ChangeGroupQuotaRequest**](docs/RequestsApi.md#Get-ChangeGroupQuotaRequest) | **GET** /requests/changegroupquota/{id} | get change group quota request
*RequestsApi* | [**Get-ChangeGroupSettingRequest**](docs/RequestsApi.md#Get-ChangeGroupSettingRequest) | **GET** /requests/changegroup/{id} | get change group settings request
*RequestsApi* | [**Get-ChangeListSettingRequest**](docs/RequestsApi.md#Get-ChangeListSettingRequest) | **GET** /requests/changelistsetting/{id} | get change list settings request
*RequestsApi* | [**Get-ChangePermissionRequest**](docs/RequestsApi.md#Get-ChangePermissionRequest) | **GET** /requests/changepermission/{id} | get change permission request
*RequestsApi* | [**Get-ChangeSiteContactRequest**](docs/RequestsApi.md#Get-ChangeSiteContactRequest) | **GET** /requests/changesite/adminorcontact/{id} | get change site administrator or contact request
*RequestsApi* | [**Get-ChangeSitePolicyRequest**](docs/RequestsApi.md#Get-ChangeSitePolicyRequest) | **GET** /requests/changesitepolicy/{id} | get change site policy request
*RequestsApi* | [**Get-ChangeSiteQuotaRequest**](docs/RequestsApi.md#Get-ChangeSiteQuotaRequest) | **GET** /requests/changesitequota/{id} | get change site quota request
*RequestsApi* | [**Get-ChangeSiteSettingRequest**](docs/RequestsApi.md#Get-ChangeSiteSettingRequest) | **GET** /requests/changesite/setting/{id} | get change site settings request
*RequestsApi* | [**Get-ChangeWebContactRequest**](docs/RequestsApi.md#Get-ChangeWebContactRequest) | **GET** /requests/changewebcontact/{id} | get change web contact request
*RequestsApi* | [**Get-ChangeWebSettingRequest**](docs/RequestsApi.md#Get-ChangeWebSettingRequest) | **GET** /requests/changewebsettings/{id} | get change web settings request
*RequestsApi* | [**Get-ChangedPermissionItems**](docs/RequestsApi.md#Get-ChangedPermissionItems) | **GET** /requests/changepermission/{id}/result | get changed permission items
*RequestsApi* | [**Get-ClonePermissionRequest**](docs/RequestsApi.md#Get-ClonePermissionRequest) | **GET** /requests/clonepermission/{id} | get clone permission request
*RequestsApi* | [**Get-ContentMoveRequest**](docs/RequestsApi.md#Get-ContentMoveRequest) | **GET** /requests/contentmove/{id} | get content move request
*RequestsApi* | [**Get-CreateGroupRequest**](docs/RequestsApi.md#Get-CreateGroupRequest) | **GET** /requests/creategroup/{id} | get create group request
*RequestsApi* | [**Get-CreateListRequest**](docs/RequestsApi.md#Get-CreateListRequest) | **GET** /requests/createlist/{id} | get create list request
*RequestsApi* | [**Get-CreateSiteRequest**](docs/RequestsApi.md#Get-CreateSiteRequest) | **GET** /requests/createsite/{id} | get create site request
*RequestsApi* | [**Get-CreateWebRequest**](docs/RequestsApi.md#Get-CreateWebRequest) | **GET** /requests/createweb/{id} | get create web request
*RequestsApi* | [**Get-CustomRequest**](docs/RequestsApi.md#Get-CustomRequest) | **GET** /requests/custom/{id} | get custom service request
*RequestsApi* | [**Get-DeleteGroupRequest**](docs/RequestsApi.md#Get-DeleteGroupRequest) | **GET** /requests/deletegroup/{id} | get delete group request
*RequestsApi* | [**Get-DeleteSiteRequest**](docs/RequestsApi.md#Get-DeleteSiteRequest) | **GET** /requests/deletesite/{id} | get delete site request
*RequestsApi* | [**Get-DeleteWebRequest**](docs/RequestsApi.md#Get-DeleteWebRequest) | **GET** /requests/deleteweb/{id} | get delete web request
*RequestsApi* | [**Get-ExtendGroupRequest**](docs/RequestsApi.md#Get-ExtendGroupRequest) | **GET** /requests/extendgroup/{id} | get extend group request
*RequestsApi* | [**Get-ExtendSiteRequest**](docs/RequestsApi.md#Get-ExtendSiteRequest) | **GET** /requests/extendsite/{id} | get extend site request
*RequestsApi* | [**Get-GrantPermissionRequest**](docs/RequestsApi.md#Get-GrantPermissionRequest) | **GET** /requests/grantpermission/{id} | get grant permission request
*RequestsApi* | [**Get-InheritedSitesForChangePermission**](docs/RequestsApi.md#Get-InheritedSitesForChangePermission) | **GET** /requests/changepermission/{id}/inheritedsites | get inherited sites for change permissin request
*RequestsApi* | [**Get-LockSiteReuqest**](docs/RequestsApi.md#Get-LockSiteReuqest) | **GET** /requests/locksite/{id} | get lock site request
*RequestsApi* | [**Get-ManagePermissionRequest**](docs/RequestsApi.md#Get-ManagePermissionRequest) | **GET** /requests/managepermission/{id} | get manage permission request
*RequestsApi* | [**Get-MyRequestFilters**](docs/RequestsApi.md#Get-MyRequestFilters) | **GET** /requests/my/filters | Get my requests filters
*RequestsApi* | [**Get-MyRequests**](docs/RequestsApi.md#Get-MyRequests) | **GET** /requests/my | get my requests
*RequestsApi* | [**Get-RequestById**](docs/RequestsApi.md#Get-RequestById) | **GET** /requests/{id} | get request by id
*RequestsApi* | [**Get-RestoreGroupRequest**](docs/RequestsApi.md#Get-RestoreGroupRequest) | **GET** /requests/restoregroup/{id} | get restore group request
*RequestsApi* | [**Get-UnlockSiteRequest**](docs/RequestsApi.md#Get-UnlockSiteRequest) | **GET** /requests/unlocksite/{id} | get unlock site request
*RequestsApi* | [**Submit-ArchiveGroupRequest**](docs/RequestsApi.md#Submit-ArchiveGroupRequest) | **POST** /requests/archivegroup | submit archive group group request
*RequestsApi* | [**Submit-ArchiveSiteRequest**](docs/RequestsApi.md#Submit-ArchiveSiteRequest) | **POST** /requests/archivesite | submit archive site request
*RequestsApi* | [**Submit-ArchiveWebRequest**](docs/RequestsApi.md#Submit-ArchiveWebRequest) | **POST** /requests/archiveweb | submit archive web request
*RequestsApi* | [**Submit-ChangeGroupPolicyRequest**](docs/RequestsApi.md#Submit-ChangeGroupPolicyRequest) | **POST** /requests/changegrouppolicy | submit change group policy request
*RequestsApi* | [**Submit-ChangeGroupQuotaRequest**](docs/RequestsApi.md#Submit-ChangeGroupQuotaRequest) | **POST** /requests/changegroupquota | submit change group quota request
*RequestsApi* | [**Submit-ChangeGroupSettingRequest**](docs/RequestsApi.md#Submit-ChangeGroupSettingRequest) | **POST** /requests/changegroup | submit change group settings request
*RequestsApi* | [**Submit-ChangeListSettingRequest**](docs/RequestsApi.md#Submit-ChangeListSettingRequest) | **POST** /requests/changelistsetting | submit change list settings request
*RequestsApi* | [**Submit-ChangePermissionRequest**](docs/RequestsApi.md#Submit-ChangePermissionRequest) | **POST** /requests/changepermission | submit change permission request
*RequestsApi* | [**Submit-ChangeSiteContactRequest**](docs/RequestsApi.md#Submit-ChangeSiteContactRequest) | **POST** /requests/changesite/adminorcontact | submit change site administrator or contact request
*RequestsApi* | [**Submit-ChangeSitePolicyRequest**](docs/RequestsApi.md#Submit-ChangeSitePolicyRequest) | **POST** /requests/changesitepolicy | submit change site policy request
*RequestsApi* | [**Submit-ChangeSiteQuotaRequest**](docs/RequestsApi.md#Submit-ChangeSiteQuotaRequest) | **POST** /requests/changesitequota | submit change site quota request
*RequestsApi* | [**Submit-ChangeSiteSettingRequest**](docs/RequestsApi.md#Submit-ChangeSiteSettingRequest) | **POST** /requests/changesite/setting | submit change site settings request
*RequestsApi* | [**Submit-ChangeWebContactRequest**](docs/RequestsApi.md#Submit-ChangeWebContactRequest) | **POST** /requests/changewebcontact | submit change web contact request
*RequestsApi* | [**Submit-ChangeWebSettingRequest**](docs/RequestsApi.md#Submit-ChangeWebSettingRequest) | **POST** /requests/changewebsettings | submit change web settings request
*RequestsApi* | [**Submit-ClonePermissionRequest**](docs/RequestsApi.md#Submit-ClonePermissionRequest) | **POST** /requests/clonepermission | get clone permission request
*RequestsApi* | [**Submit-ContentMoveRequest**](docs/RequestsApi.md#Submit-ContentMoveRequest) | **POST** /requests/contentmove | submit create content move request
*RequestsApi* | [**Submit-CreateGroupRequest**](docs/RequestsApi.md#Submit-CreateGroupRequest) | **POST** /requests/creategroup | submit create group request
*RequestsApi* | [**Submit-CreateListRequest**](docs/RequestsApi.md#Submit-CreateListRequest) | **POST** /requests/createlist | submit create list request
*RequestsApi* | [**Submit-CreateSiteRequest**](docs/RequestsApi.md#Submit-CreateSiteRequest) | **POST** /requests/createsite | submit create site request
*RequestsApi* | [**Submit-CreateWebRequest**](docs/RequestsApi.md#Submit-CreateWebRequest) | **POST** /requests/createweb | submit create web request
*RequestsApi* | [**Submit-CustomRequest**](docs/RequestsApi.md#Submit-CustomRequest) | **POST** /requests/custom | submit custom service request
*RequestsApi* | [**Submit-DeleteGroupRequest**](docs/RequestsApi.md#Submit-DeleteGroupRequest) | **POST** /requests/deletegroup | submit delete group request
*RequestsApi* | [**Submit-DeleteSiteRequest**](docs/RequestsApi.md#Submit-DeleteSiteRequest) | **POST** /requests/deletesite | submit delete site request
*RequestsApi* | [**Submit-DeleteWebRequest**](docs/RequestsApi.md#Submit-DeleteWebRequest) | **POST** /requests/deleteweb | submit delete web request
*RequestsApi* | [**Submit-ExtendGroupRequest**](docs/RequestsApi.md#Submit-ExtendGroupRequest) | **POST** /requests/extendgroup | submit extend group request
*RequestsApi* | [**Submit-ExtendSiteRequest**](docs/RequestsApi.md#Submit-ExtendSiteRequest) | **POST** /requests/extendsite | submit extend site request
*RequestsApi* | [**Submit-GrantPermissionRequest**](docs/RequestsApi.md#Submit-GrantPermissionRequest) | **POST** /requests/grantpermission | get submit grant permission request
*RequestsApi* | [**Submit-LockSiteRequest**](docs/RequestsApi.md#Submit-LockSiteRequest) | **POST** /requests/locksite | submit lock site request
*RequestsApi* | [**Submit-ManagePermimssionRequest**](docs/RequestsApi.md#Submit-ManagePermimssionRequest) | **POST** /requests/managepermission | submit manage permission request
*RequestsApi* | [**Submit-RestoreGroupRequest**](docs/RequestsApi.md#Submit-RestoreGroupRequest) | **POST** /requests/restoregroup | submit restore group request
*RequestsApi* | [**Submit-UnlockSiteRequest**](docs/RequestsApi.md#Submit-UnlockSiteRequest) | **POST** /requests/unlocksite | submit unlock site request
*RequestsDirectoryAdminApi* | [**Invoke-DeleteSelectedRequests**](docs/RequestsDirectoryAdminApi.md#Invoke-DeleteSelectedRequests) | **DELETE** /admin/directory/requests | remove selected requests
*RequestsDirectoryAdminApi* | [**Get-AllRequests**](docs/RequestsDirectoryAdminApi.md#Get-AllRequests) | **GET** /admin/directory/requests | get all requests
*RequestsDirectoryAdminApi* | [**Get-AllRequestsFilters**](docs/RequestsDirectoryAdminApi.md#Get-AllRequestsFilters) | **GET** /admin/directory/requests/filters | get all requests filters
*ServicesApi* | [**Add-CreateListService**](docs/ServicesApi.md#Add-CreateListService) | **POST** /services/createsite | Add create site service
*ServicesApi* | [**Get-ChangeGroupSettingService**](docs/ServicesApi.md#Get-ChangeGroupSettingService) | **GET** /services/changegroupsetting/{id} | get change group setting service
*ServicesApi* | [**Get-ChangeListSettingService**](docs/ServicesApi.md#Get-ChangeListSettingService) | **GET** /services/changelistsetting/{id} | get change list setting service
*ServicesApi* | [**Get-ChangePermissionService**](docs/ServicesApi.md#Get-ChangePermissionService) | **GET** /services/changepermission/{id} | get change permission service
*ServicesApi* | [**Get-ChangeSiteContactService**](docs/ServicesApi.md#Get-ChangeSiteContactService) | **GET** /services/changesitecontact/{id} | get change site contact service
*ServicesApi* | [**Get-ChangeSiteSettingService**](docs/ServicesApi.md#Get-ChangeSiteSettingService) | **GET** /services/changesitesetting/{id} | get change site setting service
*ServicesApi* | [**Get-ChangeWebContactService**](docs/ServicesApi.md#Get-ChangeWebContactService) | **GET** /services/changewebcontact/{id} | validate permissions, scope for change web contact service
*ServicesApi* | [**Get-ChangeWebSettingsService**](docs/ServicesApi.md#Get-ChangeWebSettingsService) | **GET** /services/changewebsettings/{id} | get change web setting service
*ServicesApi* | [**Get-ClonePermissionService**](docs/ServicesApi.md#Get-ClonePermissionService) | **GET** /services/clonepermission/{id} | get clone permission service
*ServicesApi* | [**Get-ContentMoveProfiles**](docs/ServicesApi.md#Get-ContentMoveProfiles) | **GET** /services/contentmove/profiles | get content move profiles from cloud management
*ServicesApi* | [**Get-ContentMoveService**](docs/ServicesApi.md#Get-ContentMoveService) | **GET** /services/contentmove/{id} | get content move service
*ServicesApi* | [**Get-CreateGroupService**](docs/ServicesApi.md#Get-CreateGroupService) | **GET** /services/creategroup/{id} | get create group service
*ServicesApi* | [**Get-CreateListService**](docs/ServicesApi.md#Get-CreateListService) | **GET** /services/createlist/{id} | get create list service
*ServicesApi* | [**Get-CreateSiteService**](docs/ServicesApi.md#Get-CreateSiteService) | **GET** /services/createsite/{id} | get create site service
*ServicesApi* | [**Get-CreateWebService**](docs/ServicesApi.md#Get-CreateWebService) | **GET** /services/createweb/{id} | get create web service
*ServicesApi* | [**Get-CustomService**](docs/ServicesApi.md#Get-CustomService) | **GET** /services/custom/{id} | get custom service
*ServicesApi* | [**Get-GrantPermissionService**](docs/ServicesApi.md#Get-GrantPermissionService) | **GET** /services/grantpermission/{id} | get grant permission service
*ServicesApi* | [**Get-GroupLifecycleService**](docs/ServicesApi.md#Get-GroupLifecycleService) | **GET** /services/grouplifecycle/{id} | get group lifecycle service
*ServicesApi* | [**Get-GroupPolicyExpirationSetting**](docs/ServicesApi.md#Get-GroupPolicyExpirationSetting) | **GET** /services/grouplifecycle/{id}/policyexpirationsetting | get the group policy expiration setting
*ServicesApi* | [**Get-ManagePermissionService**](docs/ServicesApi.md#Get-ManagePermissionService) | **GET** /services/managepermission/{id} | get manage permission service
*ServicesApi* | [**Get-MyQuickServices**](docs/ServicesApi.md#Get-MyQuickServices) | **GET** /services/my/quick | get configued quick services that can be used to start a request
*ServicesApi* | [**Get-MyServices**](docs/ServicesApi.md#Get-MyServices) | **GET** /services/my | get services that can be used to start a request
*ServicesApi* | [**Get-MyServicesWithContext**](docs/ServicesApi.md#Get-MyServicesWithContext) | **GET** /services/my/workspace/{objecttype}/{objectid} | get services that can be used to start a request within context
*ServicesApi* | [**Get-SiteLifecycleService**](docs/ServicesApi.md#Get-SiteLifecycleService) | **GET** /services/sitelifecycle/{id} | get site lifecycle service
*ServicesApi* | [**Get-SitePolicyExpirationSetting**](docs/ServicesApi.md#Get-SitePolicyExpirationSetting) | **GET** /services/sitelifecycle/{id}/policyexpirationsetting | get the site collection policy expiration setting
*ServicesApi* | [**Get-WebLifecycleService**](docs/ServicesApi.md#Get-WebLifecycleService) | **GET** /services/weblifecycle/{id} | get web lifecycle service
*ServicesApi* | [**Invoke-ValidateForChangeGroupSettingService**](docs/ServicesApi.md#Invoke-ValidateForChangeGroupSettingService) | **POST** /services/changegroupsetting/{id}/group/validation | validate permissions, scope for change group setting service
*ServicesApi* | [**Invoke-ValidateForChangeListSettingService**](docs/ServicesApi.md#Invoke-ValidateForChangeListSettingService) | **POST** /services/changelistsetting/{id}/url/validation | validate permissions, scope for change list setting service
*ServicesApi* | [**Invoke-ValidateForChangePermissionService**](docs/ServicesApi.md#Invoke-ValidateForChangePermissionService) | **POST** /services/changepermission/{id}/url/validation | validate permissions, scope for change permission service
*ServicesApi* | [**Invoke-ValidateForChangeSiteContactService**](docs/ServicesApi.md#Invoke-ValidateForChangeSiteContactService) | **POST** /services/changesitecontact/{id}/url/validation | validate permissions, scope for change site contact service
*ServicesApi* | [**Invoke-ValidateForChangeSiteSettingService**](docs/ServicesApi.md#Invoke-ValidateForChangeSiteSettingService) | **POST** /services/changesitesetting/{id}/url/validation | validate permissions, scope for change site setting service
*ServicesApi* | [**Invoke-ValidateForChangeWebContactService**](docs/ServicesApi.md#Invoke-ValidateForChangeWebContactService) | **POST** /services/changewebcontact/{id}/url/validation | validate permissions, scope for change web contact service
*ServicesApi* | [**Invoke-ValidateForChangeWebSettingService**](docs/ServicesApi.md#Invoke-ValidateForChangeWebSettingService) | **POST** /services/changewebsettings/{id}/url/validation | validate permissions, scope for change web setting service
*ServicesApi* | [**Invoke-ValidateForClonePermissionService**](docs/ServicesApi.md#Invoke-ValidateForClonePermissionService) | **POST** /services/clonepermission/{id}/url/validation | validate permissions, scope for clone permission service
*ServicesApi* | [**Invoke-ValidateForContentMoveService**](docs/ServicesApi.md#Invoke-ValidateForContentMoveService) | **POST** /services/contentmove/{id}/url/validation | validate permissions, scope for content move service
*ServicesApi* | [**Invoke-ValidateForCreateListService**](docs/ServicesApi.md#Invoke-ValidateForCreateListService) | **POST** /services/createlist/{id}/url/validation | validate permissions, scope for create list service
*ServicesApi* | [**Invoke-ValidateForCreateWebService**](docs/ServicesApi.md#Invoke-ValidateForCreateWebService) | **POST** /services/createweb/{id}/url/validation | validate permissions, scope for create web service
*ServicesApi* | [**Invoke-ValidateForGrantPermissionService**](docs/ServicesApi.md#Invoke-ValidateForGrantPermissionService) | **POST** /services/grantpermission/{id}/url/validation | validate permissions, scope for grant permission service
*ServicesApi* | [**Invoke-ValidateForGroupLifecycleService**](docs/ServicesApi.md#Invoke-ValidateForGroupLifecycleService) | **POST** /services/grouplifecycle/{id}/group/validation | validate permissions, scope for group lifecycle service
*ServicesApi* | [**Invoke-ValidateForManagePermissionService**](docs/ServicesApi.md#Invoke-ValidateForManagePermissionService) | **POST** /services/managepermission/{id}/url/validation | validate permissions, scope for manage permission service
*ServicesApi* | [**Invoke-ValidateForSiteLifecycleService**](docs/ServicesApi.md#Invoke-ValidateForSiteLifecycleService) | **POST** /services/sitelifecycle/{id}/url/validation | validate permissions, scope for site lifecycle service
*ServicesApi* | [**Invoke-ValidateForWebLifecycleService**](docs/ServicesApi.md#Invoke-ValidateForWebLifecycleService) | **POST** /services/weblifecycle/{id}/url/validation | validate permissions, scope for web lifecycle service
*SettingsApi* | [**Edit-MyPersonalSettings**](docs/SettingsApi.md#Edit-MyPersonalSettings) | **PUT** /settings/my | edit my personal settings
*SettingsApi* | [**Get-ApplicationSettings**](docs/SettingsApi.md#Get-ApplicationSettings) | **GET** /settings/app | get application settings
*SettingsApi* | [**Get-DynamicMembershipRuleItems**](docs/SettingsApi.md#Get-DynamicMembershipRuleItems) | **GET** /settings/office365/groups/dynamicmembershiprule/{tenantid} | get group/teams dynamic membership rules
*SettingsApi* | [**Get-HelpLink**](docs/SettingsApi.md#Get-HelpLink) | **GET** /settings/helplink | get help link
*SettingsApi* | [**Get-MyPersonalSettings**](docs/SettingsApi.md#Get-MyPersonalSettings) | **GET** /settings/my | get my personal settings
*SettingsApi* | [**Get-News**](docs/SettingsApi.md#Get-News) | **GET** /settings/news | get news
*SettingsApi* | [**Get-PermissionLevels**](docs/SettingsApi.md#Get-PermissionLevels) | **GET** /settings/office365/permissionlevels | get permission levels
*SettingsApi* | [**Get-SupportedLanguages**](docs/SettingsApi.md#Get-SupportedLanguages) | **GET** /settings/languages | get supported language
*SettingsApi* | [**Get-TimeZones**](docs/SettingsApi.md#Get-TimeZones) | **GET** /settings/timezones | get timezones
*SystemSettingsAdminApi* | [**Add-ExecutionSchedule**](docs/SystemSettingsAdminApi.md#Add-ExecutionSchedule) | **POST** /admin/settings/system/executionschedules | add execution schedule
*SystemSettingsAdminApi* | [**Add-NewDepartment**](docs/SystemSettingsAdminApi.md#Add-NewDepartment) | **POST** /admin/settings/system/departments | create a new department
*SystemSettingsAdminApi* | [**Invoke-CreateApiSetting**](docs/SystemSettingsAdminApi.md#Invoke-CreateApiSetting) | **POST** /admin/settings/system/api | create api authentication profile
*SystemSettingsAdminApi* | [**Invoke-CreateExportLocations**](docs/SystemSettingsAdminApi.md#Invoke-CreateExportLocations) | **POST** /admin/settings/system/exportlocations | create export location
*SystemSettingsAdminApi* | [**Invoke-CreateTerminology**](docs/SystemSettingsAdminApi.md#Invoke-CreateTerminology) | **POST** /admin/settings/system/terminologies/one | create a new terminology
*SystemSettingsAdminApi* | [**Invoke-CreateTextValidationRule**](docs/SystemSettingsAdminApi.md#Invoke-CreateTextValidationRule) | **POST** /admin/settings/system/validation/text | create text validation rule
*SystemSettingsAdminApi* | [**Invoke-DeleteDepartment**](docs/SystemSettingsAdminApi.md#Invoke-DeleteDepartment) | **DELETE** /admin/settings/system/departments/{id} | delete department
*SystemSettingsAdminApi* | [**Invoke-DeleteExecutionSchedule**](docs/SystemSettingsAdminApi.md#Invoke-DeleteExecutionSchedule) | **DELETE** /admin/settings/system/executionschedules/{id} | delete execution schedule by id
*SystemSettingsAdminApi* | [**Invoke-DeleteExecutionSchedules**](docs/SystemSettingsAdminApi.md#Invoke-DeleteExecutionSchedules) | **DELETE** /admin/settings/system/executionschedules | delete execution schedules
*SystemSettingsAdminApi* | [**Invoke-DeleteExportLocation**](docs/SystemSettingsAdminApi.md#Invoke-DeleteExportLocation) | **DELETE** /admin/settings/system/exportlocations/{id} | delete export location
*SystemSettingsAdminApi* | [**Invoke-DeleteExportLocations**](docs/SystemSettingsAdminApi.md#Invoke-DeleteExportLocations) | **DELETE** /admin/settings/system/exportlocations | delete export locations
*SystemSettingsAdminApi* | [**Invoke-DeleteSelectedApiSettings**](docs/SystemSettingsAdminApi.md#Invoke-DeleteSelectedApiSettings) | **DELETE** /admin/settings/system/api | remove selected api authentication profile
*SystemSettingsAdminApi* | [**Invoke-DeleteTerminology**](docs/SystemSettingsAdminApi.md#Invoke-DeleteTerminology) | **DELETE** /admin/settings/system/terminologies | delete terminologies
*SystemSettingsAdminApi* | [**Invoke-DeleteTerminologyById**](docs/SystemSettingsAdminApi.md#Invoke-DeleteTerminologyById) | **DELETE** /admin/settings/system/terminologies/{id} | delete terminology by id
*SystemSettingsAdminApi* | [**Invoke-DeleteTextValidationRule**](docs/SystemSettingsAdminApi.md#Invoke-DeleteTextValidationRule) | **DELETE** /admin/settings/system/validation/text | delete text validation rules
*SystemSettingsAdminApi* | [**Invoke-DeleteTextValidationRuleById**](docs/SystemSettingsAdminApi.md#Invoke-DeleteTextValidationRuleById) | **DELETE** /admin/settings/system/validation/text/{id} | delete text validation rule by id
*SystemSettingsAdminApi* | [**Edit-Department**](docs/SystemSettingsAdminApi.md#Edit-Department) | **PUT** /admin/settings/system/departments | edit department
*SystemSettingsAdminApi* | [**Edit-ExecutionSchedule**](docs/SystemSettingsAdminApi.md#Edit-ExecutionSchedule) | **PUT** /admin/settings/system/executionschedules | edit execution schedule
*SystemSettingsAdminApi* | [**Edit-ExportLocations**](docs/SystemSettingsAdminApi.md#Edit-ExportLocations) | **PUT** /admin/settings/system/exportlocations | edit export location
*SystemSettingsAdminApi* | [**Edit-Terminology**](docs/SystemSettingsAdminApi.md#Edit-Terminology) | **PUT** /admin/settings/system/terminologies | edit terminology
*SystemSettingsAdminApi* | [**Edit-TextValidatioinRule**](docs/SystemSettingsAdminApi.md#Edit-TextValidatioinRule) | **PUT** /admin/settings/system/validation/text | edit text validation rule
*SystemSettingsAdminApi* | [**Get-AccountManagementGroupMembers**](docs/SystemSettingsAdminApi.md#Get-AccountManagementGroupMembers) | **GET** /admin/settings/system/accountmanagement/groups/{id}/users | get users of account management
*SystemSettingsAdminApi* | [**Get-AccountManagementGroups**](docs/SystemSettingsAdminApi.md#Get-AccountManagementGroups) | **GET** /admin/settings/system/accountmanagement/groups | get groups of account management
*SystemSettingsAdminApi* | [**Get-ApiSetting**](docs/SystemSettingsAdminApi.md#Get-ApiSetting) | **GET** /admin/settings/system/api/{id} | get api authentication profile view
*SystemSettingsAdminApi* | [**Get-ApiSettingFilters**](docs/SystemSettingsAdminApi.md#Get-ApiSettingFilters) | **GET** /admin/settings/system/api/filters | get filters of api authentication profile
*SystemSettingsAdminApi* | [**Get-ApiSettings**](docs/SystemSettingsAdminApi.md#Get-ApiSettings) | **GET** /admin/settings/system/api | get all api authentication profiles
*SystemSettingsAdminApi* | [**Get-DemoPreparationDuration**](docs/SystemSettingsAdminApi.md#Get-DemoPreparationDuration) | **GET** /admin/settings/system/tools/duration | get duration of demo preparation
*SystemSettingsAdminApi* | [**Get-DepartmentByName**](docs/SystemSettingsAdminApi.md#Get-DepartmentByName) | **GET** /admin/settings/system/departments/{name} | get department with name
*SystemSettingsAdminApi* | [**Get-DepartmentSettings**](docs/SystemSettingsAdminApi.md#Get-DepartmentSettings) | **GET** /admin/settings/system/departments/settings | get department settings
*SystemSettingsAdminApi* | [**Get-Departments**](docs/SystemSettingsAdminApi.md#Get-Departments) | **GET** /admin/settings/system/departments | get departments
*SystemSettingsAdminApi* | [**Get-ExecutionSchedule**](docs/SystemSettingsAdminApi.md#Get-ExecutionSchedule) | **GET** /admin/settings/system/executionschedules/{id} | get executionn schedule
*SystemSettingsAdminApi* | [**Get-ExecutionScheduleList**](docs/SystemSettingsAdminApi.md#Get-ExecutionScheduleList) | **GET** /admin/settings/system/executionschedules | get execution schedule list
*SystemSettingsAdminApi* | [**Get-ExecutionScheduleListFilters**](docs/SystemSettingsAdminApi.md#Get-ExecutionScheduleListFilters) | **GET** /admin/settings/system/executionschedules/filters | get execution schedule list fileters
*SystemSettingsAdminApi* | [**Get-ExportLocation**](docs/SystemSettingsAdminApi.md#Get-ExportLocation) | **GET** /admin/settings/system/exportlocations/{id} | get export location
*SystemSettingsAdminApi* | [**Get-ExportLocations**](docs/SystemSettingsAdminApi.md#Get-ExportLocations) | **GET** /admin/settings/system/exportlocations | get export locations
*SystemSettingsAdminApi* | [**Get-GlobalPersonalSettings**](docs/SystemSettingsAdminApi.md#Get-GlobalPersonalSettings) | **GET** /admin/settings/system/default | get global personal settings
*SystemSettingsAdminApi* | [**Get-HelpLinks**](docs/SystemSettingsAdminApi.md#Get-HelpLinks) | **GET** /admin/settings/system/helplinks | get help links
*SystemSettingsAdminApi* | [**Get-NewsConfiguration**](docs/SystemSettingsAdminApi.md#Get-NewsConfiguration) | **GET** /admin/settings/system/news | get news and updates
*SystemSettingsAdminApi* | [**Get-QuickRequestSettings**](docs/SystemSettingsAdminApi.md#Get-QuickRequestSettings) | **GET** /admin/settings/system/quickrequests | get quick requests
*SystemSettingsAdminApi* | [**Get-ScheduleReferencedServices**](docs/SystemSettingsAdminApi.md#Get-ScheduleReferencedServices) | **GET** /admin/settings/system/executionschedules/{id}/services | get referenced services
*SystemSettingsAdminApi* | [**Get-Terminologies**](docs/SystemSettingsAdminApi.md#Get-Terminologies) | **GET** /admin/settings/system/terminologies | get terminologies
*SystemSettingsAdminApi* | [**Get-TerminologyById**](docs/SystemSettingsAdminApi.md#Get-TerminologyById) | **GET** /admin/settings/system/terminologies/{id} | get terminology
*SystemSettingsAdminApi* | [**Get-TerminologyFilters**](docs/SystemSettingsAdminApi.md#Get-TerminologyFilters) | **GET** /admin/settings/system/terminologies/filters | get terminology filters
*SystemSettingsAdminApi* | [**Get-TextValiationRuleFilters**](docs/SystemSettingsAdminApi.md#Get-TextValiationRuleFilters) | **GET** /admin/settings/system/validation/text/filters | get text validation rule list filters
*SystemSettingsAdminApi* | [**Get-TextValiationRules**](docs/SystemSettingsAdminApi.md#Get-TextValiationRules) | **GET** /admin/settings/system/validation/text | get text validation rule list
*SystemSettingsAdminApi* | [**Get-TextValidationRuleById**](docs/SystemSettingsAdminApi.md#Get-TextValidationRuleById) | **GET** /admin/settings/system/validation/text/{id} | get text validation rule
*SystemSettingsAdminApi* | [**Get-TimerConfigurations**](docs/SystemSettingsAdminApi.md#Get-TimerConfigurations) | **GET** /admin/settings/system/timers | get timer configurations
*SystemSettingsAdminApi* | [**Get-UploadFileUrL**](docs/SystemSettingsAdminApi.md#Get-UploadFileUrL) | **GET** /admin/settings/system/support/uploadurl | Get upload file url
*SystemSettingsAdminApi* | [**Get-relatedServices**](docs/SystemSettingsAdminApi.md#Get-relatedServices) | **GET** /admin/settings/system/departments/{name}/services | get related services
*SystemSettingsAdminApi* | [**Import-Terminolog**](docs/SystemSettingsAdminApi.md#Import-Terminolog) | **POST** /admin/settings/system/terminologies | import terminologies, max count once import is 10000
*SystemSettingsAdminApi* | [**Save-DepartmentsSettings**](docs/SystemSettingsAdminApi.md#Save-DepartmentsSettings) | **POST** /admin/settings/system/departments/settings | save departments
*SystemSettingsAdminApi* | [**Save-GlobalPersonalSettings**](docs/SystemSettingsAdminApi.md#Save-GlobalPersonalSettings) | **POST** /admin/settings/system/default | save global personal settings
*SystemSettingsAdminApi* | [**Save-HelpLinks**](docs/SystemSettingsAdminApi.md#Save-HelpLinks) | **POST** /admin/settings/system/helplinks | save help links
*SystemSettingsAdminApi* | [**Save-NewsAndUpdates**](docs/SystemSettingsAdminApi.md#Save-NewsAndUpdates) | **POST** /admin/settings/system/news | save news and updates
*SystemSettingsAdminApi* | [**Save-QuickRequestSettigns**](docs/SystemSettingsAdminApi.md#Save-QuickRequestSettigns) | **POST** /admin/settings/system/quickrequests | save quick requests
*SystemSettingsAdminApi* | [**Save-TimerConfigurations**](docs/SystemSettingsAdminApi.md#Save-TimerConfigurations) | **POST** /admin/settings/system/timers | save timer configurations
*SystemSettingsAdminApi* | [**Send-InviteSupport**](docs/SystemSettingsAdminApi.md#Send-InviteSupport) | **POST** /admin/settings/system/support | send invite support
*SystemSettingsAdminApi* | [**Submit-DemoPreparation**](docs/SystemSettingsAdminApi.md#Submit-DemoPreparation) | **POST** /admin/settings/system/tools | submit demo preparation request
*SystemSettingsAdminApi* | [**Invoke-ValidateAzureStorage**](docs/SystemSettingsAdminApi.md#Invoke-ValidateAzureStorage) | **POST** /admin/settings/system/exportlocations/azurestorage/validation | validate azure storage
*SystemSettingsAdminApi* | [**Invoke-ValidateSharePointUrl**](docs/SystemSettingsAdminApi.md#Invoke-ValidateSharePointUrl) | **POST** /admin/settings/system/exportlocations/url/validation | validate sharepoint folder or library url
*TasksApi* | [**Add-MembersForGroupMembershipRecertification**](docs/TasksApi.md#Add-MembersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/members | add members for group membership recertification
*TasksApi* | [**Add-OwnersForGroupMembershipRecertification**](docs/TasksApi.md#Add-OwnersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/owners | add owners for group membership recertification
*TasksApi* | [**Approve-Task**](docs/TasksApi.md#Approve-Task) | **POST** /tasks/{id}/approve | approve task
*TasksApi* | [**Invoke-ClaimElectionTask**](docs/TasksApi.md#Invoke-ClaimElectionTask) | **POST** /tasks/{id}/election/claim | claim election task
*TasksApi* | [**Invoke-ClaimSiteOwnershipRecertificationTask**](docs/TasksApi.md#Invoke-ClaimSiteOwnershipRecertificationTask) | **POST** /tasks/{id}/site/recertification/ownership/claim/{secondarycontact} | claim site ownership recertification task
*TasksApi* | [**Invoke-DeclineElectionTask**](docs/TasksApi.md#Invoke-DeclineElectionTask) | **POST** /tasks/{id}/election/decline | decline election task
*TasksApi* | [**Invoke-DeclineSiteOwnershipRecertificationTask**](docs/TasksApi.md#Invoke-DeclineSiteOwnershipRecertificationTask) | **POST** /tasks/{id}/site/recertification/ownership/decline | decline site ownership recertification task
*TasksApi* | [**Invoke-DemoteAsMembersForGroupMembershipRecertification**](docs/TasksApi.md#Invoke-DemoteAsMembersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/demoteasmember | demote as members for group membership recertification
*TasksApi* | [**Edit-ArchiveGroupRequest**](docs/TasksApi.md#Edit-ArchiveGroupRequest) | **PUT** /tasks/{id}/archivegroup | edit archive group request in task
*TasksApi* | [**Edit-ArchiveSiteRequest**](docs/TasksApi.md#Edit-ArchiveSiteRequest) | **PUT** /tasks/{id}/archivesite | edit archive site request in task
*TasksApi* | [**Edit-ArchiveWebRequest**](docs/TasksApi.md#Edit-ArchiveWebRequest) | **PUT** /tasks/{id}/archiveweb | edit archive web request in task
*TasksApi* | [**Edit-ChangeGroupPolicyRequest**](docs/TasksApi.md#Edit-ChangeGroupPolicyRequest) | **PUT** /tasks/{id}/changegrouppolicy | edit change group policy request in task
*TasksApi* | [**Edit-ChangeGroupQuotaRequest**](docs/TasksApi.md#Edit-ChangeGroupQuotaRequest) | **PUT** /tasks/{id}/changegroupquota | edit change group quota request in task
*TasksApi* | [**Edit-ChangeGroupRequest**](docs/TasksApi.md#Edit-ChangeGroupRequest) | **PUT** /tasks/{id}/changegroup | edit create change group request in task
*TasksApi* | [**Edit-ChangeListSettingRequest**](docs/TasksApi.md#Edit-ChangeListSettingRequest) | **PUT** /tasks/{id}/changelistsetting | edit change list setting request in task
*TasksApi* | [**Edit-ChangePermissionRequest**](docs/TasksApi.md#Edit-ChangePermissionRequest) | **PUT** /tasks/{id}/changepermission | edit change permission request in task
*TasksApi* | [**Edit-ChangeSiteContactRequest**](docs/TasksApi.md#Edit-ChangeSiteContactRequest) | **PUT** /tasks/{id}/changesite/adminorcontact | edit change site administrator/contact request in task
*TasksApi* | [**Edit-ChangeSitePolicyRequest**](docs/TasksApi.md#Edit-ChangeSitePolicyRequest) | **PUT** /tasks/{id}/changesitepolicy | edit change site policy request in task
*TasksApi* | [**Edit-ChangeSiteQuotaRequest**](docs/TasksApi.md#Edit-ChangeSiteQuotaRequest) | **PUT** /tasks/{id}/changesitequota | edit change site quota request in task
*TasksApi* | [**Edit-ChangeSiteSettingRequest**](docs/TasksApi.md#Edit-ChangeSiteSettingRequest) | **PUT** /tasks/{id}/changesite/setting | edit change site setting request in task
*TasksApi* | [**Edit-ChangeWebContactRequest**](docs/TasksApi.md#Edit-ChangeWebContactRequest) | **PUT** /tasks/{id}/changewebcontact | edit change web contact request in task
*TasksApi* | [**Edit-ChangeWebSettingRequest**](docs/TasksApi.md#Edit-ChangeWebSettingRequest) | **PUT** /tasks/{id}/changewebsettings | edit change web setting request in task
*TasksApi* | [**Edit-ClonePermissionRequest**](docs/TasksApi.md#Edit-ClonePermissionRequest) | **PUT** /tasks/{id}/clonepermission | edit clone permission request in task
*TasksApi* | [**Edit-ContentMoveRequest**](docs/TasksApi.md#Edit-ContentMoveRequest) | **PUT** /tasks/{id}/contentmove | edit content move request in task
*TasksApi* | [**Edit-CreateGroupRequest**](docs/TasksApi.md#Edit-CreateGroupRequest) | **PUT** /tasks/{id}/creategroup | edit create site group request in task
*TasksApi* | [**Edit-CreateListRequest**](docs/TasksApi.md#Edit-CreateListRequest) | **PUT** /tasks/{id}/createlist | edit create list request in task
*TasksApi* | [**Edit-CreateSiteRequest**](docs/TasksApi.md#Edit-CreateSiteRequest) | **PUT** /tasks/{id}/createsite | edit create site request in task
*TasksApi* | [**Edit-CreateWebRequest**](docs/TasksApi.md#Edit-CreateWebRequest) | **PUT** /tasks/{id}/createweb | edit create web request in task
*TasksApi* | [**Edit-CustomRequest**](docs/TasksApi.md#Edit-CustomRequest) | **PUT** /tasks/{id}/custom | edit custom request in task
*TasksApi* | [**Edit-DeleteGroupRequest**](docs/TasksApi.md#Edit-DeleteGroupRequest) | **PUT** /tasks/{id}/deletegroup | edit delete change group request in task
*TasksApi* | [**Edit-DeleteSiteRequest**](docs/TasksApi.md#Edit-DeleteSiteRequest) | **PUT** /tasks/{id}/deletesite | edit delete site request in task
*TasksApi* | [**Edit-DeleteWebRequest**](docs/TasksApi.md#Edit-DeleteWebRequest) | **PUT** /tasks/{id}/deleteweb | edit delete web request in task
*TasksApi* | [**Edit-ExtendGroupRequest**](docs/TasksApi.md#Edit-ExtendGroupRequest) | **PUT** /tasks/{id}/extendgroup | edit extend group request in task
*TasksApi* | [**Edit-ExtendSiteRequest**](docs/TasksApi.md#Edit-ExtendSiteRequest) | **PUT** /tasks/{id}/extendsite | edit extend site request in task
*TasksApi* | [**Edit-GrantPermissionRequest**](docs/TasksApi.md#Edit-GrantPermissionRequest) | **PUT** /tasks/{id}/grantpermission | edit grant permission request in task
*TasksApi* | [**Edit-LockSiteRequest**](docs/TasksApi.md#Edit-LockSiteRequest) | **PUT** /tasks/{id}/locksite | edit lock site request in task
*TasksApi* | [**Edit-ManagePermissionRequest**](docs/TasksApi.md#Edit-ManagePermissionRequest) | **PUT** /tasks/{id}/managepermission | edit manage permission request in task
*TasksApi* | [**Edit-RestoreGroupRequest**](docs/TasksApi.md#Edit-RestoreGroupRequest) | **PUT** /tasks/{id}/restoregroup | edit restore group request in task
*TasksApi* | [**Edit-UnLockSiteRequest**](docs/TasksApi.md#Edit-UnLockSiteRequest) | **PUT** /tasks/{id}/unlocksite | edit unlock site request in task
*TasksApi* | [**Get-ChangePermissionReport**](docs/TasksApi.md#Get-ChangePermissionReport) | **GET** /tasks/changepermission/{id}/permission | get change permission report
*TasksApi* | [**Get-ChangePermissionReportByVersion**](docs/TasksApi.md#Get-ChangePermissionReportByVersion) | **GET** /tasks/changepermission/{id}/permission/{version} | get change permission report with specific version
*TasksApi* | [**Get-ChangePermissionReportFilters**](docs/TasksApi.md#Get-ChangePermissionReportFilters) | **GET** /tasks/changepermission/{id}/permission/filters | get change permission report filters
*TasksApi* | [**Get-ChangePermissionReportFiltersByVersion**](docs/TasksApi.md#Get-ChangePermissionReportFiltersByVersion) | **GET** /tasks/changepermission/{id}/permission/filters/{version} | get change permission report filters with specific version
*TasksApi* | [**Get-ChangePermissionReportFiltersForSPGroup**](docs/TasksApi.md#Get-ChangePermissionReportFiltersForSPGroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters | get change permission report filters for a sharepoint group
*TasksApi* | [**Get-ChangePermissionReportFiltersForSPGroupByVersion**](docs/TasksApi.md#Get-ChangePermissionReportFiltersForSPGroupByVersion) | **GET** /tasks/changepermission/{id}/permission/group/{groupid}/filters/{version} | get change permission report filters for a sharepoint group with specific version
*TasksApi* | [**Get-ChangePermissionReportForSPGroup**](docs/TasksApi.md#Get-ChangePermissionReportForSPGroup) | **GET** /tasks/changepermission/{id}/permission/group/{groupid} | get change permission report for a sharepoint group
*TasksApi* | [**Get-ChangePermissionReportForSPGroupByVersion**](docs/TasksApi.md#Get-ChangePermissionReportForSPGroupByVersion) | **GET** /tasks/changepermission/{id}/permission/{version}/group/{groupid} | get change permission report for a sharepoint group with specific version
*TasksApi* | [**Get-ChangePermissionReportPermissionLevels**](docs/TasksApi.md#Get-ChangePermissionReportPermissionLevels) | **GET** /tasks/changepermission/{id}/permissionlevels | get change permission report permission levels
*TasksApi* | [**Get-ChangePermissionReportProperties**](docs/TasksApi.md#Get-ChangePermissionReportProperties) | **GET** /tasks/changepermission/{id}/properties | get change permission report properties
*TasksApi* | [**Get-ClonePermissionReport**](docs/TasksApi.md#Get-ClonePermissionReport) | **GET** /tasks/clonepermission/{id}/permission | get clone permission report
*TasksApi* | [**Get-ClonePermissionReportProperties**](docs/TasksApi.md#Get-ClonePermissionReportProperties) | **GET** /tasks/clonepermission/{id}/properties | get clone permission report properties
*TasksApi* | [**Get-GetManualArchiveReport**](docs/TasksApi.md#Get-GetManualArchiveReport) | **GET** /tasks/{id}/manualarchive | get manual archive report
*TasksApi* | [**Get-GetManualArchiveReportFilters**](docs/TasksApi.md#Get-GetManualArchiveReportFilters) | **GET** /tasks/{id}/manualarchive/filters | get manual archive report filters
*TasksApi* | [**Get-GroupMembershipRecertificationReport**](docs/TasksApi.md#Get-GroupMembershipRecertificationReport) | **GET** /tasks/{id}/group/recertification/membership | get group membership recertification report
*TasksApi* | [**Get-GroupMembershipRecertificationReportByVersion**](docs/TasksApi.md#Get-GroupMembershipRecertificationReportByVersion) | **GET** /tasks/{id}/group/recertification/membership/{version} | get group membership recertification report by version
*TasksApi* | [**Get-GroupMembershipRecertificationReportFilters**](docs/TasksApi.md#Get-GroupMembershipRecertificationReportFilters) | **GET** /tasks/{id}/group/recertification/membership/filters | get group membership recertification report filters
*TasksApi* | [**Get-GroupMembershipRecertificationReportFiltersByVersion**](docs/TasksApi.md#Get-GroupMembershipRecertificationReportFiltersByVersion) | **GET** /tasks/{id}/group/recertification/membership/filters/{version} | get group membership recertification report filters by version
*TasksApi* | [**Get-GroupMembershipRecertificationReportProperties**](docs/TasksApi.md#Get-GroupMembershipRecertificationReportProperties) | **GET** /tasks/{id}/group/recertification/membership/properties | get group membership recertification report properties
*TasksApi* | [**Get-GroupPermissionRecertificationReport**](docs/TasksApi.md#Get-GroupPermissionRecertificationReport) | **GET** /tasks/{id}/group/recertification/permission | get group permission recertification report
*TasksApi* | [**Get-GroupPermissionRecertificationReportByVersion**](docs/TasksApi.md#Get-GroupPermissionRecertificationReportByVersion) | **GET** /tasks/{id}/group/recertification/permission/{version} | get group permission recertification report by version
*TasksApi* | [**Get-GroupPermissionRecertificationReportFilters**](docs/TasksApi.md#Get-GroupPermissionRecertificationReportFilters) | **GET** /tasks/{id}/group/recertification/permission/filters | get group permission recertification report filters
*TasksApi* | [**Get-GroupPermissionRecertificationReportFiltersForSPGroup**](docs/TasksApi.md#Get-GroupPermissionRecertificationReportFiltersForSPGroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid}/filters | get group permission recertification report filters for sharepoint group
*TasksApi* | [**Get-GroupPermissionRecertificationReportForSPGroup**](docs/TasksApi.md#Get-GroupPermissionRecertificationReportForSPGroup) | **GET** /tasks/{id}/group/recertification/permission/group/{groupid} | get group permission recertification report for sharepoint group
*TasksApi* | [**Get-GroupPermissionRecertificationReportProperties**](docs/TasksApi.md#Get-GroupPermissionRecertificationReportProperties) | **GET** /tasks/{id}/group/recertification/permission/properties | get group permission recertification report properties
*TasksApi* | [**Get-MyTaskFilters**](docs/TasksApi.md#Get-MyTaskFilters) | **GET** /tasks/my/filters | get my task filters
*TasksApi* | [**Get-MyTasks**](docs/TasksApi.md#Get-MyTasks) | **GET** /tasks/my | get my tasks
*TasksApi* | [**Get-RemovePermissionReport**](docs/TasksApi.md#Get-RemovePermissionReport) | **GET** /tasks/removepermission/{id}/permission | get remove permission report
*TasksApi* | [**Get-RemovePermissionReportProperties**](docs/TasksApi.md#Get-RemovePermissionReportProperties) | **GET** /tasks/removepermission/{id}/properties | get remove permission report properties
*TasksApi* | [**Get-SiteMetadataRecertificationReport**](docs/TasksApi.md#Get-SiteMetadataRecertificationReport) | **GET** /tasks/{id}/site/recertification/metadata | get site metadata recertification metadata
*TasksApi* | [**Get-SiteMetadataRecertificationReportProperties**](docs/TasksApi.md#Get-SiteMetadataRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/metadata/properties | get site metadata recertification report properties
*TasksApi* | [**Get-SiteOwnershipRecertificationReportProperties**](docs/TasksApi.md#Get-SiteOwnershipRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/ownership/properties | get site ownership recertification report properties
*TasksApi* | [**Get-SitePermissionRecertificatioPermissionFilters**](docs/TasksApi.md#Get-SitePermissionRecertificatioPermissionFilters) | **GET** /tasks/{id}/site/recertification/permission/filters | get site permission recertification permission filters
*TasksApi* | [**Get-SitePermissionRecertificatioReportFiltersByVersion**](docs/TasksApi.md#Get-SitePermissionRecertificatioReportFiltersByVersion) | **GET** /tasks/{id}/site/recertification/permission/filters/{version} | get site permission recertification permission filters with specific version
*TasksApi* | [**Get-SitePermissionRecertificatioReportFiltersForSPGroup**](docs/TasksApi.md#Get-SitePermissionRecertificatioReportFiltersForSPGroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters | 
*TasksApi* | [**Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion**](docs/TasksApi.md#Get-SitePermissionRecertificatioReportFiltersForSPGroupByVersion) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid}/filters/{version} | 
*TasksApi* | [**Get-SitePermissionRecertificationPermissionLevels**](docs/TasksApi.md#Get-SitePermissionRecertificationPermissionLevels) | **GET** /tasks/{id}/recertification/permissionlevels | get site permission recertification permission levels
*TasksApi* | [**Get-SitePermissionRecertificationReport**](docs/TasksApi.md#Get-SitePermissionRecertificationReport) | **GET** /tasks/{id}/site/recertification/permission | get site permission recertification report
*TasksApi* | [**Get-SitePermissionRecertificationReportByVersion**](docs/TasksApi.md#Get-SitePermissionRecertificationReportByVersion) | **GET** /tasks/{id}/site/recertification/permission/{version} | get site permission recertification report by specific version
*TasksApi* | [**Get-SitePermissionRecertificationReportForSPGroup**](docs/TasksApi.md#Get-SitePermissionRecertificationReportForSPGroup) | **GET** /tasks/{id}/site/recertification/permission/group/{groupid} | get site permission recertification group permission items
*TasksApi* | [**Get-SitePermissionRecertificationReportForSPGroupByVersion**](docs/TasksApi.md#Get-SitePermissionRecertificationReportForSPGroupByVersion) | **GET** /tasks/{id}/site/recertification/permission/{version}/group/{groupid} | get site permission recertification group permission items with specific version with specific version
*TasksApi* | [**Get-SitePermissionRecertificationReportProperties**](docs/TasksApi.md#Get-SitePermissionRecertificationReportProperties) | **GET** /tasks/{id}/site/recertification/permission/properties | get site permission recertification report properties
*TasksApi* | [**Get-TaskByBatchId**](docs/TasksApi.md#Get-TaskByBatchId) | **GET** /tasks/my/{batchid} | get task by batch id
*TasksApi* | [**Get-TaskById**](docs/TasksApi.md#Get-TaskById) | **GET** /tasks/{id} | get my task by id
*TasksApi* | [**Invoke-PromoteAsOwnersForGroupMembershipRecertification**](docs/TasksApi.md#Invoke-PromoteAsOwnersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/promoteasowner | promote as owners for group membership recertification
*TasksApi* | [**Invoke-ReassignTask**](docs/TasksApi.md#Invoke-ReassignTask) | **POST** /tasks/{id}/reassignto/{user} | reassign task
*TasksApi* | [**Invoke-RejectTask**](docs/TasksApi.md#Invoke-RejectTask) | **POST** /tasks/{id}/reject | reject task
*TasksApi* | [**Remove-UsersForGroupMembershipRecertification**](docs/TasksApi.md#Remove-UsersForGroupMembershipRecertification) | **POST** /tasks/{id}/group/recertification/membership/removeuser | remove users for group membership recertification
*TasksApi* | [**Invoke-ReseAllChangesForChangePermissionTask**](docs/TasksApi.md#Invoke-ReseAllChangesForChangePermissionTask) | **POST** /tasks/changepermission/{id}/resetallchange | save all changes for change permission task
*TasksApi* | [**Reset-AllChangesForRecertificationTask**](docs/TasksApi.md#Reset-AllChangesForRecertificationTask) | **POST** /tasks/{id}/recertification/resetallchange | reset all changes for site/group recertification task
*TasksApi* | [**Reset-MyChangesForChangePermissionTask**](docs/TasksApi.md#Reset-MyChangesForChangePermissionTask) | **POST** /tasks/changepermission/{id}/resetmychange | save my changes for change permission task
*TasksApi* | [**Reset-MyChangesForRecertificationTask**](docs/TasksApi.md#Reset-MyChangesForRecertificationTask) | **POST** /tasks/{id}/recertification/resetmychange | reset my changes for site/group recertification task
*TasksApi* | [**Invoke-RetryErrorTask**](docs/TasksApi.md#Invoke-RetryErrorTask) | **POST** /tasks/{id}/retry | retry error task
*TasksApi* | [**Save-ChangePermissionActions**](docs/TasksApi.md#Save-ChangePermissionActions) | **POST** /tasks/changepermission/{id}/permission | save change permission actions
*TasksApi* | [**Save-ClonePermissionReport**](docs/TasksApi.md#Save-ClonePermissionReport) | **POST** /tasks/clonepermission/{id}/permission | Save clone permission report
*TasksApi* | [**Save-GetManualArchiveReport**](docs/TasksApi.md#Save-GetManualArchiveReport) | **POST** /tasks/{id}/manualarchive | save manual archive report
*TasksApi* | [**Save-GroupPermissionRecertificationResults**](docs/TasksApi.md#Save-GroupPermissionRecertificationResults) | **POST** /tasks/{id}/group/recertification/permission | save group permission recertification results
*TasksApi* | [**Save-RemovePermissionReport**](docs/TasksApi.md#Save-RemovePermissionReport) | **POST** /tasks/removepermission/{id}/permission | save remove permission report
*TasksApi* | [**Save-SiteMetadataRecertificationResult**](docs/TasksApi.md#Save-SiteMetadataRecertificationResult) | **POST** /tasks/{id}/site/recertification/metadata | save site metadata recertification metadata
*TasksApi* | [**Save-SitePermissionRecertificationResult**](docs/TasksApi.md#Save-SitePermissionRecertificationResult) | **POST** /tasks/{id}/site/recertification/permission | save site permission recertification permissions
*TasksApi* | [**Skip-ErrorTask**](docs/TasksApi.md#Skip-ErrorTask) | **POST** /tasks/{id}/skip | skip error task
*TasksApi* | [**Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived**](docs/TasksApi.md#Invoke-SpecifyPrimaryAndSecondaryContactWhenPrimaryContactIsDeactived) | **POST** /tasks/{id}/election/specify/contacts | specify primary and secondary contact when primary contact is deactived
*TasksApi* | [**Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived**](docs/TasksApi.md#Invoke-SpecifySecondaryContactWhenSecondaryContactIsDeactived) | **POST** /tasks/{id}/election/specify/secondarycontact | specify secondary contact when secondary contact is deactived
*TasksApi* | [**Submit-ArchiveGroupAutoTask**](docs/TasksApi.md#Submit-ArchiveGroupAutoTask) | **POST** /tasks/archivegroup | submit archive group auto task
*TasksApi* | [**Submit-ArchiveSiteAutoTask**](docs/TasksApi.md#Submit-ArchiveSiteAutoTask) | **POST** /tasks/archivesite | submit site archive auto task
*TasksApi* | [**Submit-ChangeSitePolicyAutoTask**](docs/TasksApi.md#Submit-ChangeSitePolicyAutoTask) | **POST** /tasks/changesitepolicy | submit site policy change auto task
*TasksApi* | [**Submit-ContinueAccessGroupAutoTask**](docs/TasksApi.md#Submit-ContinueAccessGroupAutoTask) | **POST** /tasks/continueaccessgroup | submit group continue access auto task
*TasksApi* | [**Submit-ContinueAccessSiteAutoTask**](docs/TasksApi.md#Submit-ContinueAccessSiteAutoTask) | **POST** /tasks/continueaccesssite | submit site continue access auto task
*TasksApi* | [**Submit-DeleteGroupAutoTask**](docs/TasksApi.md#Submit-DeleteGroupAutoTask) | **POST** /tasks/deletegroup | submit delete group auto task
*TasksApi* | [**Submit-DeleteSiteAutoTask**](docs/TasksApi.md#Submit-DeleteSiteAutoTask) | **POST** /tasks/deletesite | submit site delete auto task
*TasksApi* | [**Submit-ExtendGroupAutoTask**](docs/TasksApi.md#Submit-ExtendGroupAutoTask) | **POST** /tasks/extendgroup | submit extend group auto task
*TasksApi* | [**Submit-ExtendSiteAutoTask**](docs/TasksApi.md#Submit-ExtendSiteAutoTask) | **POST** /tasks/extendsite | submit site extend auto task
*TasksApi* | [**Submit-RecertificationTask**](docs/TasksApi.md#Submit-RecertificationTask) | **POST** /tasks/{id}/submit | submit site/group recertification task
*TasksApi* | [**Invoke-ViewSiteOwnershipRecertificationTask**](docs/TasksApi.md#Invoke-ViewSiteOwnershipRecertificationTask) | **GET** /tasks/{id}/site/recertification/ownership | view site ownership recertification task
*TasksDirectoryAdminApi* | [**Get-AllRecertificationTaskFilters**](docs/TasksDirectoryAdminApi.md#Get-AllRecertificationTaskFilters) | **GET** /admin/directory/tasks/recertification/filters | get all recertificate tasks filters
*TasksDirectoryAdminApi* | [**Get-AllRecertificationTasks**](docs/TasksDirectoryAdminApi.md#Get-AllRecertificationTasks) | **GET** /admin/directory/tasks/recertification | get all tasks
*TasksDirectoryAdminApi* | [**Get-AllTasks**](docs/TasksDirectoryAdminApi.md#Get-AllTasks) | **GET** /admin/directory/tasks | get all tasks
*TasksDirectoryAdminApi* | [**Get-AllTasksFilters**](docs/TasksDirectoryAdminApi.md#Get-AllTasksFilters) | **GET** /admin/directory/tasks/filters | get all tasks filters
*UsersApi* | [**Invoke-CheckUserExistsInAOS**](docs/UsersApi.md#Invoke-CheckUserExistsInAOS) | **GET** /users/avepointonlineservices/validate | check user exists in Aos
*UsersApi* | [**Get-AzureAdUserPropertyValue**](docs/UsersApi.md#Get-AzureAdUserPropertyValue) | **GET** /users/{username}/azuread/property | get user's property value by property name from azure ad
*UsersApi* | [**Get-UpsUserPropertyValue**](docs/UsersApi.md#Get-UpsUserPropertyValue) | **GET** /users/{username}/userprofile/property | get user's property value by property name from user profile service
*UsersApi* | [**Get-UserBasicProperties**](docs/UsersApi.md#Get-UserBasicProperties) | **GET** /users/me/properties | get my basic properties, City, Country, Office, Department, JobTitle,State
*UsersApi* | [**Get-UserBasicPropertyValue**](docs/UsersApi.md#Get-UserBasicPropertyValue) | **GET** /users/me/property/{name} | get my basic property value, Department, Email, DisplayName, Manager
*UsersApi* | [**Get-UserPhoto**](docs/UsersApi.md#Get-UserPhoto) | **GET** /users/{username}/photo | get user's photo
*UsersApi* | [**Get-UserRelationship**](docs/UsersApi.md#Get-UserRelationship) | **GET** /users/{username}/relationship | get user relationship
*UsersApi* | [**Get-UsersFromSharePoint**](docs/UsersApi.md#Get-UsersFromSharePoint) | **POST** /users/sharepoint/validate | get users from sharepoint
*UsersApi* | [**Resolve-Users**](docs/UsersApi.md#Resolve-Users) | **GET** /users/resolve | resolve users
*UsersApi* | [**Resolve-UsersWithExternalSharingOption**](docs/UsersApi.md#Resolve-UsersWithExternalSharingOption) | **GET** /users/resolve/{externalSharingOption} | resolve user including external users
*UsersApi* | [**Search-Users**](docs/UsersApi.md#Search-Users) | **GET** /users/search | search users
*UsersApi* | [**Search-UsersWithExternalSharingOption**](docs/UsersApi.md#Search-UsersWithExternalSharingOption) | **GET** /users/search/{externalSharingOption} | search user including external users
*UsersApi* | [**Update-UserInfo**](docs/UsersApi.md#Update-UserInfo) | **POST** /users | 
*WorkspaceApi* | [**Confirm-Gorup**](docs/WorkspaceApi.md#Confirm-Gorup) | **POST** /workspace/groups/{id}/confirm | confirm auto imported group/teams information
*WorkspaceApi* | [**Confirm-GorupWithUnknowPrimaryContact**](docs/WorkspaceApi.md#Confirm-GorupWithUnknowPrimaryContact) | **POST** /workspace/groups/{id}/confirm/assigntoadmincontact | confirm auto imported group/teams by assigning task to administrator
*WorkspaceApi* | [**Confirm-GroupWithKnowningPrimaryContact**](docs/WorkspaceApi.md#Confirm-GroupWithKnowningPrimaryContact) | **POST** /workspace/groups/{id}/confirm/changeprimarycontact | confirm auto imported group/teams by assigning task to the specified primary contact
*WorkspaceApi* | [**Confirm-Site**](docs/WorkspaceApi.md#Confirm-Site) | **POST** /workspace/sites/{id}/confirm | confirm auto imported site information
*WorkspaceApi* | [**Confirm-SiteWitKnowingPrimaryContact**](docs/WorkspaceApi.md#Confirm-SiteWitKnowingPrimaryContact) | **POST** /workspace/sites/{id}/confirm/changeprimarycontact | confirm auto imported site by assigning task to the specified primary contact
*WorkspaceApi* | [**Confirm-SiteWithUnknowPrimaryContact**](docs/WorkspaceApi.md#Confirm-SiteWithUnknowPrimaryContact) | **POST** /workspace/sites/{id}/confirm/assigntoadmincontact | confirm auto imported site by assigning task to administrator
*WorkspaceApi* | [**Get-GroupAutoImportProfile**](docs/WorkspaceApi.md#Get-GroupAutoImportProfile) | **GET** /workspace/groups/{id}/confirm/settings | get group/teams auto-imported profile information
*WorkspaceApi* | [**Get-GroupContacts**](docs/WorkspaceApi.md#Get-GroupContacts) | **GET** /workspace/groups/{id}/contacts | get group/teams contacts
*WorkspaceApi* | [**Get-GroupMembershipRenewalItems**](docs/WorkspaceApi.md#Get-GroupMembershipRenewalItems) | **GET** /workspace/groups/{id}/renew/membership | get group/teams membership renewal items
*WorkspaceApi* | [**Get-GroupMetadataRenewalItems**](docs/WorkspaceApi.md#Get-GroupMetadataRenewalItems) | **GET** /workspace/groups/{id}/renew/metadata | get group/teams metadata renewal items
*WorkspaceApi* | [**Get-GroupPermissionRenewalFilters**](docs/WorkspaceApi.md#Get-GroupPermissionRenewalFilters) | **GET** /workspace/groups/{id}/renew/permission/filters | get group/teams permission renewal report filters
*WorkspaceApi* | [**Get-GroupPermissionRenewalFiltersForSPGroup**](docs/WorkspaceApi.md#Get-GroupPermissionRenewalFiltersForSPGroup) | **GET** /workspace/groups/{id}/renew/permission/group/{groupid}/filters | get group/teams permission renewal sharePoint group report filters
*WorkspaceApi* | [**Get-GroupPermissionRenewalItems**](docs/WorkspaceApi.md#Get-GroupPermissionRenewalItems) | **GET** /workspace/groups/{id}/renew/permissions | get group/teams permission renewal items
*WorkspaceApi* | [**Get-GroupPermissionRenewalItemsForSPGroup**](docs/WorkspaceApi.md#Get-GroupPermissionRenewalItemsForSPGroup) | **GET** /workspace/groups/{id}/renew/permissions/group/{groupid} | get sharePoint group members of group/teams permission renewal item
*WorkspaceApi* | [**Get-GroupPermissionRenewalPermissionLevels**](docs/WorkspaceApi.md#Get-GroupPermissionRenewalPermissionLevels) | **GET** /workspace/groups/{id}/renew/permissionlevels | get group/teams permission level for permission renewal
*WorkspaceApi* | [**Get-GroupRenewalProfileSettings**](docs/WorkspaceApi.md#Get-GroupRenewalProfileSettings) | **GET** /workspace/groups/{id}/renew/settings | get group/teams renewal settings
*WorkspaceApi* | [**Get-GroupSharingOptions**](docs/WorkspaceApi.md#Get-GroupSharingOptions) | **GET** /workspace/groups/sharingoptions | get group sharing options
*WorkspaceApi* | [**Get-MyGroupInformation**](docs/WorkspaceApi.md#Get-MyGroupInformation) | **GET** /workspace/groups/{id} | get O365 group/teams information
*WorkspaceApi* | [**Get-MySiteInformation**](docs/WorkspaceApi.md#Get-MySiteInformation) | **GET** /workspace/sites/{id} | 
*WorkspaceApi* | [**Get-SiteAutoImportProfile**](docs/WorkspaceApi.md#Get-SiteAutoImportProfile) | **GET** /workspace/sites/{id}/confirm/settings | get site auto import settings
*WorkspaceApi* | [**Get-SiteContacts**](docs/WorkspaceApi.md#Get-SiteContacts) | **GET** /workspace/sites/{id}/contacts | get site contacts
*WorkspaceApi* | [**Get-SiteMetadata**](docs/WorkspaceApi.md#Get-SiteMetadata) | **GET** /workspace/sites/metadata | get site metadata
*WorkspaceApi* | [**Get-SiteMetadataRenewalItems**](docs/WorkspaceApi.md#Get-SiteMetadataRenewalItems) | **GET** /workspace/sites/{id}/renew/metadata | get site metadata renewal items
*WorkspaceApi* | [**Get-SitePermissionRenewalFilters**](docs/WorkspaceApi.md#Get-SitePermissionRenewalFilters) | **GET** /workspace/sites/{id}/renew/permission/filters | get site permission renewal report filters
*WorkspaceApi* | [**Get-SitePermissionRenewalFiltersForSPGroup**](docs/WorkspaceApi.md#Get-SitePermissionRenewalFiltersForSPGroup) | **GET** /workspace/sites/{id}/renew/permission/group/{groupid}/filters | get site permission renewal sharePoint group report filters
*WorkspaceApi* | [**Get-SitePermissionRenewalItems**](docs/WorkspaceApi.md#Get-SitePermissionRenewalItems) | **GET** /workspace/sites/{id}/renew/permissions | get site permission renewal items
*WorkspaceApi* | [**Get-SitePermissionRenewalItemsForSPGroup**](docs/WorkspaceApi.md#Get-SitePermissionRenewalItemsForSPGroup) | **GET** /workspace/sites/{id}/renew/permissions/group/{groupid} | get sharePoint group members of site permission renewal item
*WorkspaceApi* | [**Get-SitePermissionRenewalPermissionLevels**](docs/WorkspaceApi.md#Get-SitePermissionRenewalPermissionLevels) | **GET** /workspace/sites/{id}/renew/permissionlevels | get site permission level for permission renewal
*WorkspaceApi* | [**Get-SiteRenewalProfileSettings**](docs/WorkspaceApi.md#Get-SiteRenewalProfileSettings) | **GET** /workspace/sites/{id}/renew/settings | get site renewal settings
*WorkspaceApi* | [**Get-SiteSharingOptions**](docs/WorkspaceApi.md#Get-SiteSharingOptions) | **GET** /workspace/sites/sharingoptions | get site sharing options by site url or id
*WorkspaceApi* | [**Get-WorkspaceFilters**](docs/WorkspaceApi.md#Get-WorkspaceFilters) | **GET** /workspace/my/filters | get my workspace filters
*WorkspaceApi* | [**Get-WorkspaceItems**](docs/WorkspaceApi.md#Get-WorkspaceItems) | **GET** /workspace/my | get my workspace items
*WorkspaceApi* | [**Invoke-ReassignGroupRenewalTask**](docs/WorkspaceApi.md#Invoke-ReassignGroupRenewalTask) | **POST** /workspace/groups/{id}/renew/reassign | reassign the group/teams renewal task
*WorkspaceApi* | [**Invoke-ReassignSiteRenewalTask**](docs/WorkspaceApi.md#Invoke-ReassignSiteRenewalTask) | **POST** /workspace/sites/{id}/renew/reassign | reassign the site renewal task
*WorkspaceApi* | [**Invoke-RejectGroupRenewalTask**](docs/WorkspaceApi.md#Invoke-RejectGroupRenewalTask) | **POST** /workspace/groups/{id}/renew/reject | reject the group/teams renewal task
*WorkspaceApi* | [**Invoke-RejectSiteRenewalTask**](docs/WorkspaceApi.md#Invoke-RejectSiteRenewalTask) | **POST** /workspace/sites/{id}/renew/reject | reject the site renewal task
*WorkspaceApi* | [**Reset-ChangeForSiteRenewal**](docs/WorkspaceApi.md#Reset-ChangeForSiteRenewal) | **POST** /workspace/sites/{id}/renew/reset | reset your change
*WorkspaceApi* | [**Reset-ChangesForGroupRenewal**](docs/WorkspaceApi.md#Reset-ChangesForGroupRenewal) | **POST** /workspace/groups/{id}/renew/reset | reset your change
*WorkspaceApi* | [**Save-GroupPermissionRenewalItems**](docs/WorkspaceApi.md#Save-GroupPermissionRenewalItems) | **POST** /workspace/groups/{id}/renew/permissions | save group/teams permission renewal items
*WorkspaceApi* | [**Save-SitePermissionRenewalItems**](docs/WorkspaceApi.md#Save-SitePermissionRenewalItems) | **POST** /workspace/sites/{id}/renew/permissions | save site permission renewal items
*WorkspaceApi* | [**Submit-GroupRenewalTask**](docs/WorkspaceApi.md#Submit-GroupRenewalTask) | **POST** /workspace/groups/{id}/renew/submit | submit the group/teams renewal task
*WorkspaceApi* | [**Submit-GroupRenewalTaskForArchiving**](docs/WorkspaceApi.md#Submit-GroupRenewalTaskForArchiving) | **POST** /workspace/groups/{id}/renew/archive | submit group/teams renewal task with archive
*WorkspaceApi* | [**Submit-GroupRenewalTaskForDeleting**](docs/WorkspaceApi.md#Submit-GroupRenewalTaskForDeleting) | **POST** /workspace/groups/{id}/renew/delete | submit group/teams renewal task with deletion
*WorkspaceApi* | [**Submit-SiteRenewalTask**](docs/WorkspaceApi.md#Submit-SiteRenewalTask) | **POST** /workspace/sites/{id}/renew/submit | submit the site renewal task
*WorkspaceApi* | [**Submit-SiteRenewalTaskForDeleting**](docs/WorkspaceApi.md#Submit-SiteRenewalTaskForDeleting) | **POST** /workspace/sites/{id}/renew/delete | submit site renewal task with deletion
*WorkspaceApi* | [**Submit-SiteRenewalTaskWithArchiving**](docs/WorkspaceApi.md#Submit-SiteRenewalTaskWithArchiving) | **POST** /workspace/sites/{id}/renew/archive | approval site renewal task with archive


## Documentation for Models

 - [Cloud.Governance.Client\Model.AadPropertyInputType](docs/AadPropertyInputType.md)
 - [Cloud.Governance.Client\Model.AccessRequestType](docs/AccessRequestType.md)
 - [Cloud.Governance.Client\Model.AddGroupMemberType](docs/AddGroupMemberType.md)
 - [Cloud.Governance.Client\Model.AdditionalActionType](docs/AdditionalActionType.md)
 - [Cloud.Governance.Client\Model.AdminNotificationEscalationModel](docs/AdminNotificationEscalationModel.md)
 - [Cloud.Governance.Client\Model.AdministratorNotificationModel](docs/AdministratorNotificationModel.md)
 - [Cloud.Governance.Client\Model.AdministratorNotificationViewModel](docs/AdministratorNotificationViewModel.md)
 - [Cloud.Governance.Client\Model.AllRequestList](docs/AllRequestList.md)
 - [Cloud.Governance.Client\Model.AllRequestListPageResult](docs/AllRequestListPageResult.md)
 - [Cloud.Governance.Client\Model.AllTaskList](docs/AllTaskList.md)
 - [Cloud.Governance.Client\Model.AllTaskListPageResult](docs/AllTaskListPageResult.md)
 - [Cloud.Governance.Client\Model.AnnoymouslinkPermissions](docs/AnnoymouslinkPermissions.md)
 - [Cloud.Governance.Client\Model.AnonymousLinkSettings](docs/AnonymousLinkSettings.md)
 - [Cloud.Governance.Client\Model.ApiDurationType](docs/ApiDurationType.md)
 - [Cloud.Governance.Client\Model.ApiDurationTypeNullable](docs/ApiDurationTypeNullable.md)
 - [Cloud.Governance.Client\Model.ApiEscalationType](docs/ApiEscalationType.md)
 - [Cloud.Governance.Client\Model.ApiFeedbackServiceType](docs/ApiFeedbackServiceType.md)
 - [Cloud.Governance.Client\Model.ApiMyGroup](docs/ApiMyGroup.md)
 - [Cloud.Governance.Client\Model.ApiRequest](docs/ApiRequest.md)
 - [Cloud.Governance.Client\Model.ApiRequestProgressStatus](docs/ApiRequestProgressStatus.md)
 - [Cloud.Governance.Client\Model.ApiSettingGridModel](docs/ApiSettingGridModel.md)
 - [Cloud.Governance.Client\Model.ApiSettingGridModelPageResult](docs/ApiSettingGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.ApiSettingModel](docs/ApiSettingModel.md)
 - [Cloud.Governance.Client\Model.ApiSettingViewModel](docs/ApiSettingViewModel.md)
 - [Cloud.Governance.Client\Model.ApiTask](docs/ApiTask.md)
 - [Cloud.Governance.Client\Model.ApiTaskDynamicProperties](docs/ApiTaskDynamicProperties.md)
 - [Cloud.Governance.Client\Model.ApiTermInfo](docs/ApiTermInfo.md)
 - [Cloud.Governance.Client\Model.ApiTermInfoPageResult](docs/ApiTermInfoPageResult.md)
 - [Cloud.Governance.Client\Model.ApiUser](docs/ApiUser.md)
 - [Cloud.Governance.Client\Model.ApiUserChangedProperty](docs/ApiUserChangedProperty.md)
 - [Cloud.Governance.Client\Model.ApiUserPageResult](docs/ApiUserPageResult.md)
 - [Cloud.Governance.Client\Model.AppBrandingModel](docs/AppBrandingModel.md)
 - [Cloud.Governance.Client\Model.AppSettings](docs/AppSettings.md)
 - [Cloud.Governance.Client\Model.ApplicationSettings](docs/ApplicationSettings.md)
 - [Cloud.Governance.Client\Model.ApplyPolicyInfo](docs/ApplyPolicyInfo.md)
 - [Cloud.Governance.Client\Model.ApplyPolicyRequestModel](docs/ApplyPolicyRequestModel.md)
 - [Cloud.Governance.Client\Model.ApplyPolicyStatus](docs/ApplyPolicyStatus.md)
 - [Cloud.Governance.Client\Model.ApprovalAction](docs/ApprovalAction.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessGridModel](docs/ApprovalProcessGridModel.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessGridModelPageResult](docs/ApprovalProcessGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessModel](docs/ApprovalProcessModel.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessStageCollection](docs/ApprovalProcessStageCollection.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessStageDurationSetting](docs/ApprovalProcessStageDurationSetting.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessStageEmailSetting](docs/ApprovalProcessStageEmailSetting.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessStageInfo](docs/ApprovalProcessStageInfo.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessStageModel](docs/ApprovalProcessStageModel.md)
 - [Cloud.Governance.Client\Model.ApprovalProcessStageSettings](docs/ApprovalProcessStageSettings.md)
 - [Cloud.Governance.Client\Model.ApproveOrder](docs/ApproveOrder.md)
 - [Cloud.Governance.Client\Model.ArchiveGroupRequest](docs/ArchiveGroupRequest.md)
 - [Cloud.Governance.Client\Model.ArchiveSiteRequest](docs/ArchiveSiteRequest.md)
 - [Cloud.Governance.Client\Model.ArchiveWebLifecycleRequest](docs/ArchiveWebLifecycleRequest.md)
 - [Cloud.Governance.Client\Model.AssignBy](docs/AssignBy.md)
 - [Cloud.Governance.Client\Model.AuditActionType](docs/AuditActionType.md)
 - [Cloud.Governance.Client\Model.AuditObjectType](docs/AuditObjectType.md)
 - [Cloud.Governance.Client\Model.AuthenticationType](docs/AuthenticationType.md)
 - [Cloud.Governance.Client\Model.AutoGenerateUrlSetting](docs/AutoGenerateUrlSetting.md)
 - [Cloud.Governance.Client\Model.AutoGenerateUrlType](docs/AutoGenerateUrlType.md)
 - [Cloud.Governance.Client\Model.AutoImportObjectDemoJob](docs/AutoImportObjectDemoJob.md)
 - [Cloud.Governance.Client\Model.AutoImportPhase](docs/AutoImportPhase.md)
 - [Cloud.Governance.Client\Model.AutoImportProfileRef](docs/AutoImportProfileRef.md)
 - [Cloud.Governance.Client\Model.AutoTaskArchiveRequest](docs/AutoTaskArchiveRequest.md)
 - [Cloud.Governance.Client\Model.AutoTaskChangePolicyRequest](docs/AutoTaskChangePolicyRequest.md)
 - [Cloud.Governance.Client\Model.AutoTaskDeleteRequest](docs/AutoTaskDeleteRequest.md)
 - [Cloud.Governance.Client\Model.AutoTaskExtendRequest](docs/AutoTaskExtendRequest.md)
 - [Cloud.Governance.Client\Model.AzureADGroup](docs/AzureADGroup.md)
 - [Cloud.Governance.Client\Model.AzureAdMetadataSettings](docs/AzureAdMetadataSettings.md)
 - [Cloud.Governance.Client\Model.AzureStorage](docs/AzureStorage.md)
 - [Cloud.Governance.Client\Model.AzureStorageContainer](docs/AzureStorageContainer.md)
 - [Cloud.Governance.Client\Model.BackupEnvironmentSetting](docs/BackupEnvironmentSetting.md)
 - [Cloud.Governance.Client\Model.BooleanChangedProperty](docs/BooleanChangedProperty.md)
 - [Cloud.Governance.Client\Model.BooleanMetadataSettings](docs/BooleanMetadataSettings.md)
 - [Cloud.Governance.Client\Model.BrandingSourceType](docs/BrandingSourceType.md)
 - [Cloud.Governance.Client\Model.BriefGroupPolicy](docs/BriefGroupPolicy.md)
 - [Cloud.Governance.Client\Model.CategoryType](docs/CategoryType.md)
 - [Cloud.Governance.Client\Model.ChangeContactByUrlSetting](docs/ChangeContactByUrlSetting.md)
 - [Cloud.Governance.Client\Model.ChangeContactByUserSetting](docs/ChangeContactByUserSetting.md)
 - [Cloud.Governance.Client\Model.ChangeContactMethod](docs/ChangeContactMethod.md)
 - [Cloud.Governance.Client\Model.ChangeGroupPolicyRequest](docs/ChangeGroupPolicyRequest.md)
 - [Cloud.Governance.Client\Model.ChangeGroupPolicyResult](docs/ChangeGroupPolicyResult.md)
 - [Cloud.Governance.Client\Model.ChangeGroupQuotaRequest](docs/ChangeGroupQuotaRequest.md)
 - [Cloud.Governance.Client\Model.ChangeGroupQuotaResult](docs/ChangeGroupQuotaResult.md)
 - [Cloud.Governance.Client\Model.ChangeGroupQuotaSetting](docs/ChangeGroupQuotaSetting.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSetting](docs/ChangeGroupSetting.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingCheckResult](docs/ChangeGroupSettingCheckResult.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingRequest](docs/ChangeGroupSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingService](docs/ChangeGroupSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeGroupSettingValidationParameter](docs/ChangeGroupSettingValidationParameter.md)
 - [Cloud.Governance.Client\Model.ChangeHubsiteActionType](docs/ChangeHubsiteActionType.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingObjectInfo](docs/ChangeListSettingObjectInfo.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingRequest](docs/ChangeListSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingService](docs/ChangeListSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeListSettingValidateResult](docs/ChangeListSettingValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeMetadataActionSetting](docs/ChangeMetadataActionSetting.md)
 - [Cloud.Governance.Client\Model.ChangePermissionRequest](docs/ChangePermissionRequest.md)
 - [Cloud.Governance.Client\Model.ChangePermissionService](docs/ChangePermissionService.md)
 - [Cloud.Governance.Client\Model.ChangePermissionValidateResult](docs/ChangePermissionValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangePolicyScopeModel](docs/ChangePolicyScopeModel.md)
 - [Cloud.Governance.Client\Model.ChangeQuotaType](docs/ChangeQuotaType.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactRequest](docs/ChangeSiteContactRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactService](docs/ChangeSiteContactService.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactSubRequest](docs/ChangeSiteContactSubRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteContactValidateResult](docs/ChangeSiteContactValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeSitePolicyRequest](docs/ChangeSitePolicyRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSitePolicySetting](docs/ChangeSitePolicySetting.md)
 - [Cloud.Governance.Client\Model.ChangeSiteQuotaRequest](docs/ChangeSiteQuotaRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteQuotaSettings](docs/ChangeSiteQuotaSettings.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingRequest](docs/ChangeSiteSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingService](docs/ChangeSiteSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeSiteSettingValidateResult](docs/ChangeSiteSettingValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactByUrlSetting](docs/ChangeWebContactByUrlSetting.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactRequest](docs/ChangeWebContactRequest.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactService](docs/ChangeWebContactService.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactSubRequest](docs/ChangeWebContactSubRequest.md)
 - [Cloud.Governance.Client\Model.ChangeWebContactValidateResult](docs/ChangeWebContactValidateResult.md)
 - [Cloud.Governance.Client\Model.ChangeWebSPObject](docs/ChangeWebSPObject.md)
 - [Cloud.Governance.Client\Model.ChangeWebSettingRequest](docs/ChangeWebSettingRequest.md)
 - [Cloud.Governance.Client\Model.ChangeWebSettingService](docs/ChangeWebSettingService.md)
 - [Cloud.Governance.Client\Model.ChangeWebUrlValidateResult](docs/ChangeWebUrlValidateResult.md)
 - [Cloud.Governance.Client\Model.ChartSettings](docs/ChartSettings.md)
 - [Cloud.Governance.Client\Model.ChartStatistic](docs/ChartStatistic.md)
 - [Cloud.Governance.Client\Model.ChartType](docs/ChartType.md)
 - [Cloud.Governance.Client\Model.ChoiceMetadataSettings](docs/ChoiceMetadataSettings.md)
 - [Cloud.Governance.Client\Model.ChoiceType](docs/ChoiceType.md)
 - [Cloud.Governance.Client\Model.ClaimStatus](docs/ClaimStatus.md)
 - [Cloud.Governance.Client\Model.ClonePermissionAdditionalOption](docs/ClonePermissionAdditionalOption.md)
 - [Cloud.Governance.Client\Model.ClonePermissionOption](docs/ClonePermissionOption.md)
 - [Cloud.Governance.Client\Model.ClonePermissionReportProperty](docs/ClonePermissionReportProperty.md)
 - [Cloud.Governance.Client\Model.ClonePermissionRequest](docs/ClonePermissionRequest.md)
 - [Cloud.Governance.Client\Model.ClonePermissionSecuritySearchResult](docs/ClonePermissionSecuritySearchResult.md)
 - [Cloud.Governance.Client\Model.ClonePermissionSecuritySearchResultPageResult](docs/ClonePermissionSecuritySearchResultPageResult.md)
 - [Cloud.Governance.Client\Model.ClonePermissionService](docs/ClonePermissionService.md)
 - [Cloud.Governance.Client\Model.ClonePermissionValidateResult](docs/ClonePermissionValidateResult.md)
 - [Cloud.Governance.Client\Model.CommentsParam](docs/CommentsParam.md)
 - [Cloud.Governance.Client\Model.CommonStatus](docs/CommonStatus.md)
 - [Cloud.Governance.Client\Model.ConfirmInformation](docs/ConfirmInformation.md)
 - [Cloud.Governance.Client\Model.ConflictResolutionSetting](docs/ConflictResolutionSetting.md)
 - [Cloud.Governance.Client\Model.ConflictSolutionType](docs/ConflictSolutionType.md)
 - [Cloud.Governance.Client\Model.ConstructureType](docs/ConstructureType.md)
 - [Cloud.Governance.Client\Model.ContactActionLockItem](docs/ContactActionLockItem.md)
 - [Cloud.Governance.Client\Model.ContactOption](docs/ContactOption.md)
 - [Cloud.Governance.Client\Model.ContentMoveAction](docs/ContentMoveAction.md)
 - [Cloud.Governance.Client\Model.ContentMoveCommonSetting](docs/ContentMoveCommonSetting.md)
 - [Cloud.Governance.Client\Model.ContentMoveMethod](docs/ContentMoveMethod.md)
 - [Cloud.Governance.Client\Model.ContentMoveProfileMappings](docs/ContentMoveProfileMappings.md)
 - [Cloud.Governance.Client\Model.ContentMoveProfiles](docs/ContentMoveProfiles.md)
 - [Cloud.Governance.Client\Model.ContentMoveRequest](docs/ContentMoveRequest.md)
 - [Cloud.Governance.Client\Model.ContentMoveSPObject](docs/ContentMoveSPObject.md)
 - [Cloud.Governance.Client\Model.ContentMoveSPObjectMapping](docs/ContentMoveSPObjectMapping.md)
 - [Cloud.Governance.Client\Model.ContentMoveService](docs/ContentMoveService.md)
 - [Cloud.Governance.Client\Model.ContentMoveUrlValidationResult](docs/ContentMoveUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.ContructUrlSetting](docs/ContructUrlSetting.md)
 - [Cloud.Governance.Client\Model.ConvertHubSiteActionType](docs/ConvertHubSiteActionType.md)
 - [Cloud.Governance.Client\Model.CopyMoveSetting](docs/CopyMoveSetting.md)
 - [Cloud.Governance.Client\Model.CopyMoveSettingAssignBy](docs/CopyMoveSettingAssignBy.md)
 - [Cloud.Governance.Client\Model.CreateGroupRequest](docs/CreateGroupRequest.md)
 - [Cloud.Governance.Client\Model.CreateGroupService](docs/CreateGroupService.md)
 - [Cloud.Governance.Client\Model.CreateListRequest](docs/CreateListRequest.md)
 - [Cloud.Governance.Client\Model.CreateListSPObject](docs/CreateListSPObject.md)
 - [Cloud.Governance.Client\Model.CreateListService](docs/CreateListService.md)
 - [Cloud.Governance.Client\Model.CreateListUrlSettings](docs/CreateListUrlSettings.md)
 - [Cloud.Governance.Client\Model.CreateListUrlValidationResult](docs/CreateListUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.CreateSiteRequest](docs/CreateSiteRequest.md)
 - [Cloud.Governance.Client\Model.CreateSiteService](docs/CreateSiteService.md)
 - [Cloud.Governance.Client\Model.CreateWebRequest](docs/CreateWebRequest.md)
 - [Cloud.Governance.Client\Model.CreateWebScopeSettings](docs/CreateWebScopeSettings.md)
 - [Cloud.Governance.Client\Model.CreateWebService](docs/CreateWebService.md)
 - [Cloud.Governance.Client\Model.CreateWebUrlValidationResult](docs/CreateWebUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.CreateWebValidationParameter](docs/CreateWebValidationParameter.md)
 - [Cloud.Governance.Client\Model.CustomActionSettings](docs/CustomActionSettings.md)
 - [Cloud.Governance.Client\Model.CustomHelpLinkModel](docs/CustomHelpLinkModel.md)
 - [Cloud.Governance.Client\Model.CustomMetadata](docs/CustomMetadata.md)
 - [Cloud.Governance.Client\Model.CustomMetadataPageResult](docs/CustomMetadataPageResult.md)
 - [Cloud.Governance.Client\Model.DayOfWeek](docs/DayOfWeek.md)
 - [Cloud.Governance.Client\Model.DelayNotificationSettingsModel](docs/DelayNotificationSettingsModel.md)
 - [Cloud.Governance.Client\Model.DelegatedAccessToken](docs/DelegatedAccessToken.md)
 - [Cloud.Governance.Client\Model.DelegatedAccessTokenApiResult](docs/DelegatedAccessTokenApiResult.md)
 - [Cloud.Governance.Client\Model.DeleteGroupRequest](docs/DeleteGroupRequest.md)
 - [Cloud.Governance.Client\Model.DeleteGroupSetting](docs/DeleteGroupSetting.md)
 - [Cloud.Governance.Client\Model.DeleteSiteRequest](docs/DeleteSiteRequest.md)
 - [Cloud.Governance.Client\Model.DeleteType](docs/DeleteType.md)
 - [Cloud.Governance.Client\Model.DeleteWebLifecycleRequest](docs/DeleteWebLifecycleRequest.md)
 - [Cloud.Governance.Client\Model.DemoPreparationModel](docs/DemoPreparationModel.md)
 - [Cloud.Governance.Client\Model.DepartmentActionModel](docs/DepartmentActionModel.md)
 - [Cloud.Governance.Client\Model.DepartmentList](docs/DepartmentList.md)
 - [Cloud.Governance.Client\Model.DepartmentListPageResult](docs/DepartmentListPageResult.md)
 - [Cloud.Governance.Client\Model.DepartmentSettingsModel](docs/DepartmentSettingsModel.md)
 - [Cloud.Governance.Client\Model.DepartmentSource](docs/DepartmentSource.md)
 - [Cloud.Governance.Client\Model.DeploymentManagerPlanSettings](docs/DeploymentManagerPlanSettings.md)
 - [Cloud.Governance.Client\Model.DisplayInReportType](docs/DisplayInReportType.md)
 - [Cloud.Governance.Client\Model.DistinctPageResult](docs/DistinctPageResult.md)
 - [Cloud.Governance.Client\Model.DistinctResult](docs/DistinctResult.md)
 - [Cloud.Governance.Client\Model.DpmServiceSetting](docs/DpmServiceSetting.md)
 - [Cloud.Governance.Client\Model.DueDateType](docs/DueDateType.md)
 - [Cloud.Governance.Client\Model.DurationDateType](docs/DurationDateType.md)
 - [Cloud.Governance.Client\Model.DurationDateTypeNullable](docs/DurationDateTypeNullable.md)
 - [Cloud.Governance.Client\Model.DurationType](docs/DurationType.md)
 - [Cloud.Governance.Client\Model.DynamicGroupRuleInfo](docs/DynamicGroupRuleInfo.md)
 - [Cloud.Governance.Client\Model.DynamicRuleCondition](docs/DynamicRuleCondition.md)
 - [Cloud.Governance.Client\Model.DynamicRuleElement](docs/DynamicRuleElement.md)
 - [Cloud.Governance.Client\Model.ElectUserRequestModel](docs/ElectUserRequestModel.md)
 - [Cloud.Governance.Client\Model.ElectionDurationType](docs/ElectionDurationType.md)
 - [Cloud.Governance.Client\Model.ElectionProcessModel](docs/ElectionProcessModel.md)
 - [Cloud.Governance.Client\Model.ElectionProcessViewModel](docs/ElectionProcessViewModel.md)
 - [Cloud.Governance.Client\Model.EmailReferenceModel](docs/EmailReferenceModel.md)
 - [Cloud.Governance.Client\Model.EmailReferenceType](docs/EmailReferenceType.md)
 - [Cloud.Governance.Client\Model.EmailTemplateContent](docs/EmailTemplateContent.md)
 - [Cloud.Governance.Client\Model.EmailTemplateList](docs/EmailTemplateList.md)
 - [Cloud.Governance.Client\Model.EmailTemplateListPageResult](docs/EmailTemplateListPageResult.md)
 - [Cloud.Governance.Client\Model.EmailTemplateModel](docs/EmailTemplateModel.md)
 - [Cloud.Governance.Client\Model.EmailTemplateType](docs/EmailTemplateType.md)
 - [Cloud.Governance.Client\Model.EscalationType](docs/EscalationType.md)
 - [Cloud.Governance.Client\Model.EventAction](docs/EventAction.md)
 - [Cloud.Governance.Client\Model.EventObject](docs/EventObject.md)
 - [Cloud.Governance.Client\Model.EventObjectType](docs/EventObjectType.md)
 - [Cloud.Governance.Client\Model.ExecutionModel](docs/ExecutionModel.md)
 - [Cloud.Governance.Client\Model.ExecutionParameter](docs/ExecutionParameter.md)
 - [Cloud.Governance.Client\Model.ExecutionScheduleList](docs/ExecutionScheduleList.md)
 - [Cloud.Governance.Client\Model.ExecutionScheduleListPageResult](docs/ExecutionScheduleListPageResult.md)
 - [Cloud.Governance.Client\Model.ExecutionScheduleModel](docs/ExecutionScheduleModel.md)
 - [Cloud.Governance.Client\Model.ExpirationType](docs/ExpirationType.md)
 - [Cloud.Governance.Client\Model.ExportLocationGridModel](docs/ExportLocationGridModel.md)
 - [Cloud.Governance.Client\Model.ExportLocationGridModelPageResult](docs/ExportLocationGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.ExportLocationModel](docs/ExportLocationModel.md)
 - [Cloud.Governance.Client\Model.ExtendBasedOnPoint](docs/ExtendBasedOnPoint.md)
 - [Cloud.Governance.Client\Model.ExtendGroupRequest](docs/ExtendGroupRequest.md)
 - [Cloud.Governance.Client\Model.ExtendGroupResult](docs/ExtendGroupResult.md)
 - [Cloud.Governance.Client\Model.ExtendGroupSetting](docs/ExtendGroupSetting.md)
 - [Cloud.Governance.Client\Model.ExtendSiteRequest](docs/ExtendSiteRequest.md)
 - [Cloud.Governance.Client\Model.ExtendSiteSetting](docs/ExtendSiteSetting.md)
 - [Cloud.Governance.Client\Model.ExtendType](docs/ExtendType.md)
 - [Cloud.Governance.Client\Model.ExternalSharingOptions](docs/ExternalSharingOptions.md)
 - [Cloud.Governance.Client\Model.ExternalUserSharingSettings](docs/ExternalUserSharingSettings.md)
 - [Cloud.Governance.Client\Model.ExternalUserSharingType](docs/ExternalUserSharingType.md)
 - [Cloud.Governance.Client\Model.ExternalUserType](docs/ExternalUserType.md)
 - [Cloud.Governance.Client\Model.GeoLocationBase](docs/GeoLocationBase.md)
 - [Cloud.Governance.Client\Model.GeoLocationModel](docs/GeoLocationModel.md)
 - [Cloud.Governance.Client\Model.GiphyRatingType](docs/GiphyRatingType.md)
 - [Cloud.Governance.Client\Model.GlobalPersonalSettingModel](docs/GlobalPersonalSettingModel.md)
 - [Cloud.Governance.Client\Model.GrantPermissionGroup](docs/GrantPermissionGroup.md)
 - [Cloud.Governance.Client\Model.GrantPermissionModel](docs/GrantPermissionModel.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequest](docs/GrantPermissionRequest.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestDurationSettings](docs/GrantPermissionRequestDurationSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionRequestPermissionSettings](docs/GrantPermissionRequestPermissionSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionSPObject](docs/GrantPermissionSPObject.md)
 - [Cloud.Governance.Client\Model.GrantPermissionService](docs/GrantPermissionService.md)
 - [Cloud.Governance.Client\Model.GrantPermissionServiceDurationSettings](docs/GrantPermissionServiceDurationSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionServicePermissionSettings](docs/GrantPermissionServicePermissionSettings.md)
 - [Cloud.Governance.Client\Model.GrantPermissionUrlValidationResult](docs/GrantPermissionUrlValidationResult.md)
 - [Cloud.Governance.Client\Model.GroupConstructureRule](docs/GroupConstructureRule.md)
 - [Cloud.Governance.Client\Model.GroupEnableSharingStatus](docs/GroupEnableSharingStatus.md)
 - [Cloud.Governance.Client\Model.GroupGridModel](docs/GroupGridModel.md)
 - [Cloud.Governance.Client\Model.GroupGridModelPageResult](docs/GroupGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.GroupIdConstructureSettings](docs/GroupIdConstructureSettings.md)
 - [Cloud.Governance.Client\Model.GroupIdRuleType](docs/GroupIdRuleType.md)
 - [Cloud.Governance.Client\Model.GroupInfo](docs/GroupInfo.md)
 - [Cloud.Governance.Client\Model.GroupJobTrigger](docs/GroupJobTrigger.md)
 - [Cloud.Governance.Client\Model.GroupJobTriggers](docs/GroupJobTriggers.md)
 - [Cloud.Governance.Client\Model.GroupLeasePeriodSettings](docs/GroupLeasePeriodSettings.md)
 - [Cloud.Governance.Client\Model.GroupLeasePeriodType](docs/GroupLeasePeriodType.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleActionType](docs/GroupLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleService](docs/GroupLifecycleService.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleSetting](docs/GroupLifecycleSetting.md)
 - [Cloud.Governance.Client\Model.GroupLifecycleValidateResult](docs/GroupLifecycleValidateResult.md)
 - [Cloud.Governance.Client\Model.GroupLinks](docs/GroupLinks.md)
 - [Cloud.Governance.Client\Model.GroupList](docs/GroupList.md)
 - [Cloud.Governance.Client\Model.GroupListPageResult](docs/GroupListPageResult.md)
 - [Cloud.Governance.Client\Model.GroupMembershipAction](docs/GroupMembershipAction.md)
 - [Cloud.Governance.Client\Model.GroupMembershipItem](docs/GroupMembershipItem.md)
 - [Cloud.Governance.Client\Model.GroupNameConstructureSettings](docs/GroupNameConstructureSettings.md)
 - [Cloud.Governance.Client\Model.GroupOwnerType](docs/GroupOwnerType.md)
 - [Cloud.Governance.Client\Model.GroupPermissionActionItem](docs/GroupPermissionActionItem.md)
 - [Cloud.Governance.Client\Model.GroupPermissionActionItemPageResult](docs/GroupPermissionActionItemPageResult.md)
 - [Cloud.Governance.Client\Model.GroupPolicyLifecycleSetting](docs/GroupPolicyLifecycleSetting.md)
 - [Cloud.Governance.Client\Model.GroupPolicyModel](docs/GroupPolicyModel.md)
 - [Cloud.Governance.Client\Model.GroupQuotaThresholdSetting](docs/GroupQuotaThresholdSetting.md)
 - [Cloud.Governance.Client\Model.GroupRecertificationJobTrigger](docs/GroupRecertificationJobTrigger.md)
 - [Cloud.Governance.Client\Model.GroupRecertificationType](docs/GroupRecertificationType.md)
 - [Cloud.Governance.Client\Model.GroupRenewProfileRef](docs/GroupRenewProfileRef.md)
 - [Cloud.Governance.Client\Model.GroupReport](docs/GroupReport.md)
 - [Cloud.Governance.Client\Model.GroupReportPageResult](docs/GroupReportPageResult.md)
 - [Cloud.Governance.Client\Model.GroupRestrictionType](docs/GroupRestrictionType.md)
 - [Cloud.Governance.Client\Model.GroupSharingSetting](docs/GroupSharingSetting.md)
 - [Cloud.Governance.Client\Model.GroupSiteSharingCapabilities](docs/GroupSiteSharingCapabilities.md)
 - [Cloud.Governance.Client\Model.GroupStatus](docs/GroupStatus.md)
 - [Cloud.Governance.Client\Model.GroupStatusScanJobTrigger](docs/GroupStatusScanJobTrigger.md)
 - [Cloud.Governance.Client\Model.GroupThresholdSetting](docs/GroupThresholdSetting.md)
 - [Cloud.Governance.Client\Model.GroupUser](docs/GroupUser.md)
 - [Cloud.Governance.Client\Model.GroupValidationParameter](docs/GroupValidationParameter.md)
 - [Cloud.Governance.Client\Model.GuidBooleanModel](docs/GuidBooleanModel.md)
 - [Cloud.Governance.Client\Model.GuidModel](docs/GuidModel.md)
 - [Cloud.Governance.Client\Model.GuidSettingModel](docs/GuidSettingModel.md)
 - [Cloud.Governance.Client\Model.HelpLinkType](docs/HelpLinkType.md)
 - [Cloud.Governance.Client\Model.HubSiteChangedSettings](docs/HubSiteChangedSettings.md)
 - [Cloud.Governance.Client\Model.HubSiteSettings](docs/HubSiteSettings.md)
 - [Cloud.Governance.Client\Model.ImpersonationAccountList](docs/ImpersonationAccountList.md)
 - [Cloud.Governance.Client\Model.ImpersonationAccountListPageResult](docs/ImpersonationAccountListPageResult.md)
 - [Cloud.Governance.Client\Model.ImpersonationAccountModel](docs/ImpersonationAccountModel.md)
 - [Cloud.Governance.Client\Model.InlineResponse200](docs/InlineResponse200.md)
 - [Cloud.Governance.Client\Model.IntModel](docs/IntModel.md)
 - [Cloud.Governance.Client\Model.InviteSupportModel](docs/InviteSupportModel.md)
 - [Cloud.Governance.Client\Model.InviteType](docs/InviteType.md)
 - [Cloud.Governance.Client\Model.IssueType](docs/IssueType.md)
 - [Cloud.Governance.Client\Model.ItemConflictResolutionType](docs/ItemConflictResolutionType.md)
 - [Cloud.Governance.Client\Model.JointNode](docs/JointNode.md)
 - [Cloud.Governance.Client\Model.LanguageWithTemplates](docs/LanguageWithTemplates.md)
 - [Cloud.Governance.Client\Model.LifecycleAction](docs/LifecycleAction.md)
 - [Cloud.Governance.Client\Model.LineOrColumnChartReport](docs/LineOrColumnChartReport.md)
 - [Cloud.Governance.Client\Model.LinkMetadataSettings](docs/LinkMetadataSettings.md)
 - [Cloud.Governance.Client\Model.LinkValue](docs/LinkValue.md)
 - [Cloud.Governance.Client\Model.ListPermissionSettings](docs/ListPermissionSettings.md)
 - [Cloud.Governance.Client\Model.ListTemplate](docs/ListTemplate.md)
 - [Cloud.Governance.Client\Model.ListTemplateSettings](docs/ListTemplateSettings.md)
 - [Cloud.Governance.Client\Model.ListType](docs/ListType.md)
 - [Cloud.Governance.Client\Model.ListValidationParameter](docs/ListValidationParameter.md)
 - [Cloud.Governance.Client\Model.ListVersionSettings](docs/ListVersionSettings.md)
 - [Cloud.Governance.Client\Model.ListVersionSettingsChangedProperty](docs/ListVersionSettingsChangedProperty.md)
 - [Cloud.Governance.Client\Model.LockSiteInfo](docs/LockSiteInfo.md)
 - [Cloud.Governance.Client\Model.LockSiteRequest](docs/LockSiteRequest.md)
 - [Cloud.Governance.Client\Model.LockSiteSetting](docs/LockSiteSetting.md)
 - [Cloud.Governance.Client\Model.LogicalOperator](docs/LogicalOperator.md)
 - [Cloud.Governance.Client\Model.LookupValue](docs/LookupValue.md)
 - [Cloud.Governance.Client\Model.ManagePermissionAction](docs/ManagePermissionAction.md)
 - [Cloud.Governance.Client\Model.ManagePermissionGrantSetting](docs/ManagePermissionGrantSetting.md)
 - [Cloud.Governance.Client\Model.ManagePermissionOption](docs/ManagePermissionOption.md)
 - [Cloud.Governance.Client\Model.ManagePermissionRequest](docs/ManagePermissionRequest.md)
 - [Cloud.Governance.Client\Model.ManagePermissionSPObject](docs/ManagePermissionSPObject.md)
 - [Cloud.Governance.Client\Model.ManagePermissionService](docs/ManagePermissionService.md)
 - [Cloud.Governance.Client\Model.ManagePermissionSharePointGroupOption](docs/ManagePermissionSharePointGroupOption.md)
 - [Cloud.Governance.Client\Model.ManagePermissionUserSetting](docs/ManagePermissionUserSetting.md)
 - [Cloud.Governance.Client\Model.ManagePermissionValidateResult](docs/ManagePermissionValidateResult.md)
 - [Cloud.Governance.Client\Model.ManualArchiveNodeLevel](docs/ManualArchiveNodeLevel.md)
 - [Cloud.Governance.Client\Model.ManuallyArchiveRecordModel](docs/ManuallyArchiveRecordModel.md)
 - [Cloud.Governance.Client\Model.ManuallyArchiveRecordModelPageResult](docs/ManuallyArchiveRecordModelPageResult.md)
 - [Cloud.Governance.Client\Model.ManuallyInputUrlSetting](docs/ManuallyInputUrlSetting.md)
 - [Cloud.Governance.Client\Model.MembershipRecertificationItem](docs/MembershipRecertificationItem.md)
 - [Cloud.Governance.Client\Model.MembershipRecertificationItemPageResult](docs/MembershipRecertificationItemPageResult.md)
 - [Cloud.Governance.Client\Model.MembershipRecertificationReportProperties](docs/MembershipRecertificationReportProperties.md)
 - [Cloud.Governance.Client\Model.MembershipRenewalItemModel](docs/MembershipRenewalItemModel.md)
 - [Cloud.Governance.Client\Model.MembershipType](docs/MembershipType.md)
 - [Cloud.Governance.Client\Model.MembershipUserType](docs/MembershipUserType.md)
 - [Cloud.Governance.Client\Model.MetadataActionLockItem](docs/MetadataActionLockItem.md)
 - [Cloud.Governance.Client\Model.MetadataActionType](docs/MetadataActionType.md)
 - [Cloud.Governance.Client\Model.MetadataDisplayType](docs/MetadataDisplayType.md)
 - [Cloud.Governance.Client\Model.MetadataFieldType](docs/MetadataFieldType.md)
 - [Cloud.Governance.Client\Model.MetadataFieldTypeNullable](docs/MetadataFieldTypeNullable.md)
 - [Cloud.Governance.Client\Model.MetadataList](docs/MetadataList.md)
 - [Cloud.Governance.Client\Model.MetadataListPageResult](docs/MetadataListPageResult.md)
 - [Cloud.Governance.Client\Model.MetadataRecertificationReportProperties](docs/MetadataRecertificationReportProperties.md)
 - [Cloud.Governance.Client\Model.MultiComboBoxItem](docs/MultiComboBoxItem.md)
 - [Cloud.Governance.Client\Model.MultiGeoControlMode](docs/MultiGeoControlMode.md)
 - [Cloud.Governance.Client\Model.MultiGeoSerivceSetting](docs/MultiGeoSerivceSetting.md)
 - [Cloud.Governance.Client\Model.MultiGeoSetting](docs/MultiGeoSetting.md)
 - [Cloud.Governance.Client\Model.MySite](docs/MySite.md)
 - [Cloud.Governance.Client\Model.MySiteType](docs/MySiteType.md)
 - [Cloud.Governance.Client\Model.NewsAndUpdatesModel](docs/NewsAndUpdatesModel.md)
 - [Cloud.Governance.Client\Model.NodeLevel](docs/NodeLevel.md)
 - [Cloud.Governance.Client\Model.NodeType](docs/NodeType.md)
 - [Cloud.Governance.Client\Model.ObjectActionType](docs/ObjectActionType.md)
 - [Cloud.Governance.Client\Model.ObjectContactModel](docs/ObjectContactModel.md)
 - [Cloud.Governance.Client\Model.ObjectPermissionManagementModel](docs/ObjectPermissionManagementModel.md)
 - [Cloud.Governance.Client\Model.OwnershipRecertification](docs/OwnershipRecertification.md)
 - [Cloud.Governance.Client\Model.PermissionActionItem](docs/PermissionActionItem.md)
 - [Cloud.Governance.Client\Model.PermissionActionItemPageResult](docs/PermissionActionItemPageResult.md)
 - [Cloud.Governance.Client\Model.PermissionActionLockItem](docs/PermissionActionLockItem.md)
 - [Cloud.Governance.Client\Model.PermissionActionType](docs/PermissionActionType.md)
 - [Cloud.Governance.Client\Model.PermissionChangedActionItem](docs/PermissionChangedActionItem.md)
 - [Cloud.Governance.Client\Model.PermissionChangedActionItemPageResult](docs/PermissionChangedActionItemPageResult.md)
 - [Cloud.Governance.Client\Model.PermissionChangedType](docs/PermissionChangedType.md)
 - [Cloud.Governance.Client\Model.PermissionLevel](docs/PermissionLevel.md)
 - [Cloud.Governance.Client\Model.PermissionLevelGridModel](docs/PermissionLevelGridModel.md)
 - [Cloud.Governance.Client\Model.PermissionLevelGridModelPageResult](docs/PermissionLevelGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.PermissionLevelModel](docs/PermissionLevelModel.md)
 - [Cloud.Governance.Client\Model.PermissionLevelType](docs/PermissionLevelType.md)
 - [Cloud.Governance.Client\Model.PermissionLevelViewModel](docs/PermissionLevelViewModel.md)
 - [Cloud.Governance.Client\Model.PermissionManagementModel](docs/PermissionManagementModel.md)
 - [Cloud.Governance.Client\Model.PermissionObjectProperty](docs/PermissionObjectProperty.md)
 - [Cloud.Governance.Client\Model.PermissionSettings](docs/PermissionSettings.md)
 - [Cloud.Governance.Client\Model.PersonalSettings](docs/PersonalSettings.md)
 - [Cloud.Governance.Client\Model.PersonalSettingsPropertyInfo](docs/PersonalSettingsPropertyInfo.md)
 - [Cloud.Governance.Client\Model.PieChartReport](docs/PieChartReport.md)
 - [Cloud.Governance.Client\Model.PolicyArchiverLifecycleItem](docs/PolicyArchiverLifecycleItem.md)
 - [Cloud.Governance.Client\Model.PolicyChangeLifecycleItem](docs/PolicyChangeLifecycleItem.md)
 - [Cloud.Governance.Client\Model.PolicyDaoSetting](docs/PolicyDaoSetting.md)
 - [Cloud.Governance.Client\Model.PolicyDeletionLifecycleItem](docs/PolicyDeletionLifecycleItem.md)
 - [Cloud.Governance.Client\Model.PolicyElectionSetting](docs/PolicyElectionSetting.md)
 - [Cloud.Governance.Client\Model.PolicyExpirationSetting](docs/PolicyExpirationSetting.md)
 - [Cloud.Governance.Client\Model.PolicyExpirationSettingModel](docs/PolicyExpirationSettingModel.md)
 - [Cloud.Governance.Client\Model.PolicyExtensionLifecycleItem](docs/PolicyExtensionLifecycleItem.md)
 - [Cloud.Governance.Client\Model.PolicyExtensionType](docs/PolicyExtensionType.md)
 - [Cloud.Governance.Client\Model.PolicyGridModel](docs/PolicyGridModel.md)
 - [Cloud.Governance.Client\Model.PolicyGridModelPageResult](docs/PolicyGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.PolicyIconSetting](docs/PolicyIconSetting.md)
 - [Cloud.Governance.Client\Model.PolicyLifecycleItem](docs/PolicyLifecycleItem.md)
 - [Cloud.Governance.Client\Model.PolicyLifecycleSetting](docs/PolicyLifecycleSetting.md)
 - [Cloud.Governance.Client\Model.PolicyLockLifecycleItem](docs/PolicyLockLifecycleItem.md)
 - [Cloud.Governance.Client\Model.PolicyQuotaLifecycleItem](docs/PolicyQuotaLifecycleItem.md)
 - [Cloud.Governance.Client\Model.PolicyQuotaSetting](docs/PolicyQuotaSetting.md)
 - [Cloud.Governance.Client\Model.PolicyQuotaThresholdSetting](docs/PolicyQuotaThresholdSetting.md)
 - [Cloud.Governance.Client\Model.PolicyRecertificationSetting](docs/PolicyRecertificationSetting.md)
 - [Cloud.Governance.Client\Model.PolicyRef](docs/PolicyRef.md)
 - [Cloud.Governance.Client\Model.PolicySharingSetting](docs/PolicySharingSetting.md)
 - [Cloud.Governance.Client\Model.PolicyType](docs/PolicyType.md)
 - [Cloud.Governance.Client\Model.PolicyWithTemplates](docs/PolicyWithTemplates.md)
 - [Cloud.Governance.Client\Model.PrincipalType](docs/PrincipalType.md)
 - [Cloud.Governance.Client\Model.Question](docs/Question.md)
 - [Cloud.Governance.Client\Model.QuestionItem](docs/QuestionItem.md)
 - [Cloud.Governance.Client\Model.QuestionRequest](docs/QuestionRequest.md)
 - [Cloud.Governance.Client\Model.QuestionaireType](docs/QuestionaireType.md)
 - [Cloud.Governance.Client\Model.QuestionnaireGridModel](docs/QuestionnaireGridModel.md)
 - [Cloud.Governance.Client\Model.QuestionnaireGridModelPageResult](docs/QuestionnaireGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.QuestionnaireModel](docs/QuestionnaireModel.md)
 - [Cloud.Governance.Client\Model.QuestionnaireNode](docs/QuestionnaireNode.md)
 - [Cloud.Governance.Client\Model.QuestionnaireNodeType](docs/QuestionnaireNodeType.md)
 - [Cloud.Governance.Client\Model.QuestionnaireRef](docs/QuestionnaireRef.md)
 - [Cloud.Governance.Client\Model.QuestionnaireRequest](docs/QuestionnaireRequest.md)
 - [Cloud.Governance.Client\Model.QuickRequestManagementModel](docs/QuickRequestManagementModel.md)
 - [Cloud.Governance.Client\Model.QuickRequestManagementViewModel](docs/QuickRequestManagementViewModel.md)
 - [Cloud.Governance.Client\Model.QuotaOption](docs/QuotaOption.md)
 - [Cloud.Governance.Client\Model.RecertificationActionType](docs/RecertificationActionType.md)
 - [Cloud.Governance.Client\Model.RecertificationObjectType](docs/RecertificationObjectType.md)
 - [Cloud.Governance.Client\Model.RecertificationProfileGridModel](docs/RecertificationProfileGridModel.md)
 - [Cloud.Governance.Client\Model.RecertificationProfileGridModelPageResult](docs/RecertificationProfileGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.RecertificationReportProperties](docs/RecertificationReportProperties.md)
 - [Cloud.Governance.Client\Model.RecertificationStatus](docs/RecertificationStatus.md)
 - [Cloud.Governance.Client\Model.RecertificationTaskGridModel](docs/RecertificationTaskGridModel.md)
 - [Cloud.Governance.Client\Model.RecertificationTaskGridModelPageResult](docs/RecertificationTaskGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.RecertificationType](docs/RecertificationType.md)
 - [Cloud.Governance.Client\Model.ReminderDurationType](docs/ReminderDurationType.md)
 - [Cloud.Governance.Client\Model.ReminderGridModel](docs/ReminderGridModel.md)
 - [Cloud.Governance.Client\Model.ReminderGridModelPageResult](docs/ReminderGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.ReminderModel](docs/ReminderModel.md)
 - [Cloud.Governance.Client\Model.RenewModel](docs/RenewModel.md)
 - [Cloud.Governance.Client\Model.RenewProfileRef](docs/RenewProfileRef.md)
 - [Cloud.Governance.Client\Model.RenewalItemAction](docs/RenewalItemAction.md)
 - [Cloud.Governance.Client\Model.RenewalType](docs/RenewalType.md)
 - [Cloud.Governance.Client\Model.ReportDataSource](docs/ReportDataSource.md)
 - [Cloud.Governance.Client\Model.ReportMetadata](docs/ReportMetadata.md)
 - [Cloud.Governance.Client\Model.RequestAuditGridModel](docs/RequestAuditGridModel.md)
 - [Cloud.Governance.Client\Model.RequestAuditGridModelPageResult](docs/RequestAuditGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.RequestGroupWithPermissions](docs/RequestGroupWithPermissions.md)
 - [Cloud.Governance.Client\Model.RequestList](docs/RequestList.md)
 - [Cloud.Governance.Client\Model.RequestListPageResult](docs/RequestListPageResult.md)
 - [Cloud.Governance.Client\Model.RequestMetadata](docs/RequestMetadata.md)
 - [Cloud.Governance.Client\Model.RequestMetadataInfo](docs/RequestMetadataInfo.md)
 - [Cloud.Governance.Client\Model.RequestMetadataListChangedProperty](docs/RequestMetadataListChangedProperty.md)
 - [Cloud.Governance.Client\Model.RequestProgressStatus](docs/RequestProgressStatus.md)
 - [Cloud.Governance.Client\Model.RequestStatusNullable](docs/RequestStatusNullable.md)
 - [Cloud.Governance.Client\Model.RequestTeamsSettings](docs/RequestTeamsSettings.md)
 - [Cloud.Governance.Client\Model.RequestUserWithPermissions](docs/RequestUserWithPermissions.md)
 - [Cloud.Governance.Client\Model.ResourceValue](docs/ResourceValue.md)
 - [Cloud.Governance.Client\Model.RestoreGroupRequest](docs/RestoreGroupRequest.md)
 - [Cloud.Governance.Client\Model.RootSiteWithManagedPaths](docs/RootSiteWithManagedPaths.md)
 - [Cloud.Governance.Client\Model.SASUriModel](docs/SASUriModel.md)
 - [Cloud.Governance.Client\Model.SPBaseType](docs/SPBaseType.md)
 - [Cloud.Governance.Client\Model.SPGroup](docs/SPGroup.md)
 - [Cloud.Governance.Client\Model.SPGroupEditOption](docs/SPGroupEditOption.md)
 - [Cloud.Governance.Client\Model.SPGroupManagementModel](docs/SPGroupManagementModel.md)
 - [Cloud.Governance.Client\Model.SPGroupViewOption](docs/SPGroupViewOption.md)
 - [Cloud.Governance.Client\Model.SPList](docs/SPList.md)
 - [Cloud.Governance.Client\Model.SPListTemplateType](docs/SPListTemplateType.md)
 - [Cloud.Governance.Client\Model.SPNode](docs/SPNode.md)
 - [Cloud.Governance.Client\Model.SPNodePageResult](docs/SPNodePageResult.md)
 - [Cloud.Governance.Client\Model.SPPrincipal](docs/SPPrincipal.md)
 - [Cloud.Governance.Client\Model.SPPrincipalType](docs/SPPrincipalType.md)
 - [Cloud.Governance.Client\Model.SPRoleAssignment](docs/SPRoleAssignment.md)
 - [Cloud.Governance.Client\Model.SPUserManagementModel](docs/SPUserManagementModel.md)
 - [Cloud.Governance.Client\Model.ScheduleItemModel](docs/ScheduleItemModel.md)
 - [Cloud.Governance.Client\Model.ScopeType](docs/ScopeType.md)
 - [Cloud.Governance.Client\Model.SecuritySearchResult](docs/SecuritySearchResult.md)
 - [Cloud.Governance.Client\Model.SecuritySearchResultPageResult](docs/SecuritySearchResultPageResult.md)
 - [Cloud.Governance.Client\Model.ServiceForRequest](docs/ServiceForRequest.md)
 - [Cloud.Governance.Client\Model.ServiceGroupWithPermissions](docs/ServiceGroupWithPermissions.md)
 - [Cloud.Governance.Client\Model.ServiceList](docs/ServiceList.md)
 - [Cloud.Governance.Client\Model.ServiceListPageResult](docs/ServiceListPageResult.md)
 - [Cloud.Governance.Client\Model.ServicePermissionItem](docs/ServicePermissionItem.md)
 - [Cloud.Governance.Client\Model.ServicePermissionSettings](docs/ServicePermissionSettings.md)
 - [Cloud.Governance.Client\Model.ServicePermissionType](docs/ServicePermissionType.md)
 - [Cloud.Governance.Client\Model.ServiceScopeSettings](docs/ServiceScopeSettings.md)
 - [Cloud.Governance.Client\Model.ServiceTeamsSettings](docs/ServiceTeamsSettings.md)
 - [Cloud.Governance.Client\Model.ServiceType](docs/ServiceType.md)
 - [Cloud.Governance.Client\Model.ServiceTypeNullable](docs/ServiceTypeNullable.md)
 - [Cloud.Governance.Client\Model.ServiceUserWithPermissions](docs/ServiceUserWithPermissions.md)
 - [Cloud.Governance.Client\Model.Severity](docs/Severity.md)
 - [Cloud.Governance.Client\Model.SharePointBuildInGroupType](docs/SharePointBuildInGroupType.md)
 - [Cloud.Governance.Client\Model.SharingCapabilities](docs/SharingCapabilities.md)
 - [Cloud.Governance.Client\Model.SharingEnabledUser](docs/SharingEnabledUser.md)
 - [Cloud.Governance.Client\Model.SingleLineOrMultipleLineMetadataSettings](docs/SingleLineOrMultipleLineMetadataSettings.md)
 - [Cloud.Governance.Client\Model.SiteArchiveLifecycleItem](docs/SiteArchiveLifecycleItem.md)
 - [Cloud.Governance.Client\Model.SiteAutoLockJobTrigger](docs/SiteAutoLockJobTrigger.md)
 - [Cloud.Governance.Client\Model.SiteAutoLockJobTriggerType](docs/SiteAutoLockJobTriggerType.md)
 - [Cloud.Governance.Client\Model.SiteChangePolicyLifecycleItem](docs/SiteChangePolicyLifecycleItem.md)
 - [Cloud.Governance.Client\Model.SiteConstructTitleType](docs/SiteConstructTitleType.md)
 - [Cloud.Governance.Client\Model.SiteConstructUrlType](docs/SiteConstructUrlType.md)
 - [Cloud.Governance.Client\Model.SiteDeletionLifecycleItem](docs/SiteDeletionLifecycleItem.md)
 - [Cloud.Governance.Client\Model.SiteExtensionLifecycleItem](docs/SiteExtensionLifecycleItem.md)
 - [Cloud.Governance.Client\Model.SiteInfo](docs/SiteInfo.md)
 - [Cloud.Governance.Client\Model.SiteJobTrigger](docs/SiteJobTrigger.md)
 - [Cloud.Governance.Client\Model.SiteJobTriggers](docs/SiteJobTriggers.md)
 - [Cloud.Governance.Client\Model.SiteLeasePeriodRequestSettings](docs/SiteLeasePeriodRequestSettings.md)
 - [Cloud.Governance.Client\Model.SiteLeasePeriodServiceSettings](docs/SiteLeasePeriodServiceSettings.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleActionType](docs/SiteLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleService](docs/SiteLifecycleService.md)
 - [Cloud.Governance.Client\Model.SiteLifecycleValidateResult](docs/SiteLifecycleValidateResult.md)
 - [Cloud.Governance.Client\Model.SiteList](docs/SiteList.md)
 - [Cloud.Governance.Client\Model.SiteListPageResult](docs/SiteListPageResult.md)
 - [Cloud.Governance.Client\Model.SiteLockLifecycleItem](docs/SiteLockLifecycleItem.md)
 - [Cloud.Governance.Client\Model.SiteLockType](docs/SiteLockType.md)
 - [Cloud.Governance.Client\Model.SitePolicyAosSetting](docs/SitePolicyAosSetting.md)
 - [Cloud.Governance.Client\Model.SitePolicyElectionSetting](docs/SitePolicyElectionSetting.md)
 - [Cloud.Governance.Client\Model.SitePolicyExpirationSetting](docs/SitePolicyExpirationSetting.md)
 - [Cloud.Governance.Client\Model.SitePolicyInfo](docs/SitePolicyInfo.md)
 - [Cloud.Governance.Client\Model.SitePolicyLifecycleSetting](docs/SitePolicyLifecycleSetting.md)
 - [Cloud.Governance.Client\Model.SitePolicyModel](docs/SitePolicyModel.md)
 - [Cloud.Governance.Client\Model.SitePolicySharingSetting](docs/SitePolicySharingSetting.md)
 - [Cloud.Governance.Client\Model.SiteProperty](docs/SiteProperty.md)
 - [Cloud.Governance.Client\Model.SiteQuotaLifecycleItem](docs/SiteQuotaLifecycleItem.md)
 - [Cloud.Governance.Client\Model.SiteRecertificationJobTrigger](docs/SiteRecertificationJobTrigger.md)
 - [Cloud.Governance.Client\Model.SiteRecertificationProperty](docs/SiteRecertificationProperty.md)
 - [Cloud.Governance.Client\Model.SiteRecertificationType](docs/SiteRecertificationType.md)
 - [Cloud.Governance.Client\Model.SiteReport](docs/SiteReport.md)
 - [Cloud.Governance.Client\Model.SiteReportPageResult](docs/SiteReportPageResult.md)
 - [Cloud.Governance.Client\Model.SiteStatus](docs/SiteStatus.md)
 - [Cloud.Governance.Client\Model.SiteStatusScanJobTrigger](docs/SiteStatusScanJobTrigger.md)
 - [Cloud.Governance.Client\Model.SiteTemplate](docs/SiteTemplate.md)
 - [Cloud.Governance.Client\Model.SiteTitleConstructureRule](docs/SiteTitleConstructureRule.md)
 - [Cloud.Governance.Client\Model.SiteTitleSetting](docs/SiteTitleSetting.md)
 - [Cloud.Governance.Client\Model.SiteUnlockingLifecycleItem](docs/SiteUnlockingLifecycleItem.md)
 - [Cloud.Governance.Client\Model.SiteUrl](docs/SiteUrl.md)
 - [Cloud.Governance.Client\Model.SiteUrlSetting](docs/SiteUrlSetting.md)
 - [Cloud.Governance.Client\Model.SiteValidationParameter](docs/SiteValidationParameter.md)
 - [Cloud.Governance.Client\Model.SizeValue](docs/SizeValue.md)
 - [Cloud.Governance.Client\Model.SpecifyContactModel](docs/SpecifyContactModel.md)
 - [Cloud.Governance.Client\Model.SpecifyContactResultModel](docs/SpecifyContactResultModel.md)
 - [Cloud.Governance.Client\Model.StartDateType](docs/StartDateType.md)
 - [Cloud.Governance.Client\Model.StatusScanDemoJobType](docs/StatusScanDemoJobType.md)
 - [Cloud.Governance.Client\Model.StorageType](docs/StorageType.md)
 - [Cloud.Governance.Client\Model.StringChangedProperty](docs/StringChangedProperty.md)
 - [Cloud.Governance.Client\Model.StringModel](docs/StringModel.md)
 - [Cloud.Governance.Client\Model.TaskComment](docs/TaskComment.md)
 - [Cloud.Governance.Client\Model.TaskDurationModel](docs/TaskDurationModel.md)
 - [Cloud.Governance.Client\Model.TaskDynamicActions](docs/TaskDynamicActions.md)
 - [Cloud.Governance.Client\Model.TaskList](docs/TaskList.md)
 - [Cloud.Governance.Client\Model.TaskListPageResult](docs/TaskListPageResult.md)
 - [Cloud.Governance.Client\Model.TaskResult](docs/TaskResult.md)
 - [Cloud.Governance.Client\Model.TaskType](docs/TaskType.md)
 - [Cloud.Governance.Client\Model.TeamSiteEnableSharingStatus](docs/TeamSiteEnableSharingStatus.md)
 - [Cloud.Governance.Client\Model.TeamsGridModel](docs/TeamsGridModel.md)
 - [Cloud.Governance.Client\Model.TeamsGridModelPageResult](docs/TeamsGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.TeamsReport](docs/TeamsReport.md)
 - [Cloud.Governance.Client\Model.TeamsReportPageResult](docs/TeamsReportPageResult.md)
 - [Cloud.Governance.Client\Model.TeamsTemplateServiceSettings](docs/TeamsTemplateServiceSettings.md)
 - [Cloud.Governance.Client\Model.TeamsTemplateSettings](docs/TeamsTemplateSettings.md)
 - [Cloud.Governance.Client\Model.TemplateWithPermissions](docs/TemplateWithPermissions.md)
 - [Cloud.Governance.Client\Model.TemporaryPermissionRequestSetting](docs/TemporaryPermissionRequestSetting.md)
 - [Cloud.Governance.Client\Model.Terminology](docs/Terminology.md)
 - [Cloud.Governance.Client\Model.TerminologyImportedModel](docs/TerminologyImportedModel.md)
 - [Cloud.Governance.Client\Model.TerminologyList](docs/TerminologyList.md)
 - [Cloud.Governance.Client\Model.TerminologyListPageResult](docs/TerminologyListPageResult.md)
 - [Cloud.Governance.Client\Model.TerminologyModel](docs/TerminologyModel.md)
 - [Cloud.Governance.Client\Model.TermsMetadataSettings](docs/TermsMetadataSettings.md)
 - [Cloud.Governance.Client\Model.TermsValue](docs/TermsValue.md)
 - [Cloud.Governance.Client\Model.TextValidationRuleList](docs/TextValidationRuleList.md)
 - [Cloud.Governance.Client\Model.TextValidationRuleListPageResult](docs/TextValidationRuleListPageResult.md)
 - [Cloud.Governance.Client\Model.TextValidationRuleModel](docs/TextValidationRuleModel.md)
 - [Cloud.Governance.Client\Model.TextValidationRuleRef](docs/TextValidationRuleRef.md)
 - [Cloud.Governance.Client\Model.TimerConfigurationItem](docs/TimerConfigurationItem.md)
 - [Cloud.Governance.Client\Model.TimerConfigurationModel](docs/TimerConfigurationModel.md)
 - [Cloud.Governance.Client\Model.TreeNode](docs/TreeNode.md)
 - [Cloud.Governance.Client\Model.TreeNodeExtension](docs/TreeNodeExtension.md)
 - [Cloud.Governance.Client\Model.TreeNodeType](docs/TreeNodeType.md)
 - [Cloud.Governance.Client\Model.UnlockSiteRequest](docs/UnlockSiteRequest.md)
 - [Cloud.Governance.Client\Model.UnlockSiteSetting](docs/UnlockSiteSetting.md)
 - [Cloud.Governance.Client\Model.UpdatableApiUser](docs/UpdatableApiUser.md)
 - [Cloud.Governance.Client\Model.UrlRandomStringSettings](docs/UrlRandomStringSettings.md)
 - [Cloud.Governance.Client\Model.UrlSequentialNumberingSettings](docs/UrlSequentialNumberingSettings.md)
 - [Cloud.Governance.Client\Model.UserAccessType](docs/UserAccessType.md)
 - [Cloud.Governance.Client\Model.UserAuditGridModel](docs/UserAuditGridModel.md)
 - [Cloud.Governance.Client\Model.UserAuditGridModelPageResult](docs/UserAuditGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.UserGroupPermissions](docs/UserGroupPermissions.md)
 - [Cloud.Governance.Client\Model.UserInfo](docs/UserInfo.md)
 - [Cloud.Governance.Client\Model.UserLevelControlMode](docs/UserLevelControlMode.md)
 - [Cloud.Governance.Client\Model.UserLevelControlSettings](docs/UserLevelControlSettings.md)
 - [Cloud.Governance.Client\Model.UserLevelRestrictionType](docs/UserLevelRestrictionType.md)
 - [Cloud.Governance.Client\Model.UserList](docs/UserList.md)
 - [Cloud.Governance.Client\Model.UserListPageResult](docs/UserListPageResult.md)
 - [Cloud.Governance.Client\Model.UserManagementSourceType](docs/UserManagementSourceType.md)
 - [Cloud.Governance.Client\Model.UserMetadataSettings](docs/UserMetadataSettings.md)
 - [Cloud.Governance.Client\Model.UserParam](docs/UserParam.md)
 - [Cloud.Governance.Client\Model.UserProfileMetadataSettings](docs/UserProfileMetadataSettings.md)
 - [Cloud.Governance.Client\Model.UserRelationShip](docs/UserRelationShip.md)
 - [Cloud.Governance.Client\Model.UserSource](docs/UserSource.md)
 - [Cloud.Governance.Client\Model.UserType](docs/UserType.md)
 - [Cloud.Governance.Client\Model.WebLifecycleActionType](docs/WebLifecycleActionType.md)
 - [Cloud.Governance.Client\Model.WebLifecycleService](docs/WebLifecycleService.md)
 - [Cloud.Governance.Client\Model.WebLifecycleValidateResult](docs/WebLifecycleValidateResult.md)
 - [Cloud.Governance.Client\Model.WebList](docs/WebList.md)
 - [Cloud.Governance.Client\Model.WebListPageResult](docs/WebListPageResult.md)
 - [Cloud.Governance.Client\Model.WebServiceAuthenticationType](docs/WebServiceAuthenticationType.md)
 - [Cloud.Governance.Client\Model.WelcomeEmailSettings](docs/WelcomeEmailSettings.md)
 - [Cloud.Governance.Client\Model.WorkspaceAuditGridModel](docs/WorkspaceAuditGridModel.md)
 - [Cloud.Governance.Client\Model.WorkspaceAuditGridModelPageResult](docs/WorkspaceAuditGridModelPageResult.md)
 - [Cloud.Governance.Client\Model.WorkspaceList](docs/WorkspaceList.md)
 - [Cloud.Governance.Client\Model.WorkspaceListPageResult](docs/WorkspaceListPageResult.md)
 - [Cloud.Governance.Client\Model.WorkspaceType](docs/WorkspaceType.md)
 - [Cloud.Governance.Client\Model.YammerGroup](docs/YammerGroup.md)
 - [Cloud.Governance.Client\Model.YammerGroupJoinType](docs/YammerGroupJoinType.md)
 - [Cloud.Governance.Client\Model.YammerGroupRequestSettings](docs/YammerGroupRequestSettings.md)
 - [Cloud.Governance.Client\Model.YammerGroupServiceSettings](docs/YammerGroupServiceSettings.md)
 - [Cloud.Governance.Client\Model.YammerGroupType](docs/YammerGroupType.md)


## Documentation for Authorization


### ClientId

- **Type**: API key

- **API key parameter name**: clientId
- **Location**: HTTP header


### ClientSecret

- **Type**: API key

- **API key parameter name**: clientSecret
- **Location**: HTTP header


### UserPrincipalName

- **Type**: API key

- **API key parameter name**: userPrincipalName
- **Location**: HTTP header

