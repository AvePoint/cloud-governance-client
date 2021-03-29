#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionUrlValidationResult<PSCustomObject>
#>

function New-GrantPermissionUrlValidationResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExternalSharingOptions} = "Disabled",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableShareAnnoymousLink} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Object},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SpPermissionLevels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SpGroups},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowBreakPermissionInheritance} = $false,
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
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionUrlValidationResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ExternalSharingOptions" = ${ExternalSharingOptions}
            "EnableShareAnnoymousLink" = ${EnableShareAnnoymousLink}
            "Object" = ${Object}
            "SpPermissionLevels" = ${SpPermissionLevels}
            "SpGroups" = ${SpGroups}
            "AllowBreakPermissionInheritance" = ${AllowBreakPermissionInheritance}
            "UserMetadata" = ${UserMetadata}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
GrantPermissionUrlValidationResult<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionUrlValidationResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionUrlValidationResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionUrlValidationResult
        $AllProperties = $("ExternalSharingOptions", "EnableShareAnnoymousLink", "Object", "SpPermissionLevels", "SpGroups", "AllowBreakPermissionInheritance", "UserMetadata", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExternalSharingOptions"))) { #optional property not found
            $ExternalSharingOptions = $null
        } else {
            $ExternalSharingOptions = $JsonParameters.PSobject.Properties["ExternalSharingOptions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableShareAnnoymousLink"))) { #optional property not found
            $EnableShareAnnoymousLink = $null
        } else {
            $EnableShareAnnoymousLink = $JsonParameters.PSobject.Properties["EnableShareAnnoymousLink"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Object"))) { #optional property not found
            $Object = $null
        } else {
            $Object = $JsonParameters.PSobject.Properties["Object"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpPermissionLevels"))) { #optional property not found
            $SpPermissionLevels = $null
        } else {
            $SpPermissionLevels = $JsonParameters.PSobject.Properties["SpPermissionLevels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpGroups"))) { #optional property not found
            $SpGroups = $null
        } else {
            $SpGroups = $JsonParameters.PSobject.Properties["SpGroups"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowBreakPermissionInheritance"))) { #optional property not found
            $AllowBreakPermissionInheritance = $null
        } else {
            $AllowBreakPermissionInheritance = $JsonParameters.PSobject.Properties["AllowBreakPermissionInheritance"].value
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
            "ExternalSharingOptions" = ${ExternalSharingOptions}
            "EnableShareAnnoymousLink" = ${EnableShareAnnoymousLink}
            "Object" = ${Object}
            "SpPermissionLevels" = ${SpPermissionLevels}
            "SpGroups" = ${SpGroups}
            "AllowBreakPermissionInheritance" = ${AllowBreakPermissionInheritance}
            "UserMetadata" = ${UserMetadata}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

