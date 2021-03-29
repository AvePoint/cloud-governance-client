#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DynamicRuleElement<PSCustomObject>
#>

function New-DynamicRuleElement {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ChoiceItems}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DynamicRuleElement' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Type" = ${Type}
            "ChoiceItems" = ${ChoiceItems}
        }

        return $PSO
    }
}

<#
DynamicRuleElement<PSCustomObject>
#>
function ConvertFrom-JsonToDynamicRuleElement {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DynamicRuleElement' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DynamicRuleElement
        $AllProperties = $("Id", "Name", "Type", "ChoiceItems")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChoiceItems"))) { #optional property not found
            $ChoiceItems = $null
        } else {
            $ChoiceItems = $JsonParameters.PSobject.Properties["ChoiceItems"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Type" = ${Type}
            "ChoiceItems" = ${ChoiceItems}
        }

        return $PSO
    }

}

