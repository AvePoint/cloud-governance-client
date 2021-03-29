#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteUrlSetting<PSCustomObject>
#>

function New-SiteUrlSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "ManualInputUrl",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ManuallyInputSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoGenerateUrlSetting}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Type" = ${Type}
            "ManuallyInputSetting" = ${ManuallyInputSetting}
            "AutoGenerateUrlSetting" = ${AutoGenerateUrlSetting}
        }

        return $PSO
    }
}

<#
SiteUrlSetting<PSCustomObject>
#>
function ConvertFrom-JsonToSiteUrlSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteUrlSetting
        $AllProperties = $("Type", "ManuallyInputSetting", "AutoGenerateUrlSetting")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManuallyInputSetting"))) { #optional property not found
            $ManuallyInputSetting = $null
        } else {
            $ManuallyInputSetting = $JsonParameters.PSobject.Properties["ManuallyInputSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoGenerateUrlSetting"))) { #optional property not found
            $AutoGenerateUrlSetting = $null
        } else {
            $AutoGenerateUrlSetting = $JsonParameters.PSobject.Properties["AutoGenerateUrlSetting"].value
        }

        $PSO = [PSCustomObject]@{
            "Type" = ${Type}
            "ManuallyInputSetting" = ${ManuallyInputSetting}
            "AutoGenerateUrlSetting" = ${AutoGenerateUrlSetting}
        }

        return $PSO
    }

}

