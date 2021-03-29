#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ExtendSiteSetting<PSCustomObject>
#>

function New-ExtendSiteSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnabled} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtendType} = "WithConstantValue",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ConstantDuration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ConstantDurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ExtendBasedTime}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ExtendSiteSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "ExtendType" = ${ExtendType}
            "Duration" = ${Duration}
            "DurationType" = ${DurationType}
            "ConstantDuration" = ${ConstantDuration}
            "ConstantDurationType" = ${ConstantDurationType}
            "ExtendBasedTime" = ${ExtendBasedTime}
        }

        return $PSO
    }
}

<#
ExtendSiteSetting<PSCustomObject>
#>
function ConvertFrom-JsonToExtendSiteSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ExtendSiteSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ExtendSiteSetting
        $AllProperties = $("IsEnabled", "ExtendType", "Duration", "DurationType", "ConstantDuration", "ConstantDurationType", "ExtendBasedTime")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtendType"))) { #optional property not found
            $ExtendType = $null
        } else {
            $ExtendType = $JsonParameters.PSobject.Properties["ExtendType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Duration"))) { #optional property not found
            $Duration = $null
        } else {
            $Duration = $JsonParameters.PSobject.Properties["Duration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DurationType"))) { #optional property not found
            $DurationType = $null
        } else {
            $DurationType = $JsonParameters.PSobject.Properties["DurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConstantDuration"))) { #optional property not found
            $ConstantDuration = $null
        } else {
            $ConstantDuration = $JsonParameters.PSobject.Properties["ConstantDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConstantDurationType"))) { #optional property not found
            $ConstantDurationType = $null
        } else {
            $ConstantDurationType = $JsonParameters.PSobject.Properties["ConstantDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtendBasedTime"))) { #optional property not found
            $ExtendBasedTime = $null
        } else {
            $ExtendBasedTime = $JsonParameters.PSobject.Properties["ExtendBasedTime"].value
        }

        $PSO = [PSCustomObject]@{
            "IsEnabled" = ${IsEnabled}
            "ExtendType" = ${ExtendType}
            "Duration" = ${Duration}
            "DurationType" = ${DurationType}
            "ConstantDuration" = ${ConstantDuration}
            "ConstantDurationType" = ${ConstantDurationType}
            "ExtendBasedTime" = ${ExtendBasedTime}
        }

        return $PSO
    }

}

