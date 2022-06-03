#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CustomExtensionPropertyModel<PSCustomObject>
#>

function New-CustomExtensionPropertyModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PropertyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PropertyDataType}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CustomExtensionPropertyModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "PropertyName" = ${PropertyName}
            "PropertyDataType" = ${PropertyDataType}
        }

        return $PSO
    }
}

<#
CustomExtensionPropertyModel<PSCustomObject>
#>
function ConvertFrom-JsonToCustomExtensionPropertyModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CustomExtensionPropertyModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CustomExtensionPropertyModel
        $AllProperties = $("PropertyName", "PropertyDataType")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PropertyName"))) { #optional property not found
            $PropertyName = $null
        } else {
            $PropertyName = $JsonParameters.PSobject.Properties["PropertyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PropertyDataType"))) { #optional property not found
            $PropertyDataType = $null
        } else {
            $PropertyDataType = $JsonParameters.PSobject.Properties["PropertyDataType"].value
        }

        $PSO = [PSCustomObject]@{
            "PropertyName" = ${PropertyName}
            "PropertyDataType" = ${PropertyDataType}
        }

        return $PSO
    }

}

