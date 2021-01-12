#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContructUrlSetting<PSCustomObject>
#>

function New-ContructUrlSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Rules},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Suffix},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Connection},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ContructUrlAssignBy}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContructUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Rules" = ${Rules}
            "Suffix" = ${Suffix}
            "Connection" = ${Connection}
            "ContructUrlAssignBy" = ${ContructUrlAssignBy}
        }

        return $PSO
    }
}

<#
ContructUrlSetting<PSCustomObject>
#>
function ConvertFrom-JsonToContructUrlSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContructUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContructUrlSetting
        $AllProperties = $("Rules", "Suffix", "Connection", "ContructUrlAssignBy")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Rules"))) { #optional property not found
            $Rules = $null
        } else {
            $Rules = $JsonParameters.PSobject.Properties["Rules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Suffix"))) { #optional property not found
            $Suffix = $null
        } else {
            $Suffix = $JsonParameters.PSobject.Properties["Suffix"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Connection"))) { #optional property not found
            $Connection = $null
        } else {
            $Connection = $JsonParameters.PSobject.Properties["Connection"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContructUrlAssignBy"))) { #optional property not found
            $ContructUrlAssignBy = $null
        } else {
            $ContructUrlAssignBy = $JsonParameters.PSobject.Properties["ContructUrlAssignBy"].value
        }

        $PSO = [PSCustomObject]@{
            "Rules" = ${Rules}
            "Suffix" = ${Suffix}
            "Connection" = ${Connection}
            "ContructUrlAssignBy" = ${ContructUrlAssignBy}
        }

        return $PSO
    }

}

