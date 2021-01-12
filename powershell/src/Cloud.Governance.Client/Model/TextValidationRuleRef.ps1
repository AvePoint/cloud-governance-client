#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TextValidationRuleRef<PSCustomObject>
#>

function New-TextValidationRuleRef {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Expression},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TextValidationRuleRef' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Expression" = ${Expression}
            "ErrorMessage" = ${ErrorMessage}
        }

        return $PSO
    }
}

<#
TextValidationRuleRef<PSCustomObject>
#>
function ConvertFrom-JsonToTextValidationRuleRef {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TextValidationRuleRef' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TextValidationRuleRef
        $AllProperties = $("Id", "Name", "Expression", "ErrorMessage")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Expression"))) { #optional property not found
            $Expression = $null
        } else {
            $Expression = $JsonParameters.PSobject.Properties["Expression"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Expression" = ${Expression}
            "ErrorMessage" = ${ErrorMessage}
        }

        return $PSO
    }

}

