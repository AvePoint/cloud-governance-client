#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
PolicyWithTemplates<PSCustomObject>
#>

function New-PolicyWithTemplates {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DefaultTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Templates}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PolicyWithTemplates' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "PolicyId" = ${PolicyId}
            "DefaultTemplate" = ${DefaultTemplate}
            "Templates" = ${Templates}
        }

        return $PSO
    }
}

<#
PolicyWithTemplates<PSCustomObject>
#>
function ConvertFrom-JsonToPolicyWithTemplates {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => PolicyWithTemplates' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in PolicyWithTemplates
        $AllProperties = $("PolicyId", "DefaultTemplate", "Templates")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyId"))) { #optional property not found
            $PolicyId = $null
        } else {
            $PolicyId = $JsonParameters.PSobject.Properties["PolicyId"].value
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
            "PolicyId" = ${PolicyId}
            "DefaultTemplate" = ${DefaultTemplate}
            "Templates" = ${Templates}
        }

        return $PSO
    }

}

