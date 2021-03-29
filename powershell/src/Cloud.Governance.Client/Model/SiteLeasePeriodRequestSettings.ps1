#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteLeasePeriodRequestSettings<PSCustomObject>
#>

function New-SiteLeasePeriodRequestSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseInterval} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseDurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseWarningInterval} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseWarningDurationType} = "Day"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteLeasePeriodRequestSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "LeaseInterval" = ${LeaseInterval}
            "LeaseDurationType" = ${LeaseDurationType}
            "LeaseWarningInterval" = ${LeaseWarningInterval}
            "LeaseWarningDurationType" = ${LeaseWarningDurationType}
        }

        return $PSO
    }
}

<#
SiteLeasePeriodRequestSettings<PSCustomObject>
#>
function ConvertFrom-JsonToSiteLeasePeriodRequestSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteLeasePeriodRequestSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteLeasePeriodRequestSettings
        $AllProperties = $("LeaseInterval", "LeaseDurationType", "LeaseWarningInterval", "LeaseWarningDurationType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseInterval"))) { #optional property not found
            $LeaseInterval = $null
        } else {
            $LeaseInterval = $JsonParameters.PSobject.Properties["LeaseInterval"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseDurationType"))) { #optional property not found
            $LeaseDurationType = $null
        } else {
            $LeaseDurationType = $JsonParameters.PSobject.Properties["LeaseDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseWarningInterval"))) { #optional property not found
            $LeaseWarningInterval = $null
        } else {
            $LeaseWarningInterval = $JsonParameters.PSobject.Properties["LeaseWarningInterval"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseWarningDurationType"))) { #optional property not found
            $LeaseWarningDurationType = $null
        } else {
            $LeaseWarningDurationType = $JsonParameters.PSobject.Properties["LeaseWarningDurationType"].value
        }

        $PSO = [PSCustomObject]@{
            "LeaseInterval" = ${LeaseInterval}
            "LeaseDurationType" = ${LeaseDurationType}
            "LeaseWarningInterval" = ${LeaseWarningInterval}
            "LeaseWarningDurationType" = ${LeaseWarningDurationType}
        }

        return $PSO
    }

}

