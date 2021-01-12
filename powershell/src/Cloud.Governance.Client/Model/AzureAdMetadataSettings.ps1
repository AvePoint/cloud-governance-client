#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AzureAdMetadataSettings<PSCustomObject>
#>

function New-AzureAdMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Office365Tenant},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${UseBuiltInProperty},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Property},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReferenceAsRoleInApprovalProcess}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AzureAdMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Office365Tenant" = ${Office365Tenant}
            "UseBuiltInProperty" = ${UseBuiltInProperty}
            "Value" = ${Value}
            "Property" = ${Property}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }
}

<#
AzureAdMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToAzureAdMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AzureAdMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AzureAdMetadataSettings
        $AllProperties = $("Office365Tenant", "UseBuiltInProperty", "Value", "Property", "AllowReferenceAsRoleInApprovalProcess")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Office365Tenant"))) { #optional property not found
            $Office365Tenant = $null
        } else {
            $Office365Tenant = $JsonParameters.PSobject.Properties["Office365Tenant"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UseBuiltInProperty"))) { #optional property not found
            $UseBuiltInProperty = $null
        } else {
            $UseBuiltInProperty = $JsonParameters.PSobject.Properties["UseBuiltInProperty"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Property"))) { #optional property not found
            $Property = $null
        } else {
            $Property = $JsonParameters.PSobject.Properties["Property"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowReferenceAsRoleInApprovalProcess"))) { #optional property not found
            $AllowReferenceAsRoleInApprovalProcess = $null
        } else {
            $AllowReferenceAsRoleInApprovalProcess = $JsonParameters.PSobject.Properties["AllowReferenceAsRoleInApprovalProcess"].value
        }

        $PSO = [PSCustomObject]@{
            "Office365Tenant" = ${Office365Tenant}
            "UseBuiltInProperty" = ${UseBuiltInProperty}
            "Value" = ${Value}
            "Property" = ${Property}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }

}

