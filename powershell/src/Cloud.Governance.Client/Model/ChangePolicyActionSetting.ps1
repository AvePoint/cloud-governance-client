#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangePolicyActionSetting<PSCustomObject>
#>

function New-ChangePolicyActionSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${StartDateType} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${SpecifyDateTicks} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ChangePolicyConfig} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAllowAutoCancel} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangePolicyActionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "StartDateType" = ${StartDateType}
            "SpecifyDateTicks" = ${SpecifyDateTicks}
            "ChangePolicyConfig" = ${ChangePolicyConfig}
            "IsAllowAutoCancel" = ${IsAllowAutoCancel}
        }

        return $PSO
    }
}

<#
ChangePolicyActionSetting<PSCustomObject>
#>
function ConvertFrom-JsonToChangePolicyActionSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangePolicyActionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangePolicyActionSetting
        $AllProperties = $("StartDateType", "SpecifyDateTicks", "ChangePolicyConfig", "IsAllowAutoCancel")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartDateType"))) { #optional property not found
            $StartDateType = $null
        } else {
            $StartDateType = $JsonParameters.PSobject.Properties["StartDateType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpecifyDateTicks"))) { #optional property not found
            $SpecifyDateTicks = $null
        } else {
            $SpecifyDateTicks = $JsonParameters.PSobject.Properties["SpecifyDateTicks"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangePolicyConfig"))) { #optional property not found
            $ChangePolicyConfig = $null
        } else {
            $ChangePolicyConfig = $JsonParameters.PSobject.Properties["ChangePolicyConfig"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAllowAutoCancel"))) { #optional property not found
            $IsAllowAutoCancel = $null
        } else {
            $IsAllowAutoCancel = $JsonParameters.PSobject.Properties["IsAllowAutoCancel"].value
        }

        $PSO = [PSCustomObject]@{
            "StartDateType" = ${StartDateType}
            "SpecifyDateTicks" = ${SpecifyDateTicks}
            "ChangePolicyConfig" = ${ChangePolicyConfig}
            "IsAllowAutoCancel" = ${IsAllowAutoCancel}
        }

        return $PSO
    }

}

