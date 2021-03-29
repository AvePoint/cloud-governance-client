#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionRequestPermissionSettings<PSCustomObject>
#>

function New-GrantPermissionRequestPermissionSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsBreakInheritance} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGrantPermissionDirectly} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SelectedSPGroup},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedPermissionLevels}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionRequestPermissionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsBreakInheritance" = ${IsBreakInheritance}
            "IsGrantPermissionDirectly" = ${IsGrantPermissionDirectly}
            "SelectedSPGroup" = ${SelectedSPGroup}
            "SelectedPermissionLevels" = ${SelectedPermissionLevels}
        }

        return $PSO
    }
}

<#
GrantPermissionRequestPermissionSettings<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionRequestPermissionSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionRequestPermissionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionRequestPermissionSettings
        $AllProperties = $("IsBreakInheritance", "IsGrantPermissionDirectly", "SelectedSPGroup", "SelectedPermissionLevels")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsBreakInheritance"))) { #optional property not found
            $IsBreakInheritance = $null
        } else {
            $IsBreakInheritance = $JsonParameters.PSobject.Properties["IsBreakInheritance"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGrantPermissionDirectly"))) { #optional property not found
            $IsGrantPermissionDirectly = $null
        } else {
            $IsGrantPermissionDirectly = $JsonParameters.PSobject.Properties["IsGrantPermissionDirectly"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedSPGroup"))) { #optional property not found
            $SelectedSPGroup = $null
        } else {
            $SelectedSPGroup = $JsonParameters.PSobject.Properties["SelectedSPGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedPermissionLevels"))) { #optional property not found
            $SelectedPermissionLevels = $null
        } else {
            $SelectedPermissionLevels = $JsonParameters.PSobject.Properties["SelectedPermissionLevels"].value
        }

        $PSO = [PSCustomObject]@{
            "IsBreakInheritance" = ${IsBreakInheritance}
            "IsGrantPermissionDirectly" = ${IsGrantPermissionDirectly}
            "SelectedSPGroup" = ${SelectedSPGroup}
            "SelectedPermissionLevels" = ${SelectedPermissionLevels}
        }

        return $PSO
    }

}

