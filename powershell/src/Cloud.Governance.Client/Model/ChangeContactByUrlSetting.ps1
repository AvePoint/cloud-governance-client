#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeContactByUrlSetting<PSCustomObject>
#>

function New-ChangeContactByUrlSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalPrimaryAdministrator},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NewPrimaryAdministrator},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${OriginalAdditionalAdministrators},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${NewAdditionalAdministrators},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteTitle}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeContactByUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "OriginalPrimaryContact" = ${OriginalPrimaryContact}
            "NewPrimaryContact" = ${NewPrimaryContact}
            "OriginalSecondaryContact" = ${OriginalSecondaryContact}
            "NewSecondaryContact" = ${NewSecondaryContact}
            "OriginalPrimaryAdministrator" = ${OriginalPrimaryAdministrator}
            "NewPrimaryAdministrator" = ${NewPrimaryAdministrator}
            "OriginalAdditionalAdministrators" = ${OriginalAdditionalAdministrators}
            "NewAdditionalAdministrators" = ${NewAdditionalAdministrators}
            "SiteTitle" = ${SiteTitle}
        }

        return $PSO
    }
}

<#
ChangeContactByUrlSetting<PSCustomObject>
#>
function ConvertFrom-JsonToChangeContactByUrlSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeContactByUrlSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeContactByUrlSetting
        $AllProperties = $("SiteId", "SiteUrl", "OriginalPrimaryContact", "NewPrimaryContact", "OriginalSecondaryContact", "NewSecondaryContact", "OriginalPrimaryAdministrator", "NewPrimaryAdministrator", "OriginalAdditionalAdministrators", "NewAdditionalAdministrators", "SiteTitle")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalPrimaryContact"))) { #optional property not found
            $OriginalPrimaryContact = $null
        } else {
            $OriginalPrimaryContact = $JsonParameters.PSobject.Properties["OriginalPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewPrimaryContact"))) { #optional property not found
            $NewPrimaryContact = $null
        } else {
            $NewPrimaryContact = $JsonParameters.PSobject.Properties["NewPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalSecondaryContact"))) { #optional property not found
            $OriginalSecondaryContact = $null
        } else {
            $OriginalSecondaryContact = $JsonParameters.PSobject.Properties["OriginalSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewSecondaryContact"))) { #optional property not found
            $NewSecondaryContact = $null
        } else {
            $NewSecondaryContact = $JsonParameters.PSobject.Properties["NewSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalPrimaryAdministrator"))) { #optional property not found
            $OriginalPrimaryAdministrator = $null
        } else {
            $OriginalPrimaryAdministrator = $JsonParameters.PSobject.Properties["OriginalPrimaryAdministrator"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewPrimaryAdministrator"))) { #optional property not found
            $NewPrimaryAdministrator = $null
        } else {
            $NewPrimaryAdministrator = $JsonParameters.PSobject.Properties["NewPrimaryAdministrator"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalAdditionalAdministrators"))) { #optional property not found
            $OriginalAdditionalAdministrators = $null
        } else {
            $OriginalAdditionalAdministrators = $JsonParameters.PSobject.Properties["OriginalAdditionalAdministrators"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewAdditionalAdministrators"))) { #optional property not found
            $NewAdditionalAdministrators = $null
        } else {
            $NewAdditionalAdministrators = $JsonParameters.PSobject.Properties["NewAdditionalAdministrators"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteTitle"))) { #optional property not found
            $SiteTitle = $null
        } else {
            $SiteTitle = $JsonParameters.PSobject.Properties["SiteTitle"].value
        }

        $PSO = [PSCustomObject]@{
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "OriginalPrimaryContact" = ${OriginalPrimaryContact}
            "NewPrimaryContact" = ${NewPrimaryContact}
            "OriginalSecondaryContact" = ${OriginalSecondaryContact}
            "NewSecondaryContact" = ${NewSecondaryContact}
            "OriginalPrimaryAdministrator" = ${OriginalPrimaryAdministrator}
            "NewPrimaryAdministrator" = ${NewPrimaryAdministrator}
            "OriginalAdditionalAdministrators" = ${OriginalAdditionalAdministrators}
            "NewAdditionalAdministrators" = ${NewAdditionalAdministrators}
            "SiteTitle" = ${SiteTitle}
        }

        return $PSO
    }

}

