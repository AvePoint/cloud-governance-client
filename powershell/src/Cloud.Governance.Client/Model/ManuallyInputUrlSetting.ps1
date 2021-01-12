#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ManuallyInputUrlSetting<PSCustomObject>
#>

function New-ManuallyInputUrlSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableConstructUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableUrlValidation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ConstructUrlAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ValidationRule},
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
        'Creating PSCustomObject: Cloud.Governance.Client => ManuallyInputUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableConstructUrl" = ${EnableConstructUrl}
            "EnableUrlValidation" = ${EnableUrlValidation}
            "ConstructUrlAssignBy" = ${ConstructUrlAssignBy}
            "ValidationRule" = ${ValidationRule}
            "Rules" = ${Rules}
            "Suffix" = ${Suffix}
            "Connection" = ${Connection}
            "ContructUrlAssignBy" = ${ContructUrlAssignBy}
        }

        return $PSO
    }
}

<#
ManuallyInputUrlSetting<PSCustomObject>
#>
function ConvertFrom-JsonToManuallyInputUrlSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ManuallyInputUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ManuallyInputUrlSetting
        $AllProperties = $("EnableConstructUrl", "EnableUrlValidation", "ConstructUrlAssignBy", "ValidationRule", "Rules", "Suffix", "Connection", "ContructUrlAssignBy")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableConstructUrl"))) { #optional property not found
            $EnableConstructUrl = $null
        } else {
            $EnableConstructUrl = $JsonParameters.PSobject.Properties["EnableConstructUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableUrlValidation"))) { #optional property not found
            $EnableUrlValidation = $null
        } else {
            $EnableUrlValidation = $JsonParameters.PSobject.Properties["EnableUrlValidation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConstructUrlAssignBy"))) { #optional property not found
            $ConstructUrlAssignBy = $null
        } else {
            $ConstructUrlAssignBy = $JsonParameters.PSobject.Properties["ConstructUrlAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ValidationRule"))) { #optional property not found
            $ValidationRule = $null
        } else {
            $ValidationRule = $JsonParameters.PSobject.Properties["ValidationRule"].value
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
            "EnableConstructUrl" = ${EnableConstructUrl}
            "EnableUrlValidation" = ${EnableUrlValidation}
            "ConstructUrlAssignBy" = ${ConstructUrlAssignBy}
            "ValidationRule" = ${ValidationRule}
            "Rules" = ${Rules}
            "Suffix" = ${Suffix}
            "Connection" = ${Connection}
            "ContructUrlAssignBy" = ${ContructUrlAssignBy}
        }

        return $PSO
    }

}

