#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DynamicGroupRuleModel<PSCustomObject>
#>

function New-DynamicGroupRuleModel {
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
        [String]
        ${RelationDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Category} = "Contact",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CategoryDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataDisplayValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Condition} = "Equals",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ConditionDescription}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DynamicGroupRuleModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Order" = ${Order}
            "Relation" = ${Relation}
            "RelationDescription" = ${RelationDescription}
            "Category" = ${Category}
            "CategoryDescription" = ${CategoryDescription}
            "MetadataName" = ${MetadataName}
            "MetadataDisplayValue" = ${MetadataDisplayValue}
            "Condition" = ${Condition}
            "ConditionDescription" = ${ConditionDescription}
        }

        return $PSO
    }
}

<#
DynamicGroupRuleModel<PSCustomObject>
#>
function ConvertFrom-JsonToDynamicGroupRuleModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DynamicGroupRuleModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DynamicGroupRuleModel
        $AllProperties = $("Id", "Order", "Relation", "RelationDescription", "Category", "CategoryDescription", "MetadataName", "MetadataDisplayValue", "Condition", "ConditionDescription")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RelationDescription"))) { #optional property not found
            $RelationDescription = $null
        } else {
            $RelationDescription = $JsonParameters.PSobject.Properties["RelationDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Category"))) { #optional property not found
            $Category = $null
        } else {
            $Category = $JsonParameters.PSobject.Properties["Category"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CategoryDescription"))) { #optional property not found
            $CategoryDescription = $null
        } else {
            $CategoryDescription = $JsonParameters.PSobject.Properties["CategoryDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataName"))) { #optional property not found
            $MetadataName = $null
        } else {
            $MetadataName = $JsonParameters.PSobject.Properties["MetadataName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataDisplayValue"))) { #optional property not found
            $MetadataDisplayValue = $null
        } else {
            $MetadataDisplayValue = $JsonParameters.PSobject.Properties["MetadataDisplayValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Condition"))) { #optional property not found
            $Condition = $null
        } else {
            $Condition = $JsonParameters.PSobject.Properties["Condition"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConditionDescription"))) { #optional property not found
            $ConditionDescription = $null
        } else {
            $ConditionDescription = $JsonParameters.PSobject.Properties["ConditionDescription"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Order" = ${Order}
            "Relation" = ${Relation}
            "RelationDescription" = ${RelationDescription}
            "Category" = ${Category}
            "CategoryDescription" = ${CategoryDescription}
            "MetadataName" = ${MetadataName}
            "MetadataDisplayValue" = ${MetadataDisplayValue}
            "Condition" = ${Condition}
            "ConditionDescription" = ${ConditionDescription}
        }

        return $PSO
    }

}

