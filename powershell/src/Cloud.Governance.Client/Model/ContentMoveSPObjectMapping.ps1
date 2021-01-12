#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveSPObjectMapping<PSCustomObject>
#>

function New-ContentMoveSPObjectMapping {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Source},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Destination},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveSPObjectMapping' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Source" = ${Source}
            "Destination" = ${Destination}
            "Action" = ${Action}
        }

        return $PSO
    }
}

<#
ContentMoveSPObjectMapping<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveSPObjectMapping {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveSPObjectMapping' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveSPObjectMapping
        $AllProperties = $("Source", "Destination", "Action")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Source"))) { #optional property not found
            $Source = $null
        } else {
            $Source = $JsonParameters.PSobject.Properties["Source"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Destination"))) { #optional property not found
            $Destination = $null
        } else {
            $Destination = $JsonParameters.PSobject.Properties["Destination"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        $PSO = [PSCustomObject]@{
            "Source" = ${Source}
            "Destination" = ${Destination}
            "Action" = ${Action}
        }

        return $PSO
    }

}

