#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
PermissionObjectProperty<PSCustomObject>
#>

function New-PermissionObjectProperty {
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
        ${IsInherit} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InheritNodeType} = "Root",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TopInheritUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CheckType} = "Root"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PermissionObjectProperty' | Write-Debug
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
        }

        return $PSO
    }
}

<#
PermissionObjectProperty<PSCustomObject>
#>
function ConvertFrom-JsonToPermissionObjectProperty {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => PermissionObjectProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in PermissionObjectProperty
        $AllProperties = $("SiteId", "SiteUrl", "WebId", "WebServerRelativeUrl", "ListTitle", "ObjectUrl", "IsInherit", "InheritNodeType", "TopInheritUrl", "CheckType")
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
        }

        return $PSO
    }

}

