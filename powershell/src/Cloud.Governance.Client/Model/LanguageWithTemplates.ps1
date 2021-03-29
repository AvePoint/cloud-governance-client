#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LanguageWithTemplates<PSCustomObject>
#>

function New-LanguageWithTemplates {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LanguageId} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Templates}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LanguageWithTemplates' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "LanguageId" = ${LanguageId}
            "DefaultTemplate" = ${DefaultTemplate}
            "Templates" = ${Templates}
        }

        return $PSO
    }
}

<#
LanguageWithTemplates<PSCustomObject>
#>
function ConvertFrom-JsonToLanguageWithTemplates {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LanguageWithTemplates' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LanguageWithTemplates
        $AllProperties = $("LanguageId", "DefaultTemplate", "Templates")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LanguageId"))) { #optional property not found
            $LanguageId = $null
        } else {
            $LanguageId = $JsonParameters.PSobject.Properties["LanguageId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultTemplate"))) { #optional property not found
            $DefaultTemplate = $null
        } else {
            $DefaultTemplate = $JsonParameters.PSobject.Properties["DefaultTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Templates"))) { #optional property not found
            $Templates = $null
        } else {
            $Templates = $JsonParameters.PSobject.Properties["Templates"].value
        }

        $PSO = [PSCustomObject]@{
            "LanguageId" = ${LanguageId}
            "DefaultTemplate" = ${DefaultTemplate}
            "Templates" = ${Templates}
        }

        return $PSO
    }

}

