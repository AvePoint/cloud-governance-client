#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
InlineResponse200<PSCustomObject>
#>

function New-InlineResponse200 {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Contact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${License},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Organization}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => InlineResponse200' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Contact" = ${Contact}
            "License" = ${License}
            "Organization" = ${Organization}
        }

        return $PSO
    }
}

<#
InlineResponse200<PSCustomObject>
#>
function ConvertFrom-JsonToInlineResponse200 {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => InlineResponse200' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in InlineResponse200
        $AllProperties = $("Contact", "License", "Organization")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Contact"))) { #optional property not found
            $Contact = $null
        } else {
            $Contact = $JsonParameters.PSobject.Properties["Contact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "License"))) { #optional property not found
            $License = $null
        } else {
            $License = $JsonParameters.PSobject.Properties["License"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Organization"))) { #optional property not found
            $Organization = $null
        } else {
            $Organization = $JsonParameters.PSobject.Properties["Organization"].value
        }

        $PSO = [PSCustomObject]@{
            "Contact" = ${Contact}
            "License" = ${License}
            "Organization" = ${Organization}
        }

        return $PSO
    }

}

