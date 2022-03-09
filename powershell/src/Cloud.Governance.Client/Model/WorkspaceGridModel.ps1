#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkspaceGridModel<PSCustomObject>
#>

function New-WorkspaceGridModel {
    [CmdletBinding()]
    Param (
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
        ${Status} = "Active",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Site",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Privacy} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrivacyDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyDisplay},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableDynamicMembership} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${EnableDynamicMembershipDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryAdministrators},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryAdministratorDisplayNames},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdditionalAdministrators},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdditionalAdministratorDisplayNames},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContactEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContactDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubType} = "No",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociateHubTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GeoLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GeoLocationDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${StorageLimit} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${StorageUsed},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteSharing} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteSharingDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupSharing} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupSharingDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ClaimStatus} = "Unclaimed",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ClaimStatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CreatedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LeaseExpirationTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${InactivityThresholdTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastRenewalTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastAccessedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ApplyPolicyStatus} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${HasOngoingTasks} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${HasOngoingTasksDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastRenewalBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastRenewalByEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastRenewalByDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Sensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InsightsStatus} = "NotRegistered",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseAssigneeDisplayNames},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseAssignees},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${PhaseStartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${RenewalDueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${NextRenewalDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Phase} = "Confirmed",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhaseDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadata}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkspaceGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Type" = ${Type}
            "TypeDescription" = ${TypeDescription}
            "Url" = ${Url}
            "Email" = ${Email}
            "Privacy" = ${Privacy}
            "PrivacyDescription" = ${PrivacyDescription}
            "PolicyName" = ${PolicyName}
            "PolicyDisplay" = ${PolicyDisplay}
            "PolicyId" = ${PolicyId}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "EnableDynamicMembershipDescription" = ${EnableDynamicMembershipDescription}
            "PrimaryAdministrators" = ${PrimaryAdministrators}
            "PrimaryAdministratorDisplayNames" = ${PrimaryAdministratorDisplayNames}
            "AdditionalAdministrators" = ${AdditionalAdministrators}
            "AdditionalAdministratorDisplayNames" = ${AdditionalAdministratorDisplayNames}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactEmail" = ${PrimaryContactEmail}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactEmail" = ${SecondaryContactEmail}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "HubType" = ${HubType}
            "AssociateHubTitle" = ${AssociateHubTitle}
            "GeoLocation" = ${GeoLocation}
            "GeoLocationDescription" = ${GeoLocationDescription}
            "StorageLimit" = ${StorageLimit}
            "StorageUsed" = ${StorageUsed}
            "SiteSharing" = ${SiteSharing}
            "SiteSharingDescription" = ${SiteSharingDescription}
            "GroupSharing" = ${GroupSharing}
            "GroupSharingDescription" = ${GroupSharingDescription}
            "Classification" = ${Classification}
            "ClaimStatus" = ${ClaimStatus}
            "ClaimStatusDescription" = ${ClaimStatusDescription}
            "CreatedTime" = ${CreatedTime}
            "LeaseExpirationTime" = ${LeaseExpirationTime}
            "InactivityThresholdTime" = ${InactivityThresholdTime}
            "LastRenewalTime" = ${LastRenewalTime}
            "LastAccessedTime" = ${LastAccessedTime}
            "ApplyPolicyStatus" = ${ApplyPolicyStatus}
            "HasOngoingTasks" = ${HasOngoingTasks}
            "HasOngoingTasksDescription" = ${HasOngoingTasksDescription}
            "LastRenewalBy" = ${LastRenewalBy}
            "LastRenewalByEmail" = ${LastRenewalByEmail}
            "LastRenewalByDisplayName" = ${LastRenewalByDisplayName}
            "Sensitivity" = ${Sensitivity}
            "InsightsStatus" = ${InsightsStatus}
            "PhaseAssigneeDisplayNames" = ${PhaseAssigneeDisplayNames}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseProfileName" = ${PhaseProfileName}
            "PhaseProfileId" = ${PhaseProfileId}
            "PhaseStartTime" = ${PhaseStartTime}
            "RenewalDueDate" = ${RenewalDueDate}
            "NextRenewalDate" = ${NextRenewalDate}
            "Phase" = ${Phase}
            "PhaseDescription" = ${PhaseDescription}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }
}

