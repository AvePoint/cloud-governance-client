#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveProfileMappings<PSCustomObject>
#>

function New-ContentMoveProfileMappings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ColumnMapping},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ContentTypeMapping},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserMapping},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LanguageMapping}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveProfileMappings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ColumnMapping" = ${ColumnMapping}
            "ContentTypeMapping" = ${ContentTypeMapping}
            "UserMapping" = ${UserMapping}
            "LanguageMapping" = ${LanguageMapping}
        }

        return $PSO
    }
}

<#
ContentMoveProfileMappings<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveProfileMappings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveProfileMappings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveProfileMappings
        $AllProperties = $("ColumnMapping", "ContentTypeMapping", "UserMapping", "LanguageMapping")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ColumnMapping"))) { #optional property not found
            $ColumnMapping = $null
        } else {
            $ColumnMapping = $JsonParameters.PSobject.Properties["ColumnMapping"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContentTypeMapping"))) { #optional property not found
            $ContentTypeMapping = $null
        } else {
            $ContentTypeMapping = $JsonParameters.PSobject.Properties["ContentTypeMapping"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserMapping"))) { #optional property not found
            $UserMapping = $null
        } else {
            $UserMapping = $JsonParameters.PSobject.Properties["UserMapping"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageMapping"))) { #optional property not found
            $LanguageMapping = $null
        } else {
            $LanguageMapping = $JsonParameters.PSobject.Properties["LanguageMapping"].value
        }

        $PSO = [PSCustomObject]@{
            "ColumnMapping" = ${ColumnMapping}
            "ContentTypeMapping" = ${ContentTypeMapping}
            "UserMapping" = ${UserMapping}
            "LanguageMapping" = ${LanguageMapping}
        }

        return $PSO
    }

}

