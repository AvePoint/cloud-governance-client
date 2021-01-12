#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupNameConstructureSettings<PSCustomObject>
#>

function New-GroupNameConstructureSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Prefixs},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Suffixs}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GroupNameConstructureSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "AssignBy" = ${AssignBy}
            "Prefixs" = ${Prefixs}
            "Suffixs" = ${Suffixs}
        }

        return $PSO
    }
}

<#
GroupNameConstructureSettings<PSCustomObject>
#>
function ConvertFrom-JsonToGroupNameConstructureSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupNameConstructureSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupNameConstructureSettings
        $AllProperties = $("Enabled", "AssignBy", "Prefixs", "Suffixs")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignBy"))) { #optional property not found
            $AssignBy = $null
        } else {
            $AssignBy = $JsonParameters.PSobject.Properties["AssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Prefixs"))) { #optional property not found
            $Prefixs = $null
        } else {
            $Prefixs = $JsonParameters.PSobject.Properties["Prefixs"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Suffixs"))) { #optional property not found
            $Suffixs = $null
        } else {
            $Suffixs = $JsonParameters.PSobject.Properties["Suffixs"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "AssignBy" = ${AssignBy}
            "Prefixs" = ${Prefixs}
            "Suffixs" = ${Suffixs}
        }

        return $PSO
    }

}

