#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangePermissionValidateResult<PSCustomObject>
#>

function New-ChangePermissionValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebServerRelativeUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ListTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsInherit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InheritNodeType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TopInheritUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CheckType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Collections.Hashtable]
        ${UserMetadata},
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
        'Creating PSCustomObject: Cloud.Governance.Client => ChangePermissionValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "WebId" = ${WebId}
            "WebServerRelativeUrl" = ${WebServerRelativeUrl}
            "ListTitle" = ${ListTitle}
            "ObjectUrl" = ${ObjectUrl}
            "IsInherit" = ${IsInherit}
            "InheritNodeType" = ${InheritNodeType}
            "TopInheritUrl" = ${TopInheritUrl}
            "CheckType" = ${CheckType}
            "UserMetadata" = ${UserMetadata}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
ChangePermissionValidateResult<PSCustomObject>
#>
function ConvertFrom-JsonToChangePermissionValidateResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangePermissionValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangePermissionValidateResult
        $AllProperties = $("SiteId", "SiteUrl", "WebId", "WebServerRelativeUrl", "ListTitle", "ObjectUrl", "IsInherit", "InheritNodeType", "TopInheritUrl", "CheckType", "UserMetadata", "IsValid", "ErrorMessage", "MessageCode")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebId"))) { #optional property not found
            $WebId = $null
        } else {
            $WebId = $JsonParameters.PSobject.Properties["WebId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebServerRelativeUrl"))) { #optional property not found
            $WebServerRelativeUrl = $null
        } else {
            $WebServerRelativeUrl = $JsonParameters.PSobject.Properties["WebServerRelativeUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ListTitle"))) { #optional property not found
            $ListTitle = $null
        } else {
            $ListTitle = $JsonParameters.PSobject.Properties["ListTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectUrl"))) { #optional property not found
            $ObjectUrl = $null
        } else {
            $ObjectUrl = $JsonParameters.PSobject.Properties["ObjectUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsInherit"))) { #optional property not found
            $IsInherit = $null
        } else {
            $IsInherit = $JsonParameters.PSobject.Properties["IsInherit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InheritNodeType"))) { #optional property not found
            $InheritNodeType = $null
        } else {
            $InheritNodeType = $JsonParameters.PSobject.Properties["InheritNodeType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TopInheritUrl"))) { #optional property not found
            $TopInheritUrl = $null
        } else {
            $TopInheritUrl = $JsonParameters.PSobject.Properties["TopInheritUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CheckType"))) { #optional property not found
            $CheckType = $null
        } else {
            $CheckType = $JsonParameters.PSobject.Properties["CheckType"].value
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
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "WebId" = ${WebId}
            "WebServerRelativeUrl" = ${WebServerRelativeUrl}
            "ListTitle" = ${ListTitle}
            "ObjectUrl" = ${ObjectUrl}
            "IsInherit" = ${IsInherit}
            "InheritNodeType" = ${InheritNodeType}
            "TopInheritUrl" = ${TopInheritUrl}
            "CheckType" = ${CheckType}
            "UserMetadata" = ${UserMetadata}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

