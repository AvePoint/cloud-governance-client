#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkspaceReport<PSCustomObject>
#>

function New-WorkspaceReport {
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
        [String]
        ${Status},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyName},
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
        ${Phase},
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
        [System.Nullable[System.DateTime]]
        ${PhaseStartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${RenewalDueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${NextRenewalDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Privacy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociateHubTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GeoLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${StorageLimit} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${StorageUsed},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteSharing},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupSharing},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SensitivityLable},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ClaimStatus},
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
        [System.Collections.Hashtable]
        ${Metadata},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${HasOngoingTasks},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastRenewalTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastRenewalBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastRenewalByDisplayName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkspaceReport' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Status" = ${Status}
            "Type" = ${Type}
            "Url" = ${Url}
            "Email" = ${Email}
            "PolicyName" = ${PolicyName}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactEmail" = ${PrimaryContactEmail}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactEmail" = ${SecondaryContactEmail}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "PrimaryAdministrators" = ${PrimaryAdministrators}
            "PrimaryAdministratorDisplayNames" = ${PrimaryAdministratorDisplayNames}
            "AdditionalAdministrators" = ${AdditionalAdministrators}
            "AdditionalAdministratorDisplayNames" = ${AdditionalAdministratorDisplayNames}
            "Phase" = ${Phase}
            "PhaseAssigneeDisplayNames" = ${PhaseAssigneeDisplayNames}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseProfileName" = ${PhaseProfileName}
            "PhaseStartTime" = ${PhaseStartTime}
            "RenewalDueDate" = ${RenewalDueDate}
            "NextRenewalDate" = ${NextRenewalDate}
            "Privacy" = ${Privacy}
            "AssociateHubTitle" = ${AssociateHubTitle}
            "GeoLocation" = ${GeoLocation}
            "StorageLimit" = ${StorageLimit}
            "StorageUsed" = ${StorageUsed}
            "SiteSharing" = ${SiteSharing}
            "GroupSharing" = ${GroupSharing}
            "SensitivityLable" = ${SensitivityLable}
            "Classification" = ${Classification}
            "ClaimStatus" = ${ClaimStatus}
            "CreatedTime" = ${CreatedTime}
            "LeaseExpirationTime" = ${LeaseExpirationTime}
            "InactivityThresholdTime" = ${InactivityThresholdTime}
            "Metadata" = ${Metadata}
            "HasOngoingTasks" = ${HasOngoingTasks}
            "LastRenewalTime" = ${LastRenewalTime}
            "LastRenewalBy" = ${LastRenewalBy}
            "LastRenewalByDisplayName" = ${LastRenewalByDisplayName}
        }

        return $PSO
    }
}

<#
WorkspaceReport<PSCustomObject>
#>
function ConvertFrom-JsonToWorkspaceReport {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkspaceReport' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkspaceReport
        $AllProperties = $("Id", "Name", "Description", "Status", "Type", "Url", "Email", "PolicyName", "PrimaryContact", "PrimaryContactEmail", "PrimaryContactDisplayName", "SecondaryContact", "SecondaryContactEmail", "SecondaryContactDisplayName", "PrimaryAdministrators", "PrimaryAdministratorDisplayNames", "AdditionalAdministrators", "AdditionalAdministratorDisplayNames", "Phase", "PhaseAssigneeDisplayNames", "PhaseAssignees", "PhaseProfileName", "PhaseStartTime", "RenewalDueDate", "NextRenewalDate", "Privacy", "AssociateHubTitle", "GeoLocation", "StorageLimit", "StorageUsed", "SiteSharing", "GroupSharing", "SensitivityLable", "Classification", "ClaimStatus", "CreatedTime", "LeaseExpirationTime", "InactivityThresholdTime", "Metadata", "HasOngoingTasks", "LastRenewalTime", "LastRenewalBy", "LastRenewalByDisplayName")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyName"))) { #optional property not found
            $PolicyName = $null
        } else {
            $PolicyName = $JsonParameters.PSobject.Properties["PolicyName"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Phase"))) { #optional property not found
            $Phase = $null
        } else {
            $Phase = $JsonParameters.PSobject.Properties["Phase"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Privacy"))) { #optional property not found
            $Privacy = $null
        } else {
            $Privacy = $JsonParameters.PSobject.Properties["Privacy"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupSharing"))) { #optional property not found
            $GroupSharing = $null
        } else {
            $GroupSharing = $JsonParameters.PSobject.Properties["GroupSharing"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SensitivityLable"))) { #optional property not found
            $SensitivityLable = $null
        } else {
            $SensitivityLable = $JsonParameters.PSobject.Properties["SensitivityLable"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadata"))) { #optional property not found
            $Metadata = $null
        } else {
            $Metadata = $JsonParameters.PSobject.Properties["Metadata"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HasOngoingTasks"))) { #optional property not found
            $HasOngoingTasks = $null
        } else {
            $HasOngoingTasks = $JsonParameters.PSobject.Properties["HasOngoingTasks"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalTime"))) { #optional property not found
            $LastRenewalTime = $null
        } else {
            $LastRenewalTime = $JsonParameters.PSobject.Properties["LastRenewalTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalBy"))) { #optional property not found
            $LastRenewalBy = $null
        } else {
            $LastRenewalBy = $JsonParameters.PSobject.Properties["LastRenewalBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalByDisplayName"))) { #optional property not found
            $LastRenewalByDisplayName = $null
        } else {
            $LastRenewalByDisplayName = $JsonParameters.PSobject.Properties["LastRenewalByDisplayName"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Status" = ${Status}
            "Type" = ${Type}
            "Url" = ${Url}
            "Email" = ${Email}
            "PolicyName" = ${PolicyName}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactEmail" = ${PrimaryContactEmail}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactEmail" = ${SecondaryContactEmail}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "PrimaryAdministrators" = ${PrimaryAdministrators}
            "PrimaryAdministratorDisplayNames" = ${PrimaryAdministratorDisplayNames}
            "AdditionalAdministrators" = ${AdditionalAdministrators}
            "AdditionalAdministratorDisplayNames" = ${AdditionalAdministratorDisplayNames}
            "Phase" = ${Phase}
            "PhaseAssigneeDisplayNames" = ${PhaseAssigneeDisplayNames}
            "PhaseAssignees" = ${PhaseAssignees}
            "PhaseProfileName" = ${PhaseProfileName}
            "PhaseStartTime" = ${PhaseStartTime}
            "RenewalDueDate" = ${RenewalDueDate}
            "NextRenewalDate" = ${NextRenewalDate}
            "Privacy" = ${Privacy}
            "AssociateHubTitle" = ${AssociateHubTitle}
            "GeoLocation" = ${GeoLocation}
            "StorageLimit" = ${StorageLimit}
            "StorageUsed" = ${StorageUsed}
            "SiteSharing" = ${SiteSharing}
            "GroupSharing" = ${GroupSharing}
            "SensitivityLable" = ${SensitivityLable}
            "Classification" = ${Classification}
            "ClaimStatus" = ${ClaimStatus}
            "CreatedTime" = ${CreatedTime}
            "LeaseExpirationTime" = ${LeaseExpirationTime}
            "InactivityThresholdTime" = ${InactivityThresholdTime}
            "Metadata" = ${Metadata}
            "HasOngoingTasks" = ${HasOngoingTasks}
            "LastRenewalTime" = ${LastRenewalTime}
            "LastRenewalBy" = ${LastRenewalBy}
            "LastRenewalByDisplayName" = ${LastRenewalByDisplayName}
        }

        return $PSO
    }

}

