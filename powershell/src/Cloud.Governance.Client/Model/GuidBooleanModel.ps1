#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GuidBooleanModel<PSCustomObject>
#>

function New-GuidBooleanModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SeletedItem},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${AllItems}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GuidBooleanModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "SeletedItem" = ${SeletedItem}
            "AllItems" = ${AllItems}
        }

        return $PSO
    }
}

<#
GuidBooleanModel<PSCustomObject>
#>
function ConvertFrom-JsonToGuidBooleanModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GuidBooleanModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GuidBooleanModel
        $AllProperties = $("Enabled", "SeletedItem", "AllItems")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SeletedItem"))) { #optional property not found
            $SeletedItem = $null
        } else {
            $SeletedItem = $JsonParameters.PSobject.Properties["SeletedItem"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllItems"))) { #optional property not found
            $AllItems = $null
        } else {
            $AllItems = $JsonParameters.PSobject.Properties["AllItems"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "SeletedItem" = ${SeletedItem}
            "AllItems" = ${AllItems}
        }

        return $PSO
    }

}

