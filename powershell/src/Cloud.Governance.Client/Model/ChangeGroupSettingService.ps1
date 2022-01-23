#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeGroupSettingService<PSCustomObject>
#>

function New-ChangeGroupSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupRestriction} = "AnyGroup",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeName} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${PreventDuplicateName} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeDescription} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeMemberSubscription} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeOutsideSenders} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangePrimaryContact} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeSecondaryContact} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddOwners} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AddOwnerRestriction} = "AnyUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableRemoveOwners} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddMembers} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AddMemberRestriction} = "AnyUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableRemoveMembers} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeDynamicMembershipRules} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeTeamCollaboration} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeHubSite} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeClassification} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${ClassificationList},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeSensitivity} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SensitivityList},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeMetadata} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddOrDeleteMetadata} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${MetadataList},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeMembershipType} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupObjectType} = "Group",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeYammerGroupInfo} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ScopePeoplePickerFilterProfileId},
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
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TenantId" = ${TenantId}
            "NetworkId" = ${NetworkId}
            "GroupRestriction" = ${GroupRestriction}
            "EnableChangeName" = ${EnableChangeName}
            "PreventDuplicateName" = ${PreventDuplicateName}
            "EnableChangeDescription" = ${EnableChangeDescription}
            "EnableChangeMemberSubscription" = ${EnableChangeMemberSubscription}
            "EnableChangeOutsideSenders" = ${EnableChangeOutsideSenders}
            "EnableChangePrimaryContact" = ${EnableChangePrimaryContact}
            "EnableChangeSecondaryContact" = ${EnableChangeSecondaryContact}
            "EnableAddOwners" = ${EnableAddOwners}
            "AddOwnerRestriction" = ${AddOwnerRestriction}
            "EnableRemoveOwners" = ${EnableRemoveOwners}
            "EnableAddMembers" = ${EnableAddMembers}
            "AddMemberRestriction" = ${AddMemberRestriction}
            "EnableRemoveMembers" = ${EnableRemoveMembers}
            "EnableChangeDynamicMembershipRules" = ${EnableChangeDynamicMembershipRules}
            "EnableChangeTeamCollaboration" = ${EnableChangeTeamCollaboration}
            "EnableChangeHubSite" = ${EnableChangeHubSite}
            "EnableChangeClassification" = ${EnableChangeClassification}
            "ClassificationList" = ${ClassificationList}
            "EnableChangeSensitivity" = ${EnableChangeSensitivity}
            "SensitivityList" = ${SensitivityList}
            "EnableChangeMetadata" = ${EnableChangeMetadata}
            "EnableAddOrDeleteMetadata" = ${EnableAddOrDeleteMetadata}
            "MetadataList" = ${MetadataList}
            "EnableChangeMembershipType" = ${EnableChangeMembershipType}
            "GroupObjectType" = ${GroupObjectType}
            "EnableChangeYammerGroupInfo" = ${EnableChangeYammerGroupInfo}
            "ScopePeoplePickerFilterProfileId" = ${ScopePeoplePickerFilterProfileId}
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
ChangeGroupSettingService<PSCustomObject>
#>
function ConvertFrom-JsonToChangeGroupSettingService {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeGroupSettingService
        $AllProperties = $("TenantId", "NetworkId", "GroupRestriction", "EnableChangeName", "PreventDuplicateName", "EnableChangeDescription", "EnableChangeMemberSubscription", "EnableChangeOutsideSenders", "EnableChangePrimaryContact", "EnableChangeSecondaryContact", "EnableAddOwners", "AddOwnerRestriction", "EnableRemoveOwners", "EnableAddMembers", "AddMemberRestriction", "EnableRemoveMembers", "EnableChangeDynamicMembershipRules", "EnableChangeTeamCollaboration", "EnableChangeHubSite", "EnableChangeClassification", "ClassificationList", "EnableChangeSensitivity", "SensitivityList", "EnableChangeMetadata", "EnableAddOrDeleteMetadata", "MetadataList", "EnableChangeMembershipType", "GroupObjectType", "EnableChangeYammerGroupInfo", "ScopePeoplePickerFilterProfileId", "PeoplePickerFilterProfileId", "RequestTemplate", "Metadatas", "HideRequestSummary", "Id", "Name", "Description", "Type", "ServiceContact", "ServiceAdminContact", "ApproversContainManagerRole", "Status", "ShowServiceInCatalog", "CustomActions", "ApprovalProcessId", "LanguageId", "CategoryId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupRestriction"))) { #optional property not found
            $GroupRestriction = $null
        } else {
            $GroupRestriction = $JsonParameters.PSobject.Properties["GroupRestriction"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeName"))) { #optional property not found
            $EnableChangeName = $null
        } else {
            $EnableChangeName = $JsonParameters.PSobject.Properties["EnableChangeName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreventDuplicateName"))) { #optional property not found
            $PreventDuplicateName = $null
        } else {
            $PreventDuplicateName = $JsonParameters.PSobject.Properties["PreventDuplicateName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeDescription"))) { #optional property not found
            $EnableChangeDescription = $null
        } else {
            $EnableChangeDescription = $JsonParameters.PSobject.Properties["EnableChangeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeMemberSubscription"))) { #optional property not found
            $EnableChangeMemberSubscription = $null
        } else {
            $EnableChangeMemberSubscription = $JsonParameters.PSobject.Properties["EnableChangeMemberSubscription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeOutsideSenders"))) { #optional property not found
            $EnableChangeOutsideSenders = $null
        } else {
            $EnableChangeOutsideSenders = $JsonParameters.PSobject.Properties["EnableChangeOutsideSenders"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangePrimaryContact"))) { #optional property not found
            $EnableChangePrimaryContact = $null
        } else {
            $EnableChangePrimaryContact = $JsonParameters.PSobject.Properties["EnableChangePrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeSecondaryContact"))) { #optional property not found
            $EnableChangeSecondaryContact = $null
        } else {
            $EnableChangeSecondaryContact = $JsonParameters.PSobject.Properties["EnableChangeSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddOwners"))) { #optional property not found
            $EnableAddOwners = $null
        } else {
            $EnableAddOwners = $JsonParameters.PSobject.Properties["EnableAddOwners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AddOwnerRestriction"))) { #optional property not found
            $AddOwnerRestriction = $null
        } else {
            $AddOwnerRestriction = $JsonParameters.PSobject.Properties["AddOwnerRestriction"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableRemoveOwners"))) { #optional property not found
            $EnableRemoveOwners = $null
        } else {
            $EnableRemoveOwners = $JsonParameters.PSobject.Properties["EnableRemoveOwners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddMembers"))) { #optional property not found
            $EnableAddMembers = $null
        } else {
            $EnableAddMembers = $JsonParameters.PSobject.Properties["EnableAddMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AddMemberRestriction"))) { #optional property not found
            $AddMemberRestriction = $null
        } else {
            $AddMemberRestriction = $JsonParameters.PSobject.Properties["AddMemberRestriction"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableRemoveMembers"))) { #optional property not found
            $EnableRemoveMembers = $null
        } else {
            $EnableRemoveMembers = $JsonParameters.PSobject.Properties["EnableRemoveMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeDynamicMembershipRules"))) { #optional property not found
            $EnableChangeDynamicMembershipRules = $null
        } else {
            $EnableChangeDynamicMembershipRules = $JsonParameters.PSobject.Properties["EnableChangeDynamicMembershipRules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeTeamCollaboration"))) { #optional property not found
            $EnableChangeTeamCollaboration = $null
        } else {
            $EnableChangeTeamCollaboration = $JsonParameters.PSobject.Properties["EnableChangeTeamCollaboration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeHubSite"))) { #optional property not found
            $EnableChangeHubSite = $null
        } else {
            $EnableChangeHubSite = $JsonParameters.PSobject.Properties["EnableChangeHubSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeClassification"))) { #optional property not found
            $EnableChangeClassification = $null
        } else {
            $EnableChangeClassification = $JsonParameters.PSobject.Properties["EnableChangeClassification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassificationList"))) { #optional property not found
            $ClassificationList = $null
        } else {
            $ClassificationList = $JsonParameters.PSobject.Properties["ClassificationList"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeSensitivity"))) { #optional property not found
            $EnableChangeSensitivity = $null
        } else {
            $EnableChangeSensitivity = $JsonParameters.PSobject.Properties["EnableChangeSensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SensitivityList"))) { #optional property not found
            $SensitivityList = $null
        } else {
            $SensitivityList = $JsonParameters.PSobject.Properties["SensitivityList"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeMetadata"))) { #optional property not found
            $EnableChangeMetadata = $null
        } else {
            $EnableChangeMetadata = $JsonParameters.PSobject.Properties["EnableChangeMetadata"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddOrDeleteMetadata"))) { #optional property not found
            $EnableAddOrDeleteMetadata = $null
        } else {
            $EnableAddOrDeleteMetadata = $JsonParameters.PSobject.Properties["EnableAddOrDeleteMetadata"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataList"))) { #optional property not found
            $MetadataList = $null
        } else {
            $MetadataList = $JsonParameters.PSobject.Properties["MetadataList"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeMembershipType"))) { #optional property not found
            $EnableChangeMembershipType = $null
        } else {
            $EnableChangeMembershipType = $JsonParameters.PSobject.Properties["EnableChangeMembershipType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupObjectType"))) { #optional property not found
            $GroupObjectType = $null
        } else {
            $GroupObjectType = $JsonParameters.PSobject.Properties["GroupObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeYammerGroupInfo"))) { #optional property not found
            $EnableChangeYammerGroupInfo = $null
        } else {
            $EnableChangeYammerGroupInfo = $JsonParameters.PSobject.Properties["EnableChangeYammerGroupInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopePeoplePickerFilterProfileId"))) { #optional property not found
            $ScopePeoplePickerFilterProfileId = $null
        } else {
            $ScopePeoplePickerFilterProfileId = $JsonParameters.PSobject.Properties["ScopePeoplePickerFilterProfileId"].value
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
            "TenantId" = ${TenantId}
            "NetworkId" = ${NetworkId}
            "GroupRestriction" = ${GroupRestriction}
            "EnableChangeName" = ${EnableChangeName}
            "PreventDuplicateName" = ${PreventDuplicateName}
            "EnableChangeDescription" = ${EnableChangeDescription}
            "EnableChangeMemberSubscription" = ${EnableChangeMemberSubscription}
            "EnableChangeOutsideSenders" = ${EnableChangeOutsideSenders}
            "EnableChangePrimaryContact" = ${EnableChangePrimaryContact}
            "EnableChangeSecondaryContact" = ${EnableChangeSecondaryContact}
            "EnableAddOwners" = ${EnableAddOwners}
            "AddOwnerRestriction" = ${AddOwnerRestriction}
            "EnableRemoveOwners" = ${EnableRemoveOwners}
            "EnableAddMembers" = ${EnableAddMembers}
            "AddMemberRestriction" = ${AddMemberRestriction}
            "EnableRemoveMembers" = ${EnableRemoveMembers}
            "EnableChangeDynamicMembershipRules" = ${EnableChangeDynamicMembershipRules}
            "EnableChangeTeamCollaboration" = ${EnableChangeTeamCollaboration}
            "EnableChangeHubSite" = ${EnableChangeHubSite}
            "EnableChangeClassification" = ${EnableChangeClassification}
            "ClassificationList" = ${ClassificationList}
            "EnableChangeSensitivity" = ${EnableChangeSensitivity}
            "SensitivityList" = ${SensitivityList}
            "EnableChangeMetadata" = ${EnableChangeMetadata}
            "EnableAddOrDeleteMetadata" = ${EnableAddOrDeleteMetadata}
            "MetadataList" = ${MetadataList}
            "EnableChangeMembershipType" = ${EnableChangeMembershipType}
            "GroupObjectType" = ${GroupObjectType}
            "EnableChangeYammerGroupInfo" = ${EnableChangeYammerGroupInfo}
            "ScopePeoplePickerFilterProfileId" = ${ScopePeoplePickerFilterProfileId}
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

