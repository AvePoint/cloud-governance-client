#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionRequestDurationSettings<PSCustomObject>
#>

function New-GrantPermissionRequestDurationSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGrantTemporaryPermission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGrantPermissionLevel},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExpirationType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DurationInterval},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationDateType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${StartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${EndTime}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionRequestDurationSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsGrantTemporaryPermission" = ${IsGrantTemporaryPermission}
            "IsGrantPermissionLevel" = ${IsGrantPermissionLevel}
            "ExpirationType" = ${ExpirationType}
            "DurationInterval" = ${DurationInterval}
            "DurationDateType" = ${DurationDateType}
            "StartTime" = ${StartTime}
            "EndTime" = ${EndTime}
        }

        return $PSO
    }
}

<#
GrantPermissionRequestDurationSettings<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionRequestDurationSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionRequestDurationSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionRequestDurationSettings
        $AllProperties = $("IsGrantTemporaryPermission", "IsGrantPermissionLevel", "ExpirationType", "DurationInterval", "DurationDateType", "StartTime", "EndTime")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGrantTemporaryPermission"))) { #optional property not found
            $IsGrantTemporaryPermission = $null
        } else {
            $IsGrantTemporaryPermission = $JsonParameters.PSobject.Properties["IsGrantTemporaryPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGrantPermissionLevel"))) { #optional property not found
            $IsGrantPermissionLevel = $null
        } else {
            $IsGrantPermissionLevel = $JsonParameters.PSobject.Properties["IsGrantPermissionLevel"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpirationType"))) { #optional property not found
            $ExpirationType = $null
        } else {
            $ExpirationType = $JsonParameters.PSobject.Properties["ExpirationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DurationInterval"))) { #optional property not found
            $DurationInterval = $null
        } else {
            $DurationInterval = $JsonParameters.PSobject.Properties["DurationInterval"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DurationDateType"))) { #optional property not found
            $DurationDateType = $null
        } else {
            $DurationDateType = $JsonParameters.PSobject.Properties["DurationDateType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartTime"))) { #optional property not found
            $StartTime = $null
        } else {
            $StartTime = $JsonParameters.PSobject.Properties["StartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EndTime"))) { #optional property not found
            $EndTime = $null
        } else {
            $EndTime = $JsonParameters.PSobject.Properties["EndTime"].value
        }

        $PSO = [PSCustomObject]@{
            "IsGrantTemporaryPermission" = ${IsGrantTemporaryPermission}
            "IsGrantPermissionLevel" = ${IsGrantPermissionLevel}
            "ExpirationType" = ${ExpirationType}
            "DurationInterval" = ${DurationInterval}
            "DurationDateType" = ${DurationDateType}
            "StartTime" = ${StartTime}
            "EndTime" = ${EndTime}
        }

        return $PSO
    }

}

