#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TermsMetadataSettings<PSCustomObject>
#>

function New-TermsMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowMultiple} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdminCenter},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermStore},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermGroup},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermSet},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Scope},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Tree},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TermsMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AllowMultiple" = ${AllowMultiple}
            "AdminCenter" = ${AdminCenter}
            "Value" = ${Value}
            "TermStore" = ${TermStore}
            "TermGroup" = ${TermGroup}
            "TermSet" = ${TermSet}
            "Scope" = ${Scope}
            "Tree" = ${Tree}
            "IsValid" = ${IsValid}
        }

        return $PSO
    }
}

<#
TermsMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToTermsMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TermsMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TermsMetadataSettings
        $AllProperties = $("AllowMultiple", "AdminCenter", "Value", "TermStore", "TermGroup", "TermSet", "Scope", "Tree", "IsValid")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowMultiple"))) { #optional property not found
            $AllowMultiple = $null
        } else {
            $AllowMultiple = $JsonParameters.PSobject.Properties["AllowMultiple"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminCenter"))) { #optional property not found
            $AdminCenter = $null
        } else {
            $AdminCenter = $JsonParameters.PSobject.Properties["AdminCenter"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermStore"))) { #optional property not found
            $TermStore = $null
        } else {
            $TermStore = $JsonParameters.PSobject.Properties["TermStore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermGroup"))) { #optional property not found
            $TermGroup = $null
        } else {
            $TermGroup = $JsonParameters.PSobject.Properties["TermGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermSet"))) { #optional property not found
            $TermSet = $null
        } else {
            $TermSet = $JsonParameters.PSobject.Properties["TermSet"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Scope"))) { #optional property not found
            $Scope = $null
        } else {
            $Scope = $JsonParameters.PSobject.Properties["Scope"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Tree"))) { #optional property not found
            $Tree = $null
        } else {
            $Tree = $JsonParameters.PSobject.Properties["Tree"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        $PSO = [PSCustomObject]@{
            "AllowMultiple" = ${AllowMultiple}
            "AdminCenter" = ${AdminCenter}
            "Value" = ${Value}
            "TermStore" = ${TermStore}
            "TermGroup" = ${TermGroup}
            "TermSet" = ${TermSet}
            "Scope" = ${Scope}
            "Tree" = ${Tree}
            "IsValid" = ${IsValid}
        }

        return $PSO
    }

}