<#
WorkspaceGridModel<PSCustomObject>
#>
function ConvertFrom-JsonToWorkspaceGridModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkspaceGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkspaceGridModel
        $AllProperties = $("Id", "Name", "Description", "Status", "StatusDescription", "Type", "TypeDescription", "Url", "Email", "Privacy", "PrivacyDescription", "PolicyName", "PolicyDisplay", "PolicyId", "EnableDynamicMembership", "EnableDynamicMembershipDescription", "PrimaryAdministrators", "PrimaryAdministratorDisplayNames", "AdditionalAdministrators", "AdditionalAdministratorDisplayNames", "PrimaryContact", "PrimaryContactEmail", "PrimaryContactDisplayName", "SecondaryContact", "SecondaryContactEmail", "SecondaryContactDisplayName", "HubType", "AssociateHubTitle", "GeoLocation", "GeoLocationDescription", "StorageLimit", "StorageUsed", "SiteSharing", "SiteSharingDescription", "GroupSharing", "GroupSharingDescription", "Classification", "ClaimStatus", "ClaimStatusDescription", "CreatedTime", "LeaseExpirationTime", "InactivityThresholdTime", "LastRenewalTime", "LastAccessedTime", "ApplyPolicyStatus", "HasOngoingTasks", "HasOngoingTasksDescription", "LastRenewalBy", "LastRenewalByEmail", "LastRenewalByDisplayName", "Sensitivity", "InsightsStatus", "PhaseAssigneeDisplayNames", "PhaseAssignees", "PhaseProfileName", "PhaseProfileId", "PhaseStartTime", "RenewalDueDate", "NextRenewalDate", "Phase", "PhaseDescription", "Metadata")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StatusDescription"))) { #optional property not found
            $StatusDescription = $null
        } else {
            $StatusDescription = $JsonParameters.PSobject.Properties["StatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TypeDescription"))) { #optional property not found
            $TypeDescription = $null
        } else {
            $TypeDescription = $JsonParameters.PSobject.Properties["TypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Url"))) { #optional property not found
            $Url = $null
        } else {
            $Url = $JsonParameters.PSobject.Properties["Url"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Email"))) { #optional property not found
            $Email = $null
        } else {
            $Email = $JsonParameters.PSobject.Properties["Email"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Privacy"))) { #optional property not found
            $Privacy = $null
        } else {
            $Privacy = $JsonParameters.PSobject.Properties["Privacy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrivacyDescription"))) { #optional property not found
            $PrivacyDescription = $null
        } else {
            $PrivacyDescription = $JsonParameters.PSobject.Properties["PrivacyDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyName"))) { #optional property not found
            $PolicyName = $null
        } else {
            $PolicyName = $JsonParameters.PSobject.Properties["PolicyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyDisplay"))) { #optional property not found
            $PolicyDisplay = $null
        } else {
            $PolicyDisplay = $JsonParameters.PSobject.Properties["PolicyDisplay"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyId"))) { #optional property not found
            $PolicyId = $null
        } else {
            $PolicyId = $JsonParameters.PSobject.Properties["PolicyId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableDynamicMembership"))) { #optional property not found
            $EnableDynamicMembership = $null
        } else {
            $EnableDynamicMembership = $JsonParameters.PSobject.Properties["EnableDynamicMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableDynamicMembershipDescription"))) { #optional property not found
            $EnableDynamicMembershipDescription = $null
        } else {
            $EnableDynamicMembershipDescription = $JsonParameters.PSobject.Properties["EnableDynamicMembershipDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdministrators"))) { #optional property not found
            $PrimaryAdministrators = $null
        } else {
            $PrimaryAdministrators = $JsonParameters.PSobject.Properties["PrimaryAdministrators"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdministratorDisplayNames"))) { #optional property not found
            $PrimaryAdministratorDisplayNames = $null
        } else {
            $PrimaryAdministratorDisplayNames = $JsonParameters.PSobject.Properties["PrimaryAdministratorDisplayNames"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalAdministrators"))) { #optional property not found
            $AdditionalAdministrators = $null
        } else {
            $AdditionalAdministrators = $JsonParameters.PSobject.Properties["AdditionalAdministrators"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalAdministratorDisplayNames"))) { #optional property not found
            $AdditionalAdministratorDisplayNames = $null
        } else {
            $AdditionalAdministratorDisplayNames = $JsonParameters.PSobject.Properties["AdditionalAdministratorDisplayNames"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactEmail"))) { #optional property not found
            $PrimaryContactEmail = $null
        } else {
            $PrimaryContactEmail = $JsonParameters.PSobject.Properties["PrimaryContactEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContactDisplayName"))) { #optional property not found
            $PrimaryContactDisplayName = $null
        } else {
            $PrimaryContactDisplayName = $JsonParameters.PSobject.Properties["PrimaryContactDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactEmail"))) { #optional property not found
            $SecondaryContactEmail = $null
        } else {
            $SecondaryContactEmail = $JsonParameters.PSobject.Properties["SecondaryContactEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactDisplayName"))) { #optional property not found
            $SecondaryContactDisplayName = $null
        } else {
            $SecondaryContactDisplayName = $JsonParameters.PSobject.Properties["SecondaryContactDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubType"))) { #optional property not found
            $HubType = $null
        } else {
            $HubType = $JsonParameters.PSobject.Properties["HubType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssociateHubTitle"))) { #optional property not found
            $AssociateHubTitle = $null
        } else {
            $AssociateHubTitle = $JsonParameters.PSobject.Properties["AssociateHubTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GeoLocation"))) { #optional property not found
            $GeoLocation = $null
        } else {
            $GeoLocation = $JsonParameters.PSobject.Properties["GeoLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GeoLocationDescription"))) { #optional property not found
            $GeoLocationDescription = $null
        } else {
            $GeoLocationDescription = $JsonParameters.PSobject.Properties["GeoLocationDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageLimit"))) { #optional property not found
            $StorageLimit = $null
        } else {
            $StorageLimit = $JsonParameters.PSobject.Properties["StorageLimit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageUsed"))) { #optional property not found
            $StorageUsed = $null
        } else {
            $StorageUsed = $JsonParameters.PSobject.Properties["StorageUsed"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteSharing"))) { #optional property not found
            $SiteSharing = $null
        } else {
            $SiteSharing = $JsonParameters.PSobject.Properties["SiteSharing"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteSharingDescription"))) { #optional property not found
            $SiteSharingDescription = $null
        } else {
            $SiteSharingDescription = $JsonParameters.PSobject.Properties["SiteSharingDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupSharing"))) { #optional property not found
            $GroupSharing = $null
        } else {
            $GroupSharing = $JsonParameters.PSobject.Properties["GroupSharing"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupSharingDescription"))) { #optional property not found
            $GroupSharingDescription = $null
        } else {
            $GroupSharingDescription = $JsonParameters.PSobject.Properties["GroupSharingDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classification"))) { #optional property not found
            $Classification = $null
        } else {
            $Classification = $JsonParameters.PSobject.Properties["Classification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClaimStatus"))) { #optional property not found
            $ClaimStatus = $null
        } else {
            $ClaimStatus = $JsonParameters.PSobject.Properties["ClaimStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClaimStatusDescription"))) { #optional property not found
            $ClaimStatusDescription = $null
        } else {
            $ClaimStatusDescription = $JsonParameters.PSobject.Properties["ClaimStatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseExpirationTime"))) { #optional property not found
            $LeaseExpirationTime = $null
        } else {
            $LeaseExpirationTime = $JsonParameters.PSobject.Properties["LeaseExpirationTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InactivityThresholdTime"))) { #optional property not found
            $InactivityThresholdTime = $null
        } else {
            $InactivityThresholdTime = $JsonParameters.PSobject.Properties["InactivityThresholdTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalTime"))) { #optional property not found
            $LastRenewalTime = $null
        } else {
            $LastRenewalTime = $JsonParameters.PSobject.Properties["LastRenewalTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastAccessedTime"))) { #optional property not found
            $LastAccessedTime = $null
        } else {
            $LastAccessedTime = $JsonParameters.PSobject.Properties["LastAccessedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApplyPolicyStatus"))) { #optional property not found
            $ApplyPolicyStatus = $null
        } else {
            $ApplyPolicyStatus = $JsonParameters.PSobject.Properties["ApplyPolicyStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HasOngoingTasks"))) { #optional property not found
            $HasOngoingTasks = $null
        } else {
            $HasOngoingTasks = $JsonParameters.PSobject.Properties["HasOngoingTasks"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HasOngoingTasksDescription"))) { #optional property not found
            $HasOngoingTasksDescription = $null
        } else {
            $HasOngoingTasksDescription = $JsonParameters.PSobject.Properties["HasOngoingTasksDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalBy"))) { #optional property not found
            $LastRenewalBy = $null
        } else {
            $LastRenewalBy = $JsonParameters.PSobject.Properties["LastRenewalBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalByEmail"))) { #optional property not found
            $LastRenewalByEmail = $null
        } else {
            $LastRenewalByEmail = $JsonParameters.PSobject.Properties["LastRenewalByEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalByDisplayName"))) { #optional property not found
            $LastRenewalByDisplayName = $null
        } else {
            $LastRenewalByDisplayName = $JsonParameters.PSobject.Properties["LastRenewalByDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivity"))) { #optional property not found
            $Sensitivity = $null
        } else {
            $Sensitivity = $JsonParameters.PSobject.Properties["Sensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InsightsStatus"))) { #optional property not found
            $InsightsStatus = $null
        } else {
            $InsightsStatus = $JsonParameters.PSobject.Properties["InsightsStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseAssigneeDisplayNames"))) { #optional property not found
            $PhaseAssigneeDisplayNames = $null
        } else {
            $PhaseAssigneeDisplayNames = $JsonParameters.PSobject.Properties["PhaseAssigneeDisplayNames"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseAssignees"))) { #optional property not found
            $PhaseAssignees = $null
        } else {
            $PhaseAssignees = $JsonParameters.PSobject.Properties["PhaseAssignees"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseProfileName"))) { #optional property not found
            $PhaseProfileName = $null
        } else {
            $PhaseProfileName = $JsonParameters.PSobject.Properties["PhaseProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseProfileId"))) { #optional property not found
            $PhaseProfileId = $null
        } else {
            $PhaseProfileId = $JsonParameters.PSobject.Properties["PhaseProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseStartTime"))) { #optional property not found
            $PhaseStartTime = $null
        } else {
            $PhaseStartTime = $JsonParameters.PSobject.Properties["PhaseStartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RenewalDueDate"))) { #optional property not found
            $RenewalDueDate = $null
        } else {
            $RenewalDueDate = $JsonParameters.PSobject.Properties["RenewalDueDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NextRenewalDate"))) { #optional property not found
            $NextRenewalDate = $null
        } else {
            $NextRenewalDate = $JsonParameters.PSobject.Properties["NextRenewalDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Phase"))) { #optional property not found
            $Phase = $null
        } else {
            $Phase = $JsonParameters.PSobject.Properties["Phase"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhaseDescription"))) { #optional property not found
            $PhaseDescription = $null
        } else {
            $PhaseDescription = $JsonParameters.PSobject.Properties["PhaseDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadata"))) { #optional property not found
            $Metadata = $null
        } else {
            $Metadata = $JsonParameters.PSobject.Properties["Metadata"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Type" = ${Type}
            "TypeDescription" = ${TypeDescription}
            "Url" = ${Url}
            "Email" = ${Email}
            "Privacy" = ${Privacy}
            "PrivacyDescription" = ${PrivacyDescription}
            "PolicyName" = ${PolicyName}
            "PolicyDisplay" = ${PolicyDisplay}
            "PolicyId" = ${PolicyId}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "EnableDynamicMembershipDescription" = ${EnableDynamicMembershipDescription}
            "PrimaryAdministrators" = ${PrimaryAdministrators}
            "PrimaryAdministratorDisplayNames" = ${PrimaryAdministratorDisplayNames}
            "AdditionalAdministrators" = ${AdditionalAdministrators}
            "AdditionalAdministratorDisplayNames" = ${AdditionalAdministratorDisplayNames}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactEmail" = ${PrimaryContactEmail}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactEmail" = ${SecondaryContactEmail}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "HubType" = ${HubType}
            "AssociateHubTitle" = ${AssociateHubTitle}
            "GeoLocation" = ${GeoLocation}
            "GeoLocationDescription" = ${GeoLocationDescription}
            "StorageLimit" = ${StorageLimit}
            "StorageUsed" = ${StorageUsed}
            "SiteSharing" = ${SiteSharing}
            "SiteSharingDescription" = ${SiteSharingDescription}
            "GroupSharing" = ${GroupSharing}
            "GroupSharingDescription" = ${GroupSharingDescription}
            "Classification" = ${Classification}
            "ClaimStatus" = ${ClaimStatus}
            "ClaimStatusDescription" = ${ClaimStatusDescription}
            "CreatedTime" = ${CreatedTime}
            "LeaseExpirationTime" = ${LeaseExpirationTime}
            "InactivityThresholdTime" = ${InactivityThresholdTime}
            "LastRenewalTime" = ${LastRenewalTime}
            "LastAccessedTime" = ${LastAccessedTime}
            "ApplyPolicyStatus" = ${ApplyPolicyStatus}
            "HasOngoingTasks" = ${HasOngoingTasks}
            "HasOngoingTasksDescription" = ${HasOngoingTasksDescription}
            "LastRenewalBy" = ${LastRenewalBy}
            "LastRenewalByEmail" = ${LastRenewalByEmail}
            "LastRenewalByDisplayName" = ${LastRenewalByDisplayName}
            "Sensitivity" = ${Sensitivity}
            "InsightsStatus" = ${InsightsStatus}
            "PhaseAssigneeDisplayNames" = ${PhaseAssigneeDisplayNames}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseProfileName" = ${PhaseProfileName}
            "PhaseProfileId" = ${PhaseProfileId}
            "PhaseStartTime" = ${PhaseStartTime}
            "RenewalDueDate" = ${RenewalDueDate}
            "NextRenewalDate" = ${NextRenewalDate}
            "Phase" = ${Phase}
            "PhaseDescription" = ${PhaseDescription}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }

}

