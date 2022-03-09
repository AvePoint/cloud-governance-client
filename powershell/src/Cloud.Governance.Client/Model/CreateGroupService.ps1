#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateGroupService<PSCustomObject>
#>

function New-CreateGroupService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupType} = "Group",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeams} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsPrivate} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableSubscribe} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableApplySiteDesign} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableOutsideSender} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableHideGroupMembership} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableClassification} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${PreventDuplicateName} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableSensitivity} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AllSensitivities},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowConfigureLeasePeriod} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowNotebookLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowConversationsLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowFilesLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowTeamSiteLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowPlannerLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowYammerGroupLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Classifications},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Sensitivities},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SiteDesigns},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AddGroupMemberType} = "Manually",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedPolicies},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedLanguages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TeamsSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupNameConstructureSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupIdConstructureSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInstallApp} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInstallPanel} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TemplateSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultOwners},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultMembers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${DisableAddRemoveDynamicMembershipRules} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DynamicMembershipRules},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultPolicy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultClassification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultSensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultLanguage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultSiteDesign},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultOwnersReal},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DefaultMembersReal},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultPrimaryContactReal},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultSecondaryContactReal},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MemberAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OwnerAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrivacyAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SubscribeAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OutsideSenderAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ClassificationAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SensitivityAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LanguageAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContactAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableDynamicMembership} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HideGroupMembershipAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PolicyAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteDesignAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TimeZoneAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LocaleAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MultiGeoSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TimeZoneSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LocaleSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HasImpernastionUsers} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PeoplePickerFilterProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RequestTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HideRequestSummary} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceAdminContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ApproversContainManagerRole} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Inactive",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ShowServiceInCatalog} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CustomActions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ApprovalProcessId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateGroupService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GroupType" = ${GroupType}
            "TenantId" = ${TenantId}
            "NetworkId" = ${NetworkId}
            "EnableTeams" = ${EnableTeams}
            "IsPrivate" = ${IsPrivate}
            "EnableSubscribe" = ${EnableSubscribe}
            "EnableApplySiteDesign" = ${EnableApplySiteDesign}
            "EnableOutsideSender" = ${EnableOutsideSender}
            "EnableHideGroupMembership" = ${EnableHideGroupMembership}
            "EnableClassification" = ${EnableClassification}
            "PreventDuplicateName" = ${PreventDuplicateName}
            "EnableSensitivity" = ${EnableSensitivity}
            "AllSensitivities" = ${AllSensitivities}
            "AllowConfigureLeasePeriod" = ${AllowConfigureLeasePeriod}
            "ShowNotebookLink" = ${ShowNotebookLink}
            "ShowConversationsLink" = ${ShowConversationsLink}
            "ShowFilesLink" = ${ShowFilesLink}
            "ShowTeamSiteLink" = ${ShowTeamSiteLink}
            "ShowPlannerLink" = ${ShowPlannerLink}
            "ShowYammerGroupLink" = ${ShowYammerGroupLink}
            "Classifications" = ${Classifications}
            "Sensitivities" = ${Sensitivities}
            "SiteDesigns" = ${SiteDesigns}
            "AddGroupMemberType" = ${AddGroupMemberType}
            "SelectedPolicies" = ${SelectedPolicies}
            "SelectedLanguages" = ${SelectedLanguages}
            "TeamsSettings" = ${TeamsSettings}
            "GroupNameConstructureSettings" = ${GroupNameConstructureSettings}
            "GroupIdConstructureSettings" = ${GroupIdConstructureSettings}
            "EnableInstallApp" = ${EnableInstallApp}
            "EnableInstallPanel" = ${EnableInstallPanel}
            "TemplateSettings" = ${TemplateSettings}
            "DefaultPrimaryContact" = ${DefaultPrimaryContact}
            "DefaultSecondaryContact" = ${DefaultSecondaryContact}
            "DefaultOwners" = ${DefaultOwners}
            "DefaultMembers" = ${DefaultMembers}
            "DisableAddRemoveDynamicMembershipRules" = ${DisableAddRemoveDynamicMembershipRules}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "DefaultPolicy" = ${DefaultPolicy}
            "DefaultClassification" = ${DefaultClassification}
            "DefaultSensitivity" = ${DefaultSensitivity}
            "DefaultLanguage" = ${DefaultLanguage}
            "DefaultSiteDesign" = ${DefaultSiteDesign}
            "DefaultOwnersReal" = ${DefaultOwnersReal}
            "DefaultMembersReal" = ${DefaultMembersReal}
            "DefaultPrimaryContactReal" = ${DefaultPrimaryContactReal}
            "DefaultSecondaryContactReal" = ${DefaultSecondaryContactReal}
            "MemberAssignBy" = ${MemberAssignBy}
            "OwnerAssignBy" = ${OwnerAssignBy}
            "PrivacyAssignBy" = ${PrivacyAssignBy}
            "SubscribeAssignBy" = ${SubscribeAssignBy}
            "OutsideSenderAssignBy" = ${OutsideSenderAssignBy}
            "ClassificationAssignBy" = ${ClassificationAssignBy}
            "SensitivityAssignBy" = ${SensitivityAssignBy}
            "LanguageAssignBy" = ${LanguageAssignBy}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "HideGroupMembershipAssignBy" = ${HideGroupMembershipAssignBy}
            "PolicyAssignBy" = ${PolicyAssignBy}
            "SiteDesignAssignBy" = ${SiteDesignAssignBy}
            "HubSiteAssignBy" = ${HubSiteAssignBy}
            "TimeZoneAssignBy" = ${TimeZoneAssignBy}
            "LocaleAssignBy" = ${LocaleAssignBy}
            "MultiGeoSetting" = ${MultiGeoSetting}
            "HubSiteSettings" = ${HubSiteSettings}
            "TimeZoneSettings" = ${TimeZoneSettings}
            "LocaleSettings" = ${LocaleSettings}
            "HasImpernastionUsers" = ${HasImpernastionUsers}
            "PeoplePickerFilterProfileId" = ${PeoplePickerFilterProfileId}
            "RequestTemplate" = ${RequestTemplate}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
        }

        return $PSO
    }
}

