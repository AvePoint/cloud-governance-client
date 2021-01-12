#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ListTemplateSettings<PSCustomObject>
#>

function New-ListTemplateSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AvailabeTemplates},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TemplateStoreUrl}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ListTemplateSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AvailabeTemplates" = ${AvailabeTemplates}
            "DefaultTemplate" = ${DefaultTemplate}
            "TemplateStoreUrl" = ${TemplateStoreUrl}
        }

        return $PSO
    }
}

<#
ListTemplateSettings<PSCustomObject>
#>
function ConvertFrom-JsonToListTemplateSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ListTemplateSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ListTemplateSettings
        $AllProperties = $("AvailabeTemplates", "DefaultTemplate", "TemplateStoreUrl")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AvailabeTemplates"))) { #optional property not found
            $AvailabeTemplates = $null
        } else {
            $AvailabeTemplates = $JsonParameters.PSobject.Properties["AvailabeTemplates"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DefaultTemplate"))) { #optional property not found
            $DefaultTemplate = $null
        } else {
            $DefaultTemplate = $JsonParameters.PSobject.Properties["DefaultTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateStoreUrl"))) { #optional property not found
            $TemplateStoreUrl = $null
        } else {
            $TemplateStoreUrl = $JsonParameters.PSobject.Properties["TemplateStoreUrl"].value
        }

        $PSO = [PSCustomObject]@{
            "AvailabeTemplates" = ${AvailabeTemplates}
            "DefaultTemplate" = ${DefaultTemplate}
            "TemplateStoreUrl" = ${TemplateStoreUrl}
        }

        return $PSO
    }

}

