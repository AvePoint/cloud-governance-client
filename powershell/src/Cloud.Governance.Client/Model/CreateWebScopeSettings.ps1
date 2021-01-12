#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateWebScopeSettings<PSCustomObject>
#>

function New-CreateWebScopeSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RestrictParentUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ScopeType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${UseTitleInUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableUrlValidation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TextValidationRule},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedNodes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AutoPopulateUrlWithSPContext},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoPopulateUrlWithSPContextAssignBy}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateWebScopeSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "RestrictParentUrl" = ${RestrictParentUrl}
            "ScopeType" = ${ScopeType}
            "UseTitleInUrl" = ${UseTitleInUrl}
            "EnableUrlValidation" = ${EnableUrlValidation}
            "TextValidationRule" = ${TextValidationRule}
            "SelectedNodes" = ${SelectedNodes}
            "AutoPopulateUrlWithSPContext" = ${AutoPopulateUrlWithSPContext}
            "AutoPopulateUrlWithSPContextAssignBy" = ${AutoPopulateUrlWithSPContextAssignBy}
        }

        return $PSO
    }
}

<#
CreateWebScopeSettings<PSCustomObject>
#>
function ConvertFrom-JsonToCreateWebScopeSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateWebScopeSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateWebScopeSettings
        $AllProperties = $("RestrictParentUrl", "ScopeType", "UseTitleInUrl", "EnableUrlValidation", "TextValidationRule", "SelectedNodes", "AutoPopulateUrlWithSPContext", "AutoPopulateUrlWithSPContextAssignBy")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RestrictParentUrl"))) { #optional property not found
            $RestrictParentUrl = $null
        } else {
            $RestrictParentUrl = $JsonParameters.PSobject.Properties["RestrictParentUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ScopeType"))) { #optional property not found
            $ScopeType = $null
        } else {
            $ScopeType = $JsonParameters.PSobject.Properties["ScopeType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UseTitleInUrl"))) { #optional property not found
            $UseTitleInUrl = $null
        } else {
            $UseTitleInUrl = $JsonParameters.PSobject.Properties["UseTitleInUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableUrlValidation"))) { #optional property not found
            $EnableUrlValidation = $null
        } else {
            $EnableUrlValidation = $JsonParameters.PSobject.Properties["EnableUrlValidation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TextValidationRule"))) { #optional property not found
            $TextValidationRule = $null
        } else {
            $TextValidationRule = $JsonParameters.PSobject.Properties["TextValidationRule"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedNodes"))) { #optional property not found
            $SelectedNodes = $null
        } else {
            $SelectedNodes = $JsonParameters.PSobject.Properties["SelectedNodes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoPopulateUrlWithSPContext"))) { #optional property not found
            $AutoPopulateUrlWithSPContext = $null
        } else {
            $AutoPopulateUrlWithSPContext = $JsonParameters.PSobject.Properties["AutoPopulateUrlWithSPContext"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoPopulateUrlWithSPContextAssignBy"))) { #optional property not found
            $AutoPopulateUrlWithSPContextAssignBy = $null
        } else {
            $AutoPopulateUrlWithSPContextAssignBy = $JsonParameters.PSobject.Properties["AutoPopulateUrlWithSPContextAssignBy"].value
        }

        $PSO = [PSCustomObject]@{
            "RestrictParentUrl" = ${RestrictParentUrl}
            "ScopeType" = ${ScopeType}
            "UseTitleInUrl" = ${UseTitleInUrl}
            "EnableUrlValidation" = ${EnableUrlValidation}
            "TextValidationRule" = ${TextValidationRule}
            "SelectedNodes" = ${SelectedNodes}
            "AutoPopulateUrlWithSPContext" = ${AutoPopulateUrlWithSPContext}
            "AutoPopulateUrlWithSPContextAssignBy" = ${AutoPopulateUrlWithSPContextAssignBy}
        }

        return $PSO
    }

}