<#
CreateGroupService<PSCustomObject>
#>
function ConvertFrom-JsonToCreateGroupService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateGroupService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateGroupService
        $AllProperties = $("GroupType", "TenantId", "NetworkId", "EnableTeams", "IsPrivate", "EnableSubscribe", "EnableApplySiteDesign", "EnableOutsideSender", "EnableHideGroupMembership", "EnableClassification", "PreventDuplicateName", "EnableSensitivity", "AllSensitivities", "AllowConfigureLeasePeriod", "ShowNotebookLink", "ShowConversationsLink", "ShowFilesLink", "ShowTeamSiteLink", "ShowPlannerLink", "ShowYammerGroupLink", "Classifications", "Sensitivities", "SiteDesigns", "AddGroupMemberType", "SelectedPolicies", "SelectedLanguages", "TeamsSettings", "GroupNameConstructureSettings", "GroupIdConstructureSettings", "EnableInstallApp", "EnableInstallPanel", "TemplateSettings", "DefaultPrimaryContact", "DefaultSecondaryContact", "DefaultOwners", "DefaultMembers", "DisableAddRemoveDynamicMembershipRules", "DynamicMembershipRules", "DefaultPolicy", "DefaultClassification", "DefaultSensitivity", "DefaultLanguage", "DefaultSiteDesign", "DefaultOwnersReal", "DefaultMembersReal", "DefaultPrimaryContactReal", "DefaultSecondaryContactReal", "MemberAssignBy", "OwnerAssignBy", "PrivacyAssignBy", "SubscribeAssignBy", "OutsideSenderAssignBy", "ClassificationAssignBy", "SensitivityAssignBy", "LanguageAssignBy", "SecondaryContactAssignBy", "PrimaryContactAssignBy", "EnableDynamicMembership", "HideGroupMembershipAssignBy", "PolicyAssignBy", "SiteDesignAssignBy", "HubSiteAssignBy", "TimeZoneAssignBy", "LocaleAssignBy", "MultiGeoSetting", "IsShowHubSiteSection", "HubSiteSettings", "TimeZoneSettings", "LocaleSettings", "HasImpernastionUsers", "PeoplePickerFilterProfileId", "RequestTemplate", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupType"))) { #optional property not found
            $GroupType = $null
        } else {
            $GroupType = $JsonParameters.PSobject.Properties["GroupType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkId"))) { #optional property not found
            $NetworkId = $null
        } else {
            $NetworkId = $JsonParameters.PSobject.Properties["NetworkId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTeams"))) { #optional property not found
            $EnableTeams = $null
        } else {
            $EnableTeams = $JsonParameters.PSobject.Properties["EnableTeams"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPrivate"))) { #optional property not found
            $IsPrivate = $null
        } else {
            $IsPrivate = $JsonParameters.PSobject.Properties["IsPrivate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableSubscribe"))) { #optional property not found
            $EnableSubscribe = $null
        } else {
            $EnableSubscribe = $JsonParameters.PSobject.Properties["EnableSubscribe"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableApplySiteDesign"))) { #optional property not found
            $EnableApplySiteDesign = $null
        } else {
            $EnableApplySiteDesign = $JsonParameters.PSobject.Properties["EnableApplySiteDesign"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableOutsideSender"))) { #optional property not found
            $EnableOutsideSender = $null
        } else {
            $EnableOutsideSender = $JsonParameters.PSobject.Properties["EnableOutsideSender"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableHideGroupMembership"))) { #optional property not found
            $EnableHideGroupMembership = $null
        } else {
            $EnableHideGroupMembership = $JsonParameters.PSobject.Properties["EnableHideGroupMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableClassification"))) { #optional property not found
            $EnableClassification = $null
        } else {
            $EnableClassification = $JsonParameters.PSobject.Properties["EnableClassification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreventDuplicateName"))) { #optional property not found
            $PreventDuplicateName = $null
        } else {
            $PreventDuplicateName = $JsonParameters.PSobject.Properties["PreventDuplicateName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableSensitivity"))) { #optional property not found
            $EnableSensitivity = $null
        } else {
            $EnableSensitivity = $JsonParameters.PSobject.Properties["EnableSensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllSensitivities"))) { #optional property not found
            $AllSensitivities = $null
        } else {
            $AllSensitivities = $JsonParameters.PSobject.Properties["AllSensitivities"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowConfigureLeasePeriod"))) { #optional property not found
            $AllowConfigureLeasePeriod = $null
        } else {
            $AllowConfigureLeasePeriod = $JsonParameters.PSobject.Properties["AllowConfigureLeasePeriod"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowNotebookLink"))) { #optional property not found
            $ShowNotebookLink = $null
        } else {
            $ShowNotebookLink = $JsonParameters.PSobject.Properties["ShowNotebookLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowConversationsLink"))) { #optional property not found
            $ShowConversationsLink = $null
        } else {
            $ShowConversationsLink = $JsonParameters.PSobject.Properties["ShowConversationsLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowFilesLink"))) { #optional property not found
            $ShowFilesLink = $null
        } else {
            $ShowFilesLink = $JsonParameters.PSobject.Properties["ShowFilesLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowTeamSiteLink"))) { #optional property not found
            $ShowTeamSiteLink = $null
        } else {
            $ShowTeamSiteLink = $JsonParameters.PSobject.Properties["ShowTeamSiteLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowPlannerLink"))) { #optional property not found
            $ShowPlannerLink = $null
        } else {
            $ShowPlannerLink = $JsonParameters.PSobject.Properties["ShowPlannerLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowYammerGroupLink"))) { #optional property not found
            $ShowYammerGroupLink = $null
        } else {
            $ShowYammerGroupLink = $JsonParameters.PSobject.Properties["ShowYammerGroupLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classifications"))) { #optional property not found
            $Classifications = $null
        } else {
            $Classifications = $JsonParameters.PSobject.Properties["Classifications"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivities"))) { #optional property not found
            $Sensitivities = $null
        } else {
            $Sensitivities = $JsonParameters.PSobject.Properties["Sensitivities"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDesigns"))) { #optional property not found
            $SiteDesigns = $null
        } else {
            $SiteDesigns = $JsonParameters.PSobject.Properties["SiteDesigns"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AddGroupMemberType"))) { #optional property not found
            $AddGroupMemberType = $null
        } else {
            $AddGroupMemberType = $JsonParameters.PSobject.Properties["AddGroupMemberType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedPolicies"))) { #optional property not found
            $SelectedPolicies = $null
        } else {
            $SelectedPolicies = $JsonParameters.PSobject.Properties["SelectedPolicies"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedLanguages"))) { #optional property not found
            $SelectedLanguages = $null
        } else {
            $SelectedLanguages = $JsonParameters.PSobject.Properties["SelectedLanguages"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TeamsSettings"))) { #optional property not found
            $TeamsSettings = $null
        } else {
            $TeamsSettings = $JsonParameters.PSobject.Properties["TeamsSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupNameConstructureSettings"))) { #optional property not found
            $GroupNameConstructureSettings = $null
        } else {
            $GroupNameConstructureSettings = $JsonParameters.PSobject.Properties["GroupNameConstructureSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupIdConstructureSettings"))) { #optional property not found
            $GroupIdConstructureSettings = $null
        } else {
            $GroupIdConstructureSettings = $JsonParameters.PSobject.Properties["GroupIdConstructureSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInstallApp"))) { #optional property not found
            $EnableInstallApp = $null
        } else {
            $EnableInstallApp = $JsonParameters.PSobject.Properties["EnableInstallApp"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInstallPanel"))) { #optional property not found
            $EnableInstallPanel = $null
        } else {
            $EnableInstallPanel = $JsonParameters.PSobject.Properties["EnableInstallPanel"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateSettings"))) { #optional property not found
            $TemplateSettings = $null
        } else {
            $TemplateSettings = $JsonParameters.PSobject.Properties["TemplateSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPrimaryContact"))) { #optional property not found
            $DefaultPrimaryContact = $null
        } else {
            $DefaultPrimaryContact = $JsonParameters.PSobject.Properties["DefaultPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSecondaryContact"))) { #optional property not found
            $DefaultSecondaryContact = $null
        } else {
            $DefaultSecondaryContact = $JsonParameters.PSobject.Properties["DefaultSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultOwners"))) { #optional property not found
            $DefaultOwners = $null
        } else {
            $DefaultOwners = $JsonParameters.PSobject.Properties["DefaultOwners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultMembers"))) { #optional property not found
            $DefaultMembers = $null
        } else {
            $DefaultMembers = $JsonParameters.PSobject.Properties["DefaultMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisableAddRemoveDynamicMembershipRules"))) { #optional property not found
            $DisableAddRemoveDynamicMembershipRules = $null
        } else {
            $DisableAddRemoveDynamicMembershipRules = $JsonParameters.PSobject.Properties["DisableAddRemoveDynamicMembershipRules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DynamicMembershipRules"))) { #optional property not found
            $DynamicMembershipRules = $null
        } else {
            $DynamicMembershipRules = $JsonParameters.PSobject.Properties["DynamicMembershipRules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPolicy"))) { #optional property not found
            $DefaultPolicy = $null
        } else {
            $DefaultPolicy = $JsonParameters.PSobject.Properties["DefaultPolicy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultClassification"))) { #optional property not found
            $DefaultClassification = $null
        } else {
            $DefaultClassification = $JsonParameters.PSobject.Properties["DefaultClassification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSensitivity"))) { #optional property not found
            $DefaultSensitivity = $null
        } else {
            $DefaultSensitivity = $JsonParameters.PSobject.Properties["DefaultSensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultLanguage"))) { #optional property not found
            $DefaultLanguage = $null
        } else {
            $DefaultLanguage = $JsonParameters.PSobject.Properties["DefaultLanguage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSiteDesign"))) { #optional property not found
            $DefaultSiteDesign = $null
        } else {
            $DefaultSiteDesign = $JsonParameters.PSobject.Properties["DefaultSiteDesign"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultOwnersReal"))) { #optional property not found
            $DefaultOwnersReal = $null
        } else {
            $DefaultOwnersReal = $JsonParameters.PSobject.Properties["DefaultOwnersReal"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultMembersReal"))) { #optional property not found
            $DefaultMembersReal = $null
        } else {
            $DefaultMembersReal = $JsonParameters.PSobject.Properties["DefaultMembersReal"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultPrimaryContactReal"))) { #optional property not found
            $DefaultPrimaryContactReal = $null
        } else {
            $DefaultPrimaryContactReal = $JsonParameters.PSobject.Properties["DefaultPrimaryContactReal"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultSecondaryContactReal"))) { #optional property not found
            $DefaultSecondaryContactReal = $null
        } else {
            $DefaultSecondaryContactReal = $JsonParameters.PSobject.Properties["DefaultSecondaryContactReal"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MemberAssignBy"))) { #optional property not found
            $MemberAssignBy = $null
        } else {
            $MemberAssignBy = $JsonParameters.PSobject.Properties["MemberAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OwnerAssignBy"))) { #optional property not found
            $OwnerAssignBy = $null
        } else {
            $OwnerAssignBy = $JsonParameters.PSobject.Properties["OwnerAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrivacyAssignBy"))) { #optional property not found
            $PrivacyAssignBy = $null
        } else {
            $PrivacyAssignBy = $JsonParameters.PSobject.Properties["PrivacyAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SubscribeAssignBy"))) { #optional property not found
            $SubscribeAssignBy = $null
        } else {
            $SubscribeAssignBy = $JsonParameters.PSobject.Properties["SubscribeAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OutsideSenderAssignBy"))) { #optional property not found
            $OutsideSenderAssignBy = $null
        } else {
            $OutsideSenderAssignBy = $JsonParameters.PSobject.Properties["OutsideSenderAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassificationAssignBy"))) { #optional property not found
            $ClassificationAssignBy = $null
        } else {
            $ClassificationAssignBy = $JsonParameters.PSobject.Properties["ClassificationAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SensitivityAssignBy"))) { #optional property not found
            $SensitivityAssignBy = $null
        } else {
            $SensitivityAssignBy = $JsonParameters.PSobject.Properties["SensitivityAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageAssignBy"))) { #optional property not found
            $LanguageAssignBy = $null
        } else {
            $LanguageAssignBy = $JsonParameters.PSobject.Properties["LanguageAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactAssignBy"))) { #optional property not found
            $SecondaryContactAssignBy = $null
        } else {
            $SecondaryContactAssignBy = $JsonParameters.PSobject.Properties["SecondaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactAssignBy"))) { #optional property not found
            $PrimaryContactAssignBy = $null
        } else {
            $PrimaryContactAssignBy = $JsonParameters.PSobject.Properties["PrimaryContactAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableDynamicMembership"))) { #optional property not found
            $EnableDynamicMembership = $null
        } else {
            $EnableDynamicMembership = $JsonParameters.PSobject.Properties["EnableDynamicMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HideGroupMembershipAssignBy"))) { #optional property not found
            $HideGroupMembershipAssignBy = $null
        } else {
            $HideGroupMembershipAssignBy = $JsonParameters.PSobject.Properties["HideGroupMembershipAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyAssignBy"))) { #optional property not found
            $PolicyAssignBy = $null
        } else {
            $PolicyAssignBy = $JsonParameters.PSobject.Properties["PolicyAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDesignAssignBy"))) { #optional property not found
            $SiteDesignAssignBy = $null
        } else {
            $SiteDesignAssignBy = $JsonParameters.PSobject.Properties["SiteDesignAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubSiteAssignBy"))) { #optional property not found
            $HubSiteAssignBy = $null
        } else {
            $HubSiteAssignBy = $JsonParameters.PSobject.Properties["HubSiteAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZoneAssignBy"))) { #optional property not found
            $TimeZoneAssignBy = $null
        } else {
            $TimeZoneAssignBy = $JsonParameters.PSobject.Properties["TimeZoneAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LocaleAssignBy"))) { #optional property not found
            $LocaleAssignBy = $null
        } else {
            $LocaleAssignBy = $JsonParameters.PSobject.Properties["LocaleAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MultiGeoSetting"))) { #optional property not found
            $MultiGeoSetting = $null
        } else {
            $MultiGeoSetting = $JsonParameters.PSobject.Properties["MultiGeoSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsShowHubSiteSection"))) { #optional property not found
            $IsShowHubSiteSection = $null
        } else {
            $IsShowHubSiteSection = $JsonParameters.PSobject.Properties["IsShowHubSiteSection"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubSiteSettings"))) { #optional property not found
            $HubSiteSettings = $null
        } else {
            $HubSiteSettings = $JsonParameters.PSobject.Properties["HubSiteSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZoneSettings"))) { #optional property not found
            $TimeZoneSettings = $null
        } else {
            $TimeZoneSettings = $JsonParameters.PSobject.Properties["TimeZoneSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LocaleSettings"))) { #optional property not found
            $LocaleSettings = $null
        } else {
            $LocaleSettings = $JsonParameters.PSobject.Properties["LocaleSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HasImpernastionUsers"))) { #optional property not found
            $HasImpernastionUsers = $null
        } else {
            $HasImpernastionUsers = $JsonParameters.PSobject.Properties["HasImpernastionUsers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeoplePickerFilterProfileId"))) { #optional property not found
            $PeoplePickerFilterProfileId = $null
        } else {
            $PeoplePickerFilterProfileId = $JsonParameters.PSobject.Properties["PeoplePickerFilterProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestTemplate"))) { #optional property not found
            $RequestTemplate = $null
        } else {
            $RequestTemplate = $JsonParameters.PSobject.Properties["RequestTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HideRequestSummary"))) { #optional property not found
            $HideRequestSummary = $null
        } else {
            $HideRequestSummary = $JsonParameters.PSobject.Properties["HideRequestSummary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceContact"))) { #optional property not found
            $ServiceContact = $null
        } else {
            $ServiceContact = $JsonParameters.PSobject.Properties["ServiceContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceAdminContact"))) { #optional property not found
            $ServiceAdminContact = $null
        } else {
            $ServiceAdminContact = $JsonParameters.PSobject.Properties["ServiceAdminContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApproversContainManagerRole"))) { #optional property not found
            $ApproversContainManagerRole = $null
        } else {
            $ApproversContainManagerRole = $JsonParameters.PSobject.Properties["ApproversContainManagerRole"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ShowServiceInCatalog"))) { #optional property not found
            $ShowServiceInCatalog = $null
        } else {
            $ShowServiceInCatalog = $JsonParameters.PSobject.Properties["ShowServiceInCatalog"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CustomActions"))) { #optional property not found
            $CustomActions = $null
        } else {
            $CustomActions = $JsonParameters.PSobject.Properties["CustomActions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApprovalProcessId"))) { #optional property not found
            $ApprovalProcessId = $null
        } else {
            $ApprovalProcessId = $JsonParameters.PSobject.Properties["ApprovalProcessId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageId"))) { #optional property not found
            $LanguageId = $null
        } else {
            $LanguageId = $JsonParameters.PSobject.Properties["LanguageId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CategoryId"))) { #optional property not found
            $CategoryId = $null
        } else {
            $CategoryId = $JsonParameters.PSobject.Properties["CategoryId"].value
        }

        $PSO = [PSCustomObject]@{
            "GroupType" = ${GroupType}
            "TenantId" = ${TenantId}
            "NetworkId" = ${NetworkId}
            "EnableTeams" = ${EnableTeams}
            "IsPrivate" = ${IsPrivate}
            "EnableSubscribe" = ${EnableSubscribe}
            "EnableApplySiteDesign" = ${EnableApplySiteDesign}
            "EnableOutsideSender" = ${EnableOutsideSender}
            "EnableHideGroupMembership" = ${EnableHideGroupMembership}
            "EnableClassification" = ${EnableClassification}
            "PreventDuplicateName" = ${PreventDuplicateName}
            "EnableSensitivity" = ${EnableSensitivity}
            "AllSensitivities" = ${AllSensitivities}
            "AllowConfigureLeasePeriod" = ${AllowConfigureLeasePeriod}
            "ShowNotebookLink" = ${ShowNotebookLink}
            "ShowConversationsLink" = ${ShowConversationsLink}
            "ShowFilesLink" = ${ShowFilesLink}
            "ShowTeamSiteLink" = ${ShowTeamSiteLink}
            "ShowPlannerLink" = ${ShowPlannerLink}
            "ShowYammerGroupLink" = ${ShowYammerGroupLink}
            "Classifications" = ${Classifications}
            "Sensitivities" = ${Sensitivities}
            "SiteDesigns" = ${SiteDesigns}
            "AddGroupMemberType" = ${AddGroupMemberType}
            "SelectedPolicies" = ${SelectedPolicies}
            "SelectedLanguages" = ${SelectedLanguages}
            "TeamsSettings" = ${TeamsSettings}
            "GroupNameConstructureSettings" = ${GroupNameConstructureSettings}
            "GroupIdConstructureSettings" = ${GroupIdConstructureSettings}
            "EnableInstallApp" = ${EnableInstallApp}
            "EnableInstallPanel" = ${EnableInstallPanel}
            "TemplateSettings" = ${TemplateSettings}
            "DefaultPrimaryContact" = ${DefaultPrimaryContact}
            "DefaultSecondaryContact" = ${DefaultSecondaryContact}
            "DefaultOwners" = ${DefaultOwners}
            "DefaultMembers" = ${DefaultMembers}
            "DisableAddRemoveDynamicMembershipRules" = ${DisableAddRemoveDynamicMembershipRules}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "DefaultPolicy" = ${DefaultPolicy}
            "DefaultClassification" = ${DefaultClassification}
            "DefaultSensitivity" = ${DefaultSensitivity}
            "DefaultLanguage" = ${DefaultLanguage}
            "DefaultSiteDesign" = ${DefaultSiteDesign}
            "DefaultOwnersReal" = ${DefaultOwnersReal}
            "DefaultMembersReal" = ${DefaultMembersReal}
            "DefaultPrimaryContactReal" = ${DefaultPrimaryContactReal}
            "DefaultSecondaryContactReal" = ${DefaultSecondaryContactReal}
            "MemberAssignBy" = ${MemberAssignBy}
            "OwnerAssignBy" = ${OwnerAssignBy}
            "PrivacyAssignBy" = ${PrivacyAssignBy}
            "SubscribeAssignBy" = ${SubscribeAssignBy}
            "OutsideSenderAssignBy" = ${OutsideSenderAssignBy}
            "ClassificationAssignBy" = ${ClassificationAssignBy}
            "SensitivityAssignBy" = ${SensitivityAssignBy}
            "LanguageAssignBy" = ${LanguageAssignBy}
            "SecondaryContactAssignBy" = ${SecondaryContactAssignBy}
            "PrimaryContactAssignBy" = ${PrimaryContactAssignBy}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "HideGroupMembershipAssignBy" = ${HideGroupMembershipAssignBy}
            "PolicyAssignBy" = ${PolicyAssignBy}
            "SiteDesignAssignBy" = ${SiteDesignAssignBy}
            "HubSiteAssignBy" = ${HubSiteAssignBy}
            "TimeZoneAssignBy" = ${TimeZoneAssignBy}
            "LocaleAssignBy" = ${LocaleAssignBy}
            "MultiGeoSetting" = ${MultiGeoSetting}
            "IsShowHubSiteSection" = ${IsShowHubSiteSection}
            "HubSiteSettings" = ${HubSiteSettings}
            "TimeZoneSettings" = ${TimeZoneSettings}
            "LocaleSettings" = ${LocaleSettings}
            "HasImpernastionUsers" = ${HasImpernastionUsers}
            "PeoplePickerFilterProfileId" = ${PeoplePickerFilterProfileId}
            "RequestTemplate" = ${RequestTemplate}
            "Metadatas" = ${Metadatas}
            "HideRequestSummary" = ${HideRequestSummary}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "ServiceContact" = ${ServiceContact}
            "ServiceAdminContact" = ${ServiceAdminContact}
            "ApproversContainManagerRole" = ${ApproversContainManagerRole}
            "Status" = ${Status}
            "ShowServiceInCatalog" = ${ShowServiceInCatalog}
            "CustomActions" = ${CustomActions}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LanguageId" = ${LanguageId}
            "CategoryId" = ${CategoryId}
        }

        return $PSO
    }

}

