#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeSiteSettingValidateResult<PSCustomObject>
#>

function New-ChangeSiteSettingValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableChangeHubSite} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsModernSite} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsHubSite} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociatedHubSiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryAdministrator},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Sensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode} = "None"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeSiteSettingValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteUrl" = ${SiteUrl}
            "SiteId" = ${SiteId}
            "SiteTitle" = ${SiteTitle}
            "SiteDescription" = ${SiteDescription}
            "IsEnableChangeHubSite" = ${IsEnableChangeHubSite}
            "IsModernSite" = ${IsModernSite}
            "IsHubSite" = ${IsHubSite}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "Metadatas" = ${Metadatas}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "TenantId" = ${TenantId}
            "Sensitivity" = ${Sensitivity}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
ChangeSiteSettingValidateResult<PSCustomObject>
#>
function ConvertFrom-JsonToChangeSiteSettingValidateResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeSiteSettingValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeSiteSettingValidateResult
        $AllProperties = $("SiteUrl", "SiteId", "SiteTitle", "SiteDescription", "IsEnableChangeHubSite", "IsModernSite", "IsHubSite", "AssociatedHubSiteId", "Metadatas", "PrimaryContact", "SecondaryContact", "PrimaryAdministrator", "TenantId", "Sensitivity", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteTitle"))) { #optional property not found
            $SiteTitle = $null
        } else {
            $SiteTitle = $JsonParameters.PSobject.Properties["SiteTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDescription"))) { #optional property not found
            $SiteDescription = $null
        } else {
            $SiteDescription = $JsonParameters.PSobject.Properties["SiteDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableChangeHubSite"))) { #optional property not found
            $IsEnableChangeHubSite = $null
        } else {
            $IsEnableChangeHubSite = $JsonParameters.PSobject.Properties["IsEnableChangeHubSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsModernSite"))) { #optional property not found
            $IsModernSite = $null
        } else {
            $IsModernSite = $JsonParameters.PSobject.Properties["IsModernSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsHubSite"))) { #optional property not found
            $IsHubSite = $null
        } else {
            $IsHubSite = $JsonParameters.PSobject.Properties["IsHubSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssociatedHubSiteId"))) { #optional property not found
            $AssociatedHubSiteId = $null
        } else {
            $AssociatedHubSiteId = $JsonParameters.PSobject.Properties["AssociatedHubSiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdministrator"))) { #optional property not found
            $PrimaryAdministrator = $null
        } else {
            $PrimaryAdministrator = $JsonParameters.PSobject.Properties["PrimaryAdministrator"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivity"))) { #optional property not found
            $Sensitivity = $null
        } else {
            $Sensitivity = $JsonParameters.PSobject.Properties["Sensitivity"].value
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
            "SiteUrl" = ${SiteUrl}
            "SiteId" = ${SiteId}
            "SiteTitle" = ${SiteTitle}
            "SiteDescription" = ${SiteDescription}
            "IsEnableChangeHubSite" = ${IsEnableChangeHubSite}
            "IsModernSite" = ${IsModernSite}
            "IsHubSite" = ${IsHubSite}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "Metadatas" = ${Metadatas}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "TenantId" = ${TenantId}
            "Sensitivity" = ${Sensitivity}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

