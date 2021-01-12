#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupLeasePeriodSettings<PSCustomObject>
#>

function New-GroupLeasePeriodSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DurationInterval},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LeaseExpirationDate}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GroupLeasePeriodSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "LeaseType" = ${LeaseType}
            "DurationType" = ${DurationType}
            "DurationInterval" = ${DurationInterval}
            "LeaseExpirationDate" = ${LeaseExpirationDate}
        }

        return $PSO
    }
}

<#
GroupLeasePeriodSettings<PSCustomObject>
#>
function ConvertFrom-JsonToGroupLeasePeriodSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupLeasePeriodSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupLeasePeriodSettings
        $AllProperties = $("IsEnabled", "LeaseType", "DurationType", "DurationInterval", "LeaseExpirationDate")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnabled"))) { #optional property not found
            $IsEnabled = $null
        } else {
            $IsEnabled = $JsonParameters.PSobject.Properties["IsEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseType"))) { #optional property not found
            $LeaseType = $null
        } else {
            $LeaseType = $JsonParameters.PSobject.Properties["LeaseType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DurationType"))) { #optional property not found
            $DurationType = $null
        } else {
            $DurationType = $JsonParameters.PSobject.Properties["DurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DurationInterval"))) { #optional property not found
            $DurationInterval = $null
        } else {
            $DurationInterval = $JsonParameters.PSobject.Properties["DurationInterval"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseExpirationDate"))) { #optional property not found
            $LeaseExpirationDate = $null
        } else {
            $LeaseExpirationDate = $JsonParameters.PSobject.Properties["LeaseExpirationDate"].value
        }

        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "LeaseType" = ${LeaseType}
            "DurationType" = ${DurationType}
            "DurationInterval" = ${DurationInterval}
            "LeaseExpirationDate" = ${LeaseExpirationDate}
        }

        return $PSO
    }

}

