#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RequestMetadata<PSCustomObject>
#>

function New-RequestMetadata {
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
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${BooleanValue} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SingleLineOrMultipleLineValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UpsOrAzureAdValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermsValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${UserValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LinkValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${ChoiceValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LookupListValue},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ValueDisplayString},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action} = "NoChange",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReferenceAsRoleInApprovalProcess} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => RequestMetadata' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
            "BooleanValue" = ${BooleanValue}
            "SingleLineOrMultipleLineValue" = ${SingleLineOrMultipleLineValue}
            "UpsOrAzureAdValue" = ${UpsOrAzureAdValue}
            "TermsValue" = ${TermsValue}
            "UserValue" = ${UserValue}
            "LinkValue" = ${LinkValue}
            "ChoiceValue" = ${ChoiceValue}
            "LookupListValue" = ${LookupListValue}
            "ValueDisplayString" = ${ValueDisplayString}
            "Value" = ${Value}
            "Action" = ${Action}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }
}

<#
RequestMetadata<PSCustomObject>
#>
function ConvertFrom-JsonToRequestMetadata {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RequestMetadata' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RequestMetadata
        $AllProperties = $("Id", "Name", "DisplayName", "BooleanValue", "SingleLineOrMultipleLineValue", "UpsOrAzureAdValue", "TermsValue", "UserValue", "LinkValue", "ChoiceValue", "LookupListValue", "Type", "ValueString", "ValueDisplayString", "Value", "Action", "AllowReferenceAsRoleInApprovalProcess")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BooleanValue"))) { #optional property not found
            $BooleanValue = $null
        } else {
            $BooleanValue = $JsonParameters.PSobject.Properties["BooleanValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SingleLineOrMultipleLineValue"))) { #optional property not found
            $SingleLineOrMultipleLineValue = $null
        } else {
            $SingleLineOrMultipleLineValue = $JsonParameters.PSobject.Properties["SingleLineOrMultipleLineValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UpsOrAzureAdValue"))) { #optional property not found
            $UpsOrAzureAdValue = $null
        } else {
            $UpsOrAzureAdValue = $JsonParameters.PSobject.Properties["UpsOrAzureAdValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermsValue"))) { #optional property not found
            $TermsValue = $null
        } else {
            $TermsValue = $JsonParameters.PSobject.Properties["TermsValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserValue"))) { #optional property not found
            $UserValue = $null
        } else {
            $UserValue = $JsonParameters.PSobject.Properties["UserValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LinkValue"))) { #optional property not found
            $LinkValue = $null
        } else {
            $LinkValue = $JsonParameters.PSobject.Properties["LinkValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChoiceValue"))) { #optional property not found
            $ChoiceValue = $null
        } else {
            $ChoiceValue = $JsonParameters.PSobject.Properties["ChoiceValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LookupListValue"))) { #optional property not found
            $LookupListValue = $null
        } else {
            $LookupListValue = $JsonParameters.PSobject.Properties["LookupListValue"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ValueString"))) { #optional property not found
            $ValueString = $null
        } else {
            $ValueString = $JsonParameters.PSobject.Properties["ValueString"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ValueDisplayString"))) { #optional property not found
            $ValueDisplayString = $null
        } else {
            $ValueDisplayString = $JsonParameters.PSobject.Properties["ValueDisplayString"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowReferenceAsRoleInApprovalProcess"))) { #optional property not found
            $AllowReferenceAsRoleInApprovalProcess = $null
        } else {
            $AllowReferenceAsRoleInApprovalProcess = $JsonParameters.PSobject.Properties["AllowReferenceAsRoleInApprovalProcess"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
            "BooleanValue" = ${BooleanValue}
            "SingleLineOrMultipleLineValue" = ${SingleLineOrMultipleLineValue}
            "UpsOrAzureAdValue" = ${UpsOrAzureAdValue}
            "TermsValue" = ${TermsValue}
            "UserValue" = ${UserValue}
            "LinkValue" = ${LinkValue}
            "ChoiceValue" = ${ChoiceValue}
            "LookupListValue" = ${LookupListValue}
            "Type" = ${Type}
            "ValueString" = ${ValueString}
            "ValueDisplayString" = ${ValueDisplayString}
            "Value" = ${Value}
            "Action" = ${Action}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }

}

