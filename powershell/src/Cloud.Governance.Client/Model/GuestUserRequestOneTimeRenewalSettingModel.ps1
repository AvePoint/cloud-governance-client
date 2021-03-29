#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GuestUserRequestOneTimeRenewalSettingModel<PSCustomObject>
#>

function New-GuestUserRequestOneTimeRenewalSettingModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Option} = "NoMore",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Duration} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DurationType} = "Day",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${StartTime}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GuestUserRequestOneTimeRenewalSettingModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Option" = ${Option}
            "Duration" = ${Duration}
            "DurationType" = ${DurationType}
            "StartTime" = ${StartTime}
        }

        return $PSO
    }
}

<#
GuestUserRequestOneTimeRenewalSettingModel<PSCustomObject>
#>
function ConvertFrom-JsonToGuestUserRequestOneTimeRenewalSettingModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GuestUserRequestOneTimeRenewalSettingModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GuestUserRequestOneTimeRenewalSettingModel
        $AllProperties = $("Option", "Duration", "DurationType", "StartTime")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Option"))) { #optional property not found
            $Option = $null
        } else {
            $Option = $JsonParameters.PSobject.Properties["Option"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartTime"))) { #optional property not found
            $StartTime = $null
        } else {
            $StartTime = $JsonParameters.PSobject.Properties["StartTime"].value
        }

        $PSO = [PSCustomObject]@{
            "Option" = ${Option}
            "Duration" = ${Duration}
            "DurationType" = ${DurationType}
            "StartTime" = ${StartTime}
        }

        return $PSO
    }

}

