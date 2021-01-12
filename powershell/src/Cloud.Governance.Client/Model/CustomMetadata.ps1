#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CustomMetadata<PSCustomObject>
#>

function New-CustomMetadata {
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
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DisplayType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTextValidation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TextValidationRule},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BooleanMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TermsMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserProfileMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AzureAdMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChoiceMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LinkMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SingleLineOrMultipleLineMetadataSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SharePointListMetadataSettings}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CustomMetadata' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "DisplayType" = ${DisplayType}
            "AssignBy" = ${AssignBy}
            "EnableTextValidation" = ${EnableTextValidation}
            "TextValidationRule" = ${TextValidationRule}
            "BooleanMetadataSettings" = ${BooleanMetadataSettings}
            "TermsMetadataSettings" = ${TermsMetadataSettings}
            "UserMetadataSettings" = ${UserMetadataSettings}
            "UserProfileMetadataSettings" = ${UserProfileMetadataSettings}
            "AzureAdMetadataSettings" = ${AzureAdMetadataSettings}
            "ChoiceMetadataSettings" = ${ChoiceMetadataSettings}
            "LinkMetadataSettings" = ${LinkMetadataSettings}
            "SingleLineOrMultipleLineMetadataSettings" = ${SingleLineOrMultipleLineMetadataSettings}
            "SharePointListMetadataSettings" = ${SharePointListMetadataSettings}
        }

        return $PSO
    }
}

<#
CustomMetadata<PSCustomObject>
#>
function ConvertFrom-JsonToCustomMetadata {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CustomMetadata' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CustomMetadata
        $AllProperties = $("Id", "Name", "Description", "Type", "DisplayType", "AssignBy", "EnableTextValidation", "TextValidationRule", "BooleanMetadataSettings", "TermsMetadataSettings", "UserMetadataSettings", "UserProfileMetadataSettings", "AzureAdMetadataSettings", "ChoiceMetadataSettings", "LinkMetadataSettings", "SingleLineOrMultipleLineMetadataSettings", "SharePointListMetadataSettings")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayType"))) { #optional property not found
            $DisplayType = $null
        } else {
            $DisplayType = $JsonParameters.PSobject.Properties["DisplayType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignBy"))) { #optional property not found
            $AssignBy = $null
        } else {
            $AssignBy = $JsonParameters.PSobject.Properties["AssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTextValidation"))) { #optional property not found
            $EnableTextValidation = $null
        } else {
            $EnableTextValidation = $JsonParameters.PSobject.Properties["EnableTextValidation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TextValidationRule"))) { #optional property not found
            $TextValidationRule = $null
        } else {
            $TextValidationRule = $JsonParameters.PSobject.Properties["TextValidationRule"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BooleanMetadataSettings"))) { #optional property not found
            $BooleanMetadataSettings = $null
        } else {
            $BooleanMetadataSettings = $JsonParameters.PSobject.Properties["BooleanMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TermsMetadataSettings"))) { #optional property not found
            $TermsMetadataSettings = $null
        } else {
            $TermsMetadataSettings = $JsonParameters.PSobject.Properties["TermsMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserMetadataSettings"))) { #optional property not found
            $UserMetadataSettings = $null
        } else {
            $UserMetadataSettings = $JsonParameters.PSobject.Properties["UserMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserProfileMetadataSettings"))) { #optional property not found
            $UserProfileMetadataSettings = $null
        } else {
            $UserProfileMetadataSettings = $JsonParameters.PSobject.Properties["UserProfileMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AzureAdMetadataSettings"))) { #optional property not found
            $AzureAdMetadataSettings = $null
        } else {
            $AzureAdMetadataSettings = $JsonParameters.PSobject.Properties["AzureAdMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChoiceMetadataSettings"))) { #optional property not found
            $ChoiceMetadataSettings = $null
        } else {
            $ChoiceMetadataSettings = $JsonParameters.PSobject.Properties["ChoiceMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LinkMetadataSettings"))) { #optional property not found
            $LinkMetadataSettings = $null
        } else {
            $LinkMetadataSettings = $JsonParameters.PSobject.Properties["LinkMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SingleLineOrMultipleLineMetadataSettings"))) { #optional property not found
            $SingleLineOrMultipleLineMetadataSettings = $null
        } else {
            $SingleLineOrMultipleLineMetadataSettings = $JsonParameters.PSobject.Properties["SingleLineOrMultipleLineMetadataSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SharePointListMetadataSettings"))) { #optional property not found
            $SharePointListMetadataSettings = $null
        } else {
            $SharePointListMetadataSettings = $JsonParameters.PSobject.Properties["SharePointListMetadataSettings"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Type" = ${Type}
            "DisplayType" = ${DisplayType}
            "AssignBy" = ${AssignBy}
            "EnableTextValidation" = ${EnableTextValidation}
            "TextValidationRule" = ${TextValidationRule}
            "BooleanMetadataSettings" = ${BooleanMetadataSettings}
            "TermsMetadataSettings" = ${TermsMetadataSettings}
            "UserMetadataSettings" = ${UserMetadataSettings}
            "UserProfileMetadataSettings" = ${UserProfileMetadataSettings}
            "AzureAdMetadataSettings" = ${AzureAdMetadataSettings}
            "ChoiceMetadataSettings" = ${ChoiceMetadataSettings}
            "LinkMetadataSettings" = ${LinkMetadataSettings}
            "SingleLineOrMultipleLineMetadataSettings" = ${SingleLineOrMultipleLineMetadataSettings}
            "SharePointListMetadataSettings" = ${SharePointListMetadataSettings}
        }

        return $PSO
    }

}

