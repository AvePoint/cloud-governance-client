#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SharePointListMetadataSettings<PSCustomObject>
#>

function New-SharePointListMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ListUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PropertyType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Property},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PropertyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAdditionalColumnEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MatchedMetadataId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MatchedMetadataName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdditionalColumn},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdditionalColumnType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdditionalColumnName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReferenceAsRoleInApprovalProcess}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SharePointListMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ListUrl" = ${ListUrl}
            "WebUrl" = ${WebUrl}
            "PropertyType" = ${PropertyType}
            "Property" = ${Property}
            "PropertyName" = ${PropertyName}
            "IsAdditionalColumnEnabled" = ${IsAdditionalColumnEnabled}
            "MatchedMetadataId" = ${MatchedMetadataId}
            "MatchedMetadataName" = ${MatchedMetadataName}
            "AdditionalColumn" = ${AdditionalColumn}
            "AdditionalColumnType" = ${AdditionalColumnType}
            "AdditionalColumnName" = ${AdditionalColumnName}
            "Value" = ${Value}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }
}

<#
SharePointListMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToSharePointListMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SharePointListMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SharePointListMetadataSettings
        $AllProperties = $("ListUrl", "WebUrl", "PropertyType", "Property", "PropertyName", "IsAdditionalColumnEnabled", "MatchedMetadataId", "MatchedMetadataName", "AdditionalColumn", "AdditionalColumnType", "AdditionalColumnName", "Value", "AllowReferenceAsRoleInApprovalProcess")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListUrl"))) { #optional property not found
            $ListUrl = $null
        } else {
            $ListUrl = $JsonParameters.PSobject.Properties["ListUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebUrl"))) { #optional property not found
            $WebUrl = $null
        } else {
            $WebUrl = $JsonParameters.PSobject.Properties["WebUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PropertyType"))) { #optional property not found
            $PropertyType = $null
        } else {
            $PropertyType = $JsonParameters.PSobject.Properties["PropertyType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Property"))) { #optional property not found
            $Property = $null
        } else {
            $Property = $JsonParameters.PSobject.Properties["Property"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PropertyName"))) { #optional property not found
            $PropertyName = $null
        } else {
            $PropertyName = $JsonParameters.PSobject.Properties["PropertyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAdditionalColumnEnabled"))) { #optional property not found
            $IsAdditionalColumnEnabled = $null
        } else {
            $IsAdditionalColumnEnabled = $JsonParameters.PSobject.Properties["IsAdditionalColumnEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MatchedMetadataId"))) { #optional property not found
            $MatchedMetadataId = $null
        } else {
            $MatchedMetadataId = $JsonParameters.PSobject.Properties["MatchedMetadataId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MatchedMetadataName"))) { #optional property not found
            $MatchedMetadataName = $null
        } else {
            $MatchedMetadataName = $JsonParameters.PSobject.Properties["MatchedMetadataName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalColumn"))) { #optional property not found
            $AdditionalColumn = $null
        } else {
            $AdditionalColumn = $JsonParameters.PSobject.Properties["AdditionalColumn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalColumnType"))) { #optional property not found
            $AdditionalColumnType = $null
        } else {
            $AdditionalColumnType = $JsonParameters.PSobject.Properties["AdditionalColumnType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalColumnName"))) { #optional property not found
            $AdditionalColumnName = $null
        } else {
            $AdditionalColumnName = $JsonParameters.PSobject.Properties["AdditionalColumnName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowReferenceAsRoleInApprovalProcess"))) { #optional property not found
            $AllowReferenceAsRoleInApprovalProcess = $null
        } else {
            $AllowReferenceAsRoleInApprovalProcess = $JsonParameters.PSobject.Properties["AllowReferenceAsRoleInApprovalProcess"].value
        }

        $PSO = [PSCustomObject]@{
            "ListUrl" = ${ListUrl}
            "WebUrl" = ${WebUrl}
            "PropertyType" = ${PropertyType}
            "Property" = ${Property}
            "PropertyName" = ${PropertyName}
            "IsAdditionalColumnEnabled" = ${IsAdditionalColumnEnabled}
            "MatchedMetadataId" = ${MatchedMetadataId}
            "MatchedMetadataName" = ${MatchedMetadataName}
            "AdditionalColumn" = ${AdditionalColumn}
            "AdditionalColumnType" = ${AdditionalColumnType}
            "AdditionalColumnName" = ${AdditionalColumnName}
            "Value" = ${Value}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }

}

