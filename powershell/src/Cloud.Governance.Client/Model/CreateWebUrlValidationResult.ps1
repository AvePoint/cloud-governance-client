#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateWebUrlValidationResult<PSCustomObject>
#>

function New-CreateWebUrlValidationResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentWebUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentSiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SitePrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateWebUrlValidationResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ParentWebUrl" = ${ParentWebUrl}
            "ParentSiteUrl" = ${ParentSiteUrl}
            "SitePrimaryContact" = ${SitePrimaryContact}
            "SiteSecondaryContact" = ${SiteSecondaryContact}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
CreateWebUrlValidationResult<PSCustomObject>
#>
function ConvertFrom-JsonToCreateWebUrlValidationResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateWebUrlValidationResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateWebUrlValidationResult
        $AllProperties = $("ParentWebUrl", "ParentSiteUrl", "SitePrimaryContact", "SiteSecondaryContact", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentWebUrl"))) { #optional property not found
            $ParentWebUrl = $null
        } else {
            $ParentWebUrl = $JsonParameters.PSobject.Properties["ParentWebUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentSiteUrl"))) { #optional property not found
            $ParentSiteUrl = $null
        } else {
            $ParentSiteUrl = $JsonParameters.PSobject.Properties["ParentSiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SitePrimaryContact"))) { #optional property not found
            $SitePrimaryContact = $null
        } else {
            $SitePrimaryContact = $JsonParameters.PSobject.Properties["SitePrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteSecondaryContact"))) { #optional property not found
            $SiteSecondaryContact = $null
        } else {
            $SiteSecondaryContact = $JsonParameters.PSobject.Properties["SiteSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MessageCode"))) { #optional property not found
            $MessageCode = $null
        } else {
            $MessageCode = $JsonParameters.PSobject.Properties["MessageCode"].value
        }

        $PSO = [PSCustomObject]@{
            "ParentWebUrl" = ${ParentWebUrl}
            "ParentSiteUrl" = ${ParentSiteUrl}
            "SitePrimaryContact" = ${SitePrimaryContact}
            "SiteSecondaryContact" = ${SiteSecondaryContact}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

