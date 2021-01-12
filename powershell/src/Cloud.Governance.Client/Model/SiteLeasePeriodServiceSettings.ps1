#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteLeasePeriodServiceSettings<PSCustomObject>
#>

function New-SiteLeasePeriodServiceSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeasePeriodAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseWarningAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LeaseEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LeaseWarningEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ApprovalProcessId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseInterval},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseDurationType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseWarningInterval},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseWarningDurationType}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteLeasePeriodServiceSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "LeasePeriodAssignBy" = ${LeasePeriodAssignBy}
            "LeaseWarningAssignBy" = ${LeaseWarningAssignBy}
            "LeaseEnabled" = ${LeaseEnabled}
            "LeaseWarningEnabled" = ${LeaseWarningEnabled}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LeaseInterval" = ${LeaseInterval}
            "LeaseDurationType" = ${LeaseDurationType}
            "LeaseWarningInterval" = ${LeaseWarningInterval}
            "LeaseWarningDurationType" = ${LeaseWarningDurationType}
        }

        return $PSO
    }
}

<#
SiteLeasePeriodServiceSettings<PSCustomObject>
#>
function ConvertFrom-JsonToSiteLeasePeriodServiceSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteLeasePeriodServiceSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteLeasePeriodServiceSettings
        $AllProperties = $("LeasePeriodAssignBy", "LeaseWarningAssignBy", "LeaseEnabled", "LeaseWarningEnabled", "ApprovalProcessId", "LeaseInterval", "LeaseDurationType", "LeaseWarningInterval", "LeaseWarningDurationType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeasePeriodAssignBy"))) { #optional property not found
            $LeasePeriodAssignBy = $null
        } else {
            $LeasePeriodAssignBy = $JsonParameters.PSobject.Properties["LeasePeriodAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseWarningAssignBy"))) { #optional property not found
            $LeaseWarningAssignBy = $null
        } else {
            $LeaseWarningAssignBy = $JsonParameters.PSobject.Properties["LeaseWarningAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseEnabled"))) { #optional property not found
            $LeaseEnabled = $null
        } else {
            $LeaseEnabled = $JsonParameters.PSobject.Properties["LeaseEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseWarningEnabled"))) { #optional property not found
            $LeaseWarningEnabled = $null
        } else {
            $LeaseWarningEnabled = $JsonParameters.PSobject.Properties["LeaseWarningEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApprovalProcessId"))) { #optional property not found
            $ApprovalProcessId = $null
        } else {
            $ApprovalProcessId = $JsonParameters.PSobject.Properties["ApprovalProcessId"].value
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
            "LeasePeriodAssignBy" = ${LeasePeriodAssignBy}
            "LeaseWarningAssignBy" = ${LeaseWarningAssignBy}
            "LeaseEnabled" = ${LeaseEnabled}
            "LeaseWarningEnabled" = ${LeaseWarningEnabled}
            "ApprovalProcessId" = ${ApprovalProcessId}
            "LeaseInterval" = ${LeaseInterval}
            "LeaseDurationType" = ${LeaseDurationType}
            "LeaseWarningInterval" = ${LeaseWarningInterval}
            "LeaseWarningDurationType" = ${LeaseWarningDurationType}
        }

        return $PSO
    }

}

