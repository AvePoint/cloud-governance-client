#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ApiMyGroup<PSCustomObject>
#>

function New-ApiMyGroup {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Language},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ApplyPolicyStatus} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeamCollaboration} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DynamicGroupRules},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Owners},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PreferredDataLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PreferredDataLocationName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableDynamicMembership} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupTeamSiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${QuotaSize} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StorageUsed},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TeamLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NoteBookLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PlannerLink},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupObjectType} = "Group",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Sensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Phase} = "Confirmed",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${PhaseStartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AutoImportProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AutoImportProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCurrentRenewer} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PhaseAssignees},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${PhaseDueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ApiMyGroup' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ObjectId" = ${ObjectId}
            "PolicyId" = ${PolicyId}
            "TenantId" = ${TenantId}
            "GroupName" = ${GroupName}
            "Email" = ${Email}
            "Language" = ${Language}
            "ApplyPolicyStatus" = ${ApplyPolicyStatus}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "DynamicGroupRules" = ${DynamicGroupRules}
            "GroupType" = ${GroupType}
            "CreatedTime" = ${CreatedTime}
            "Owners" = ${Owners}
            "PreferredDataLocation" = ${PreferredDataLocation}
            "PreferredDataLocationName" = ${PreferredDataLocationName}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "GroupTeamSiteUrl" = ${GroupTeamSiteUrl}
            "QuotaSize" = ${QuotaSize}
            "StorageUsed" = ${StorageUsed}
            "TeamLink" = ${TeamLink}
            "NoteBookLink" = ${NoteBookLink}
            "PlannerLink" = ${PlannerLink}
            "Classification" = ${Classification}
            "GroupObjectType" = ${GroupObjectType}
            "GroupObjectId" = ${GroupObjectId}
            "NetworkId" = ${NetworkId}
            "Sensitivity" = ${Sensitivity}
            "Id" = ${Id}
            "Phase" = ${Phase}
            "PhaseStartTime" = ${PhaseStartTime}
            "PhaseDescription" = ${PhaseDescription}
            "AutoImportProfileId" = ${AutoImportProfileId}
            "AutoImportProfileName" = ${AutoImportProfileName}
            "PolicyName" = ${PolicyName}
            "PolicyDescription" = ${PolicyDescription}
            "IsCurrentRenewer" = ${IsCurrentRenewer}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseDueDate" = ${PhaseDueDate}
            "Metadatas" = ${Metadatas}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "ErrorMessage" = ${ErrorMessage}
        }

        return $PSO
    }
}

