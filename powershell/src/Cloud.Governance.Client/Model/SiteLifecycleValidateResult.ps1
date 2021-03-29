#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteLifecycleValidateResult<PSCustomObject>
#>

function New-SiteLifecycleValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangeQuotaSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UnlockSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangePolicySetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LockSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode} = "None"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteLifecycleValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "ChangeQuotaSetting" = ${ChangeQuotaSetting}
            "ExtendSetting" = ${ExtendSetting}
            "UnlockSetting" = ${UnlockSetting}
            "ChangePolicySetting" = ${ChangePolicySetting}
            "LockSetting" = ${LockSetting}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
SiteLifecycleValidateResult<PSCustomObject>
#>
function ConvertFrom-JsonToSiteLifecycleValidateResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteLifecycleValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteLifecycleValidateResult
        $AllProperties = $("SiteId", "SiteUrl", "ChangeQuotaSetting", "ExtendSetting", "UnlockSetting", "ChangePolicySetting", "LockSetting", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangeQuotaSetting"))) { #optional property not found
            $ChangeQuotaSetting = $null
        } else {
            $ChangeQuotaSetting = $JsonParameters.PSobject.Properties["ChangeQuotaSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtendSetting"))) { #optional property not found
            $ExtendSetting = $null
        } else {
            $ExtendSetting = $JsonParameters.PSobject.Properties["ExtendSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UnlockSetting"))) { #optional property not found
            $UnlockSetting = $null
        } else {
            $UnlockSetting = $JsonParameters.PSobject.Properties["UnlockSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangePolicySetting"))) { #optional property not found
            $ChangePolicySetting = $null
        } else {
            $ChangePolicySetting = $JsonParameters.PSobject.Properties["ChangePolicySetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LockSetting"))) { #optional property not found
            $LockSetting = $null
        } else {
            $LockSetting = $JsonParameters.PSobject.Properties["LockSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MessageCode"))) { #optional property not found
            $MessageCode = $null
        } else {
            $MessageCode = $JsonParameters.PSobject.Properties["MessageCode"].value
        }

        $PSO = [PSCustomObject]@{
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "ChangeQuotaSetting" = ${ChangeQuotaSetting}
            "ExtendSetting" = ${ExtendSetting}
            "UnlockSetting" = ${UnlockSetting}
            "ChangePolicySetting" = ${ChangePolicySetting}
            "LockSetting" = ${LockSetting}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

