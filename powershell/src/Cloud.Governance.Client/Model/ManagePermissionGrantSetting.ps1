#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ManagePermissionGrantSetting<PSCustomObject>
#>

function New-ManagePermissionGrantSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableGrantPermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGrantTemporaryPermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GrantPermissionAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TemporaryPermissionDuration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TemporaryDurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsMaxTemporaryDurationSetted} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TemporaryPermissionMaxDuration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TemporaryPermissionMaxDurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableExpireNotify} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAllowSelectAdmin} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ExpireNotifyDuration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExpireNotifyDurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ExpireNotifyEmailTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableWelcomeNotify} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WelcomeEmailSubject},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WelcomeEmailBody},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WelcomeEmailAssignBy} = "BusinessUser",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowSpecifyTemporayPermissionDuration} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ManagePermissionGrantSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsEnableGrantPermission" = ${IsEnableGrantPermission}
            "IsGrantTemporaryPermission" = ${IsGrantTemporaryPermission}
            "GrantPermissionAssignBy" = ${GrantPermissionAssignBy}
            "TemporaryPermissionDuration" = ${TemporaryPermissionDuration}
            "TemporaryDurationType" = ${TemporaryDurationType}
            "IsMaxTemporaryDurationSetted" = ${IsMaxTemporaryDurationSetted}
            "TemporaryPermissionMaxDuration" = ${TemporaryPermissionMaxDuration}
            "TemporaryPermissionMaxDurationType" = ${TemporaryPermissionMaxDurationType}
            "IsEnableExpireNotify" = ${IsEnableExpireNotify}
            "IsAllowSelectAdmin" = ${IsAllowSelectAdmin}
            "ExpireNotifyDuration" = ${ExpireNotifyDuration}
            "ExpireNotifyDurationType" = ${ExpireNotifyDurationType}
            "ExpireNotifyEmailTemplate" = ${ExpireNotifyEmailTemplate}
            "IsEnableWelcomeNotify" = ${IsEnableWelcomeNotify}
            "WelcomeEmailSubject" = ${WelcomeEmailSubject}
            "WelcomeEmailBody" = ${WelcomeEmailBody}
            "WelcomeEmailAssignBy" = ${WelcomeEmailAssignBy}
            "AllowSpecifyTemporayPermissionDuration" = ${AllowSpecifyTemporayPermissionDuration}
        }

        return $PSO
    }
}

