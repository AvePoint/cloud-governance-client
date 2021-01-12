#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionServiceDurationSettings<PSCustomObject>
#>

function New-GrantPermissionServiceDurationSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGrantTemporaryPermission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${DefaultDurationInterval},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DefaultDurationType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableMaxDuration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MaxDuration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MaxDurationType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableExpirationNotify},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ExpirationNotifyDurationInterval},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExpirationNotifyDurationType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOnlyUseDefaultDuration}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionServiceDurationSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AssignBy" = ${AssignBy}
            "IsGrantTemporaryPermission" = ${IsGrantTemporaryPermission}
            "DefaultDurationInterval" = ${DefaultDurationInterval}
            "DefaultDurationType" = ${DefaultDurationType}
            "IsEnableMaxDuration" = ${IsEnableMaxDuration}
            "MaxDuration" = ${MaxDuration}
            "MaxDurationType" = ${MaxDurationType}
            "IsEnableExpirationNotify" = ${IsEnableExpirationNotify}
            "ExpirationNotifyDurationInterval" = ${ExpirationNotifyDurationInterval}
            "ExpirationNotifyDurationType" = ${ExpirationNotifyDurationType}
            "IsOnlyUseDefaultDuration" = ${IsOnlyUseDefaultDuration}
        }

        return $PSO
    }
}

<#
GrantPermissionServiceDurationSettings<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionServiceDurationSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionServiceDurationSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionServiceDurationSettings
        $AllProperties = $("AssignBy", "IsGrantTemporaryPermission", "DefaultDurationInterval", "DefaultDurationType", "IsEnableMaxDuration", "MaxDuration", "MaxDurationType", "IsEnableExpirationNotify", "ExpirationNotifyDurationInterval", "ExpirationNotifyDurationType", "IsOnlyUseDefaultDuration")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGrantTemporaryPermission"))) { #optional property not found
            $IsGrantTemporaryPermission = $null
        } else {
            $IsGrantTemporaryPermission = $JsonParameters.PSobject.Properties["IsGrantTemporaryPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultDurationInterval"))) { #optional property not found
            $DefaultDurationInterval = $null
        } else {
            $DefaultDurationInterval = $JsonParameters.PSobject.Properties["DefaultDurationInterval"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultDurationType"))) { #optional property not found
            $DefaultDurationType = $null
        } else {
            $DefaultDurationType = $JsonParameters.PSobject.Properties["DefaultDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableMaxDuration"))) { #optional property not found
            $IsEnableMaxDuration = $null
        } else {
            $IsEnableMaxDuration = $JsonParameters.PSobject.Properties["IsEnableMaxDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaxDuration"))) { #optional property not found
            $MaxDuration = $null
        } else {
            $MaxDuration = $JsonParameters.PSobject.Properties["MaxDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaxDurationType"))) { #optional property not found
            $MaxDurationType = $null
        } else {
            $MaxDurationType = $JsonParameters.PSobject.Properties["MaxDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableExpirationNotify"))) { #optional property not found
            $IsEnableExpirationNotify = $null
        } else {
            $IsEnableExpirationNotify = $JsonParameters.PSobject.Properties["IsEnableExpirationNotify"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpirationNotifyDurationInterval"))) { #optional property not found
            $ExpirationNotifyDurationInterval = $null
        } else {
            $ExpirationNotifyDurationInterval = $JsonParameters.PSobject.Properties["ExpirationNotifyDurationInterval"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpirationNotifyDurationType"))) { #optional property not found
            $ExpirationNotifyDurationType = $null
        } else {
            $ExpirationNotifyDurationType = $JsonParameters.PSobject.Properties["ExpirationNotifyDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOnlyUseDefaultDuration"))) { #optional property not found
            $IsOnlyUseDefaultDuration = $null
        } else {
            $IsOnlyUseDefaultDuration = $JsonParameters.PSobject.Properties["IsOnlyUseDefaultDuration"].value
        }

        $PSO = [PSCustomObject]@{
            "AssignBy" = ${AssignBy}
            "IsGrantTemporaryPermission" = ${IsGrantTemporaryPermission}
            "DefaultDurationInterval" = ${DefaultDurationInterval}
            "DefaultDurationType" = ${DefaultDurationType}
            "IsEnableMaxDuration" = ${IsEnableMaxDuration}
            "MaxDuration" = ${MaxDuration}
            "MaxDurationType" = ${MaxDurationType}
            "IsEnableExpirationNotify" = ${IsEnableExpirationNotify}
            "ExpirationNotifyDurationInterval" = ${ExpirationNotifyDurationInterval}
            "ExpirationNotifyDurationType" = ${ExpirationNotifyDurationType}
            "IsOnlyUseDefaultDuration" = ${IsOnlyUseDefaultDuration}
        }

        return $PSO
    }

}

