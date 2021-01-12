#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UrlRandomStringSettings<PSCustomObject>
#>

function New-UrlRandomStringSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Prefix},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MaxLength},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MinLength}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UrlRandomStringSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Prefix" = ${Prefix}
            "MaxLength" = ${MaxLength}
            "MinLength" = ${MinLength}
        }

        return $PSO
    }
}

<#
UrlRandomStringSettings<PSCustomObject>
#>
function ConvertFrom-JsonToUrlRandomStringSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UrlRandomStringSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UrlRandomStringSettings
        $AllProperties = $("Prefix", "MaxLength", "MinLength")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Prefix"))) { #optional property not found
            $Prefix = $null
        } else {
            $Prefix = $JsonParameters.PSobject.Properties["Prefix"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MaxLength"))) { #optional property not found
            $MaxLength = $null
        } else {
            $MaxLength = $JsonParameters.PSobject.Properties["MaxLength"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MinLength"))) { #optional property not found
            $MinLength = $null
        } else {
            $MinLength = $JsonParameters.PSobject.Properties["MinLength"].value
        }

        $PSO = [PSCustomObject]@{
            "Prefix" = ${Prefix}
            "MaxLength" = ${MaxLength}
            "MinLength" = ${MinLength}
        }

        return $PSO
    }

}

