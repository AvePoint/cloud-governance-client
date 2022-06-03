#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UserMetadataSettings<PSCustomObject>
#>

function New-UserMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PeoplePickerProfile},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReferenceAsRoleInApprovalProcess} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UserMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "PeoplePickerProfile" = ${PeoplePickerProfile}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }
}

<#
UserMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToUserMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UserMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UserMetadataSettings
        $AllProperties = $("Value", "PeoplePickerProfile", "AllowReferenceAsRoleInApprovalProcess")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeoplePickerProfile"))) { #optional property not found
            $PeoplePickerProfile = $null
        } else {
            $PeoplePickerProfile = $JsonParameters.PSobject.Properties["PeoplePickerProfile"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowReferenceAsRoleInApprovalProcess"))) { #optional property not found
            $AllowReferenceAsRoleInApprovalProcess = $null
        } else {
            $AllowReferenceAsRoleInApprovalProcess = $JsonParameters.PSobject.Properties["AllowReferenceAsRoleInApprovalProcess"].value
        }

        $PSO = [PSCustomObject]@{
            "Value" = ${Value}
            "PeoplePickerProfile" = ${PeoplePickerProfile}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }

}

