#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LinkValue<PSCustomObject>
#>

function New-LinkValue {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Address}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LinkValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Title" = ${Title}
            "Address" = ${Address}
        }

        return $PSO
    }
}

<#
LinkValue<PSCustomObject>
#>
function ConvertFrom-JsonToLinkValue {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LinkValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LinkValue
        $AllProperties = $("Title", "Address")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Address"))) { #optional property not found
            $Address = $null
        } else {
            $Address = $JsonParameters.PSobject.Properties["Address"].value
        }

        $PSO = [PSCustomObject]@{
            "Title" = ${Title}
            "Address" = ${Address}
        }

        return $PSO
    }

}