<#
ApiMyGroup<PSCustomObject>
#>
function ConvertFrom-JsonToApiMyGroup {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ApiMyGroup' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ApiMyGroup
        $AllProperties = $("ObjectId", "PolicyId", "TenantId", "GroupName", "Email", "Language", "ApplyPolicyStatus", "EnableTeamCollaboration", "DynamicGroupRules", "GroupType", "CreatedTime", "Owners", "PreferredDataLocation", "PreferredDataLocationName", "EnableDynamicMembership", "GroupTeamSiteUrl", "QuotaSize", "StorageUsed", "TeamLink", "NoteBookLink", "PlannerLink", "Classification", "GroupObjectType", "GroupObjectId", "NetworkId", "Sensitivity", "Id", "Phase", "PhaseStartTime", "PhaseDescription", "AutoImportProfileId", "AutoImportProfileName", "PolicyName", "PolicyDescription", "IsCurrentRenewer", "PhaseAssignees", "PhaseDueDate", "Metadatas", "PrimaryContact", "SecondaryContact", "ErrorMessage")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectId"))) { #optional property not found
            $ObjectId = $null
        } else {
            $ObjectId = $JsonParameters.PSobject.Properties["ObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyId"))) { #optional property not found
            $PolicyId = $null
        } else {
            $PolicyId = $JsonParameters.PSobject.Properties["PolicyId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupName"))) { #optional property not found
            $GroupName = $null
        } else {
            $GroupName = $JsonParameters.PSobject.Properties["GroupName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Email"))) { #optional property not found
            $Email = $null
        } else {
            $Email = $JsonParameters.PSobject.Properties["Email"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Language"))) { #optional property not found
            $Language = $null
        } else {
            $Language = $JsonParameters.PSobject.Properties["Language"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApplyPolicyStatus"))) { #optional property not found
            $ApplyPolicyStatus = $null
        } else {
            $ApplyPolicyStatus = $JsonParameters.PSobject.Properties["ApplyPolicyStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTeamCollaboration"))) { #optional property not found
            $EnableTeamCollaboration = $null
        } else {
            $EnableTeamCollaboration = $JsonParameters.PSobject.Properties["EnableTeamCollaboration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DynamicGroupRules"))) { #optional property not found
            $DynamicGroupRules = $null
        } else {
            $DynamicGroupRules = $JsonParameters.PSobject.Properties["DynamicGroupRules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupType"))) { #optional property not found
            $GroupType = $null
        } else {
            $GroupType = $JsonParameters.PSobject.Properties["GroupType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Owners"))) { #optional property not found
            $Owners = $null
        } else {
            $Owners = $JsonParameters.PSobject.Properties["Owners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreferredDataLocation"))) { #optional property not found
            $PreferredDataLocation = $null
        } else {
            $PreferredDataLocation = $JsonParameters.PSobject.Properties["PreferredDataLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreferredDataLocationName"))) { #optional property not found
            $PreferredDataLocationName = $null
        } else {
            $PreferredDataLocationName = $JsonParameters.PSobject.Properties["PreferredDataLocationName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableDynamicMembership"))) { #optional property not found
            $EnableDynamicMembership = $null
        } else {
            $EnableDynamicMembership = $JsonParameters.PSobject.Properties["EnableDynamicMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupTeamSiteUrl"))) { #optional property not found
            $GroupTeamSiteUrl = $null
        } else {
            $GroupTeamSiteUrl = $JsonParameters.PSobject.Properties["GroupTeamSiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "QuotaSize"))) { #optional property not found
            $QuotaSize = $null
        } else {
            $QuotaSize = $JsonParameters.PSobject.Properties["QuotaSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageUsed"))) { #optional property not found
            $StorageUsed = $null
        } else {
            $StorageUsed = $JsonParameters.PSobject.Properties["StorageUsed"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TeamLink"))) { #optional property not found
            $TeamLink = $null
        } else {
            $TeamLink = $JsonParameters.PSobject.Properties["TeamLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NoteBookLink"))) { #optional property not found
            $NoteBookLink = $null
        } else {
            $NoteBookLink = $JsonParameters.PSobject.Properties["NoteBookLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PlannerLink"))) { #optional property not found
            $PlannerLink = $null
        } else {
            $PlannerLink = $JsonParameters.PSobject.Properties["PlannerLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classification"))) { #optional property not found
            $Classification = $null
        } else {
            $Classification = $JsonParameters.PSobject.Properties["Classification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupObjectType"))) { #optional property not found
            $GroupObjectType = $null
        } else {
            $GroupObjectType = $JsonParameters.PSobject.Properties["GroupObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupObjectId"))) { #optional property not found
            $GroupObjectId = $null
        } else {
            $GroupObjectId = $JsonParameters.PSobject.Properties["GroupObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkId"))) { #optional property not found
            $NetworkId = $null
        } else {
            $NetworkId = $JsonParameters.PSobject.Properties["NetworkId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivity"))) { #optional property not found
            $Sensitivity = $null
        } else {
            $Sensitivity = $JsonParameters.PSobject.Properties["Sensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Phase"))) { #optional property not found
            $Phase = $null
        } else {
            $Phase = $JsonParameters.PSobject.Properties["Phase"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseStartTime"))) { #optional property not found
            $PhaseStartTime = $null
        } else {
            $PhaseStartTime = $JsonParameters.PSobject.Properties["PhaseStartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseDescription"))) { #optional property not found
            $PhaseDescription = $null
        } else {
            $PhaseDescription = $JsonParameters.PSobject.Properties["PhaseDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoImportProfileId"))) { #optional property not found
            $AutoImportProfileId = $null
        } else {
            $AutoImportProfileId = $JsonParameters.PSobject.Properties["AutoImportProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoImportProfileName"))) { #optional property not found
            $AutoImportProfileName = $null
        } else {
            $AutoImportProfileName = $JsonParameters.PSobject.Properties["AutoImportProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyName"))) { #optional property not found
            $PolicyName = $null
        } else {
            $PolicyName = $JsonParameters.PSobject.Properties["PolicyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyDescription"))) { #optional property not found
            $PolicyDescription = $null
        } else {
            $PolicyDescription = $JsonParameters.PSobject.Properties["PolicyDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCurrentRenewer"))) { #optional property not found
            $IsCurrentRenewer = $null
        } else {
            $IsCurrentRenewer = $JsonParameters.PSobject.Properties["IsCurrentRenewer"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseAssignees"))) { #optional property not found
            $PhaseAssignees = $null
        } else {
            $PhaseAssignees = $JsonParameters.PSobject.Properties["PhaseAssignees"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseDueDate"))) { #optional property not found
            $PhaseDueDate = $null
        } else {
            $PhaseDueDate = $JsonParameters.PSobject.Properties["PhaseDueDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        $PSO = [PSCustomObject]@{
            "ObjectId" = ${ObjectId}
            "PolicyId" = ${PolicyId}
            "TenantId" = ${TenantId}
            "GroupName" = ${GroupName}
            "Email" = ${Email}
            "Language" = ${Language}
            "ApplyPolicyStatus" = ${ApplyPolicyStatus}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "DynamicGroupRules" = ${DynamicGroupRules}
            "GroupType" = ${GroupType}
            "CreatedTime" = ${CreatedTime}
            "Owners" = ${Owners}
            "PreferredDataLocation" = ${PreferredDataLocation}
            "PreferredDataLocationName" = ${PreferredDataLocationName}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "GroupTeamSiteUrl" = ${GroupTeamSiteUrl}
            "QuotaSize" = ${QuotaSize}
            "StorageUsed" = ${StorageUsed}
            "TeamLink" = ${TeamLink}
            "NoteBookLink" = ${NoteBookLink}
            "PlannerLink" = ${PlannerLink}
            "Classification" = ${Classification}
            "GroupObjectType" = ${GroupObjectType}
            "GroupObjectId" = ${GroupObjectId}
            "NetworkId" = ${NetworkId}
            "Sensitivity" = ${Sensitivity}
            "Id" = ${Id}
            "Phase" = ${Phase}
            "PhaseStartTime" = ${PhaseStartTime}
            "PhaseDescription" = ${PhaseDescription}
            "AutoImportProfileId" = ${AutoImportProfileId}
            "AutoImportProfileName" = ${AutoImportProfileName}
            "PolicyName" = ${PolicyName}
            "PolicyDescription" = ${PolicyDescription}
            "IsCurrentRenewer" = ${IsCurrentRenewer}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseDueDate" = ${PhaseDueDate}
            "Metadatas" = ${Metadatas}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "ErrorMessage" = ${ErrorMessage}
        }

        return $PSO
    }

}