<#
ManagePermissionGrantSetting<PSCustomObject>
#>
function ConvertFrom-JsonToManagePermissionGrantSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ManagePermissionGrantSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ManagePermissionGrantSetting
        $AllProperties = $("IsEnableGrantPermission", "IsGrantTemporaryPermission", "GrantPermissionAssignBy", "TemporaryPermissionDuration", "TemporaryDurationType", "IsMaxTemporaryDurationSetted", "TemporaryPermissionMaxDuration", "TemporaryPermissionMaxDurationType", "IsEnableExpireNotify", "IsAllowSelectAdmin", "ExpireNotifyDuration", "ExpireNotifyDurationType", "ExpireNotifyEmailTemplate", "IsEnableWelcomeNotify", "WelcomeEmailSubject", "WelcomeEmailBody", "WelcomeEmailAssignBy", "AllowSpecifyTemporayPermissionDuration")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableGrantPermission"))) { #optional property not found
            $IsEnableGrantPermission = $null
        } else {
            $IsEnableGrantPermission = $JsonParameters.PSobject.Properties["IsEnableGrantPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGrantTemporaryPermission"))) { #optional property not found
            $IsGrantTemporaryPermission = $null
        } else {
            $IsGrantTemporaryPermission = $JsonParameters.PSobject.Properties["IsGrantTemporaryPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GrantPermissionAssignBy"))) { #optional property not found
            $GrantPermissionAssignBy = $null
        } else {
            $GrantPermissionAssignBy = $JsonParameters.PSobject.Properties["GrantPermissionAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemporaryPermissionDuration"))) { #optional property not found
            $TemporaryPermissionDuration = $null
        } else {
            $TemporaryPermissionDuration = $JsonParameters.PSobject.Properties["TemporaryPermissionDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemporaryDurationType"))) { #optional property not found
            $TemporaryDurationType = $null
        } else {
            $TemporaryDurationType = $JsonParameters.PSobject.Properties["TemporaryDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsMaxTemporaryDurationSetted"))) { #optional property not found
            $IsMaxTemporaryDurationSetted = $null
        } else {
            $IsMaxTemporaryDurationSetted = $JsonParameters.PSobject.Properties["IsMaxTemporaryDurationSetted"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemporaryPermissionMaxDuration"))) { #optional property not found
            $TemporaryPermissionMaxDuration = $null
        } else {
            $TemporaryPermissionMaxDuration = $JsonParameters.PSobject.Properties["TemporaryPermissionMaxDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemporaryPermissionMaxDurationType"))) { #optional property not found
            $TemporaryPermissionMaxDurationType = $null
        } else {
            $TemporaryPermissionMaxDurationType = $JsonParameters.PSobject.Properties["TemporaryPermissionMaxDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableExpireNotify"))) { #optional property not found
            $IsEnableExpireNotify = $null
        } else {
            $IsEnableExpireNotify = $JsonParameters.PSobject.Properties["IsEnableExpireNotify"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAllowSelectAdmin"))) { #optional property not found
            $IsAllowSelectAdmin = $null
        } else {
            $IsAllowSelectAdmin = $JsonParameters.PSobject.Properties["IsAllowSelectAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpireNotifyDuration"))) { #optional property not found
            $ExpireNotifyDuration = $null
        } else {
            $ExpireNotifyDuration = $JsonParameters.PSobject.Properties["ExpireNotifyDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpireNotifyDurationType"))) { #optional property not found
            $ExpireNotifyDurationType = $null
        } else {
            $ExpireNotifyDurationType = $JsonParameters.PSobject.Properties["ExpireNotifyDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpireNotifyEmailTemplate"))) { #optional property not found
            $ExpireNotifyEmailTemplate = $null
        } else {
            $ExpireNotifyEmailTemplate = $JsonParameters.PSobject.Properties["ExpireNotifyEmailTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableWelcomeNotify"))) { #optional property not found
            $IsEnableWelcomeNotify = $null
        } else {
            $IsEnableWelcomeNotify = $JsonParameters.PSobject.Properties["IsEnableWelcomeNotify"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WelcomeEmailSubject"))) { #optional property not found
            $WelcomeEmailSubject = $null
        } else {
            $WelcomeEmailSubject = $JsonParameters.PSobject.Properties["WelcomeEmailSubject"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WelcomeEmailBody"))) { #optional property not found
            $WelcomeEmailBody = $null
        } else {
            $WelcomeEmailBody = $JsonParameters.PSobject.Properties["WelcomeEmailBody"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WelcomeEmailAssignBy"))) { #optional property not found
            $WelcomeEmailAssignBy = $null
        } else {
            $WelcomeEmailAssignBy = $JsonParameters.PSobject.Properties["WelcomeEmailAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowSpecifyTemporayPermissionDuration"))) { #optional property not found
            $AllowSpecifyTemporayPermissionDuration = $null
        } else {
            $AllowSpecifyTemporayPermissionDuration = $JsonParameters.PSobject.Properties["AllowSpecifyTemporayPermissionDuration"].value
        }

        $PSO = [PSCustomObject]@{
            "IsEnableGrantPermission" = ${IsEnableGrantPermission}
            "IsGrantTemporaryPermission" = ${IsGrantTemporaryPermission}
            "GrantPermissionAssignBy" = ${GrantPermissionAssignBy}
            "TemporaryPermissionDuration" = ${TemporaryPermissionDuration}
            "TemporaryDurationType" = ${TemporaryDurationType}
            "IsMaxTemporaryDurationSetted" = ${IsMaxTemporaryDurationSetted}
            "TemporaryPermissionMaxDuration" = ${TemporaryPermissionMaxDuration}
            "TemporaryPermissionMaxDurationType" = ${TemporaryPermissionMaxDurationType}
            "IsEnableExpireNotify" = ${IsEnableExpireNotify}
            "IsAllowSelectAdmin" = ${IsAllowSelectAdmin}
            "ExpireNotifyDuration" = ${ExpireNotifyDuration}
            "ExpireNotifyDurationType" = ${ExpireNotifyDurationType}
            "ExpireNotifyEmailTemplate" = ${ExpireNotifyEmailTemplate}
            "IsEnableWelcomeNotify" = ${IsEnableWelcomeNotify}
            "WelcomeEmailSubject" = ${WelcomeEmailSubject}
            "WelcomeEmailBody" = ${WelcomeEmailBody}
            "WelcomeEmailAssignBy" = ${WelcomeEmailAssignBy}
            "AllowSpecifyTemporayPermissionDuration" = ${AllowSpecifyTemporayPermissionDuration}
        }

        return $PSO
    }

}

