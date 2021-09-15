#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DynamicGroupRuleInfo<PSCustomObject>
#>

function New-DynamicGroupRuleInfo {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Order} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Relation} = "And",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Category} = "Contact",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataDisplayValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataValueAzureUserType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Condition} = "Equals",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${DisableEditRule} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${DisableEditRuleValue} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DynamicGroupRuleInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Order" = ${Order}
            "Relation" = ${Relation}
            "Category" = ${Category}
            "MetadataId" = ${MetadataId}
            "MetadataName" = ${MetadataName}
            "MetadataValue" = ${MetadataValue}
            "MetadataDisplayValue" = ${MetadataDisplayValue}
            "MetadataValueAzureUserType" = ${MetadataValueAzureUserType}
            "Condition" = ${Condition}
            "DisableEditRule" = ${DisableEditRule}
            "DisableEditRuleValue" = ${DisableEditRuleValue}
        }

        return $PSO
    }
}

<#
DynamicGroupRuleInfo<PSCustomObject>
#>
function ConvertFrom-JsonToDynamicGroupRuleInfo {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DynamicGroupRuleInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DynamicGroupRuleInfo
        $AllProperties = $("Id", "Order", "Relation", "Category", "MetadataId", "MetadataName", "MetadataValue", "MetadataDisplayValue", "MetadataValueAzureUserType", "Condition", "DisableEditRule", "DisableEditRuleValue")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Order"))) { #optional property not found
            $Order = $null
        } else {
            $Order = $JsonParameters.PSobject.Properties["Order"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Relation"))) { #optional property not found
            $Relation = $null
        } else {
            $Relation = $JsonParameters.PSobject.Properties["Relation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Category"))) { #optional property not found
            $Category = $null
        } else {
            $Category = $JsonParameters.PSobject.Properties["Category"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataId"))) { #optional property not found
            $MetadataId = $null
        } else {
            $MetadataId = $JsonParameters.PSobject.Properties["MetadataId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataName"))) { #optional property not found
            $MetadataName = $null
        } else {
            $MetadataName = $JsonParameters.PSobject.Properties["MetadataName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataValue"))) { #optional property not found
            $MetadataValue = $null
        } else {
            $MetadataValue = $JsonParameters.PSobject.Properties["MetadataValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataDisplayValue"))) { #optional property not found
            $MetadataDisplayValue = $null
        } else {
            $MetadataDisplayValue = $JsonParameters.PSobject.Properties["MetadataDisplayValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataValueAzureUserType"))) { #optional property not found
            $MetadataValueAzureUserType = $null
        } else {
            $MetadataValueAzureUserType = $JsonParameters.PSobject.Properties["MetadataValueAzureUserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Condition"))) { #optional property not found
            $Condition = $null
        } else {
            $Condition = $JsonParameters.PSobject.Properties["Condition"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisableEditRule"))) { #optional property not found
            $DisableEditRule = $null
        } else {
            $DisableEditRule = $JsonParameters.PSobject.Properties["DisableEditRule"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisableEditRuleValue"))) { #optional property not found
            $DisableEditRuleValue = $null
        } else {
            $DisableEditRuleValue = $JsonParameters.PSobject.Properties["DisableEditRuleValue"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Order" = ${Order}
            "Relation" = ${Relation}
            "Category" = ${Category}
            "MetadataId" = ${MetadataId}
            "MetadataName" = ${MetadataName}
            "MetadataValue" = ${MetadataValue}
            "MetadataDisplayValue" = ${MetadataDisplayValue}
            "MetadataValueAzureUserType" = ${MetadataValueAzureUserType}
            "Condition" = ${Condition}
            "DisableEditRule" = ${DisableEditRule}
            "DisableEditRuleValue" = ${DisableEditRuleValue}
        }

        return $PSO
    }

}

