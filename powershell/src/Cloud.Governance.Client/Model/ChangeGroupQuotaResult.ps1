#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeGroupQuotaResult<PSCustomObject>
#>

function New-ChangeGroupQuotaResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowedAnySize} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MinQuotaSize} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${MaxQuotaSize} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${CurrentQuotaSize} = 0
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeGroupQuotaResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AllowedAnySize" = ${AllowedAnySize}
            "MinQuotaSize" = ${MinQuotaSize}
            "MaxQuotaSize" = ${MaxQuotaSize}
            "CurrentQuotaSize" = ${CurrentQuotaSize}
        }

        return $PSO
    }
}

<#
ChangeGroupQuotaResult<PSCustomObject>
#>
function ConvertFrom-JsonToChangeGroupQuotaResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeGroupQuotaResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeGroupQuotaResult
        $AllProperties = $("AllowedAnySize", "MinQuotaSize", "MaxQuotaSize", "CurrentQuotaSize")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowedAnySize"))) { #optional property not found
            $AllowedAnySize = $null
        } else {
            $AllowedAnySize = $JsonParameters.PSobject.Properties["AllowedAnySize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MinQuotaSize"))) { #optional property not found
            $MinQuotaSize = $null
        } else {
            $MinQuotaSize = $JsonParameters.PSobject.Properties["MinQuotaSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaxQuotaSize"))) { #optional property not found
            $MaxQuotaSize = $null
        } else {
            $MaxQuotaSize = $JsonParameters.PSobject.Properties["MaxQuotaSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CurrentQuotaSize"))) { #optional property not found
            $CurrentQuotaSize = $null
        } else {
            $CurrentQuotaSize = $JsonParameters.PSobject.Properties["CurrentQuotaSize"].value
        }

        $PSO = [PSCustomObject]@{
            "AllowedAnySize" = ${AllowedAnySize}
            "MinQuotaSize" = ${MinQuotaSize}
            "MaxQuotaSize" = ${MaxQuotaSize}
            "CurrentQuotaSize" = ${CurrentQuotaSize}
        }

        return $PSO
    }

}

