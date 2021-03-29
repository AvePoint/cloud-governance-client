#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ManagePermissionValidateResult<PSCustomObject>
#>

function New-ManagePermissionValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PermissionLevels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExternalSharingOptions} = "Disabled",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableShareAnonymousLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Object},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Collections.Hashtable]
        ${UserMetadata},
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
        'Creating PSCustomObject: Cloud.Governance.Client => ManagePermissionValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "PermissionLevels" = ${PermissionLevels}
            "ExternalSharingOptions" = ${ExternalSharingOptions}
            "EnableShareAnonymousLink" = ${EnableShareAnonymousLink}
            "Object" = ${Object}
            "UserMetadata" = ${UserMetadata}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
ManagePermissionValidateResult<PSCustomObject>
#>
function ConvertFrom-JsonToManagePermissionValidateResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ManagePermissionValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ManagePermissionValidateResult
        $AllProperties = $("PermissionLevels", "ExternalSharingOptions", "EnableShareAnonymousLink", "Object", "UserMetadata", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionLevels"))) { #optional property not found
            $PermissionLevels = $null
        } else {
            $PermissionLevels = $JsonParameters.PSobject.Properties["PermissionLevels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExternalSharingOptions"))) { #optional property not found
            $ExternalSharingOptions = $null
        } else {
            $ExternalSharingOptions = $JsonParameters.PSobject.Properties["ExternalSharingOptions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableShareAnonymousLink"))) { #optional property not found
            $EnableShareAnonymousLink = $null
        } else {
            $EnableShareAnonymousLink = $JsonParameters.PSobject.Properties["EnableShareAnonymousLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Object"))) { #optional property not found
            $Object = $null
        } else {
            $Object = $JsonParameters.PSobject.Properties["Object"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserMetadata"))) { #optional property not found
            $UserMetadata = $null
        } else {
            $UserMetadata = $JsonParameters.PSobject.Properties["UserMetadata"].value
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
            "PermissionLevels" = ${PermissionLevels}
            "ExternalSharingOptions" = ${ExternalSharingOptions}
            "EnableShareAnonymousLink" = ${EnableShareAnonymousLink}
            "Object" = ${Object}
            "UserMetadata" = ${UserMetadata}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

