#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GuestUserGridModel<PSCustomObject>
#>

function New-GuestUserGridModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Mail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrimaryContactDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecondaryContactDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Active",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${NextRenewalDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RenewalAssignees},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RenewalAssigneeDisplayNames},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastRenewalBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastRenewalByDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExternalUserState} = "PendingAcceptance",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ExternalUserStateDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastSyncTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${InviteTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastRenewalTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${RenewalStartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${RenewalDueDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ElectionProfileName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadata}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GuestUserGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "DisplayName" = ${DisplayName}
            "Mail" = ${Mail}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "ProfileName" = ${ProfileName}
            "TenantId" = ${TenantId}
            "NextRenewalDate" = ${NextRenewalDate}
            "RenewalAssignees" = ${RenewalAssignees}
            "RenewalAssigneeDisplayNames" = ${RenewalAssigneeDisplayNames}
            "LastRenewalBy" = ${LastRenewalBy}
            "LastRenewalByDisplayName" = ${LastRenewalByDisplayName}
            "ExternalUserState" = ${ExternalUserState}
            "ExternalUserStateDescription" = ${ExternalUserStateDescription}
            "LastSyncTime" = ${LastSyncTime}
            "InviteTime" = ${InviteTime}
            "LastRenewalTime" = ${LastRenewalTime}
            "RenewalStartTime" = ${RenewalStartTime}
            "RenewalDueDate" = ${RenewalDueDate}
            "ElectionProfileName" = ${ElectionProfileName}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }
}

<#
GuestUserGridModel<PSCustomObject>
#>
function ConvertFrom-JsonToGuestUserGridModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GuestUserGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GuestUserGridModel
        $AllProperties = $("Id", "DisplayName", "Mail", "PrimaryContact", "PrimaryContactDisplayName", "SecondaryContact", "SecondaryContactDisplayName", "Status", "StatusDescription", "ProfileName", "TenantId", "NextRenewalDate", "RenewalAssignees", "RenewalAssigneeDisplayNames", "LastRenewalBy", "LastRenewalByDisplayName", "ExternalUserState", "ExternalUserStateDescription", "LastSyncTime", "InviteTime", "LastRenewalTime", "RenewalStartTime", "RenewalDueDate", "ElectionProfileName", "Metadata")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Mail"))) { #optional property not found
            $Mail = $null
        } else {
            $Mail = $JsonParameters.PSobject.Properties["Mail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContactDisplayName"))) { #optional property not found
            $SecondaryContactDisplayName = $null
        } else {
            $SecondaryContactDisplayName = $JsonParameters.PSobject.Properties["SecondaryContactDisplayName"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProfileName"))) { #optional property not found
            $ProfileName = $null
        } else {
            $ProfileName = $JsonParameters.PSobject.Properties["ProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NextRenewalDate"))) { #optional property not found
            $NextRenewalDate = $null
        } else {
            $NextRenewalDate = $JsonParameters.PSobject.Properties["NextRenewalDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RenewalAssignees"))) { #optional property not found
            $RenewalAssignees = $null
        } else {
            $RenewalAssignees = $JsonParameters.PSobject.Properties["RenewalAssignees"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RenewalAssigneeDisplayNames"))) { #optional property not found
            $RenewalAssigneeDisplayNames = $null
        } else {
            $RenewalAssigneeDisplayNames = $JsonParameters.PSobject.Properties["RenewalAssigneeDisplayNames"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExternalUserState"))) { #optional property not found
            $ExternalUserState = $null
        } else {
            $ExternalUserState = $JsonParameters.PSobject.Properties["ExternalUserState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExternalUserStateDescription"))) { #optional property not found
            $ExternalUserStateDescription = $null
        } else {
            $ExternalUserStateDescription = $JsonParameters.PSobject.Properties["ExternalUserStateDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastSyncTime"))) { #optional property not found
            $LastSyncTime = $null
        } else {
            $LastSyncTime = $JsonParameters.PSobject.Properties["LastSyncTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InviteTime"))) { #optional property not found
            $InviteTime = $null
        } else {
            $InviteTime = $JsonParameters.PSobject.Properties["InviteTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastRenewalTime"))) { #optional property not found
            $LastRenewalTime = $null
        } else {
            $LastRenewalTime = $JsonParameters.PSobject.Properties["LastRenewalTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RenewalStartTime"))) { #optional property not found
            $RenewalStartTime = $null
        } else {
            $RenewalStartTime = $JsonParameters.PSobject.Properties["RenewalStartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RenewalDueDate"))) { #optional property not found
            $RenewalDueDate = $null
        } else {
            $RenewalDueDate = $JsonParameters.PSobject.Properties["RenewalDueDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ElectionProfileName"))) { #optional property not found
            $ElectionProfileName = $null
        } else {
            $ElectionProfileName = $JsonParameters.PSobject.Properties["ElectionProfileName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadata"))) { #optional property not found
            $Metadata = $null
        } else {
            $Metadata = $JsonParameters.PSobject.Properties["Metadata"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "DisplayName" = ${DisplayName}
            "Mail" = ${Mail}
            "PrimaryContact" = ${PrimaryContact}
            "PrimaryContactDisplayName" = ${PrimaryContactDisplayName}
            "SecondaryContact" = ${SecondaryContact}
            "SecondaryContactDisplayName" = ${SecondaryContactDisplayName}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "ProfileName" = ${ProfileName}
            "TenantId" = ${TenantId}
            "NextRenewalDate" = ${NextRenewalDate}
            "RenewalAssignees" = ${RenewalAssignees}
            "RenewalAssigneeDisplayNames" = ${RenewalAssigneeDisplayNames}
            "LastRenewalBy" = ${LastRenewalBy}
            "LastRenewalByDisplayName" = ${LastRenewalByDisplayName}
            "ExternalUserState" = ${ExternalUserState}
            "ExternalUserStateDescription" = ${ExternalUserStateDescription}
            "LastSyncTime" = ${LastSyncTime}
            "InviteTime" = ${InviteTime}
            "LastRenewalTime" = ${LastRenewalTime}
            "RenewalStartTime" = ${RenewalStartTime}
            "RenewalDueDate" = ${RenewalDueDate}
            "ElectionProfileName" = ${ElectionProfileName}
            "Metadata" = ${Metadata}
        }

        return $PSO
    }

}

