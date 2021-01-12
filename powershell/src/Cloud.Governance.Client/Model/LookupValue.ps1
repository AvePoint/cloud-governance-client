#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LookupValue<PSCustomObject>
#>

function New-LookupValue {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TargetUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserPropertyValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserPropertyDisplayValue}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LookupValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TargetUser" = ${TargetUser}
            "UserPropertyValue" = ${UserPropertyValue}
            "UserPropertyDisplayValue" = ${UserPropertyDisplayValue}
        }

        return $PSO
    }
}

<#
LookupValue<PSCustomObject>
#>
function ConvertFrom-JsonToLookupValue {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LookupValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LookupValue
        $AllProperties = $("Tenant", "Property", "TargetUser", "UserPropertyValue", "UserPropertyDisplayValue")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Tenant"))) { #optional property not found
            $Tenant = $null
        } else {
            $Tenant = $JsonParameters.PSobject.Properties["Tenant"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Property"))) { #optional property not found
            $Property = $null
        } else {
            $Property = $JsonParameters.PSobject.Properties["Property"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetUser"))) { #optional property not found
            $TargetUser = $null
        } else {
            $TargetUser = $JsonParameters.PSobject.Properties["TargetUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserPropertyValue"))) { #optional property not found
            $UserPropertyValue = $null
        } else {
            $UserPropertyValue = $JsonParameters.PSobject.Properties["UserPropertyValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserPropertyDisplayValue"))) { #optional property not found
            $UserPropertyDisplayValue = $null
        } else {
            $UserPropertyDisplayValue = $JsonParameters.PSobject.Properties["UserPropertyDisplayValue"].value
        }

        $PSO = [PSCustomObject]@{
            "Tenant" = ${Tenant}
            "Property" = ${Property}
            "TargetUser" = ${TargetUser}
            "UserPropertyValue" = ${UserPropertyValue}
            "UserPropertyDisplayValue" = ${UserPropertyDisplayValue}
        }

        return $PSO
    }

}

