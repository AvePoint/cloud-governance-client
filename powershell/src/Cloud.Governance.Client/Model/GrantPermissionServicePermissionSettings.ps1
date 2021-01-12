#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionServicePermissionSettings<PSCustomObject>
#>

function New-GrantPermissionServicePermissionSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGrantPermissionDirectly},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableExcludePermissionLevles},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ExcludedPermissionLevles}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionServicePermissionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AssignBy" = ${AssignBy}
            "IsGrantPermissionDirectly" = ${IsGrantPermissionDirectly}
            "EnableExcludePermissionLevles" = ${EnableExcludePermissionLevles}
            "ExcludedPermissionLevles" = ${ExcludedPermissionLevles}
        }

        return $PSO
    }
}

<#
GrantPermissionServicePermissionSettings<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionServicePermissionSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionServicePermissionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionServicePermissionSettings
        $AllProperties = $("AssignBy", "IsGrantPermissionDirectly", "EnableExcludePermissionLevles", "ExcludedPermissionLevles")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignBy"))) { #optional property not found
            $AssignBy = $null
        } else {
            $AssignBy = $JsonParameters.PSobject.Properties["AssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGrantPermissionDirectly"))) { #optional property not found
            $IsGrantPermissionDirectly = $null
        } else {
            $IsGrantPermissionDirectly = $JsonParameters.PSobject.Properties["IsGrantPermissionDirectly"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableExcludePermissionLevles"))) { #optional property not found
            $EnableExcludePermissionLevles = $null
        } else {
            $EnableExcludePermissionLevles = $JsonParameters.PSobject.Properties["EnableExcludePermissionLevles"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExcludedPermissionLevles"))) { #optional property not found
            $ExcludedPermissionLevles = $null
        } else {
            $ExcludedPermissionLevles = $JsonParameters.PSobject.Properties["ExcludedPermissionLevles"].value
        }

        $PSO = [PSCustomObject]@{
            "AssignBy" = ${AssignBy}
            "IsGrantPermissionDirectly" = ${IsGrantPermissionDirectly}
            "EnableExcludePermissionLevles" = ${EnableExcludePermissionLevles}
            "ExcludedPermissionLevles" = ${ExcludedPermissionLevles}
        }

        return $PSO
    }

}

