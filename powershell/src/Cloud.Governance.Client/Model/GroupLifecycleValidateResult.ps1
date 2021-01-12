#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupLifecycleValidateResult<PSCustomObject>
#>

function New-GroupLifecycleValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangePolicySetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangeQuotaSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeamCollaboration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GroupLifecycleValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ExtendSetting" = ${ExtendSetting}
            "ChangePolicySetting" = ${ChangePolicySetting}
            "ChangeQuotaSetting" = ${ChangeQuotaSetting}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "GroupObjectType" = ${GroupObjectType}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
GroupLifecycleValidateResult<PSCustomObject>
#>
function ConvertFrom-JsonToGroupLifecycleValidateResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupLifecycleValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupLifecycleValidateResult
        $AllProperties = $("ExtendSetting", "ChangePolicySetting", "ChangeQuotaSetting", "EnableTeamCollaboration", "GroupObjectType", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtendSetting"))) { #optional property not found
            $ExtendSetting = $null
        } else {
            $ExtendSetting = $JsonParameters.PSobject.Properties["ExtendSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangePolicySetting"))) { #optional property not found
            $ChangePolicySetting = $null
        } else {
            $ChangePolicySetting = $JsonParameters.PSobject.Properties["ChangePolicySetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangeQuotaSetting"))) { #optional property not found
            $ChangeQuotaSetting = $null
        } else {
            $ChangeQuotaSetting = $JsonParameters.PSobject.Properties["ChangeQuotaSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTeamCollaboration"))) { #optional property not found
            $EnableTeamCollaboration = $null
        } else {
            $EnableTeamCollaboration = $JsonParameters.PSobject.Properties["EnableTeamCollaboration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupObjectType"))) { #optional property not found
            $GroupObjectType = $null
        } else {
            $GroupObjectType = $JsonParameters.PSobject.Properties["GroupObjectType"].value
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
            "ExtendSetting" = ${ExtendSetting}
            "ChangePolicySetting" = ${ChangePolicySetting}
            "ChangeQuotaSetting" = ${ChangeQuotaSetting}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "GroupObjectType" = ${GroupObjectType}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

