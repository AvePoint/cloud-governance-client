#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DpmServiceSetting<PSCustomObject>
#>

function New-DpmServiceSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${SelectedItems},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignBy} = "BusinessUser"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DpmServiceSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "DefaultValue" = ${DefaultValue}
            "SelectedItems" = ${SelectedItems}
            "AssignBy" = ${AssignBy}
        }

        return $PSO
    }
}

<#
DpmServiceSetting<PSCustomObject>
#>
function ConvertFrom-JsonToDpmServiceSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DpmServiceSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DpmServiceSetting
        $AllProperties = $("IsEnabled", "DefaultValue", "SelectedItems", "AssignBy")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultValue"))) { #optional property not found
            $DefaultValue = $null
        } else {
            $DefaultValue = $JsonParameters.PSobject.Properties["DefaultValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedItems"))) { #optional property not found
            $SelectedItems = $null
        } else {
            $SelectedItems = $JsonParameters.PSobject.Properties["SelectedItems"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignBy"))) { #optional property not found
            $AssignBy = $null
        } else {
            $AssignBy = $JsonParameters.PSobject.Properties["AssignBy"].value
        }

        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "DefaultValue" = ${DefaultValue}
            "SelectedItems" = ${SelectedItems}
            "AssignBy" = ${AssignBy}
        }

        return $PSO
    }

}

